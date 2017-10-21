﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Zarya
    {
        Languages.English.Heroes.EN_Zarya EN;
        string myLang;

        public L_Zarya(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Zarya();
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


        //Skin

        //Rare
        public string Brick_SK
        {
            get
            {
                //else
                {
                    return EN.Brick_SK;
                }
            }
        }

        public string Goldenrod_SK
        {
            get
            {
                //else
                {
                    return EN.Goldenrod_SK;
                }
            }
        }

        public string Taiga_SK
        {
            get
            {
                //else
                {
                    return EN.Taiga_SK;
                }
            }
        }

        public string Violet_SK
        {
            get
            {
                //else
                {
                    return EN.Violet_SK;
                }
            }
        }
        //Epic
        public string Dawn_SK
        {
            get
            {
                //else
                {
                    return EN.Dawn_SK;
                }
            }
        }

        public string Midnight_SK
        {
            get
            {
                //else
                {
                    return EN.Midnight_SK;
                }
            }
        }

        public string Frosted_SK
        {//Winter 2016
            get
            {
                //else
                {
                    return EN.Frosted_SK;
                }
            }
        }
        //Legendary
        public string Arctic_SK
        {
            get
            {
                //else
                {
                    return EN.Arctic_SK;
                }
            }
        }

        public string Siberian_Front_SK
        {
            get
            {
                //else
                {
                    return EN.Siberian_Front_SK;
                }
            }
        }

        public string Cybergoth_SK
        {
            get
            {
                //else
                {
                    return EN.Cybergoth_SK;
                }
            }
        }

        public string Industrial_SK
        {
            get
            {
                //else
                {
                    return EN.Industrial_SK;
                }
            }
        }

        public string Champion_SK
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Champion_SK;
                }
            }
        }

        public string Weightlifter_SK
        {//Summer 2016
            get
            {
                //else
                {
                    return EN.Weightlifter_SK;
                }
            }
        }

        public string Totally_80s_SK
        {//Halloween 2017
            get
            {
                //else
                {
                    return EN.Totally_80s_SK;
                }
            }
        }

        public string Cyberian_SK
        {//Annyver 2017
            get
            {
                //else
                {
                    return EN.Cyberian_SK;
                }
            }
        }


        //Emotes
    }
}
