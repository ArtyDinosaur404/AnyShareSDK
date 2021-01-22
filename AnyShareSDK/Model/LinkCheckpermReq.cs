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
    /// LinkCheckpermReq
    /// </summary>
    [DataContract]
    public partial class LinkCheckpermReq :  IEquatable<LinkCheckpermReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkCheckpermReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkCheckpermReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkCheckpermReq" /> class.
        /// </summary>
        /// <param name="link">外链唯一标识，如FC5E038D38A57032085441E7FE7010B0 (required).</param>
        /// <param name="password">密码 (required).</param>
        /// <param name="perm">权限值，值域为1、2、4，具体说明参见开启外链中的描述 (required).</param>
        public LinkCheckpermReq(string link = default(string), string password = default(string), long? perm = default(long?))
        {
            this.Link = link;
            this.Password = password;
            this.Perm = perm;
        }
        
        /// <summary>
        /// 外链唯一标识，如FC5E038D38A57032085441E7FE7010B0
        /// </summary>
        /// <value>外链唯一标识，如FC5E038D38A57032085441E7FE7010B0</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        /// <value>密码</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// 权限值，值域为1、2、4，具体说明参见开启外链中的描述
        /// </summary>
        /// <value>权限值，值域为1、2、4，具体说明参见开启外链中的描述</value>
        [DataMember(Name="perm", EmitDefaultValue=false)]
        public long? Perm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkCheckpermReq {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Perm: ").Append(Perm).Append("\n");
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
            return this.Equals(input as LinkCheckpermReq);
        }

        /// <summary>
        /// Returns true if LinkCheckpermReq instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkCheckpermReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkCheckpermReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Perm == input.Perm ||
                    (this.Perm != null &&
                    this.Perm.Equals(input.Perm))
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Perm != null)
                    hashCode = hashCode * 59 + this.Perm.GetHashCode();
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
