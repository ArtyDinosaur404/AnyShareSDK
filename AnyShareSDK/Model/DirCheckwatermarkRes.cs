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
    /// DirCheckwatermarkRes
    /// </summary>
    [DataContract]
    public partial class DirCheckwatermarkRes :  IEquatable<DirCheckwatermarkRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirCheckwatermarkRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DirCheckwatermarkRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DirCheckwatermarkRes" /> class.
        /// </summary>
        /// <param name="watermarktype">水印类型(0:无水印，1：预览水印，2:下载水印，3：预览下载水印) (required).</param>
        /// <param name="watermarkconfig">水印配置信息 (required).</param>
        public DirCheckwatermarkRes(long? watermarktype = default(long?), string watermarkconfig = default(string))
        {
            this.Watermarktype = watermarktype;
            this.Watermarkconfig = watermarkconfig;
        }
        
        /// <summary>
        /// 水印类型(0:无水印，1：预览水印，2:下载水印，3：预览下载水印)
        /// </summary>
        /// <value>水印类型(0:无水印，1：预览水印，2:下载水印，3：预览下载水印)</value>
        [DataMember(Name="watermarktype ", EmitDefaultValue=false)]
        public long? Watermarktype { get; set; }

        /// <summary>
        /// 水印配置信息
        /// </summary>
        /// <value>水印配置信息</value>
        [DataMember(Name="watermarkconfig", EmitDefaultValue=false)]
        public string Watermarkconfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirCheckwatermarkRes {\n");
            sb.Append("  Watermarktype: ").Append(Watermarktype).Append("\n");
            sb.Append("  Watermarkconfig: ").Append(Watermarkconfig).Append("\n");
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
            return this.Equals(input as DirCheckwatermarkRes);
        }

        /// <summary>
        /// Returns true if DirCheckwatermarkRes instances are equal
        /// </summary>
        /// <param name="input">Instance of DirCheckwatermarkRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirCheckwatermarkRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Watermarktype == input.Watermarktype ||
                    (this.Watermarktype != null &&
                    this.Watermarktype.Equals(input.Watermarktype))
                ) && 
                (
                    this.Watermarkconfig == input.Watermarkconfig ||
                    (this.Watermarkconfig != null &&
                    this.Watermarkconfig.Equals(input.Watermarkconfig))
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
                if (this.Watermarktype != null)
                    hashCode = hashCode * 59 + this.Watermarktype.GetHashCode();
                if (this.Watermarkconfig != null)
                    hashCode = hashCode * 59 + this.Watermarkconfig.GetHashCode();
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
