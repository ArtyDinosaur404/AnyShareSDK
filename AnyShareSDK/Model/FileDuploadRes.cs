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
    /// FileDuploadRes
    /// </summary>
    [DataContract]
    public partial class FileDuploadRes :  IEquatable<FileDuploadRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDuploadRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileDuploadRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDuploadRes" /> class.
        /// </summary>
        /// <param name="success">秒传是否成功,如果为false，忽略其它字段 (required).</param>
        /// <param name="docid">文件的gns路径.</param>
        /// <param name="editor">编辑者名称，UTF8编码，秒传成功则返回.</param>
        /// <param name="modified">上传时间，UTC时间，此为上传版本时的服务器时间，秒传成功则返回.</param>
        /// <param name="name">文件名称，UTF8编码.</param>
        /// <param name="rev">文件版本号.</param>
        public FileDuploadRes(bool? success = default(bool?), string docid = default(string), string editor = default(string), long? modified = default(long?), string name = default(string), string rev = default(string))
        {
            this.Success = success;
            this.Docid = docid;
            this.Editor = editor;
            this.Modified = modified;
            this.Name = name;
            this.Rev = rev;
        }
        
        /// <summary>
        /// 秒传是否成功,如果为false，忽略其它字段
        /// </summary>
        /// <value>秒传是否成功,如果为false，忽略其它字段</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 文件的gns路径
        /// </summary>
        /// <value>文件的gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 编辑者名称，UTF8编码，秒传成功则返回
        /// </summary>
        /// <value>编辑者名称，UTF8编码，秒传成功则返回</value>
        [DataMember(Name="editor", EmitDefaultValue=false)]
        public string Editor { get; set; }

        /// <summary>
        /// 上传时间，UTC时间，此为上传版本时的服务器时间，秒传成功则返回
        /// </summary>
        /// <value>上传时间，UTC时间，此为上传版本时的服务器时间，秒传成功则返回</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public long? Modified { get; set; }

        /// <summary>
        /// 文件名称，UTF8编码
        /// </summary>
        /// <value>文件名称，UTF8编码</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 文件版本号
        /// </summary>
        /// <value>文件版本号</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public string Rev { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDuploadRes {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
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
            return this.Equals(input as FileDuploadRes);
        }

        /// <summary>
        /// Returns true if FileDuploadRes instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDuploadRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDuploadRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
                ) && 
                (
                    this.Editor == input.Editor ||
                    (this.Editor != null &&
                    this.Editor.Equals(input.Editor))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rev == input.Rev ||
                    (this.Rev != null &&
                    this.Rev.Equals(input.Rev))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Editor != null)
                    hashCode = hashCode * 59 + this.Editor.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rev != null)
                    hashCode = hashCode * 59 + this.Rev.GetHashCode();
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