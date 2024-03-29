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
    /// LinkSetRes
    /// </summary>
    [DataContract]
    public partial class LinkSetRes :  IEquatable<LinkSetRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkSetRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkSetRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkSetRes" /> class.
        /// </summary>
        /// <param name="endtime">到期时间  (required).</param>
        /// <param name="link">外链唯一标识，如FC5E038D38A57032085441E7FE7010B0 (required).</param>
        /// <param name="password">空表示没有 (required).</param>
        /// <param name="perm">权限值，值域为[1,7]，具体说明参见开启外链中的描述 (required).</param>
        /// <param name="limittimes">外链使用次数。  -1为无限制   (required).</param>
        /// <param name="result">0，请求已生效，返回为最新信息    1，请求正在审核，返回为更改前信息   (required).</param>
        public LinkSetRes(long? endtime = default(long?), string link = default(string), string password = default(string), long? perm = default(long?), long? limittimes = default(long?), long? result = default(long?))
        {
            this.Endtime = endtime;
            this.Link = link;
            this.Password = password;
            this.Perm = perm;
            this.Limittimes = limittimes;
            this.Result = result;
        }
        
        /// <summary>
        /// 到期时间 
        /// </summary>
        /// <value>到期时间 </value>
        [DataMember(Name="endtime", EmitDefaultValue=false)]
        public long? Endtime { get; set; }

        /// <summary>
        /// 外链唯一标识，如FC5E038D38A57032085441E7FE7010B0
        /// </summary>
        /// <value>外链唯一标识，如FC5E038D38A57032085441E7FE7010B0</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// 空表示没有
        /// </summary>
        /// <value>空表示没有</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// 权限值，值域为[1,7]，具体说明参见开启外链中的描述
        /// </summary>
        /// <value>权限值，值域为[1,7]，具体说明参见开启外链中的描述</value>
        [DataMember(Name="perm", EmitDefaultValue=false)]
        public long? Perm { get; set; }

        /// <summary>
        /// 外链使用次数。  -1为无限制  
        /// </summary>
        /// <value>外链使用次数。  -1为无限制  </value>
        [DataMember(Name="limittimes", EmitDefaultValue=false)]
        public long? Limittimes { get; set; }

        /// <summary>
        /// 0，请求已生效，返回为最新信息    1，请求正在审核，返回为更改前信息  
        /// </summary>
        /// <value>0，请求已生效，返回为最新信息    1，请求正在审核，返回为更改前信息  </value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public long? Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkSetRes {\n");
            sb.Append("  Endtime: ").Append(Endtime).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Perm: ").Append(Perm).Append("\n");
            sb.Append("  Limittimes: ").Append(Limittimes).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as LinkSetRes);
        }

        /// <summary>
        /// Returns true if LinkSetRes instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkSetRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkSetRes input)
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
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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
