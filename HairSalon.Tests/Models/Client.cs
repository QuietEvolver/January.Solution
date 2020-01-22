using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest : IDisposable
  {

    public void Dispose()
    {
      Client.ClearAll();
    }

    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      Client newClient = new Client("test client");
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Client";
      Client newClient = new Client(name);

      //Act
      string result = newClient.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsClientId_Int()
    {
      //Arrange
      string name = "Test Client";
      Client newClient = new Client(name);

      //Act
      int result = newClient.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllClientObjects_ClientList()
    {
      //Arrange
      string name01 = "Thelma";
      string name02 = "Louise";
      Client newClient1 = new Client(name01);
      Client newClient2 = new Client(name02);
      List<Client> newList = new List<Client> { newClient1, newClient2 };

      //Act
      List<Client> result = Client.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectClient_Client()
    {
      //Arrange
      string name01 = "Thelma";
      string name02 = "Louise";
      Client newClient1 = new Client(name01);
      Client newClient2 = new Client(name02);

      //Act
      Client result = Client.Find(2);

      //Assert
      Assert.AreEqual(newClient2, result);
    }

    [TestMethod]
    public void AddStylist_AssociatesStylistWithClient_StylistList()
    {
      //Arrange
      string description = "Make-up.";
      Stylist newStylist = new Stylist(description);
      List<Stylist> newList = new List<Stylist> { newStylist };
      string name = "Thelma";
      Client newClient = new Client(name);
      newClient.AddStylist(newStylist);

      //Act
      List<Stylist> result = newClient.Stylists;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}