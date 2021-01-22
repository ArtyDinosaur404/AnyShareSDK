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
    /// RecycleListResDirs
    /// </summary>
    [DataContract]
    public partial class RecycleListResDirs :  IEquatable<RecycleListResDirs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecycleListResDirs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecycleListResDirs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecycleListResDirs" /> class.
        /// </summary>
        /// <param name="docid">回收站中文件/目录的gns路径 (required).</param>
        /// <param name="editor">回收站中文件/目录删除者的名称 (required).</param>
        /// <param name="modified">回收站中文件/目录的删除时间 (required).</param>
        /// <param name="name">回收站中文件/目录的名称，UTF8编码 (required).</param>
        /// <param name="path">回收站中文件/目录的原路径，UTF8编码 (required).</param>
        /// <param name="size">回收站中文件的大小，目录大小为-1 (required).</param>
        public RecycleListResDirs(string docid = default(string), string editor = default(string), long? modified = default(long?), string name = default(string), string path = default(string), long? size = default(long?))
        {
            this.Docid = docid;
            this.Editor = editor;
            this.Modified = modified;
            this.Name = name;
            this.Path = path;
            this.Size = size;
        }
        
        /// <summary>
        /// 回收站中文件/目录的gns路径
        /// </summary>
        /// <value>回收站中文件/目录的gns路径</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 回收站中文件/目录删除者的名称
        /// </summary>
        /// <value>回收站中文件/目录删除者的名称</value>
        [DataMember(Name="editor", EmitDefaultValue=false)]
        public string Editor { get; set; }

        /// <summary>
        /// 回收站中文件/目录的删除时间
        /// </summary>
        /// <value>回收站中文件/目录的删除时间</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public long? Modified { get; set; }

        /// <summary>
        /// 回收站中文件/目录的名称，UTF8编码
        /// </summary>
        /// <value>回收站中文件/目录的名称，UTF8编码</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 回收站中文件/目录的原路径，UTF8编码
        /// </summary>
        /// <value>回收站中文件/目录的原路径，UTF8编码</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// 回收站中文件的大小，目录大小为-1
        /// </summary>
        /// <value>回收站中文件的大小，目录大小为-1</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleListResDirs {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as RecycleListResDirs);
        }

        /// <summary>
        /// Returns true if RecycleListResDirs instances are equal
        /// </summary>
        /// <param name="input">Instance of RecycleListResDirs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecycleListResDirs input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Editor != null)
                    hashCode = hashCode * 59 + this.Editor.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
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