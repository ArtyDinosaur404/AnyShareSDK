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
    /// ConfigGetRes
    /// </summary>
    [DataContract]
    public partial class ConfigGetRes :  IEquatable<ConfigGetRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigGetRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetRes" /> class.
        /// </summary>
        /// <param name="cache">缓存相关配置信息 (required).</param>
        /// <param name="detectInterval">客户端探测时间 (required).</param>
        /// <param name="localsync">localsync (required).</param>
        /// <param name="needquickstart">快速入门文档阅读状态 (required).</param>
        public ConfigGetRes(List<ConfigGetResCache> cache = default(List<ConfigGetResCache>), long? detectInterval = default(long?), ConfigGetResLocalsync localsync = default(ConfigGetResLocalsync), bool? needquickstart = default(bool?))
        {
            this.Cache = cache;
            this.DetectInterval = detectInterval;
            this.Localsync = localsync;
            this.Needquickstart = needquickstart;
        }
        
        /// <summary>
        /// 缓存相关配置信息
        /// </summary>
        /// <value>缓存相关配置信息</value>
        [DataMember(Name="cache", EmitDefaultValue=false)]
        public List<ConfigGetResCache> Cache { get; set; }

        /// <summary>
        /// 客户端探测时间
        /// </summary>
        /// <value>客户端探测时间</value>
        [DataMember(Name="detect_interval", EmitDefaultValue=false)]
        public long? DetectInterval { get; set; }

        /// <summary>
        /// Gets or Sets Localsync
        /// </summary>
        [DataMember(Name="localsync", EmitDefaultValue=false)]
        public ConfigGetResLocalsync Localsync { get; set; }

        /// <summary>
        /// 快速入门文档阅读状态
        /// </summary>
        /// <value>快速入门文档阅读状态</value>
        [DataMember(Name="needquickstart", EmitDefaultValue=false)]
        public bool? Needquickstart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigGetRes {\n");
            sb.Append("  Cache: ").Append(Cache).Append("\n");
            sb.Append("  DetectInterval: ").Append(DetectInterval).Append("\n");
            sb.Append("  Localsync: ").Append(Localsync).Append("\n");
            sb.Append("  Needquickstart: ").Append(Needquickstart).Append("\n");
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
            return this.Equals(input as ConfigGetRes);
        }

        /// <summary>
        /// Returns true if ConfigGetRes instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigGetRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigGetRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cache == input.Cache ||
                    this.Cache != null &&
                    input.Cache != null &&
                    this.Cache.SequenceEqual(input.Cache)
                ) && 
                (
                    this.DetectInterval == input.DetectInterval ||
                    (this.DetectInterval != null &&
                    this.DetectInterval.Equals(input.DetectInterval))
                ) && 
                (
                    this.Localsync == input.Localsync ||
                    (this.Localsync != null &&
                    this.Localsync.Equals(input.Localsync))
                ) && 
                (
                    this.Needquickstart == input.Needquickstart ||
                    (this.Needquickstart != null &&
                    this.Needquickstart.Equals(input.Needquickstart))
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
                if (this.Cache != null)
                    hashCode = hashCode * 59 + this.Cache.GetHashCode();
                if (this.DetectInterval != null)
                    hashCode = hashCode * 59 + this.DetectInterval.GetHashCode();
                if (this.Localsync != null)
                    hashCode = hashCode * 59 + this.Localsync.GetHashCode();
                if (this.Needquickstart != null)
                    hashCode = hashCode * 59 + this.Needquickstart.GetHashCode();
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
