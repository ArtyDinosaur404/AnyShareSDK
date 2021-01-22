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
    /// LinkOpstatisticsResStatistic
    /// </summary>
    [DataContract]
    public partial class LinkOpstatisticsResStatistic :  IEquatable<LinkOpstatisticsResStatistic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkOpstatisticsResStatistic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkOpstatisticsResStatistic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkOpstatisticsResStatistic" /> class.
        /// </summary>
        /// <param name="ip">访问ip (required).</param>
        /// <param name="download">下载量 (required).</param>
        /// <param name="preview">预览量 (required).</param>
        public LinkOpstatisticsResStatistic(string ip = default(string), long? download = default(long?), long? preview = default(long?))
        {
            this.Ip = ip;
            this.Download = download;
            this.Preview = preview;
        }
        
        /// <summary>
        /// 访问ip
        /// </summary>
        /// <value>访问ip</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// 下载量
        /// </summary>
        /// <value>下载量</value>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public long? Download { get; set; }

        /// <summary>
        /// 预览量
        /// </summary>
        /// <value>预览量</value>
        [DataMember(Name="preview", EmitDefaultValue=false)]
        public long? Preview { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkOpstatisticsResStatistic {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
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
            return this.Equals(input as LinkOpstatisticsResStatistic);
        }

        /// <summary>
        /// Returns true if LinkOpstatisticsResStatistic instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkOpstatisticsResStatistic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkOpstatisticsResStatistic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Download == input.Download ||
                    (this.Download != null &&
                    this.Download.Equals(input.Download))
                ) && 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
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
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Download != null)
                    hashCode = hashCode * 59 + this.Download.GetHashCode();
                if (this.Preview != null)
                    hashCode = hashCode * 59 + this.Preview.GetHashCode();
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