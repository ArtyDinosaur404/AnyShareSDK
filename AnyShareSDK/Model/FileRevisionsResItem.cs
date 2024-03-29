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
    /// FileRevisionsResItem
    /// </summary>
    [DataContract]
    public partial class FileRevisionsResItem :  IEquatable<FileRevisionsResItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileRevisionsResItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileRevisionsResItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileRevisionsResItem" /> class.
        /// </summary>
        /// <param name="rev">版本号 (required).</param>
        /// <param name="name">版本所对应文件的最新名称 (required).</param>
        /// <param name="editor">版本编辑者名称 (required).</param>
        /// <param name="modified">版本上传时间，UTC时间，此为上传版本时记录的服务器时间 (required).</param>
        /// <param name="size">版本的大小 (required).</param>
        /// <param name="clientMtime">由客户端设置的文件本地修改时间    若未设置，返回modified的值   (required).</param>
        public FileRevisionsResItem(string rev = default(string), string name = default(string), string editor = default(string), long? modified = default(long?), long? size = default(long?), long? clientMtime = default(long?))
        {
            this.Rev = rev;
            this.Name = name;
            this.Editor = editor;
            this.Modified = modified;
            this.Size = size;
            this.ClientMtime = clientMtime;
        }
        
        /// <summary>
        /// 版本号
        /// </summary>
        /// <value>版本号</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public string Rev { get; set; }

        /// <summary>
        /// 版本所对应文件的最新名称
        /// </summary>
        /// <value>版本所对应文件的最新名称</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 版本编辑者名称
        /// </summary>
        /// <value>版本编辑者名称</value>
        [DataMember(Name="editor", EmitDefaultValue=false)]
        public string Editor { get; set; }

        /// <summary>
        /// 版本上传时间，UTC时间，此为上传版本时记录的服务器时间
        /// </summary>
        /// <value>版本上传时间，UTC时间，此为上传版本时记录的服务器时间</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public long? Modified { get; set; }

        /// <summary>
        /// 版本的大小
        /// </summary>
        /// <value>版本的大小</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// 由客户端设置的文件本地修改时间    若未设置，返回modified的值  
        /// </summary>
        /// <value>由客户端设置的文件本地修改时间    若未设置，返回modified的值  </value>
        [DataMember(Name="client_mtime", EmitDefaultValue=false)]
        public long? ClientMtime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileRevisionsResItem {\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ClientMtime: ").Append(ClientMtime).Append("\n");
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
            return this.Equals(input as FileRevisionsResItem);
        }

        /// <summary>
        /// Returns true if FileRevisionsResItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FileRevisionsResItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileRevisionsResItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rev == input.Rev ||
                    (this.Rev != null &&
                    this.Rev.Equals(input.Rev))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ClientMtime == input.ClientMtime ||
                    (this.ClientMtime != null &&
                    this.ClientMtime.Equals(input.ClientMtime))
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
                if (this.Rev != null)
                    hashCode = hashCode * 59 + this.Rev.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Editor != null)
                    hashCode = hashCode * 59 + this.Editor.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ClientMtime != null)
                    hashCode = hashCode * 59 + this.ClientMtime.GetHashCode();
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
