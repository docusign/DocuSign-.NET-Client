/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Net;
using System.Net.Http;

namespace DocuSign.eSign.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    [Obsolete("ApiClient is now obsolete and will be removed in a future release. Use DocuSignClient instead.", false)]
    public class ApiClient : DocuSignClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration and base path (https://demo.docusign.net/restapi).
        /// </summary>
        [Obsolete("ApiClient is now obsolete and will be removed in a future release. Use DocuSignClient() instead.", false)]
        public ApiClient() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default base path (https://demo.docusign.net/restapi).
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        [Obsolete("ApiClient is now obsolete and will be removed in a future release. Use DocuSignClient(Configuration) instead.", false)]
        public ApiClient(Configuration configuration) : base(configuration) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration.
        /// </summary>
        /// <param name="apiBase">The base path.</param>
        /// <param name="proxy">An optional WebProxy instance.</param>
        [Obsolete("ApiClient is now obsolete and will be removed in a future release. Use DocuSignClient(string, IWebProxy) instead.", false)]
        public ApiClient(String apiBase, IWebProxy proxy = null) : base(apiBase, proxy) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration.
        /// </summary>
        /// <param name="apiBase">The base path.</param>
        /// <param name="oAuthBase">The oAuth base path.</param>
        /// <param name="proxy">An optional WebProxy instance.</param>
        [Obsolete("ApiClient is now obsolete and will be removed in a future release. Use DocuSignClient(String, String, WebProxy) instead.", false)]
        public ApiClient(String apiBase, String oAuthBase, IWebProxy proxy = null) : base(apiBase, oAuthBase, proxy) { }
    }
}