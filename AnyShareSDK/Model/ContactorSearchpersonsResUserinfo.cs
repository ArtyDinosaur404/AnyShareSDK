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
    /// 联系人信息
    /// </summary>
    [DataContract]
    public partial class ContactorSearchpersonsResUserinfo :  IEquatable<ContactorSearchpersonsResUserinfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactorSearchpersonsResUserinfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactorSearchpersonsResUserinfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactorSearchpersonsResUserinfo" /> class.
        /// </summary>
        /// <param name="account">用户名 (required).</param>
        /// <param name="groupid">联系人组id (required).</param>
        /// <param name="groupname">联系人组名 (required).</param>
        /// <param name="name">显示名 (required).</param>
        /// <param name="userid">用户id (required).</param>
        public ContactorSearchpersonsResUserinfo(string account = default(string), string groupid = default(string), string groupname = default(string), string name = default(string), string userid = default(string))
        {
            this.Account = account;
            this.Groupid = groupid;
            this.Groupname = groupname;
            this.Name = name;
            this.Userid = userid;
        }
        
        /// <summary>
        /// 用户名
        /// </summary>
        /// <value>用户名</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// 联系人组id
        /// </summary>
        /// <value>联系人组id</value>
        [DataMember(Name="groupid", EmitDefaultValue=false)]
        public string Groupid { get; set; }

        /// <summary>
        /// 联系人组名
        /// </summary>
        /// <value>联系人组名</value>
        [DataMember(Name="groupname", EmitDefaultValue=false)]
        public string Groupname { get; set; }

        /// <summary>
        /// 显示名
        /// </summary>
        /// <value>显示名</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        /// <value>用户id</value>
        [DataMember(Name="userid", EmitDefaultValue=false)]
        public string Userid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactorSearchpersonsResUserinfo {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Groupid: ").Append(Groupid).Append("\n");
            sb.Append("  Groupname: ").Append(Groupname).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Userid: ").Append(Userid).Append("\n");
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
            return this.Equals(input as ContactorSearchpersonsResUserinfo);
        }

        /// <summary>
        /// Returns true if ContactorSearchpersonsResUserinfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactorSearchpersonsResUserinfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactorSearchpersonsResUserinfo input)
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
                    this.Groupid == input.Groupid ||
                    (this.Groupid != null &&
                    this.Groupid.Equals(input.Groupid))
                ) && 
                (
                    this.Groupname == input.Groupname ||
                    (this.Groupname != null &&
                    this.Groupname.Equals(input.Groupname))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Userid == input.Userid ||
                    (this.Userid != null &&
                    this.Userid.Equals(input.Userid))
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
                if (this.Groupid != null)
                    hashCode = hashCode * 59 + this.Groupid.GetHashCode();
                if (this.Groupname != null)
                    hashCode = hashCode * 59 + this.Groupname.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Userid != null)
                    hashCode = hashCode * 59 + this.Userid.GetHashCode();
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