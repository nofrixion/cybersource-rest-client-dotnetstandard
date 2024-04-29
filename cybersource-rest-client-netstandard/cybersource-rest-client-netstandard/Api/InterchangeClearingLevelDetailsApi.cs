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
    public interface IInterchangeClearingLevelDetailsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Interchange Clearing Level data for an account or a merchant
        /// </summary>
        /// <remarks>
        /// Interchange Clearing Level data for an account or a merchant
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ReportingV3InterchangeClearingLevelDetailsGet200Response</returns>
        ReportingV3InterchangeClearingLevelDetailsGet200Response GetInterchangeClearingLevelDetails (DateTime? startTime, DateTime? endTime, string organizationId = null);

        /// <summary>
        /// Interchange Clearing Level data for an account or a merchant
        /// </summary>
        /// <remarks>
        /// Interchange Clearing Level data for an account or a merchant
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3InterchangeClearingLevelDetailsGet200Response</returns>
        ApiResponse<ReportingV3InterchangeClearingLevelDetailsGet200Response> GetInterchangeClearingLevelDetailsWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Interchange Clearing Level data for an account or a merchant
        /// </summary>
        /// <remarks>
        /// Interchange Clearing Level data for an account or a merchant
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ReportingV3InterchangeClearingLevelDetailsGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3InterchangeClearingLevelDetailsGet200Response> GetInterchangeClearingLevelDetailsAsync (DateTime? startTime, DateTime? endTime, string organizationId = null);

        /// <summary>
        /// Interchange Clearing Level data for an account or a merchant
        /// </summary>
        /// <remarks>
        /// Interchange Clearing Level data for an account or a merchant
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3InterchangeClearingLevelDetailsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3InterchangeClearingLevelDetailsGet200Response>> GetInterchangeClearingLevelDetailsAsyncWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InterchangeClearingLevelDetailsApi : IInterchangeClearingLevelDetailsApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InterchangeClearingLevelDetailsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InterchangeClearingLevelDetailsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="InterchangeClearingLevelDetailsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InterchangeClearingLevelDetailsApi(Configuration configuration = null)
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
            return Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
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
        /// Interchange Clearing Level data for an account or a merchant Interchange Clearing Level data for an account or a merchant
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ReportingV3InterchangeClearingLevelDetailsGet200Response</returns>
        public ReportingV3InterchangeClearingLevelDetailsGet200Response GetInterchangeClearingLevelDetails (DateTime? startTime, DateTime? endTime, string organizationId = null)
        {
            logger.Debug("CALLING API \"GetInterchangeClearingLevelDetails\" STARTED");
            ApiResponse<ReportingV3InterchangeClearingLevelDetailsGet200Response> localVarResponse = GetInterchangeClearingLevelDetailsWithHttpInfo(startTime, endTime, organizationId);
            logger.Debug("CALLING API \"GetInterchangeClearingLevelDetails\" ENDED");
            return localVarResponse.Data;
        }

        /// <summary>
        /// Interchange Clearing Level data for an account or a merchant Interchange Clearing Level data for an account or a merchant
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3InterchangeClearingLevelDetailsGet200Response</returns>
        public ApiResponse< ReportingV3InterchangeClearingLevelDetailsGet200Response > GetInterchangeClearingLevelDetailsWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'startTime' is set
            if (startTime == null)
            {
                logger.Error("ApiException : Missing required parameter 'startTime' when calling InterchangeClearingLevelDetailsApi->GetInterchangeClearingLevelDetails");
                throw new ApiException(400, "Missing required parameter 'startTime' when calling InterchangeClearingLevelDetailsApi->GetInterchangeClearingLevelDetails");
            }
            // verify the required parameter 'endTime' is set
            if (endTime == null)
            {
                logger.Error("ApiException : Missing required parameter 'endTime' when calling InterchangeClearingLevelDetailsApi->GetInterchangeClearingLevelDetails");
                throw new ApiException(400, "Missing required parameter 'endTime' when calling InterchangeClearingLevelDetailsApi->GetInterchangeClearingLevelDetails");
            }

            var localVarPath = $"/reporting/v3/interchange-clearing-level-details";
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
                "application/hal+json",
                "application/xml"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (startTime != null)
            {
                localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            }
            if (endTime != null)
            {
                localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            }
            if (organizationId != null)
            {
                localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInterchangeClearingLevelDetails", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<ReportingV3InterchangeClearingLevelDetailsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportingV3InterchangeClearingLevelDetailsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportingV3InterchangeClearingLevelDetailsGet200Response))); // Return statement
        }

        /// <summary>
        /// Interchange Clearing Level data for an account or a merchant Interchange Clearing Level data for an account or a merchant
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ReportingV3InterchangeClearingLevelDetailsGet200Response</returns>
        public async System.Threading.Tasks.Task<ReportingV3InterchangeClearingLevelDetailsGet200Response> GetInterchangeClearingLevelDetailsAsync (DateTime? startTime, DateTime? endTime, string organizationId = null)
        {
            logger.Debug("CALLING API \"GetInterchangeClearingLevelDetailsAsync\" STARTED");
            ApiResponse<ReportingV3InterchangeClearingLevelDetailsGet200Response> localVarResponse = await GetInterchangeClearingLevelDetailsAsyncWithHttpInfo(startTime, endTime, organizationId);
            logger.Debug("CALLING API \"GetInterchangeClearingLevelDetailsAsync\" ENDED");
            return localVarResponse.Data;

        }

        /// <summary>
        /// Interchange Clearing Level data for an account or a merchant Interchange Clearing Level data for an account or a merchant
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3InterchangeClearingLevelDetailsGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportingV3InterchangeClearingLevelDetailsGet200Response>> GetInterchangeClearingLevelDetailsAsyncWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'startTime' is set
            if (startTime == null)
            {
                logger.Error("ApiException : Missing required parameter 'startTime' when calling InterchangeClearingLevelDetailsApi->GetInterchangeClearingLevelDetails");
                throw new ApiException(400, "Missing required parameter 'startTime' when calling InterchangeClearingLevelDetailsApi->GetInterchangeClearingLevelDetails");
            }
            // verify the required parameter 'endTime' is set
            if (endTime == null)
            {
                logger.Error("ApiException : Missing required parameter 'endTime' when calling InterchangeClearingLevelDetailsApi->GetInterchangeClearingLevelDetails");
                throw new ApiException(400, "Missing required parameter 'endTime' when calling InterchangeClearingLevelDetailsApi->GetInterchangeClearingLevelDetails");
            }

            var localVarPath = $"/reporting/v3/interchange-clearing-level-details";
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
                "application/hal+json",
                "application/xml"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (startTime != null)
            {
                localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            }
            if (endTime != null)
            {
                localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            }
            if (organizationId != null)
            {
                localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInterchangeClearingLevelDetails", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<ReportingV3InterchangeClearingLevelDetailsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportingV3InterchangeClearingLevelDetailsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportingV3InterchangeClearingLevelDetailsGet200Response))); // Return statement
        }
    }
}
