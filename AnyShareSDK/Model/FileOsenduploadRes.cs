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
    /// FileOsenduploadRes
    /// </summary>
    [DataContract]
    public partial class FileOsenduploadRes :  IEquatable<FileOsenduploadRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsenduploadRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileOsenduploadRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsenduploadRes" /> class.
        /// </summary>
        /// <param name="editor">编辑者 (required).</param>
        /// <param name="modified">上传时间，UTC时间，此为上传版本完成时的服务器时间 (required).</param>
        public FileOsenduploadRes(string editor = default(string), long? modified = default(long?))
        {
            this.Editor = editor;
            this.Modified = modified;
        }
        
        /// <summary>
        /// 编辑者
        /// </summary>
        /// <value>编辑者</value>
        [DataMember(Name="editor", EmitDefaultValue=false)]
        public string Editor { get; set; }

        /// <summary>
        /// 上传时间，UTC时间，此为上传版本完成时的服务器时间
        /// </summary>
        /// <value>上传时间，UTC时间，此为上传版本完成时的服务器时间</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public long? Modified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileOsenduploadRes {\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
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
            return this.Equals(input as FileOsenduploadRes);
        }

        /// <summary>
        /// Returns true if FileOsenduploadRes instances are equal
        /// </summary>
        /// <param name="input">Instance of FileOsenduploadRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileOsenduploadRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Editor == input.Editor ||
                    (this.Editor != null &&
                    this.Editor.Equals(input.Editor))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
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
                if (this.Editor != null)
                    hashCode = hashCode * 59 + this.Editor.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
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
