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
    /// FileSetappmetadataReq
    /// </summary>
    [DataContract]
    public partial class FileSetappmetadataReq :  IEquatable<FileSetappmetadataReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSetappmetadataReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileSetappmetadataReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSetappmetadataReq" /> class.
        /// </summary>
        /// <param name="appid">应用 id，由控制台配置后分配 (required).</param>
        /// <param name="appmetadata">- json 格式的应用元数据集合，key-value string 的形式 - appmetadata 中只允许 key-value string，对于 value 为 integer、boolen、array 等情况，要求把值转为 string。非 key-value string 的值会被忽略 (required).</param>
        /// <param name="docid">文件gns路径（列举协议返回） (required).</param>
        public FileSetappmetadataReq(string appid = default(string), Dictionary<string, string> appmetadata = default(Dictionary<string, string>), string docid = default(string))
        {
            this.Appid = appid;
            this.Appmetadata = appmetadata;
            this.Docid = docid;
        }
        
        /// <summary>
        /// 应用 id，由控制台配置后分配
        /// </summary>
        /// <value>应用 id，由控制台配置后分配</value>
        [DataMember(Name="appid", EmitDefaultValue=false)]
        public string Appid { get; set; }

        /// <summary>
        /// - json 格式的应用元数据集合，key-value string 的形式 - appmetadata 中只允许 key-value string，对于 value 为 integer、boolen、array 等情况，要求把值转为 string。非 key-value string 的值会被忽略
        /// </summary>
        /// <value>- json 格式的应用元数据集合，key-value string 的形式 - appmetadata 中只允许 key-value string，对于 value 为 integer、boolen、array 等情况，要求把值转为 string。非 key-value string 的值会被忽略</value>
        [DataMember(Name="appmetadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Appmetadata { get; set; }

        /// <summary>
        /// 文件gns路径（列举协议返回）
        /// </summary>
        /// <value>文件gns路径（列举协议返回）</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileSetappmetadataReq {\n");
            sb.Append("  Appid: ").Append(Appid).Append("\n");
            sb.Append("  Appmetadata: ").Append(Appmetadata).Append("\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
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
            return this.Equals(input as FileSetappmetadataReq);
        }

        /// <summary>
        /// Returns true if FileSetappmetadataReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FileSetappmetadataReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileSetappmetadataReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Appid == input.Appid ||
                    (this.Appid != null &&
                    this.Appid.Equals(input.Appid))
                ) && 
                (
                    this.Appmetadata == input.Appmetadata ||
                    this.Appmetadata != null &&
                    input.Appmetadata != null &&
                    this.Appmetadata.SequenceEqual(input.Appmetadata)
                ) && 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
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
                if (this.Appid != null)
                    hashCode = hashCode * 59 + this.Appid.GetHashCode();
                if (this.Appmetadata != null)
                    hashCode = hashCode * 59 + this.Appmetadata.GetHashCode();
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
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
