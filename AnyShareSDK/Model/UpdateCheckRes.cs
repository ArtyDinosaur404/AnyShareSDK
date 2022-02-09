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
    /// UpdateCheckRes
    /// </summary>
    [DataContract]
    public partial class UpdateCheckRes :  IEquatable<UpdateCheckRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateCheckRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRes" /> class.
        /// </summary>
        /// <param name="result">客户端是否需要更新 “ok”表示客户端版本是最新的 “optional”表示客户端可选择更新 “forced”表示客户端必须进行更新 (required).</param>
        /// <param name="latest">可用客户端安装包的版本信息，如3.5.4.244形式 (required).</param>
        /// <param name="ostype">可用客户端安装包对应的ostype (required).</param>
        /// <param name="downloadurl">可用客户端安装包的相对下载路径，需要加上服务器的ip后才能进行下载 (required).</param>
        /// <param name="size">可用客户端安装包的大小 (required).</param>
        public UpdateCheckRes(string result = default(string), string latest = default(string), long? ostype = default(long?), string downloadurl = default(string), long? size = default(long?))
        {
            this.Result = result;
            this.Latest = latest;
            this.Ostype = ostype;
            this.Downloadurl = downloadurl;
            this.Size = size;
        }
        
        /// <summary>
        /// 客户端是否需要更新 “ok”表示客户端版本是最新的 “optional”表示客户端可选择更新 “forced”表示客户端必须进行更新
        /// </summary>
        /// <value>客户端是否需要更新 “ok”表示客户端版本是最新的 “optional”表示客户端可选择更新 “forced”表示客户端必须进行更新</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// 可用客户端安装包的版本信息，如3.5.4.244形式
        /// </summary>
        /// <value>可用客户端安装包的版本信息，如3.5.4.244形式</value>
        [DataMember(Name="latest", EmitDefaultValue=false)]
        public string Latest { get; set; }

        /// <summary>
        /// 可用客户端安装包对应的ostype
        /// </summary>
        /// <value>可用客户端安装包对应的ostype</value>
        [DataMember(Name="ostype", EmitDefaultValue=false)]
        public long? Ostype { get; set; }

        /// <summary>
        /// 可用客户端安装包的相对下载路径，需要加上服务器的ip后才能进行下载
        /// </summary>
        /// <value>可用客户端安装包的相对下载路径，需要加上服务器的ip后才能进行下载</value>
        [DataMember(Name="downloadurl", EmitDefaultValue=false)]
        public string Downloadurl { get; set; }

        /// <summary>
        /// 可用客户端安装包的大小
        /// </summary>
        /// <value>可用客户端安装包的大小</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCheckRes {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
            sb.Append("  Ostype: ").Append(Ostype).Append("\n");
            sb.Append("  Downloadurl: ").Append(Downloadurl).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as UpdateCheckRes);
        }

        /// <summary>
        /// Returns true if UpdateCheckRes instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCheckRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCheckRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Latest == input.Latest ||
                    (this.Latest != null &&
                    this.Latest.Equals(input.Latest))
                ) && 
                (
                    this.Ostype == input.Ostype ||
                    (this.Ostype != null &&
                    this.Ostype.Equals(input.Ostype))
                ) && 
                (
                    this.Downloadurl == input.Downloadurl ||
                    (this.Downloadurl != null &&
                    this.Downloadurl.Equals(input.Downloadurl))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Latest != null)
                    hashCode = hashCode * 59 + this.Latest.GetHashCode();
                if (this.Ostype != null)
                    hashCode = hashCode * 59 + this.Ostype.GetHashCode();
                if (this.Downloadurl != null)
                    hashCode = hashCode * 59 + this.Downloadurl.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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
