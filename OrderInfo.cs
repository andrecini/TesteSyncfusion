using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XlsIO;

namespace TesteSyncFusion
{
    public class OrderInfo
    {
        #region Singleton
        private static OrderInfo _instance;

        public static OrderInfo GetInstance()
        {
            if (_instance == null)
                _instance = new OrderInfo();

            return _instance;
        }
        #endregion

        //Variáveis com os dados da pessoa
        int orderID;
        string orderName;
        int orderAge;
        string orderState;
        
        /// <summary>
        /// Construtor personalizado que recebe
        /// os dados da pessoa como parâmetro
        /// para setar as propriedades.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="state"></param>
        public OrderInfo(int ID, string name, int age, string state)
        {
            this.OrderID = ID;
            this.OrderName = name;
            this.OrderAge = age;
            this.OrderState = state;
        }

        //Construtor Padrão
        public OrderInfo()
        {
        }

        //Propriedades com os dados da pessoa
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        public string OrderName
        {
            get { return orderName; }
            set { orderName = value; }
        }
        public int OrderAge
        {
            get { return orderAge; }
            set { orderAge = value; }
        }
        public string OrderState
        {
            get { return orderState; }
            set { orderState = value; }
        }
    }
}
