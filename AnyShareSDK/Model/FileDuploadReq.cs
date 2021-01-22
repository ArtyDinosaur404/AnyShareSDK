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
    /// FileDuploadReq
    /// </summary>
    [DataContract]
    public partial class FileDuploadReq :  IEquatable<FileDuploadReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDuploadReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileDuploadReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDuploadReq" /> class.
        /// </summary>
        /// <param name="clientMtime">由客户端设置的文件本地修改时间.</param>
        /// <param name="crc32">文件的CRC32校验码，如果为空文件, 此字段为空 (required).</param>
        /// <param name="docid">gns（全局名字空间）路径，创建或者列举协议返回    说明：如果name不为空，gns为待创建文件的父目录gns；否则为文件的gns。   (required).</param>
        /// <param name="length">整个文件的长度，如果为空文件, 此字段为空 (required).</param>
        /// <param name="md5">文件MD5值，如果为空文件, 此字段为空 (required).</param>
        /// <param name="name">文件名称，UTF8编码    说明：1、如果为空，在父目录文件下生成版本；2、如果不为空，在父目录下创建文件，同时生成版本  .</param>
        /// <param name="ondup">仅当name不为空时才会生效  - 1:检查是否重命名，重名则抛异常  - 2:如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  .</param>
        /// <param name="csflevel">文件密级  - 0：默认值，创建文件时文件密级设为创建者密级，覆盖版本时不改变密级  - 5~15：正常密级  - 0x7FFF：空密级  .</param>
        public FileDuploadReq(long? clientMtime = default(long?), string crc32 = default(string), string docid = default(string), long? length = default(long?), string md5 = default(string), string name = default(string), long? ondup = default(long?), long? csflevel = default(long?))
        {
            this.Crc32 = crc32;
            this.Docid = docid;
            this.Length = length;
            this.Md5 = md5;
            this.ClientMtime = clientMtime;
            this.Name = name;
            this.Ondup = ondup;
            this.Csflevel = csflevel;
        }
        
        /// <summary>
        /// 由客户端设置的文件本地修改时间
        /// </summary>
        /// <value>由客户端设置的文件本地修改时间</value>
        [DataMember(Name="client_mtime", EmitDefaultValue=false)]
        public long? ClientMtime { get; set; }

        /// <summary>
        /// 文件的CRC32校验码，如果为空文件, 此字段为空
        /// </summary>
        /// <value>文件的CRC32校验码，如果为空文件, 此字段为空</value>
        [DataMember(Name="crc32", EmitDefaultValue=false)]
        public string Crc32 { get; set; }

        /// <summary>
        /// gns（全局名字空间）路径，创建或者列举协议返回    说明：如果name不为空，gns为待创建文件的父目录gns；否则为文件的gns。  
        /// </summary>
        /// <value>gns（全局名字空间）路径，创建或者列举协议返回    说明：如果name不为空，gns为待创建文件的父目录gns；否则为文件的gns。  </value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 整个文件的长度，如果为空文件, 此字段为空
        /// </summary>
        /// <value>整个文件的长度，如果为空文件, 此字段为空</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public long? Length { get; set; }

        /// <summary>
        /// 文件MD5值，如果为空文件, 此字段为空
        /// </summary>
        /// <value>文件MD5值，如果为空文件, 此字段为空</value>
        [DataMember(Name="md5", EmitDefaultValue=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// 文件名称，UTF8编码    说明：1、如果为空，在父目录文件下生成版本；2、如果不为空，在父目录下创建文件，同时生成版本  
        /// </summary>
        /// <value>文件名称，UTF8编码    说明：1、如果为空，在父目录文件下生成版本；2、如果不为空，在父目录下创建文件，同时生成版本  </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 仅当name不为空时才会生效  - 1:检查是否重命名，重名则抛异常  - 2:如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  
        /// </summary>
        /// <value>仅当name不为空时才会生效  - 1:检查是否重命名，重名则抛异常  - 2:如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  </value>
        [DataMember(Name="ondup", EmitDefaultValue=false)]
        public long? Ondup { get; set; }

        /// <summary>
        /// 文件密级  - 0：默认值，创建文件时文件密级设为创建者密级，覆盖版本时不改变密级  - 5~15：正常密级  - 0x7FFF：空密级  
        /// </summary>
        /// <value>文件密级  - 0：默认值，创建文件时文件密级设为创建者密级，覆盖版本时不改变密级  - 5~15：正常密级  - 0x7FFF：空密级  </value>
        [DataMember(Name="csflevel", EmitDefaultValue=false)]
        public long? Csflevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDuploadReq {\n");
            sb.Append("  ClientMtime: ").Append(ClientMtime).Append("\n");
            sb.Append("  Crc32: ").Append(Crc32).Append("\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ondup: ").Append(Ondup).Append("\n");
            sb.Append("  Csflevel: ").Append(Csflevel).Append("\n");
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
            return this.Equals(input as FileDuploadReq);
        }

        /// <summary>
        /// Returns true if FileDuploadReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDuploadReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDuploadReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientMtime == input.ClientMtime ||
                    (this.ClientMtime != null &&
                    this.ClientMtime.Equals(input.ClientMtime))
                ) && 
                (
                    this.Crc32 == input.Crc32 ||
                    (this.Crc32 != null &&
                    this.Crc32.Equals(input.Crc32))
                ) && 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Md5 == input.Md5 ||
                    (this.Md5 != null &&
                    this.Md5.Equals(input.Md5))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Ondup == input.Ondup ||
                    (this.Ondup != null &&
                    this.Ondup.Equals(input.Ondup))
                ) && 
                (
                    this.Csflevel == input.Csflevel ||
                    (this.Csflevel != null &&
                    this.Csflevel.Equals(input.Csflevel))
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
                if (this.ClientMtime != null)
                    hashCode = hashCode * 59 + this.ClientMtime.GetHashCode();
                if (this.Crc32 != null)
                    hashCode = hashCode * 59 + this.Crc32.GetHashCode();
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Md5 != null)
                    hashCode = hashCode * 59 + this.Md5.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ondup != null)
                    hashCode = hashCode * 59 + this.Ondup.GetHashCode();
                if (this.Csflevel != null)
                    hashCode = hashCode * 59 + this.Csflevel.GetHashCode();
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
