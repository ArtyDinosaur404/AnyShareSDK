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
    /// DirCreatemultileveldirRes
    /// </summary>
    [DataContract]
    public partial class DirCreatemultileveldirRes :  IEquatable<DirCreatemultileveldirRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirCreatemultileveldirRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DirCreatemultileveldirRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DirCreatemultileveldirRes" /> class.
        /// </summary>
        /// <param name="docid">创建的多级目录最后一级的gns路径 (required).</param>
        /// <param name="rev">数据变化标识 (required).</param>
        /// <param name="modified">创建时间，UTC时间，此为服务器时间 (required).</param>
        public DirCreatemultileveldirRes(string docid = default(string), string rev = default(string), long? modified = default(long?))
        {
            this.Docid = docid;
            this.Rev = rev;
            this.Modified = modified;
        }
        
        /// <summary>
        /// 创建的多级目录最后一级的gns路径
        /// </summary>
        /// <value>创建的多级目录最后一级的gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 数据变化标识
        /// </summary>
        /// <value>数据变化标识</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public string Rev { get; set; }

        /// <summary>
        /// 创建时间，UTC时间，此为服务器时间
        /// </summary>
        /// <value>创建时间，UTC时间，此为服务器时间</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public long? Modified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirCreatemultileveldirRes {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
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
            return this.Equals(input as DirCreatemultileveldirRes);
        }

        /// <summary>
        /// Returns true if DirCreatemultileveldirRes instances are equal
        /// </summary>
        /// <param name="input">Instance of DirCreatemultileveldirRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirCreatemultileveldirRes input)
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
                    this.Rev == input.Rev ||
                    (this.Rev != null &&
                    this.Rev.Equals(input.Rev))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
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
                if (this.Rev != null)
                    hashCode = hashCode * 59 + this.Rev.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
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
