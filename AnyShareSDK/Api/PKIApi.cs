/* 
 * OpenDoc_API-文档访问
 *
 * API to access AnyShare    如有任何疑问，可到开发者社区提问：https://developers.aishu.cn  # Authentication  - 调用需要鉴权的API，必须将token放在HTTP header中：\"Authorization: Bearer ACCESS_TOKEN\"  - 对于GET请求，除了将token放在HTTP header中，也可以将token放在URL query string中：\"tokenid=ACCESS_TOKEN\"  
 *
 * The version of the OpenAPI document: 6.0.10
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using AnyShareSDK.Client;
using AnyShareSDK.Model;

namespace AnyShareSDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPKIApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 使用PKI认证
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pkiAuthenReq"></param>
        /// <returns>PkiAuthenRes</returns>
        PkiAuthenRes PkiAuthenPost (PkiAuthenReq pkiAuthenReq);

        /// <summary>
        /// 使用PKI认证
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pkiAuthenReq"></param>
        /// <returns>ApiResponse of PkiAuthenRes</returns>
        ApiResponse<PkiAuthenRes> PkiAuthenPostWithHttpInfo (PkiAuthenReq pkiAuthenReq);
        /// <summary>
        /// 获取original
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PkiOriginalRes</returns>
        PkiOriginalRes PkiOriginalPost ();

        /// <summary>
        /// 获取original
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PkiOriginalRes</returns>
        ApiResponse<PkiOriginalRes> PkiOriginalPostWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 使用PKI认证
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pkiAuthenReq"></param>
        /// <returns>Task of PkiAuthenRes</returns>
        System.Threading.Tasks.Task<PkiAuthenRes> PkiAuthenPostAsync (PkiAuthenReq pkiAuthenReq);

        /// <summary>
        /// 使用PKI认证
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pkiAuthenReq"></param>
        /// <returns>Task of ApiResponse (PkiAuthenRes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PkiAuthenRes>> PkiAuthenPostAsyncWithHttpInfo (PkiAuthenReq pkiAuthenReq);
        /// <summary>
        /// 获取original
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PkiOriginalRes</returns>
        System.Threading.Tasks.Task<PkiOriginalRes> PkiOriginalPostAsync ();

        /// <summary>
        /// 获取original
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PkiOriginalRes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PkiOriginalRes>> PkiOriginalPostAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PKIApi : IPKIApi
    {
        private AnyShareSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PKIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PKIApi(String basePath)
        {
            this.Configuration = new AnyShareSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AnyShareSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKIApi"/> class
        /// </summary>
        /// <returns></returns>
        public PKIApi()
        {
            this.Configuration = AnyShareSDK.Client.Configuration.Default;

            ExceptionFactory = AnyShareSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKIApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PKIApi(AnyShareSDK.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = AnyShareSDK.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = AnyShareSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AnyShareSDK.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AnyShareSDK.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// 使用PKI认证 
        /// </summary>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pkiAuthenReq"></param>
        /// <returns>PkiAuthenRes</returns>
        public PkiAuthenRes PkiAuthenPost (PkiAuthenReq pkiAuthenReq)
        {
             ApiResponse<PkiAuthenRes> localVarResponse = PkiAuthenPostWithHttpInfo(pkiAuthenReq);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 使用PKI认证 
        /// </summary>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pkiAuthenReq"></param>
        /// <returns>ApiResponse of PkiAuthenRes</returns>
        public ApiResponse<PkiAuthenRes> PkiAuthenPostWithHttpInfo (PkiAuthenReq pkiAuthenReq)
        {
            // verify the required parameter 'pkiAuthenReq' is set
            if (pkiAuthenReq == null)
                throw new ApiException(400, "Missing required parameter 'pkiAuthenReq' when calling PKIApi->PkiAuthenPost");

            var localVarPath = "/pki/authen";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (pkiAuthenReq != null && pkiAuthenReq.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pkiAuthenReq); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pkiAuthenReq; // byte array
            }

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PkiAuthenPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PkiAuthenRes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PkiAuthenRes) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PkiAuthenRes)));
        }

        /// <summary>
        /// 使用PKI认证 
        /// </summary>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pkiAuthenReq"></param>
        /// <returns>Task of PkiAuthenRes</returns>
        public async System.Threading.Tasks.Task<PkiAuthenRes> PkiAuthenPostAsync (PkiAuthenReq pkiAuthenReq)
        {
             ApiResponse<PkiAuthenRes> localVarResponse = await PkiAuthenPostAsyncWithHttpInfo(pkiAuthenReq);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 使用PKI认证 
        /// </summary>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pkiAuthenReq"></param>
        /// <returns>Task of ApiResponse (PkiAuthenRes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PkiAuthenRes>> PkiAuthenPostAsyncWithHttpInfo (PkiAuthenReq pkiAuthenReq)
        {
            // verify the required parameter 'pkiAuthenReq' is set
            if (pkiAuthenReq == null)
                throw new ApiException(400, "Missing required parameter 'pkiAuthenReq' when calling PKIApi->PkiAuthenPost");

            var localVarPath = "/pki/authen";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (pkiAuthenReq != null && pkiAuthenReq.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pkiAuthenReq); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pkiAuthenReq; // byte array
            }

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PkiAuthenPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PkiAuthenRes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PkiAuthenRes) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PkiAuthenRes)));
        }

        /// <summary>
        /// 获取original 
        /// </summary>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PkiOriginalRes</returns>
        public PkiOriginalRes PkiOriginalPost ()
        {
             ApiResponse<PkiOriginalRes> localVarResponse = PkiOriginalPostWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// 获取original 
        /// </summary>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PkiOriginalRes</returns>
        public ApiResponse<PkiOriginalRes> PkiOriginalPostWithHttpInfo ()
        {

            var localVarPath = "/pki/original";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PkiOriginalPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PkiOriginalRes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PkiOriginalRes) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PkiOriginalRes)));
        }

        /// <summary>
        /// 获取original 
        /// </summary>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PkiOriginalRes</returns>
        public async System.Threading.Tasks.Task<PkiOriginalRes> PkiOriginalPostAsync ()
        {
             ApiResponse<PkiOriginalRes> localVarResponse = await PkiOriginalPostAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// 获取original 
        /// </summary>
        /// <exception cref="AnyShareSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PkiOriginalRes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PkiOriginalRes>> PkiOriginalPostAsyncWithHttpInfo ()
        {

            var localVarPath = "/pki/original";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PkiOriginalPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PkiOriginalRes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PkiOriginalRes) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PkiOriginalRes)));
        }

    }
}
