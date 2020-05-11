using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesUtility
{
    public class SalesUtility : IDisposable
    {
        public void Dispose()
        {
            //
        }

        public bool AuthorizeUser(string userName, string password)
        {
            try
            {
                using (DataAccessLayer.DataAccess dataAccess = new DataAccessLayer.DataAccess())
                {
                    return dataAccess.AuthorizeUser(userName, password);
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                using(DataAccess dataAccess = new DataAccess()) 
                {
                    return dataAccess.GetProducts();
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public List<Order> GetOrders()
        {
            try
            {
                using( DataAccess dataAccess = new DataAccess()) 
                {
                    return dataAccess.GetOrders();
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        private decimal totalSales = 0;
        private int quantity = 0;
        public void AddToTotalSales(decimal subTotal, int quatity)
        {
            totalSales += subTotal;
            quantity += quatity;
        }

        public decimal GetDiscount()
        {
            decimal discount = 0;
            if(totalSales > 200)
            {
                discount = 3;
            }
            if(quantity > 10)
            {
                discount += 8;
            }
            return discount;
        }

        public decimal GetSalesTotalWithDiscountVAT()
        {

            decimal discountedValue = GetDiscountedValue();
            decimal VAT = GetVAT();
            return Math.Round((totalSales - discountedValue) * VAT,2);
        }

        public decimal GetSalesTotalWitoutDiscountVAT()
        {
            decimal VAT = GetVAT();
            return Math.Round((totalSales) * VAT,2);
        }

        private decimal GetVAT()
        {
            return Convert.ToDecimal(1.15);
        }

        private decimal GetDiscountedValue()
        {
            return (totalSales * (GetDiscount() / 100));
        }
    }
}
