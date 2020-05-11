using System;
using System.Collections.Generic;
using DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sales
{
    [TestClass]
    public class Users
    {
        [TestMethod]
        public void AuthorizeUser_ValidUserAndPassword_returnTrue()
        {
            using (SalesUtility.SalesUtility salesUtility = new SalesUtility.SalesUtility())
            {
                bool result = salesUtility.AuthorizeUser("Jeff", "123");
                Assert.AreEqual(result, true);
            }
        }
    }

    [TestClass]
    public class Products
    {
        [TestMethod]
        public void GetProducts_ValidProducts_returnProducts()
        {
            using (SalesUtility.SalesUtility salesUtility = new SalesUtility.SalesUtility())
            {
                List<Product> products = salesUtility.GetProducts();
                Assert.AreEqual(products.Count, 1);
            }
        }
    }


    [TestClass]
    public class Orders
    {
        [TestMethod]
        public void GetOrders_ValidOrders_returnOrders()
        {
            using (SalesUtility.SalesUtility salesUtility = new SalesUtility.SalesUtility())
            {
                List<Order> orders = salesUtility.GetOrders();
                Assert.AreEqual(orders.Count, 1);
            }
        }
    }
}
