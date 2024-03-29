/* 
 * 6.0-OpenDoc_API-文档访问
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
    /// LinkGetinfoRes
    /// </summary>
    [DataContract]
    public partial class LinkGetinfoRes :  IEquatable<LinkGetinfoRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkGetinfoRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkGetinfoRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkGetinfoRes" /> class.
        /// </summary>
        /// <param name="name">文件或文件夹名 (required).</param>
        /// <param name="modified">修改时间 (required).</param>
        /// <param name="size">文件大小，文件夹为-1 (required).</param>
        /// <param name="site">站点名 (required).</param>
        public LinkGetinfoRes(string name = default(string), long? modified = default(long?), long? size = default(long?), string site = default(string))
        {
            this.Name = name;
            this.Modified = modified;
            this.Size = size;
            this.Site = site;
        }
        
        /// <summary>
        /// 文件或文件夹名
        /// </summary>
        /// <value>文件或文件夹名</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public long? Modified { get; set; }

        /// <summary>
        /// 文件大小，文件夹为-1
        /// </summary>
        /// <value>文件大小，文件夹为-1</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// 站点名
        /// </summary>
        /// <value>站点名</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public string Site { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkGetinfoRes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
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
            return this.Equals(input as LinkGetinfoRes);
        }

        /// <summary>
        /// Returns true if LinkGetinfoRes instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkGetinfoRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkGetinfoRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Site != null)
                    hashCode = hashCode * 59 + this.Site.GetHashCode();
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
