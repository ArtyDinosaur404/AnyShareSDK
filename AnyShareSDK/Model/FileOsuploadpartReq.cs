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
    /// FileOsuploadpartReq
    /// </summary>
    [DataContract]
    public partial class FileOsuploadpartReq :  IEquatable<FileOsuploadpartReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsuploadpartReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileOsuploadpartReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsuploadpartReq" /> class.
        /// </summary>
        /// <param name="docid">文件的gns路径（创建协议返回） (required).</param>
        /// <param name="rev">文件版本号 (required).</param>
        /// <param name="uploadid">Multiupload事件Id (required).</param>
        /// <param name="parts">需要鉴权的数据块号，支持两种格式的组合，组合时以逗号分隔：  - 以“-”连接的数据块区间  - 单独的数据块号  - 如：1-100,2,3,4,23-120,130,288  - 数据块号最小为1，最大为10000。  - 根据parts参数的请求形式，可以批量申请上传数据的请求，减少上传文件时的请求次数。   (required).</param>
        /// <param name="reqhost">向存储服务器上传数据时的请求地址.</param>
        /// <param name="usehttps">上传是否使用https，默认为true.</param>
        public FileOsuploadpartReq(string docid = default(string), string rev = default(string), string uploadid = default(string), string parts = default(string), string reqhost = default(string), bool? usehttps = default(bool?))
        {
            this.Docid = docid;
            this.Rev = rev;
            this.Uploadid = uploadid;
            this.Parts = parts;
            this.Reqhost = reqhost;
            this.Usehttps = usehttps;
        }
        
        /// <summary>
        /// 文件的gns路径（创建协议返回）
        /// </summary>
        /// <value>文件的gns路径（创建协议返回）</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 文件版本号
        /// </summary>
        /// <value>文件版本号</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public string Rev { get; set; }

        /// <summary>
        /// Multiupload事件Id
        /// </summary>
        /// <value>Multiupload事件Id</value>
        [DataMember(Name="uploadid", EmitDefaultValue=false)]
        public string Uploadid { get; set; }

        /// <summary>
        /// 需要鉴权的数据块号，支持两种格式的组合，组合时以逗号分隔：  - 以“-”连接的数据块区间  - 单独的数据块号  - 如：1-100,2,3,4,23-120,130,288  - 数据块号最小为1，最大为10000。  - 根据parts参数的请求形式，可以批量申请上传数据的请求，减少上传文件时的请求次数。  
        /// </summary>
        /// <value>需要鉴权的数据块号，支持两种格式的组合，组合时以逗号分隔：  - 以“-”连接的数据块区间  - 单独的数据块号  - 如：1-100,2,3,4,23-120,130,288  - 数据块号最小为1，最大为10000。  - 根据parts参数的请求形式，可以批量申请上传数据的请求，减少上传文件时的请求次数。  </value>
        [DataMember(Name="parts", EmitDefaultValue=false)]
        public string Parts { get; set; }

        /// <summary>
        /// 向存储服务器上传数据时的请求地址
        /// </summary>
        /// <value>向存储服务器上传数据时的请求地址</value>
        [DataMember(Name="reqhost", EmitDefaultValue=false)]
        public string Reqhost { get; set; }

        /// <summary>
        /// 上传是否使用https，默认为true
        /// </summary>
        /// <value>上传是否使用https，默认为true</value>
        [DataMember(Name="usehttps", EmitDefaultValue=false)]
        public bool? Usehttps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileOsuploadpartReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  Uploadid: ").Append(Uploadid).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
            sb.Append("  Reqhost: ").Append(Reqhost).Append("\n");
            sb.Append("  Usehttps: ").Append(Usehttps).Append("\n");
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
            return this.Equals(input as FileOsuploadpartReq);
        }

        /// <summary>
        /// Returns true if FileOsuploadpartReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FileOsuploadpartReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileOsuploadpartReq input)
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
                    this.Rev == input.Rev ||
                    (this.Rev != null &&
                    this.Rev.Equals(input.Rev))
                ) && 
                (
                    this.Uploadid == input.Uploadid ||
                    (this.Uploadid != null &&
                    this.Uploadid.Equals(input.Uploadid))
                ) && 
                (
                    this.Parts == input.Parts ||
                    (this.Parts != null &&
                    this.Parts.Equals(input.Parts))
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
                if (this.Rev != null)
                    hashCode = hashCode * 59 + this.Rev.GetHashCode();
                if (this.Uploadid != null)
                    hashCode = hashCode * 59 + this.Uploadid.GetHashCode();
                if (this.Parts != null)
                    hashCode = hashCode * 59 + this.Parts.GetHashCode();
                if (this.Reqhost != null)
                    hashCode = hashCode * 59 + this.Reqhost.GetHashCode();
                if (this.Usehttps != null)
                    hashCode = hashCode * 59 + this.Usehttps.GetHashCode();
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
