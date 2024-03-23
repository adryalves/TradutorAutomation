using EasyAutomationFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradutorAutomation
{
    public class Traduzir : WebPersonalizado
    {
        
        List<string> idiomasLista = new List<string>();
        public Traduzir()
        {
            StartBrowser();
        }

        public void PegarListaIdiomas()
        {
            string teste = "Olá Mundo";
            Navigate("https://www.reverso.net/tradu%C3%A7%C3%A3o-texto");


            Click(TypeElement.Xpath, "/html/body/app-root/app-translation/div/app-translation-box/div[1]/div[1]/div[1]/app-language-switch/div/app-language-select[1]/div");
          //  Thread.Sleep(4000);
            GetListData(TypeElement.Xpath, "/html/body/div[2]/app-language-select-options/div/ul", "Português");

            AssignValue(TypeElement.Xpath, "/html/body/app-root/app-translation/div/app-translation-box/div[1]/div[1]/div[2]/div[1]/div[1]/div/div[1]/textarea", teste);

            Click(TypeElement.Xpath, "/html/body/app-root/app-translation/div/app-translation-box/div[1]/div[1]/div[1]/app-language-switch/div/app-language-select[2]/div/div/div");

            TranslateAll(TypeElement.Xpath, "/html/body/div[3]/app-language-select-options/div/ul", teste);

           
        }
       

    }
}
