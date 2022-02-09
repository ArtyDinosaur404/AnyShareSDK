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
    /// Perm1GetsharedResDocinfo
    /// </summary>
    [DataContract]
    public partial class Perm1GetsharedResDocinfo :  IEquatable<Perm1GetsharedResDocinfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm1GetsharedResDocinfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Perm1GetsharedResDocinfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm1GetsharedResDocinfo" /> class.
        /// </summary>
        /// <param name="docid">文档id (required).</param>
        /// <param name="path">文档路径 (required).</param>
        /// <param name="size">文件大小，文件夹则为-1 (required).</param>
        /// <param name="clientMtime">如果是文件，返回由客户端设置的文件本地修改时间；若未设置，返回modified的值 (required).</param>
        /// <param name="accessorNames">访问者名称，存在多个访问者时用\&quot;,\&quot;进行分隔 (required).</param>
        public Perm1GetsharedResDocinfo(string docid = default(string), string path = default(string), long? size = default(long?), long? clientMtime = default(long?), string accessorNames = default(string))
        {
            this.Docid = docid;
            this.Path = path;
            this.Size = size;
            this.ClientMtime = clientMtime;
            this.AccessorNames = accessorNames;
        }
        
        /// <summary>
        /// 文档id
        /// </summary>
        /// <value>文档id</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 文档路径
        /// </summary>
        /// <value>文档路径</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// 文件大小，文件夹则为-1
        /// </summary>
        /// <value>文件大小，文件夹则为-1</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// 如果是文件，返回由客户端设置的文件本地修改时间；若未设置，返回modified的值
        /// </summary>
        /// <value>如果是文件，返回由客户端设置的文件本地修改时间；若未设置，返回modified的值</value>
        [DataMember(Name="client_mtime", EmitDefaultValue=false)]
        public long? ClientMtime { get; set; }

        /// <summary>
        /// 访问者名称，存在多个访问者时用\&quot;,\&quot;进行分隔
        /// </summary>
        /// <value>访问者名称，存在多个访问者时用\&quot;,\&quot;进行分隔</value>
        [DataMember(Name="accessor_names", EmitDefaultValue=false)]
        public string AccessorNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Perm1GetsharedResDocinfo {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ClientMtime: ").Append(ClientMtime).Append("\n");
            sb.Append("  AccessorNames: ").Append(AccessorNames).Append("\n");
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
            return this.Equals(input as Perm1GetsharedResDocinfo);
        }

        /// <summary>
        /// Returns true if Perm1GetsharedResDocinfo instances are equal
        /// </summary>
        /// <param name="input">Instance of Perm1GetsharedResDocinfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Perm1GetsharedResDocinfo input)
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
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                ) && 
                (
                    this.AccessorNames == input.AccessorNames ||
                    (this.AccessorNames != null &&
                    this.AccessorNames.Equals(input.AccessorNames))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ClientMtime != null)
                    hashCode = hashCode * 59 + this.ClientMtime.GetHashCode();
                if (this.AccessorNames != null)
                    hashCode = hashCode * 59 + this.AccessorNames.GetHashCode();
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
