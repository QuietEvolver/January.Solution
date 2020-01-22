using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HairSalon.Models;
using System;
using MySql.Data.MySqlClient;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest : IDisposable
  {
    public void Dispose()
    {
      Stylist.ClearAll();
    }
    
    public StylistTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;port=3306;database=vera_weikel_db_test;";
    }

    // [TestMethod]
    // public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    // {
    //   Stylist newStylist = new Stylist("test");
    //   Assert.AreEqual(typeof(Stylist), newStylist.GetType());
    // }

    // [TestMethod]
    // public void GetStylistName_ReturnsStylistName_String()
    // {
    //   //Arrange
    //   string stylistName = "AJ";

    //   //Act
    //   Stylist newStylist = new Stylist(stylistName);
    //   string result = newStylist.StylistName;

    //   //Assert
    //   Assert.AreEqual(stylistName, result);
    // }

    // [TestMethod]
    // public void SetStylistName_SetStylistName_String()
    // {
    //   //Arrange
    //   string stylistName = "AJ";
    //   Stylist newStylist = new Stylist(stylistName);

    //   //Act
    //   string updatedStylistName = "Vijay";
    //   newStylist.StylistName = updatedStylistName;
    //   string result = newStylist.StylistName;

    //   //Assert
    //   Assert.AreEqual(updatedStylistName, result);
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
    // public void GetId_StylistsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string stylistName = "AJ";
    //   Stylist newStylist = new Stylist(stylistName);

    //   //Act
    //   int result = newStylist.Id;

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
      Stylist firstStylist = new Stylist("Della");
      Stylist secondStylist = new Stylist("Della");

      // Assert
      Assert.AreEqual(firstStylist, secondStylist);
    }

    [TestMethod]
    public void Save_SavesToDatabase_StylistList()
    {
      //Arrange
      Stylist testStylist = new Stylist("Della");

      //Act
      testStylist.Save();
      List<Stylist> result = Stylist.GetAll();
      List<Stylist> testList = new List<Stylist> { testStylist };

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
  }
}