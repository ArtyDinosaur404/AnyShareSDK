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
    /// AutolockLockReq
    /// </summary>
    [DataContract]
    public partial class AutolockLockReq :  IEquatable<AutolockLockReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutolockLockReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutolockLockReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutolockLockReq" /> class.
        /// </summary>
        /// <param name="docid">文件id (required).</param>
        /// <param name="force">是否强制获取锁，默认为false  false：不强制获取锁  true：强制获取锁.</param>
        /// <param name="expiretime">文件锁有效期限，默认为使用服务器可配置的超期间隔进行定期清理  -1：永久有效.</param>
        public AutolockLockReq(string docid = default(string), bool? force = default(bool?), long? expiretime = default(long?))
        {
            this.Docid = docid;
            this.Force = force;
            this.Expiretime = expiretime;
        }
        
        /// <summary>
        /// 文件id
        /// </summary>
        /// <value>文件id</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 是否强制获取锁，默认为false  false：不强制获取锁  true：强制获取锁
        /// </summary>
        /// <value>是否强制获取锁，默认为false  false：不强制获取锁  true：强制获取锁</value>
        [DataMember(Name="force", EmitDefaultValue=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// 文件锁有效期限，默认为使用服务器可配置的超期间隔进行定期清理  -1：永久有效
        /// </summary>
        /// <value>文件锁有效期限，默认为使用服务器可配置的超期间隔进行定期清理  -1：永久有效</value>
        [DataMember(Name="expiretime", EmitDefaultValue=false)]
        public long? Expiretime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutolockLockReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
            sb.Append("  Expiretime: ").Append(Expiretime).Append("\n");
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
            return this.Equals(input as AutolockLockReq);
        }

        /// <summary>
        /// Returns true if AutolockLockReq instances are equal
        /// </summary>
        /// <param name="input">Instance of AutolockLockReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutolockLockReq input)
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
                    this.Force == input.Force ||
                    (this.Force != null &&
                    this.Force.Equals(input.Force))
                ) && 
                (
                    this.Expiretime == input.Expiretime ||
                    (this.Expiretime != null &&
                    this.Expiretime.Equals(input.Expiretime))
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
                if (this.Force != null)
                    hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.Expiretime != null)
                    hashCode = hashCode * 59 + this.Expiretime.GetHashCode();
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
