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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AnyShareSDK.Client.OpenAPIDateConverter;

namespace AnyShareSDK.Model
{
    /// <summary>
    /// Auth1GetbythirdpartyReq
    /// </summary>
    [DataContract]
    public partial class Auth1GetbythirdpartyReq :  IEquatable<Auth1GetbythirdpartyReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetbythirdpartyReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth1GetbythirdpartyReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetbythirdpartyReq" /> class.
        /// </summary>
        /// <param name="thirdpartyid">标识第三方认证类型 (required).</param>
        /// <param name="_params">保存第三方认证系统相关的参数 (required).</param>
        /// <param name="deviceinfo">deviceinfo (required).</param>
        public Auth1GetbythirdpartyReq(string thirdpartyid = default(string), Dictionary<string, Object> _params = default(Dictionary<string, Object>), Auth1GetbythirdpartyReqDeviceinfo deviceinfo = default(Auth1GetbythirdpartyReqDeviceinfo))
        {
            this.Thirdpartyid = thirdpartyid;
            this.Params = _params;
            this.Deviceinfo = deviceinfo;
        }
        
        /// <summary>
        /// 标识第三方认证类型
        /// </summary>
        /// <value>标识第三方认证类型</value>
        [DataMember(Name="thirdpartyid", EmitDefaultValue=false)]
        public string Thirdpartyid { get; set; }

        /// <summary>
        /// 保存第三方认证系统相关的参数
        /// </summary>
        /// <value>保存第三方认证系统相关的参数</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Dictionary<string, Object> Params { get; set; }

        /// <summary>
        /// Gets or Sets Deviceinfo
        /// </summary>
        [DataMember(Name="deviceinfo", EmitDefaultValue=false)]
        public Auth1GetbythirdpartyReqDeviceinfo Deviceinfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1GetbythirdpartyReq {\n");
            sb.Append("  Thirdpartyid: ").Append(Thirdpartyid).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Deviceinfo: ").Append(Deviceinfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Auth1GetbythirdpartyReq);
        }

        /// <summary>
        /// Returns true if Auth1GetbythirdpartyReq instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1GetbythirdpartyReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1GetbythirdpartyReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Thirdpartyid == input.Thirdpartyid ||
                    (this.Thirdpartyid != null &&
                    this.Thirdpartyid.Equals(input.Thirdpartyid))
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    input.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.Deviceinfo == input.Deviceinfo ||
                    (this.Deviceinfo != null &&
                    this.Deviceinfo.Equals(input.Deviceinfo))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Thirdpartyid != null)
                    hashCode = hashCode * 59 + this.Thirdpartyid.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.Deviceinfo != null)
                    hashCode = hashCode * 59 + this.Deviceinfo.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}