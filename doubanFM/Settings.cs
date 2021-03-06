﻿using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubanFM
{
    public class Settings
    {
        public static IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

        private static void Save()
        {
            settings.Save();
        }

        public static void Put<T>(string key, T val)
        {
            if(settings.Contains(key))
            {
                settings[key] = val;
            }
            else
            {
                settings.Add(key, val);
            }
            Save();
        }

        public static T Get<T>(string key)
        {
            if(settings.Contains(key))
            {
                return (T)settings[key];
            }
            return default(T);
        }
    }

}
