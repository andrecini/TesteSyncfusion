using System;
using System.IO;

namespace TesteSyncFusion
{
    class DataCreator
    {
        #region Singleton
        private static DataCreator _instance;

        public static DataCreator GetInstance(string namesPath, string statesPath)
        {
            if (_instance == null)
                _instance = new DataCreator(namesPath, statesPath);

            return _instance;
        }
        #endregion

        #region Arrays with data
        public string[] names;

        public int[] ages;

        public string[] states;
        #endregion

        #region Methods to create arrays with data
        /// <summary>
        /// Cria array com 100 nomes
        /// </summary>
        /// <param name="path">Endereço do arquivo com os nomes</param>
        /// <returns>string[] names</returns>
        private string[] ReturnArrayWithNames(string path)
        {
            return File.ReadAllLines(string.Format(@"{0}", path));
        }

        /// <summary>
        /// Cria array com 100 posições, contendo
        /// os Estados Brasileiros(de forma aleatória).
        /// </summary>
        /// <param name="path">Endereço do arquivo com os Estados</param>
        /// <returns>string[] states</returns>
        private string[] ReturnArrayWithState(string path)
        {
            string[] statesAux = File.ReadAllLines(string.Format(@"{0}", path));
            string[] states = new string[100];
            Random rdm = new Random();

            for (int i = 0; i < 100; i++)
            {
                states[i] = statesAux[rdm.Next(0, statesAux.Length - 1)];
            }

            return states;
        }

        /// <summary>
        /// Cria array com 100 idades geradas
        /// de forma aleatória.
        /// </summary>
        /// <returns>int[] ages</returns>
        private int[] ReturnArrayWithAges()
        {
            int[] ages = new int[100];
            Random rdm = new Random();

            for (int i = 0; i < 100; i++)
            {
                ages[i] = rdm.Next(1, 100);
            }

            return ages;
        }
        #endregion

        /// <summary>
        /// Cria todos os arrays contendo os dados
        /// das pessoas.
        /// </summary>
        /// <param name="namesPath">Endereço do arquivo com os nomes</param>
        /// <param name="statesPath">Endereço do arquivo com os Estados</param>
        public DataCreator(string namesPath, string statesPath)
        {
            names = ReturnArrayWithNames(namesPath);
            ages = ReturnArrayWithAges();
            states = ReturnArrayWithState(statesPath);
        }
    }
}
