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
    /// LinkGetdetailRes
    /// </summary>
    [DataContract]
    public partial class LinkGetdetailRes :  IEquatable<LinkGetdetailRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkGetdetailRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkGetdetailRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkGetdetailRes" /> class.
        /// </summary>
        /// <param name="endtime">到期时间，单位：微秒，如果为-1，表示无限期，表示从1970-01-01,00-00-00至今的时间 (required).</param>
        /// <param name="link">- 外链唯一标识，如FC5E038D38A57032085441E7FE7010B0 - link不是完全链接，需要客户端加上域名或者ip加端口的形式，如share.eisoocloud.com:80/link/1ERSDSEc或者192.168.83.33:80/link/1ERSDSEcad (required).</param>
        /// <param name="password">密码，空表示没有 (required).</param>
        /// <param name="perm">按位存储的权限值（返回的是十进制），获取该值后，需要转化成二级制，检查对应的位码是否被设置。    右数第一位表示该外链可以被预览    右数第二位表示该外链可以被下载    例如：  - 返回1表示只能被预览  - 返回2表示只能被下载  - 返回3表示可被预览和下载   (required).</param>
        /// <param name="limittimes">外链使用次数。  -1为无限制   (required).</param>
        public LinkGetdetailRes(long? endtime = default(long?), string link = default(string), string password = default(string), long? perm = default(long?), long? limittimes = default(long?))
        {
            this.Endtime = endtime;
            this.Link = link;
            this.Password = password;
            this.Perm = perm;
            this.Limittimes = limittimes;
        }
        
        /// <summary>
        /// 到期时间，单位：微秒，如果为-1，表示无限期，表示从1970-01-01,00-00-00至今的时间
        /// </summary>
        /// <value>到期时间，单位：微秒，如果为-1，表示无限期，表示从1970-01-01,00-00-00至今的时间</value>
        [DataMember(Name="endtime", EmitDefaultValue=false)]
        public long? Endtime { get; set; }

        /// <summary>
        /// - 外链唯一标识，如FC5E038D38A57032085441E7FE7010B0 - link不是完全链接，需要客户端加上域名或者ip加端口的形式，如share.eisoocloud.com:80/link/1ERSDSEc或者192.168.83.33:80/link/1ERSDSEcad
        /// </summary>
        /// <value>- 外链唯一标识，如FC5E038D38A57032085441E7FE7010B0 - link不是完全链接，需要客户端加上域名或者ip加端口的形式，如share.eisoocloud.com:80/link/1ERSDSEc或者192.168.83.33:80/link/1ERSDSEcad</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// 密码，空表示没有
        /// </summary>
        /// <value>密码，空表示没有</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// 按位存储的权限值（返回的是十进制），获取该值后，需要转化成二级制，检查对应的位码是否被设置。    右数第一位表示该外链可以被预览    右数第二位表示该外链可以被下载    例如：  - 返回1表示只能被预览  - 返回2表示只能被下载  - 返回3表示可被预览和下载  
        /// </summary>
        /// <value>按位存储的权限值（返回的是十进制），获取该值后，需要转化成二级制，检查对应的位码是否被设置。    右数第一位表示该外链可以被预览    右数第二位表示该外链可以被下载    例如：  - 返回1表示只能被预览  - 返回2表示只能被下载  - 返回3表示可被预览和下载  </value>
        [DataMember(Name="perm", EmitDefaultValue=false)]
        public long? Perm { get; set; }

        /// <summary>
        /// 外链使用次数。  -1为无限制  
        /// </summary>
        /// <value>外链使用次数。  -1为无限制  </value>
        [DataMember(Name="limittimes", EmitDefaultValue=false)]
        public long? Limittimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkGetdetailRes {\n");
            sb.Append("  Endtime: ").Append(Endtime).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Perm: ").Append(Perm).Append("\n");
            sb.Append("  Limittimes: ").Append(Limittimes).Append("\n");
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
            return this.Equals(input as LinkGetdetailRes);
        }

        /// <summary>
        /// Returns true if LinkGetdetailRes instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkGetdetailRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkGetdetailRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endtime == input.Endtime ||
                    (this.Endtime != null &&
                    this.Endtime.Equals(input.Endtime))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Perm == input.Perm ||
                    (this.Perm != null &&
                    this.Perm.Equals(input.Perm))
                ) && 
                (
                    this.Limittimes == input.Limittimes ||
                    (this.Limittimes != null &&
                    this.Limittimes.Equals(input.Limittimes))
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
                if (this.Endtime != null)
                    hashCode = hashCode * 59 + this.Endtime.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Perm != null)
                    hashCode = hashCode * 59 + this.Perm.GetHashCode();
                if (this.Limittimes != null)
                    hashCode = hashCode * 59 + this.Limittimes.GetHashCode();
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