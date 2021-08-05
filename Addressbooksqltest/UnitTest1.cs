using Microsoft.VisualStudio.TestTools.UnitTesting;
using Addressbooksql;

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
}

