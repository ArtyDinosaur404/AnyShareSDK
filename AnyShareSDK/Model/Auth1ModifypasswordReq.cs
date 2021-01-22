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
    /// Auth1ModifypasswordReq
    /// </summary>
    [DataContract]
    public partial class Auth1ModifypasswordReq :  IEquatable<Auth1ModifypasswordReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1ModifypasswordReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth1ModifypasswordReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1ModifypasswordReq" /> class.
        /// </summary>
        /// <param name="account">用户登录名 (required).</param>
        /// <param name="oldpwd">用户旧密码 (required).</param>
        /// <param name="newpwd">用户新密码 (required).</param>
        public Auth1ModifypasswordReq(string account = default(string), string oldpwd = default(string), string newpwd = default(string))
        {
            this.Account = account;
            this.Oldpwd = oldpwd;
            this.Newpwd = newpwd;
        }
        
        /// <summary>
        /// 用户登录名
        /// </summary>
        /// <value>用户登录名</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// 用户旧密码
        /// </summary>
        /// <value>用户旧密码</value>
        [DataMember(Name="oldpwd", EmitDefaultValue=false)]
        public string Oldpwd { get; set; }

        /// <summary>
        /// 用户新密码
        /// </summary>
        /// <value>用户新密码</value>
        [DataMember(Name="newpwd", EmitDefaultValue=false)]
        public string Newpwd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1ModifypasswordReq {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Oldpwd: ").Append(Oldpwd).Append("\n");
            sb.Append("  Newpwd: ").Append(Newpwd).Append("\n");
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
            return this.Equals(input as Auth1ModifypasswordReq);
        }

        /// <summary>
        /// Returns true if Auth1ModifypasswordReq instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1ModifypasswordReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1ModifypasswordReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Oldpwd == input.Oldpwd ||
                    (this.Oldpwd != null &&
                    this.Oldpwd.Equals(input.Oldpwd))
                ) && 
                (
                    this.Newpwd == input.Newpwd ||
                    (this.Newpwd != null &&
                    this.Newpwd.Equals(input.Newpwd))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Oldpwd != null)
                    hashCode = hashCode * 59 + this.Oldpwd.GetHashCode();
                if (this.Newpwd != null)
                    hashCode = hashCode * 59 + this.Newpwd.GetHashCode();
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