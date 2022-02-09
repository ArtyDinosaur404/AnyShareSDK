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
    /// FileAttributeRes
    /// </summary>
    [DataContract]
    public partial class FileAttributeRes :  IEquatable<FileAttributeRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttributeRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileAttributeRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttributeRes" /> class.
        /// </summary>
        /// <param name="createTime">返回服务器端modified的值 (required).</param>
        /// <param name="creator">文件创建者 (required).</param>
        /// <param name="csflevel">文件密级，5~15 (required).</param>
        /// <param name="name">文件名，UTF8编码 (required).</param>
        /// <param name="tags">文件的标签，字符串数组 (required).</param>
        /// <param name="uniqueid">对于归档库文件，返回文件唯一标识.</param>
        public FileAttributeRes(long? createTime = default(long?), string creator = default(string), long? csflevel = default(long?), string name = default(string), List<string> tags = default(List<string>), string uniqueid = default(string))
        {
            this.CreateTime = createTime;
            this.Creator = creator;
            this.Csflevel = csflevel;
            this.Name = name;
            this.Tags = tags;
            this.Uniqueid = uniqueid;
        }
        
        /// <summary>
        /// 返回服务器端modified的值
        /// </summary>
        /// <value>返回服务器端modified的值</value>
        [DataMember(Name="create_time", EmitDefaultValue=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 文件创建者
        /// </summary>
        /// <value>文件创建者</value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; set; }

        /// <summary>
        /// 文件密级，5~15
        /// </summary>
        /// <value>文件密级，5~15</value>
        [DataMember(Name="csflevel", EmitDefaultValue=false)]
        public long? Csflevel { get; set; }

        /// <summary>
        /// 文件名，UTF8编码
        /// </summary>
        /// <value>文件名，UTF8编码</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 文件的标签，字符串数组
        /// </summary>
        /// <value>文件的标签，字符串数组</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 对于归档库文件，返回文件唯一标识
        /// </summary>
        /// <value>对于归档库文件，返回文件唯一标识</value>
        [DataMember(Name="uniqueid", EmitDefaultValue=false)]
        public string Uniqueid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileAttributeRes {\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Csflevel: ").Append(Csflevel).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Uniqueid: ").Append(Uniqueid).Append("\n");
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
            return this.Equals(input as FileAttributeRes);
        }

        /// <summary>
        /// Returns true if FileAttributeRes instances are equal
        /// </summary>
        /// <param name="input">Instance of FileAttributeRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileAttributeRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Csflevel == input.Csflevel ||
                    (this.Csflevel != null &&
                    this.Csflevel.Equals(input.Csflevel))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Uniqueid == input.Uniqueid ||
                    (this.Uniqueid != null &&
                    this.Uniqueid.Equals(input.Uniqueid))
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
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Csflevel != null)
                    hashCode = hashCode * 59 + this.Csflevel.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Uniqueid != null)
                    hashCode = hashCode * 59 + this.Uniqueid.GetHashCode();
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
