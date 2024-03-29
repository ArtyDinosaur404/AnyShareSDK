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
    /// FileOsdownloadReq
    /// </summary>
    [DataContract]
    public partial class FileOsdownloadReq :  IEquatable<FileOsdownloadReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsdownloadReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileOsdownloadReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsdownloadReq" /> class.
        /// </summary>
        /// <param name="docid">文档id (required).</param>
        /// <param name="rev">文件版本号，为空默认下载最新版本.</param>
        /// <param name="authtype">默认为空，在header中包含鉴权，否则在url中包含鉴权。QUERY_STRING，url中包含鉴权.</param>
        /// <param name="reqhost">从存储服务器下载数据时的请求地址.</param>
        /// <param name="usehttps">是否使用https下载，默认为true；使用亚马逊AWS S3时，参数usehttps的设置无效，统一使用https.</param>
        /// <param name="savename">使用QUERY_STRING方式下载时（浏览器），可以设置要保存的文件名.</param>
        public FileOsdownloadReq(string docid = default(string), string rev = default(string), string authtype = default(string), string reqhost = default(string), bool? usehttps = default(bool?), string savename = default(string))
        {
            this.Docid = docid;
            this.Rev = rev;
            this.Authtype = authtype;
            this.Reqhost = reqhost;
            this.Usehttps = usehttps;
            this.Savename = savename;
        }
        
        /// <summary>
        /// 文档id
        /// </summary>
        /// <value>文档id</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 文件版本号，为空默认下载最新版本
        /// </summary>
        /// <value>文件版本号，为空默认下载最新版本</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public string Rev { get; set; }

        /// <summary>
        /// 默认为空，在header中包含鉴权，否则在url中包含鉴权。QUERY_STRING，url中包含鉴权
        /// </summary>
        /// <value>默认为空，在header中包含鉴权，否则在url中包含鉴权。QUERY_STRING，url中包含鉴权</value>
        [DataMember(Name="authtype", EmitDefaultValue=false)]
        public string Authtype { get; set; }

        /// <summary>
        /// 从存储服务器下载数据时的请求地址
        /// </summary>
        /// <value>从存储服务器下载数据时的请求地址</value>
        [DataMember(Name="reqhost", EmitDefaultValue=false)]
        public string Reqhost { get; set; }

        /// <summary>
        /// 是否使用https下载，默认为true；使用亚马逊AWS S3时，参数usehttps的设置无效，统一使用https
        /// </summary>
        /// <value>是否使用https下载，默认为true；使用亚马逊AWS S3时，参数usehttps的设置无效，统一使用https</value>
        [DataMember(Name="usehttps", EmitDefaultValue=false)]
        public bool? Usehttps { get; set; }

        /// <summary>
        /// 使用QUERY_STRING方式下载时（浏览器），可以设置要保存的文件名
        /// </summary>
        /// <value>使用QUERY_STRING方式下载时（浏览器），可以设置要保存的文件名</value>
        [DataMember(Name="savename", EmitDefaultValue=false)]
        public string Savename { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileOsdownloadReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  Authtype: ").Append(Authtype).Append("\n");
            sb.Append("  Reqhost: ").Append(Reqhost).Append("\n");
            sb.Append("  Usehttps: ").Append(Usehttps).Append("\n");
            sb.Append("  Savename: ").Append(Savename).Append("\n");
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
            return this.Equals(input as FileOsdownloadReq);
        }

        /// <summary>
        /// Returns true if FileOsdownloadReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FileOsdownloadReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileOsdownloadReq input)
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
                    this.Authtype == input.Authtype ||
                    (this.Authtype != null &&
                    this.Authtype.Equals(input.Authtype))
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
                    this.Savename == input.Savename ||
                    (this.Savename != null &&
                    this.Savename.Equals(input.Savename))
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
                if (this.Authtype != null)
                    hashCode = hashCode * 59 + this.Authtype.GetHashCode();
                if (this.Reqhost != null)
                    hashCode = hashCode * 59 + this.Reqhost.GetHashCode();
                if (this.Usehttps != null)
                    hashCode = hashCode * 59 + this.Usehttps.GetHashCode();
                if (this.Savename != null)
                    hashCode = hashCode * 59 + this.Savename.GetHashCode();
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
