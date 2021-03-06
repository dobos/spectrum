﻿using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Jhu.SpecSvc.Web
{
    public class AppSettings
    {
        private static string GetValue(string key)
        {
            return (string)((NameValueCollection)ConfigurationManager.GetSection("Jhu.SpecSvc.Web/Settings"))[key];
        }

        public static NameValueCollection ImageCutOuts
        {
            get
            {
                return (NameValueCollection)ConfigurationManager.GetSection("Jhu.SpecSvc.Web/ImageCutOuts");
            }
        }

        public static string SkyServerWsUrl
        {
            get { return GetValue("SkyServerWsUrl"); }
        }

        public static long SkyServerWsId
        {
            get { return long.Parse(GetValue("SkyServerWsId")); }
        }

        public static string RegionSearchUrl
        {
            get { return GetValue("RegionSearchUrl"); }
        }

        public static string WebServiceBaseUrl
        {
            get { return GetValue("WebServiceBaseUrl"); }
        }

        public static string SsaBaseUrl
        {
            get { return GetValue("SsaBaseUrl"); }
        }

        public static string DefaultMySpectrumBaseUrl
        {
            get { return GetValue("DefaultMySpectrumBaseUrl"); }
        }

        /*public static string ExportDir
        {
            get { return GetValue("ExportDir"); }       // *** TODO: move this to the federation config?
        }*/
    }
}