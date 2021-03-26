using System.Collections.ObjectModel;
namespace TesteSyncFusion
{
    public class OrderInfoCollection
    {
        #region Singleton
        private static OrderInfoCollection _instance;

        public static OrderInfoCollection GetInstance(string namesPath, string statesPath)
        {
            if (_instance == null)
                _instance = new OrderInfoCollection(namesPath, statesPath);

            return _instance;
        }
        #endregion

        //Coleção de dados dinâmica local.
        private ObservableCollection<OrderInfo> _orders;
        
        //Variáveis que contém o endereço
        //dos arquivos ".txt" com os dados.
        private string _namesPath;
        private string _statesPath;

        //Coleção de dados dinâmica global.
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders;}
            set { _orders = value;}
        }

        /// <summary>
        /// Construtor que seta as variáveis de
        /// endereço dos arquivos e gera a cole-
        /// ção Observable
        /// </summary>
        /// <param name="namesPath">Endereço dos arquivos com os nomes</param>
        /// <param name="statesPath">Endereço dos arquivos com os Estados</param>
        public OrderInfoCollection(string namesPath, string statesPath)
        {
            _orders = new ObservableCollection<OrderInfo>();
            _namesPath = namesPath;
            _statesPath = statesPath;
            GenerateOrders();
            
        }

        //Gera a ObservableCollection com
        //os dados do arquivo ".txt".
        private void GenerateOrders()
        {
            DataCreator dc = new DataCreator(_namesPath, _statesPath);

            for (int i = 0; i < 100; i++)
            {
                _orders.Add(new OrderInfo(i + 1, dc.names[i], dc.ages[i], dc.states[i]));
            }
        }
    }
}
