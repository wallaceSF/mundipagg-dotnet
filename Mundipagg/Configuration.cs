﻿namespace Mundipagg
{
    /// <summary>
    /// Mundipagg Api Client Configuration
    /// </summary>
    public class Configuration
    {
        #region Private Fields

        /// <summary>
        /// Default api url
        /// </summary>
        private const string API_URL = "https://api.Mundipagg.com";

        /// <summary>
        /// Default timeout
        /// </summary>
        private const int TIMEOUT = 30000;

        #endregion Private Fields

        #region Public Constructors

        public Configuration()
        {
        }

        /// <summary>
        /// Creates a new configuration using default values for api url and timeout
        /// </summary>
        /// <param name="secretKey">Your secret key, something like sk_xxxxx or sk_test_xxxx</param>
        public Configuration(string secretKey)
        {
            this.SecretKey = secretKey;
            this.ApiUrl = API_URL;
            this.Timeout = TIMEOUT;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Api Url
        /// </summary>
        public string ApiUrl { get; set; }

        /// <summary>
        /// Your secret key, something like sk_xxxxx or sk_test_xxxx
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Timeout in milliseconds
        /// </summary>
        public int Timeout { get; set; }

        #endregion Public Properties
    }
}