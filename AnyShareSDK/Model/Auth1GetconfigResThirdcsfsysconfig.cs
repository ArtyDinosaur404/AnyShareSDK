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
    /// 第三方标密系统配置，如果未开启，则不会有
    /// </summary>
    [DataContract]
    public partial class Auth1GetconfigResThirdcsfsysconfig :  IEquatable<Auth1GetconfigResThirdcsfsysconfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigResThirdcsfsysconfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth1GetconfigResThirdcsfsysconfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigResThirdcsfsysconfig" /> class.
        /// </summary>
        /// <param name="id">第三方标密系统唯一标识 (required).</param>
        /// <param name="onlyUploadClassified">是否仅上传已标密文件 (required).</param>
        /// <param name="onlyShareClassified">是否仅共享已标密文件 (required).</param>
        /// <param name="autoMatchDocClassfication">是否自动识别文件密级 (required).</param>
        public Auth1GetconfigResThirdcsfsysconfig(string id = default(string), bool? onlyUploadClassified = default(bool?), bool? onlyShareClassified = default(bool?), bool? autoMatchDocClassfication = default(bool?))
        {
            this.Id = id;
            this.OnlyUploadClassified = onlyUploadClassified;
            this.OnlyShareClassified = onlyShareClassified;
            this.AutoMatchDocClassfication = autoMatchDocClassfication;
        }
        
        /// <summary>
        /// 第三方标密系统唯一标识
        /// </summary>
        /// <value>第三方标密系统唯一标识</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// 是否仅上传已标密文件
        /// </summary>
        /// <value>是否仅上传已标密文件</value>
        [DataMember(Name="only_upload_classified", EmitDefaultValue=false)]
        public bool? OnlyUploadClassified { get; set; }

        /// <summary>
        /// 是否仅共享已标密文件
        /// </summary>
        /// <value>是否仅共享已标密文件</value>
        [DataMember(Name="only_share_classified", EmitDefaultValue=false)]
        public bool? OnlyShareClassified { get; set; }

        /// <summary>
        /// 是否自动识别文件密级
        /// </summary>
        /// <value>是否自动识别文件密级</value>
        [DataMember(Name="auto_match_doc_classfication", EmitDefaultValue=false)]
        public bool? AutoMatchDocClassfication { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1GetconfigResThirdcsfsysconfig {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OnlyUploadClassified: ").Append(OnlyUploadClassified).Append("\n");
            sb.Append("  OnlyShareClassified: ").Append(OnlyShareClassified).Append("\n");
            sb.Append("  AutoMatchDocClassfication: ").Append(AutoMatchDocClassfication).Append("\n");
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
            return this.Equals(input as Auth1GetconfigResThirdcsfsysconfig);
        }

        /// <summary>
        /// Returns true if Auth1GetconfigResThirdcsfsysconfig instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1GetconfigResThirdcsfsysconfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1GetconfigResThirdcsfsysconfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OnlyUploadClassified == input.OnlyUploadClassified ||
                    (this.OnlyUploadClassified != null &&
                    this.OnlyUploadClassified.Equals(input.OnlyUploadClassified))
                ) && 
                (
                    this.OnlyShareClassified == input.OnlyShareClassified ||
                    (this.OnlyShareClassified != null &&
                    this.OnlyShareClassified.Equals(input.OnlyShareClassified))
                ) && 
                (
                    this.AutoMatchDocClassfication == input.AutoMatchDocClassfication ||
                    (this.AutoMatchDocClassfication != null &&
                    this.AutoMatchDocClassfication.Equals(input.AutoMatchDocClassfication))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OnlyUploadClassified != null)
                    hashCode = hashCode * 59 + this.OnlyUploadClassified.GetHashCode();
                if (this.OnlyShareClassified != null)
                    hashCode = hashCode * 59 + this.OnlyShareClassified.GetHashCode();
                if (this.AutoMatchDocClassfication != null)
                    hashCode = hashCode * 59 + this.AutoMatchDocClassfication.GetHashCode();
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
