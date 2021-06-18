using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabelac3
{
    class clsVendas
    {
        static List<clsVendas> listaLG = new List<clsVendas>();
        static int MaxID = 0;

        protected int _ID;
        protected string _NOME;
        protected string _PRECO;
        protected string _OBS;

        #region Construtores
        public clsVendas(string nome, string preco, string obs)
        {
            _NOME = nome;
            _PRECO = preco;
            _OBS = obs;
        }
        public clsVendas(int id, string nome, string preco, string obs)
        {
            _ID = id;
            _NOME = nome;
            _PRECO = preco;
            _OBS = obs;
        }

        public clsVendas(int id, int v)
        {
            clsVendas aux = listaLG.Find(lc => lc.ID == id);
            _ID = aux.ID;
            _NOME = aux.NOME;
            _PRECO = aux.PRECO;
            _OBS = aux.OBS;
        }
        #endregion

        #region Propriedades
        public int ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        public string NOME
        {
            set { _NOME = value; }
            get { return _NOME; }
        }
        public string PRECO
        {
            set { _PRECO = value; }
            get { return _PRECO; }
        }
        public string OBS
        {
            set { _OBS = value; }
            get { return _OBS; }
        }

        #endregion

        #region Acessa dados
        public void Inserir()
        {
            MaxID++;
            _ID = MaxID;
            listaLG.Add(this);
        }
        public static List<clsVendas> Consultar()
        {
            return listaLG;
        }
        public static List<clsVendas> Consultar(string nome)
        {
            return listaLG.FindAll(ltg => ltg.NOME.Contains(nome));
        }

        public void Alterar()
        {
            int i;
            i = listaLG.FindIndex(lg => lg.ID == _ID);
            listaLG[i].ID = _ID;
            listaLG[i].NOME = _NOME;
            listaLG[i].PRECO = _PRECO;
            listaLG[i].OBS = _OBS;
        }


        public void Excluir()
        { }

        #endregion
    }
}
