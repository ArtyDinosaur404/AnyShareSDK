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
    /// LinkCopyprogressRes
    /// </summary>
    [DataContract]
    public partial class LinkCopyprogressRes :  IEquatable<LinkCopyprogressRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkCopyprogressRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkCopyprogressRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkCopyprogressRes" /> class.
        /// </summary>
        /// <param name="success">是否查询成功，如果没有找到，可能是复制任务不存在或者已经完成 (required).</param>
        /// <param name="filecount">如果查询成功，返回总文件个数.</param>
        /// <param name="dircount">如果查询成功，返回总目录个数.</param>
        /// <param name="filecopied">如果查询成功，返回已复制的文件个数.</param>
        /// <param name="dircopied">如果查询成功，返回已复制的目录个数.</param>
        /// <param name="size">如果查询成功，返回总大小.</param>
        /// <param name="sizecopied">如果查询成功，返回已复制的大小.</param>
        /// <param name="filecopying">如果查询成功，返回正在复制的文件名.</param>
        /// <param name="source">如果查询成功，返回复制源位置的父目录名称，如果为根目录，返回空.</param>
        /// <param name="destination">如果查询成功，返回复制目标父目录的名称.</param>
        public LinkCopyprogressRes(bool? success = default(bool?), long? filecount = default(long?), long? dircount = default(long?), long? filecopied = default(long?), long? dircopied = default(long?), long? size = default(long?), long? sizecopied = default(long?), string filecopying = default(string), string source = default(string), string destination = default(string))
        {
            this.Success = success;
            this.Filecount = filecount;
            this.Dircount = dircount;
            this.Filecopied = filecopied;
            this.Dircopied = dircopied;
            this.Size = size;
            this.Sizecopied = sizecopied;
            this.Filecopying = filecopying;
            this.Source = source;
            this.Destination = destination;
        }
        
        /// <summary>
        /// 是否查询成功，如果没有找到，可能是复制任务不存在或者已经完成
        /// </summary>
        /// <value>是否查询成功，如果没有找到，可能是复制任务不存在或者已经完成</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 如果查询成功，返回总文件个数
        /// </summary>
        /// <value>如果查询成功，返回总文件个数</value>
        [DataMember(Name="filecount", EmitDefaultValue=false)]
        public long? Filecount { get; set; }

        /// <summary>
        /// 如果查询成功，返回总目录个数
        /// </summary>
        /// <value>如果查询成功，返回总目录个数</value>
        [DataMember(Name="dircount", EmitDefaultValue=false)]
        public long? Dircount { get; set; }

        /// <summary>
        /// 如果查询成功，返回已复制的文件个数
        /// </summary>
        /// <value>如果查询成功，返回已复制的文件个数</value>
        [DataMember(Name="filecopied", EmitDefaultValue=false)]
        public long? Filecopied { get; set; }

        /// <summary>
        /// 如果查询成功，返回已复制的目录个数
        /// </summary>
        /// <value>如果查询成功，返回已复制的目录个数</value>
        [DataMember(Name="dircopied", EmitDefaultValue=false)]
        public long? Dircopied { get; set; }

        /// <summary>
        /// 如果查询成功，返回总大小
        /// </summary>
        /// <value>如果查询成功，返回总大小</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// 如果查询成功，返回已复制的大小
        /// </summary>
        /// <value>如果查询成功，返回已复制的大小</value>
        [DataMember(Name="sizecopied", EmitDefaultValue=false)]
        public long? Sizecopied { get; set; }

        /// <summary>
        /// 如果查询成功，返回正在复制的文件名
        /// </summary>
        /// <value>如果查询成功，返回正在复制的文件名</value>
        [DataMember(Name="filecopying", EmitDefaultValue=false)]
        public string Filecopying { get; set; }

        /// <summary>
        /// 如果查询成功，返回复制源位置的父目录名称，如果为根目录，返回空
        /// </summary>
        /// <value>如果查询成功，返回复制源位置的父目录名称，如果为根目录，返回空</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// 如果查询成功，返回复制目标父目录的名称
        /// </summary>
        /// <value>如果查询成功，返回复制目标父目录的名称</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkCopyprogressRes {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Filecount: ").Append(Filecount).Append("\n");
            sb.Append("  Dircount: ").Append(Dircount).Append("\n");
            sb.Append("  Filecopied: ").Append(Filecopied).Append("\n");
            sb.Append("  Dircopied: ").Append(Dircopied).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Sizecopied: ").Append(Sizecopied).Append("\n");
            sb.Append("  Filecopying: ").Append(Filecopying).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
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
            return this.Equals(input as LinkCopyprogressRes);
        }

        /// <summary>
        /// Returns true if LinkCopyprogressRes instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkCopyprogressRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkCopyprogressRes input)
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
                    this.Filecount == input.Filecount ||
                    (this.Filecount != null &&
                    this.Filecount.Equals(input.Filecount))
                ) && 
                (
                    this.Dircount == input.Dircount ||
                    (this.Dircount != null &&
                    this.Dircount.Equals(input.Dircount))
                ) && 
                (
                    this.Filecopied == input.Filecopied ||
                    (this.Filecopied != null &&
                    this.Filecopied.Equals(input.Filecopied))
                ) && 
                (
                    this.Dircopied == input.Dircopied ||
                    (this.Dircopied != null &&
                    this.Dircopied.Equals(input.Dircopied))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Sizecopied == input.Sizecopied ||
                    (this.Sizecopied != null &&
                    this.Sizecopied.Equals(input.Sizecopied))
                ) && 
                (
                    this.Filecopying == input.Filecopying ||
                    (this.Filecopying != null &&
                    this.Filecopying.Equals(input.Filecopying))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
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
                if (this.Filecount != null)
                    hashCode = hashCode * 59 + this.Filecount.GetHashCode();
                if (this.Dircount != null)
                    hashCode = hashCode * 59 + this.Dircount.GetHashCode();
                if (this.Filecopied != null)
                    hashCode = hashCode * 59 + this.Filecopied.GetHashCode();
                if (this.Dircopied != null)
                    hashCode = hashCode * 59 + this.Dircopied.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Sizecopied != null)
                    hashCode = hashCode * 59 + this.Sizecopied.GetHashCode();
                if (this.Filecopying != null)
                    hashCode = hashCode * 59 + this.Filecopying.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
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
