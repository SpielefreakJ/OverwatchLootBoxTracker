﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Genji
    {
        Languages.English.Heroes.EN_Genji EN;
        Languages.German.Heroes.DE_Genji DE;
        string myLang;

        public L_Genji(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Genji();
            DE = new Languages.German.Heroes.DE_Genji();
        }

        public string ChangeLang
        {
            get
            {
                return myLang;
            }
            set
            {
                myLang = value;
            }
        }

        public string Name
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Name;
                }
                else
                {
                    return EN.Name;
                }
            }
        }


        //Skin

        //Rare
        public string Azurite_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Azurite_SK;
                }
                else
                {
                    return EN.Azurite_SK;
                }
            }
        }

        public string Cinnabar_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cinnabar_SK;
                }
                else
                {
                    return EN.Cinnabar_SK;
                }
            }
        }

        public string Malachite_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Malachite_SK;
                }
                else
                {
                    return EN.Malachite_SK;
                }
            }
        }

        public string Ochre_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ochre_SK;
                }
                else
                {
                    return EN.Ochre_SK;
                }
            }
        }
        //Epic
        public string Carbon_Fiber_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Carbon_Fiber_SK;
                }
                else
                {
                    return EN.Carbon_Fiber_SK;
                }
            }
        }

        public string Chrome_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Chrome_SK;
                }
                else
                {
                    return EN.Chrome_SK;
                }
            }
        }

        public string Nihon_SK//7
        {//Summer 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Nihon_SK;
                }
                else
                {
                    return EN.Nihon_SK;
                }
            }
        }
        //Legendary
        public string Sparrow_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sparrow_SK;
                }
                else
                {
                    return EN.Sparrow_SK;
                }
            }
        }

        public string Young_Genji_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Young_Genji_SK;
                }
                else
                {
                    return EN.Young_Genji_SK;
                }
            }
        }

        public string Bedouin_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bedouin_SK;
                }
                else
                {
                    return EN.Bedouin_SK;
                }
            }
        }

        public string Nomad_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Nomad_SK;
                }
                else
                {
                    return EN.Nomad_SK;
                }
            }
        }

        public string Oni_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Oni_SK;
                }
                else
                {
                    return EN.Oni_SK;
                }
            }
        }

        public string Blackwatch_SK//13
        {//Uprising 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Blackwatch_SK;
                }
                else
                {
                    return EN.Blackwatch_SK;
                }
            }
        }

        public string Sentai_SK//14
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sentai_SK;
                }
                else
                {
                    return EN.Sentai_SK;
                }
            }
        }


        //Emotes
    }
}
