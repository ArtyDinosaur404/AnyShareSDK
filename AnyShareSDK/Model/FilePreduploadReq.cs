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
    /// FilePreduploadReq
    /// </summary>
    [DataContract]
    public partial class FilePreduploadReq :  IEquatable<FilePreduploadReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilePreduploadReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilePreduploadReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilePreduploadReq" /> class.
        /// </summary>
        /// <param name="length">整个文件的长度 (required).</param>
        /// <param name="sliceMd5">- 校验段校验码 - 如果文件大于200KB，slice_md5为文件的前200KB的MD5值 - 如果文件小于等于200KB，slice_md5为整个文件的MD5值 - 如果是空文件，slilce为空。 (required).</param>
        public FilePreduploadReq(long? length = default(long?), string sliceMd5 = default(string))
        {
            this.Length = length;
            this.SliceMd5 = sliceMd5;
        }
        
        /// <summary>
        /// 整个文件的长度
        /// </summary>
        /// <value>整个文件的长度</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public long? Length { get; set; }

        /// <summary>
        /// - 校验段校验码 - 如果文件大于200KB，slice_md5为文件的前200KB的MD5值 - 如果文件小于等于200KB，slice_md5为整个文件的MD5值 - 如果是空文件，slilce为空。
        /// </summary>
        /// <value>- 校验段校验码 - 如果文件大于200KB，slice_md5为文件的前200KB的MD5值 - 如果文件小于等于200KB，slice_md5为整个文件的MD5值 - 如果是空文件，slilce为空。</value>
        [DataMember(Name="slice_md5", EmitDefaultValue=false)]
        public string SliceMd5 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilePreduploadReq {\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  SliceMd5: ").Append(SliceMd5).Append("\n");
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
            return this.Equals(input as FilePreduploadReq);
        }

        /// <summary>
        /// Returns true if FilePreduploadReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FilePreduploadReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilePreduploadReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.SliceMd5 == input.SliceMd5 ||
                    (this.SliceMd5 != null &&
                    this.SliceMd5.Equals(input.SliceMd5))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.SliceMd5 != null)
                    hashCode = hashCode * 59 + this.SliceMd5.GetHashCode();
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