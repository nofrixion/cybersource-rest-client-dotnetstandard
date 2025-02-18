/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokenizationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Tokenize Card
        /// </summary>
        /// <remarks>
        /// Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"></param>
        /// <returns>FlexV1TokensPost200Response</returns>
        FlexV1TokensPost200Response Tokenize (TokenizeRequest tokenizeRequest);

        /// <summary>
        /// Tokenize Card
        /// </summary>
        /// <remarks>
        /// Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"></param>
        /// <returns>ApiResponse of FlexV1TokensPost200Response</returns>
        ApiResponse<FlexV1TokensPost200Response> TokenizeWithHttpInfo (TokenizeRequest tokenizeRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Tokenize Card
        /// </summary>
        /// <remarks>
        /// Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"></param>
        /// <returns>Task of FlexV1TokensPost200Response</returns>
        System.Threading.Tasks.Task<FlexV1TokensPost200Response> TokenizeAsync (TokenizeRequest tokenizeRequest);

        /// <summary>
        /// Tokenize Card
        /// </summary>
        /// <remarks>
        /// Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"></param>
        /// <returns>Task of ApiResponse (FlexV1TokensPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlexV1TokensPost200Response>> TokenizeAsyncWithHttpInfo (TokenizeRequest tokenizeRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokenizationApi : ITokenizationApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenizationApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokenizationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Tokenize Card Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"></param>
        /// <returns>FlexV1TokensPost200Response</returns>
        public FlexV1TokensPost200Response Tokenize (TokenizeRequest tokenizeRequest)
        {
            logger.Debug("CALLING API \"Tokenize\" STARTED");
            ApiResponse<FlexV1TokensPost200Response> localVarResponse = TokenizeWithHttpInfo(tokenizeRequest);
            logger.Debug("CALLING API \"Tokenize\" ENDED");
            return localVarResponse.Data;
        }

        /// <summary>
        /// Tokenize Card Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"></param>
        /// <returns>ApiResponse of FlexV1TokensPost200Response</returns>
        public ApiResponse< FlexV1TokensPost200Response > TokenizeWithHttpInfo (TokenizeRequest tokenizeRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'tokenizeRequest' is set
            if (tokenizeRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'tokenizeRequest' when calling TokenizationApi->Tokenize");
                throw new ApiException(400, "Missing required parameter 'tokenizeRequest' when calling TokenizationApi->Tokenize");
            }

            var localVarPath = $"/flex/v1/tokens";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (tokenizeRequest != null && tokenizeRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tokenizeRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenizeRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Tokenize", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<FlexV1TokensPost200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlexV1TokensPost200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlexV1TokensPost200Response))); // Return statement
        }

        /// <summary>
        /// Tokenize Card Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"></param>
        /// <returns>Task of FlexV1TokensPost200Response</returns>
        public async System.Threading.Tasks.Task<FlexV1TokensPost200Response> TokenizeAsync (TokenizeRequest tokenizeRequest)
        {
            logger.Debug("CALLING API \"TokenizeAsync\" STARTED");
            ApiResponse<FlexV1TokensPost200Response> localVarResponse = await TokenizeAsyncWithHttpInfo(tokenizeRequest);
            logger.Debug("CALLING API \"TokenizeAsync\" ENDED");
            return localVarResponse.Data;

        }

        /// <summary>
        /// Tokenize Card Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"></param>
        /// <returns>Task of ApiResponse (FlexV1TokensPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlexV1TokensPost200Response>> TokenizeAsyncWithHttpInfo (TokenizeRequest tokenizeRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'tokenizeRequest' is set
            if (tokenizeRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'tokenizeRequest' when calling TokenizationApi->Tokenize");
                throw new ApiException(400, "Missing required parameter 'tokenizeRequest' when calling TokenizationApi->Tokenize");
            }

            var localVarPath = $"/flex/v1/tokens";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (tokenizeRequest != null && tokenizeRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tokenizeRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenizeRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Tokenize", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<FlexV1TokensPost200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlexV1TokensPost200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlexV1TokensPost200Response))); // Return statement
        }
    }
}
