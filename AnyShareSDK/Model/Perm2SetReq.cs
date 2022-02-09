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
    /// Perm2SetReq
    /// </summary>
    [DataContract]
    public partial class Perm2SetReq :  IEquatable<Perm2SetReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm2SetReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Perm2SetReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm2SetReq" /> class.
        /// </summary>
        /// <param name="docid">文档id (required).</param>
        /// <param name="perminfos">权限配置条目数组 (required).</param>
        /// <param name="inherit">启用继承：true，上级所有权限均继承  禁用继承：false，上级所有权限均不继承   (required).</param>
        public Perm2SetReq(string docid = default(string), List<Perm2SetReqPerminfo> perminfos = default(List<Perm2SetReqPerminfo>), bool? inherit = default(bool?))
        {
            this.Docid = docid;
            this.Perminfos = perminfos;
            this.Inherit = inherit;
        }
        
        /// <summary>
        /// 文档id
        /// </summary>
        /// <value>文档id</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 权限配置条目数组
        /// </summary>
        /// <value>权限配置条目数组</value>
        [DataMember(Name="perminfos", EmitDefaultValue=false)]
        public List<Perm2SetReqPerminfo> Perminfos { get; set; }

        /// <summary>
        /// 启用继承：true，上级所有权限均继承  禁用继承：false，上级所有权限均不继承  
        /// </summary>
        /// <value>启用继承：true，上级所有权限均继承  禁用继承：false，上级所有权限均不继承  </value>
        [DataMember(Name="inherit", EmitDefaultValue=false)]
        public bool? Inherit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Perm2SetReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Perminfos: ").Append(Perminfos).Append("\n");
            sb.Append("  Inherit: ").Append(Inherit).Append("\n");
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
            return this.Equals(input as Perm2SetReq);
        }

        /// <summary>
        /// Returns true if Perm2SetReq instances are equal
        /// </summary>
        /// <param name="input">Instance of Perm2SetReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Perm2SetReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
                ) && 
                (
                    this.Perminfos == input.Perminfos ||
                    this.Perminfos != null &&
                    input.Perminfos != null &&
                    this.Perminfos.SequenceEqual(input.Perminfos)
                ) && 
                (
                    this.Inherit == input.Inherit ||
                    (this.Inherit != null &&
                    this.Inherit.Equals(input.Inherit))
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
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Perminfos != null)
                    hashCode = hashCode * 59 + this.Perminfos.GetHashCode();
                if (this.Inherit != null)
                    hashCode = hashCode * 59 + this.Inherit.GetHashCode();
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
