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
    /// FileMoveReq
    /// </summary>
    [DataContract]
    public partial class FileMoveReq :  IEquatable<FileMoveReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileMoveReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileMoveReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileMoveReq" /> class.
        /// </summary>
        /// <param name="docid">要移动的文件gns路径 (required).</param>
        /// <param name="destparent">目标父对象的gns路径 (required).</param>
        /// <param name="ondup">- 1:检查是否重命名，重名则抛异常  - 2:默认值，如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  .</param>
        public FileMoveReq(string docid = default(string), string destparent = default(string), long? ondup = default(long?))
        {
            this.Docid = docid;
            this.Destparent = destparent;
            this.Ondup = ondup;
        }
        
        /// <summary>
        /// 要移动的文件gns路径
        /// </summary>
        /// <value>要移动的文件gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 目标父对象的gns路径
        /// </summary>
        /// <value>目标父对象的gns路径</value>
        [DataMember(Name="destparent", EmitDefaultValue=false)]
        public string Destparent { get; set; }

        /// <summary>
        /// - 1:检查是否重命名，重名则抛异常  - 2:默认值，如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  
        /// </summary>
        /// <value>- 1:检查是否重命名，重名则抛异常  - 2:默认值，如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  </value>
        [DataMember(Name="ondup", EmitDefaultValue=false)]
        public long? Ondup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileMoveReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Destparent: ").Append(Destparent).Append("\n");
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
            return this.Equals(input as FileMoveReq);
        }

        /// <summary>
        /// Returns true if FileMoveReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FileMoveReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileMoveReq input)
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
                    this.Destparent == input.Destparent ||
                    (this.Destparent != null &&
                    this.Destparent.Equals(input.Destparent))
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
                if (this.Destparent != null)
                    hashCode = hashCode * 59 + this.Destparent.GetHashCode();
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
