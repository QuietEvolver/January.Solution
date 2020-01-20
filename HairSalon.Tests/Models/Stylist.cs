using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HairSalon.Models;
using System;
using MySql.Data.MySqlClient;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest : IDisposable
  {
    public void Dispose()
    {
      Client.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=vera_weikel_db_test;";
    }

    // [TestMethod]
    // public void ClientConstructor_CreatesInstanceOfClient_Client()
    // {
    //   Client newClient = new Client("test");
    //   Assert.AreEqual(typeof(Client), newClient.GetType());
    // }

    // [TestMethod]
    // public void GetClientName_ReturnsClientName_String()
    // {
    //   //Arrange
    //   string clientName = "AJ";

    //   //Act
    //   Client newClient = new Client(clientName);
    //   string result = newClient.ClientName;

    //   //Assert
    //   Assert.AreEqual(clientName, result);
    // }

    // [TestMethod]
    // public void SetClientName_SetClientName_String()
    // {
    //   //Arrange
    //   string clientName = "AJ";
    //   Client newClient = new Client(clientName);

    //   //Act
    //   string updatedClientName = "Do the dishes";
    //   newClient.ClientName = updatedClientName;
    //   string result = newClient.ClientName;

    //   //Assert
    //   Assert.AreEqual(updatedClientName, result);
    // }

    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_StylistList()
    {
      // Arrange
      List<Stylist> newList = new List<Stylist> { };

      // Act
      List<Stylist> result = Stylist.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsStylists_StylistList()
    {
      //Arrange
      string type01 = "Sarge"; 
      string type02 = "Della";
      Stylist newStylist1 = new Stylist(type01);
      newStylist1.Save();
      Stylist newStylist2 = new Stylist(type02);
      newStylist2.Save();
      List<Stylist> newList = new List<Stylist> { newStylist1, newStylist2 };

      //Act
      List<Stylist> result = Stylist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void GetId_ClientsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string clientName = "AJ";
    //   Client newClient = new Client(clientName);

    //   //Act
    //   int result = newClient.Id;

    //   //Assert
    //   Assert.AreEqual(1, result);
    // }

    [TestMethod]
    public void Find_ReturnsCorrectStylistFromDatabase_Stylist()
    {
      //Arrange
      Stylist newStylist = new Stylist("Sarge");
      newStylist.Save();
      Stylist newStylist2 = new Stylist("Della");
      newStylist2.Save();

      //Act
      Stylist foundStylist = Stylist.Find(newStylist.Id);
      //Assert
      Assert.AreEqual(newStylist, foundStylist);
    }

    [TestMethod]
    public void Equals_ReturnsTrueIfStylistNamesAreTheSame_Stylist()
    {
      // Arrange, Act
      Stylist firstStylist = new Stylist("Sarge");
      Stylist secondStylist = new Stylist("Della");

      // Assert
      Assert.AreEqual(firstStylist, secondStylist);
    }

    [TestMethod]
    public void Save_SavesToDatabase_StylistList()
    {
      //Arrange
      Stylist testStylist = new Stylist("Sarge");

      //Act
      testStylist.Save();
      List<Stylist> result = Stylist.GetAll();
      List<Stylist> testList = new List<Stylist> { testStylist };

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
  }
}