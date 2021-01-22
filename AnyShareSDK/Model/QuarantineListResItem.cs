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
    /// QuarantineListResItem
    /// </summary>
    [DataContract]
    public partial class QuarantineListResItem :  IEquatable<QuarantineListResItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuarantineListResItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuarantineListResItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuarantineListResItem" /> class.
        /// </summary>
        /// <param name="docid">文件位于隔离区的docid (required).</param>
        /// <param name="name">文件被隔离时最新名字 (required).</param>
        /// <param name="parentpath">文件被隔离时所在路径 (required).</param>
        /// <param name="appealexpiredtime">文件申诉保护到期日（UNIX时间戳） (required).</param>
        /// <param name="status">文件状态：  - 1 未申诉  - 2 已申诉  - 3 已否决   (required).</param>
        public QuarantineListResItem(string docid = default(string), string name = default(string), string parentpath = default(string), long? appealexpiredtime = default(long?), long? status = default(long?))
        {
            this.Docid = docid;
            this.Name = name;
            this.Parentpath = parentpath;
            this.Appealexpiredtime = appealexpiredtime;
            this.Status = status;
        }
        
        /// <summary>
        /// 文件位于隔离区的docid
        /// </summary>
        /// <value>文件位于隔离区的docid</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 文件被隔离时最新名字
        /// </summary>
        /// <value>文件被隔离时最新名字</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 文件被隔离时所在路径
        /// </summary>
        /// <value>文件被隔离时所在路径</value>
        [DataMember(Name="parentpath", EmitDefaultValue=false)]
        public string Parentpath { get; set; }

        /// <summary>
        /// 文件申诉保护到期日（UNIX时间戳）
        /// </summary>
        /// <value>文件申诉保护到期日（UNIX时间戳）</value>
        [DataMember(Name="appealexpiredtime", EmitDefaultValue=false)]
        public long? Appealexpiredtime { get; set; }

        /// <summary>
        /// 文件状态：  - 1 未申诉  - 2 已申诉  - 3 已否决  
        /// </summary>
        /// <value>文件状态：  - 1 未申诉  - 2 已申诉  - 3 已否决  </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuarantineListResItem {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parentpath: ").Append(Parentpath).Append("\n");
            sb.Append("  Appealexpiredtime: ").Append(Appealexpiredtime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as QuarantineListResItem);
        }

        /// <summary>
        /// Returns true if QuarantineListResItem instances are equal
        /// </summary>
        /// <param name="input">Instance of QuarantineListResItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuarantineListResItem input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Parentpath == input.Parentpath ||
                    (this.Parentpath != null &&
                    this.Parentpath.Equals(input.Parentpath))
                ) && 
                (
                    this.Appealexpiredtime == input.Appealexpiredtime ||
                    (this.Appealexpiredtime != null &&
                    this.Appealexpiredtime.Equals(input.Appealexpiredtime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Parentpath != null)
                    hashCode = hashCode * 59 + this.Parentpath.GetHashCode();
                if (this.Appealexpiredtime != null)
                    hashCode = hashCode * 59 + this.Appealexpiredtime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
