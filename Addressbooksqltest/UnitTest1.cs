using Microsoft.VisualStudio.TestTools.UnitTesting;
using Addressbooksql;
using System.Collections.Generic;

namespace Addressbooksqltest
{
    [TestClass]
    public class UnitTest1
    {
        AddressBookManager addressBookManager;
        [TestInitialize]
        public void SetUp()
        {
            addressBookManager = new AddressBookManager();
        }
        //UC1-Inserting the data into the record and checking the data
        [TestMethod]
        public void InsertionOfRecordTest()
        {
            //assign 
            int expected = 1;
            ContactDetails contactDetails = new ContactDetails();
            contactDetails = addressBookManager.ReadData(contactDetails);
            //act
            int actual = addressBookManager.insertIntoTable(contactDetails);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //UC2-Editing the data in the record and checking the data
        [TestMethod]
        public void EditphoneNumberTest()
        {
            //assign 
            int expected = 1;
            //act
            int actual = addressBookManager.EditContactDetail(5, "Rathna", 54632150987);
            //assert
            Assert.AreEqual(expected, actual);
        }
        //UC5-deleting the data in the record 
        [TestMethod]
        public void DeletingTheRecordTest()
        {
            //assign 
            int expected = 1;
            string name = "Bala";
            int id = 6;
            //act
            int actual = addressBookManager.DeletetheRecord(id, name);
            //assert
            Assert.AreEqual(expected, actual);
        }
        //UC7-Retriving the data in the record and checking the data
        [TestMethod]
        public void RetrivingTheRecordTest()
        {
            //assign 
            string expected = "siva priya ";
            string actual = "";
            //assign state and city
            string state = "Kerala";
            string city = "madurai";
            //act
            List<ContactDetails> list = addressBookManager.RetriveData(state, city, "dbo.RetriveData");
            foreach (var l in list)
            {
                actual += "" + l.firstName + " ";
            }
            //assert
            Assert.AreEqual(expected, actual);
        }
        //UC8-Retriving record in sorted order
        [TestMethod]
        public void RetrivingTheSortedRecordTest()
        {
            //assign 
            string expected = "Bala karthik Rathna Siva ";
            string actual = "";
            //act
            List<ContactDetails> list = addressBookManager.RetriveDataSorted("dbo.RetriveDataSorted");
            foreach (var l in list)
            {
                actual += "" + l.firstName + " ";
            }
            //assert
            Assert.AreEqual(expected, actual);
        }
        //UC9-Retriving the data in the record and checking the data
        [TestMethod]
        public void RetrivingTheRecordTestBasedOnType()
        {
            //assign 
            string expected = "stuart Jessi ";
            string actual = "";
            //assign state and city
            string type = "friend";
            string addressBookaname = "TVS";
            //act
            List<ContactDetails> list = addressBookManager.RetriveData(type, addressBookaname, "@type", "@addressName", "dbo.RetriveDataType");
            foreach (var l in list)
            {
                actual += "" + l.firstName + " ";
            }
            //assert
            Assert.AreEqual(expected, actual);
        }
        //UC10-Calculate the count of person by type
        [TestMethod]
        public void CountByTyeTest()
        {
            string expected = "2 3 1 ";
            string actual = addressBookManager.CountByType("dbo.CountByType");
            Assert.AreEqual(expected, actual);
        }
    }
    //UC13-Retriving the data in the record and checking the data
    [TestMethod]
    public void RetrivingTheRecordTest2()
    {
        //assign 
        string expected = "Stephan harry ";
        string actual = "";
        //assign state and city
        string state = "Kerala";
        string city = "madurai";
        //act
        List<ContactDetails> list = addressBookManager.RetriveData(state, city, "@state", "@city", "dbo.RetriveDataState1");
        foreach (var l in list)
        {
            actual += "" + l.firstName + " ";
        }
        //assert
        Assert.AreEqual(expected, actual);
    }
    //UC10-Calculate the count of person by type
    [TestMethod]
    public void CountByTyeTest1()
    {
        string expected = "2 2 2 ";
        string actual = addressBookManager.CountByType("dbo.CountByType1");
        Assert.AreEqual(expected, actual);
    }
    //UC8-Retriving record in sorted order
    [TestMethod]
    public void RetrivingTheSortedRecordTest1()
    {
        //assign 
        string expected = "bala karthi Rathna siva";
        string actual = "";
        //act
        List<ContactDetails> list = addressBookManager.RetriveDataSorted("dbo.SortedOrder");
        foreach (var l in list)
        {
            actual += "" + l.firstName + " ";
        }
        //assert
        Assert.AreEqual(expected, actual);
    }

}
}
    }
}

