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
    /// RecycleRestoreReq
    /// </summary>
    [DataContract]
    public partial class RecycleRestoreReq :  IEquatable<RecycleRestoreReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecycleRestoreReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecycleRestoreReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecycleRestoreReq" /> class.
        /// </summary>
        /// <param name="docid">要还原的文件/目录在回收站的gns路径（可以是回收站的子目录或者子文件） (required).</param>
        /// <param name="ondup">1:检查是否重命名，重名则抛异常  2:如果重名冲突，自动重名   (required).</param>
        public RecycleRestoreReq(string docid = default(string), long? ondup = default(long?))
        {
            this.Docid = docid;
            this.Ondup = ondup;
        }
        
        /// <summary>
        /// 要还原的文件/目录在回收站的gns路径（可以是回收站的子目录或者子文件）
        /// </summary>
        /// <value>要还原的文件/目录在回收站的gns路径（可以是回收站的子目录或者子文件）</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 1:检查是否重命名，重名则抛异常  2:如果重名冲突，自动重名  
        /// </summary>
        /// <value>1:检查是否重命名，重名则抛异常  2:如果重名冲突，自动重名  </value>
        [DataMember(Name="ondup", EmitDefaultValue=false)]
        public long? Ondup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleRestoreReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Ondup: ").Append(Ondup).Append("\n");
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
            return this.Equals(input as RecycleRestoreReq);
        }

        /// <summary>
        /// Returns true if RecycleRestoreReq instances are equal
        /// </summary>
        /// <param name="input">Instance of RecycleRestoreReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecycleRestoreReq input)
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
                    this.Ondup == input.Ondup ||
                    (this.Ondup != null &&
                    this.Ondup.Equals(input.Ondup))
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
                if (this.Ondup != null)
                    hashCode = hashCode * 59 + this.Ondup.GetHashCode();
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