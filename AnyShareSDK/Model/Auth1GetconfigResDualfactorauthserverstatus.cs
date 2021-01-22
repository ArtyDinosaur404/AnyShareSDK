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
    /// 双因子认证配置信息
    /// </summary>
    [DataContract]
    public partial class Auth1GetconfigResDualfactorauthserverstatus :  IEquatable<Auth1GetconfigResDualfactorauthserverstatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigResDualfactorauthserverstatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth1GetconfigResDualfactorauthserverstatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigResDualfactorauthserverstatus" /> class.
        /// </summary>
        /// <param name="authByOTP">是否使用动态密保验证 (required).</param>
        /// <param name="authByUkey">是否使用Ukey验证 (required).</param>
        /// <param name="authByEmail">是否使用邮箱验证 (required).</param>
        /// <param name="authBySms">是否使用短信验证 (required).</param>
        public Auth1GetconfigResDualfactorauthserverstatus(bool? authByOTP = default(bool?), bool? authByUkey = default(bool?), bool? authByEmail = default(bool?), bool? authBySms = default(bool?))
        {
            this.AuthByOTP = authByOTP;
            this.AuthByUkey = authByUkey;
            this.AuthByEmail = authByEmail;
            this.AuthBySms = authBySms;
        }
        
        /// <summary>
        /// 是否使用动态密保验证
        /// </summary>
        /// <value>是否使用动态密保验证</value>
        [DataMember(Name="auth_by_OTP", EmitDefaultValue=false)]
        public bool? AuthByOTP { get; set; }

        /// <summary>
        /// 是否使用Ukey验证
        /// </summary>
        /// <value>是否使用Ukey验证</value>
        [DataMember(Name="auth_by_Ukey", EmitDefaultValue=false)]
        public bool? AuthByUkey { get; set; }

        /// <summary>
        /// 是否使用邮箱验证
        /// </summary>
        /// <value>是否使用邮箱验证</value>
        [DataMember(Name="auth_by_email", EmitDefaultValue=false)]
        public bool? AuthByEmail { get; set; }

        /// <summary>
        /// 是否使用短信验证
        /// </summary>
        /// <value>是否使用短信验证</value>
        [DataMember(Name="auth_by_sms", EmitDefaultValue=false)]
        public bool? AuthBySms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1GetconfigResDualfactorauthserverstatus {\n");
            sb.Append("  AuthByOTP: ").Append(AuthByOTP).Append("\n");
            sb.Append("  AuthByUkey: ").Append(AuthByUkey).Append("\n");
            sb.Append("  AuthByEmail: ").Append(AuthByEmail).Append("\n");
            sb.Append("  AuthBySms: ").Append(AuthBySms).Append("\n");
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
            return this.Equals(input as Auth1GetconfigResDualfactorauthserverstatus);
        }

        /// <summary>
        /// Returns true if Auth1GetconfigResDualfactorauthserverstatus instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1GetconfigResDualfactorauthserverstatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1GetconfigResDualfactorauthserverstatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthByOTP == input.AuthByOTP ||
                    (this.AuthByOTP != null &&
                    this.AuthByOTP.Equals(input.AuthByOTP))
                ) && 
                (
                    this.AuthByUkey == input.AuthByUkey ||
                    (this.AuthByUkey != null &&
                    this.AuthByUkey.Equals(input.AuthByUkey))
                ) && 
                (
                    this.AuthByEmail == input.AuthByEmail ||
                    (this.AuthByEmail != null &&
                    this.AuthByEmail.Equals(input.AuthByEmail))
                ) && 
                (
                    this.AuthBySms == input.AuthBySms ||
                    (this.AuthBySms != null &&
                    this.AuthBySms.Equals(input.AuthBySms))
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
                if (this.AuthByOTP != null)
                    hashCode = hashCode * 59 + this.AuthByOTP.GetHashCode();
                if (this.AuthByUkey != null)
                    hashCode = hashCode * 59 + this.AuthByUkey.GetHashCode();
                if (this.AuthByEmail != null)
                    hashCode = hashCode * 59 + this.AuthByEmail.GetHashCode();
                if (this.AuthBySms != null)
                    hashCode = hashCode * 59 + this.AuthBySms.GetHashCode();
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
