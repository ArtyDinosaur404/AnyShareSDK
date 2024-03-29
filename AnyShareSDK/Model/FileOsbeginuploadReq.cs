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
    /// FileOsbeginuploadReq
    /// </summary>
    [DataContract]
    public partial class FileOsbeginuploadReq :  IEquatable<FileOsbeginuploadReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsbeginuploadReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileOsbeginuploadReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsbeginuploadReq" /> class.
        /// </summary>
        /// <param name="docid">gns（全局名字空间）路径，创建或者列举协议返回  - 创建文件时， gns为待创建文件的父目录gns；  - 编辑文件时（文件生成新版本），gns为所编辑文件的gns (required).</param>
        /// <param name="length">整个文件的长度，支持最大5G (required).</param>
        /// <param name="name">文件名称，UTF8编码  - 创建文件时， name为文件名；  - 编辑文件时（文件生成新版本），参数为空  .</param>
        /// <param name="clientMtime">由客户端设置的文件本地修改时间  创建新版本（rev为空或name为为空）时，写入版本.</param>
        /// <param name="ondup">当name不为空时生效  - 1:检查是否重命名，重名则抛异常  - 2:如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  .</param>
        /// <param name="reqmethod">向存储服务器上传数据时的请求方法。  默认为“PUT”；参数值“POST”表示使用POST表单的方式上传  .</param>
        /// <param name="reqhost">向存储服务器上传数据时的请求地址.</param>
        /// <param name="usehttps">上传是否使用https，默认为true，只对一体机自有对象存储EOSS生效.</param>
        /// <param name="csflevel">文件密级预检查，要设置密级必须在osendupload中设置  - 0：默认值，不检查密级  - 5~15：正常密级  - 0x7FFF：空密级  .</param>
        /// <param name="editedrev">表示编辑文件时，基于文件的哪个版本（版本ID）进行编辑，默认为空。  - 如果为空，不检查是否基于文件的最新版本进行编辑；  - 如果不为空，若所编辑的版本ID不是服务器上文件的最新版本，则上传报错。错误码403203，“所编辑文件的版本与服务端文件最新版本不一致”  .</param>
        public FileOsbeginuploadReq(string docid = default(string), long? length = default(long?), string name = default(string), long? clientMtime = default(long?), long? ondup = default(long?), string reqmethod = default(string), string reqhost = default(string), bool? usehttps = default(bool?), long? csflevel = default(long?), string editedrev = default(string))
        {
            this.Docid = docid;
            this.Length = length;
            this.Name = name;
            this.ClientMtime = clientMtime;
            this.Ondup = ondup;
            this.Reqmethod = reqmethod;
            this.Reqhost = reqhost;
            this.Usehttps = usehttps;
            this.Csflevel = csflevel;
            this.Editedrev = editedrev;
        }
        
        /// <summary>
        /// gns（全局名字空间）路径，创建或者列举协议返回  - 创建文件时， gns为待创建文件的父目录gns；  - 编辑文件时（文件生成新版本），gns为所编辑文件的gns
        /// </summary>
        /// <value>gns（全局名字空间）路径，创建或者列举协议返回  - 创建文件时， gns为待创建文件的父目录gns；  - 编辑文件时（文件生成新版本），gns为所编辑文件的gns</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 整个文件的长度，支持最大5G
        /// </summary>
        /// <value>整个文件的长度，支持最大5G</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public long? Length { get; set; }

        /// <summary>
        /// 文件名称，UTF8编码  - 创建文件时， name为文件名；  - 编辑文件时（文件生成新版本），参数为空  
        /// </summary>
        /// <value>文件名称，UTF8编码  - 创建文件时， name为文件名；  - 编辑文件时（文件生成新版本），参数为空  </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 由客户端设置的文件本地修改时间  创建新版本（rev为空或name为为空）时，写入版本
        /// </summary>
        /// <value>由客户端设置的文件本地修改时间  创建新版本（rev为空或name为为空）时，写入版本</value>
        [DataMember(Name="client_mtime", EmitDefaultValue=false)]
        public long? ClientMtime { get; set; }

        /// <summary>
        /// 当name不为空时生效  - 1:检查是否重命名，重名则抛异常  - 2:如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  
        /// </summary>
        /// <value>当name不为空时生效  - 1:检查是否重命名，重名则抛异常  - 2:如果重名冲突，自动重名  - 3:如果重名冲突，自动覆盖  </value>
        [DataMember(Name="ondup", EmitDefaultValue=false)]
        public long? Ondup { get; set; }

        /// <summary>
        /// 向存储服务器上传数据时的请求方法。  默认为“PUT”；参数值“POST”表示使用POST表单的方式上传  
        /// </summary>
        /// <value>向存储服务器上传数据时的请求方法。  默认为“PUT”；参数值“POST”表示使用POST表单的方式上传  </value>
        [DataMember(Name="reqmethod", EmitDefaultValue=false)]
        public string Reqmethod { get; set; }

        /// <summary>
        /// 向存储服务器上传数据时的请求地址
        /// </summary>
        /// <value>向存储服务器上传数据时的请求地址</value>
        [DataMember(Name="reqhost", EmitDefaultValue=false)]
        public string Reqhost { get; set; }

        /// <summary>
        /// 上传是否使用https，默认为true，只对一体机自有对象存储EOSS生效
        /// </summary>
        /// <value>上传是否使用https，默认为true，只对一体机自有对象存储EOSS生效</value>
        [DataMember(Name="usehttps", EmitDefaultValue=false)]
        public bool? Usehttps { get; set; }

        /// <summary>
        /// 文件密级预检查，要设置密级必须在osendupload中设置  - 0：默认值，不检查密级  - 5~15：正常密级  - 0x7FFF：空密级  
        /// </summary>
        /// <value>文件密级预检查，要设置密级必须在osendupload中设置  - 0：默认值，不检查密级  - 5~15：正常密级  - 0x7FFF：空密级  </value>
        [DataMember(Name="csflevel", EmitDefaultValue=false)]
        public long? Csflevel { get; set; }

        /// <summary>
        /// 表示编辑文件时，基于文件的哪个版本（版本ID）进行编辑，默认为空。  - 如果为空，不检查是否基于文件的最新版本进行编辑；  - 如果不为空，若所编辑的版本ID不是服务器上文件的最新版本，则上传报错。错误码403203，“所编辑文件的版本与服务端文件最新版本不一致”  
        /// </summary>
        /// <value>表示编辑文件时，基于文件的哪个版本（版本ID）进行编辑，默认为空。  - 如果为空，不检查是否基于文件的最新版本进行编辑；  - 如果不为空，若所编辑的版本ID不是服务器上文件的最新版本，则上传报错。错误码403203，“所编辑文件的版本与服务端文件最新版本不一致”  </value>
        [DataMember(Name="editedrev", EmitDefaultValue=false)]
        public string Editedrev { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileOsbeginuploadReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ClientMtime: ").Append(ClientMtime).Append("\n");
            sb.Append("  Ondup: ").Append(Ondup).Append("\n");
            sb.Append("  Reqmethod: ").Append(Reqmethod).Append("\n");
            sb.Append("  Reqhost: ").Append(Reqhost).Append("\n");
            sb.Append("  Usehttps: ").Append(Usehttps).Append("\n");
            sb.Append("  Csflevel: ").Append(Csflevel).Append("\n");
            sb.Append("  Editedrev: ").Append(Editedrev).Append("\n");
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
            return this.Equals(input as FileOsbeginuploadReq);
        }

        /// <summary>
        /// Returns true if FileOsbeginuploadReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FileOsbeginuploadReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileOsbeginuploadReq input)
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
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ClientMtime == input.ClientMtime ||
                    (this.ClientMtime != null &&
                    this.ClientMtime.Equals(input.ClientMtime))
                ) && 
                (
                    this.Ondup == input.Ondup ||
                    (this.Ondup != null &&
                    this.Ondup.Equals(input.Ondup))
                ) && 
                (
                    this.Reqmethod == input.Reqmethod ||
                    (this.Reqmethod != null &&
                    this.Reqmethod.Equals(input.Reqmethod))
                ) && 
                (
                    this.Reqhost == input.Reqhost ||
                    (this.Reqhost != null &&
                    this.Reqhost.Equals(input.Reqhost))
                ) && 
                (
                    this.Usehttps == input.Usehttps ||
                    (this.Usehttps != null &&
                    this.Usehttps.Equals(input.Usehttps))
                ) && 
                (
                    this.Csflevel == input.Csflevel ||
                    (this.Csflevel != null &&
                    this.Csflevel.Equals(input.Csflevel))
                ) && 
                (
                    this.Editedrev == input.Editedrev ||
                    (this.Editedrev != null &&
                    this.Editedrev.Equals(input.Editedrev))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ClientMtime != null)
                    hashCode = hashCode * 59 + this.ClientMtime.GetHashCode();
                if (this.Ondup != null)
                    hashCode = hashCode * 59 + this.Ondup.GetHashCode();
                if (this.Reqmethod != null)
                    hashCode = hashCode * 59 + this.Reqmethod.GetHashCode();
                if (this.Reqhost != null)
                    hashCode = hashCode * 59 + this.Reqhost.GetHashCode();
                if (this.Usehttps != null)
                    hashCode = hashCode * 59 + this.Usehttps.GetHashCode();
                if (this.Csflevel != null)
                    hashCode = hashCode * 59 + this.Csflevel.GetHashCode();
                if (this.Editedrev != null)
                    hashCode = hashCode * 59 + this.Editedrev.GetHashCode();
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
