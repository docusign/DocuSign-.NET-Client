/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace DocuSign.eSign.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITrustServiceProvidersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns Account available seals for specified account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns></returns>
        AccountSeals GetSealProviders(string accountId);

        /// <summary>
        /// Returns Account available seals for specified account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<AccountSeals> GetSealProvidersWithHttpInfo(string accountId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns Account available seals for specified account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of AccountSeals</returns>
        System.Threading.Tasks.Task<AccountSeals> GetSealProvidersAsync(string accountId);

        /// <summary>
        /// Returns Account available seals for specified account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ApiResponse (AccountSeals)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountSeals>> GetSealProvidersAsyncWithHttpInfo(string accountId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TrustServiceProvidersApi : ITrustServiceProvidersApi
    {
        private DocuSign.eSign.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustServiceProvidersApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public TrustServiceProvidersApi(DocuSignClient aplClient)
        {
            this.ApiClient = aplClient;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.GetBasePath();
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public DocuSignClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.eSign.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }



        /// <summary>
        /// Returns Account available seals for specified account. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>AccountSeals</returns>
        public AccountSeals GetSealProviders(string accountId)
        {
             ApiResponse<AccountSeals> localVarResponse = GetSealProvidersWithHttpInfo(accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns Account available seals for specified account. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>ApiResponse of AccountSeals</returns>
        public ApiResponse<AccountSeals> GetSealProvidersWithHttpInfo(string accountId)
        {
            return GetSealProvidersAsyncWithHttpInfo(accountId)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }

        /// <summary>
        /// Returns Account available seals for specified account. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of AccountSeals</returns>
        public async System.Threading.Tasks.Task<AccountSeals> GetSealProvidersAsync(string accountId, System.Threading.CancellationToken cancellationToken = default)
        {
             ApiResponse<AccountSeals> localVarResponse = await GetSealProvidersAsyncWithHttpInfo(accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns Account available seals for specified account. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ApiResponse (AccountSeals)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountSeals>> GetSealProvidersAsyncWithHttpInfo(string accountId, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling TrustServiceProvidersApi->GetSealProviders");

            var localVarPath = "/v2.1/accounts/{accountId}/seals";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new List<FileParameter>();
            Object localVarPostBody = null;
            String localVarHttpContentDisposition = string.Empty;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", this.ApiClient.ParameterToString(accountId)); // path parameter

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }

            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, HttpMethod.Get, localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = await this.ApiClient.CallApiAsync(localVarRequest, cancellationToken)

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSealProviders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountSeals>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (AccountSeals)this.ApiClient.Deserialize(localVarResponse, typeof(AccountSeals)));
        }

    }
}