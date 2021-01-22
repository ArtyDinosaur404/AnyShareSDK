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
    /// ContactorGetpersonsResUserinfo
    /// </summary>
    [DataContract]
    public partial class ContactorGetpersonsResUserinfo :  IEquatable<ContactorGetpersonsResUserinfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactorGetpersonsResUserinfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactorGetpersonsResUserinfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactorGetpersonsResUserinfo" /> class.
        /// </summary>
        /// <param name="departname">联系人所属部门名称 (required).</param>
        /// <param name="email">用户邮箱地址 (required).</param>
        /// <param name="userid">用户唯一标识 (required).</param>
        /// <param name="username">用户显示名 (required).</param>
        public ContactorGetpersonsResUserinfo(List<string> departname = default(List<string>), string email = default(string), string userid = default(string), string username = default(string))
        {
            this.Departname = departname;
            this.Email = email;
            this.Userid = userid;
            this.Username = username;
        }
        
        /// <summary>
        /// 联系人所属部门名称
        /// </summary>
        /// <value>联系人所属部门名称</value>
        [DataMember(Name="departname", EmitDefaultValue=false)]
        public List<string> Departname { get; set; }

        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        /// <value>用户邮箱地址</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// 用户唯一标识
        /// </summary>
        /// <value>用户唯一标识</value>
        [DataMember(Name="userid", EmitDefaultValue=false)]
        public string Userid { get; set; }

        /// <summary>
        /// 用户显示名
        /// </summary>
        /// <value>用户显示名</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactorGetpersonsResUserinfo {\n");
            sb.Append("  Departname: ").Append(Departname).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Userid: ").Append(Userid).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as ContactorGetpersonsResUserinfo);
        }

        /// <summary>
        /// Returns true if ContactorGetpersonsResUserinfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactorGetpersonsResUserinfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactorGetpersonsResUserinfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Departname == input.Departname ||
                    this.Departname != null &&
                    input.Departname != null &&
                    this.Departname.SequenceEqual(input.Departname)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Userid == input.Userid ||
                    (this.Userid != null &&
                    this.Userid.Equals(input.Userid))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Departname != null)
                    hashCode = hashCode * 59 + this.Departname.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Userid != null)
                    hashCode = hashCode * 59 + this.Userid.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
