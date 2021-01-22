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
    /// OwnerSetReqUserconfig
    /// </summary>
    [DataContract]
    public partial class OwnerSetReqUserconfig :  IEquatable<OwnerSetReqUserconfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerSetReqUserconfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OwnerSetReqUserconfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerSetReqUserconfig" /> class.
        /// </summary>
        /// <param name="userid">用户ID (required).</param>
        /// <param name="inheritpath">所有者的继承路径，被设置为当前文档为空 (required).</param>
        public OwnerSetReqUserconfig(string userid = default(string), string inheritpath = default(string))
        {
            this.Userid = userid;
            this.Inheritpath = inheritpath;
        }
        
        /// <summary>
        /// 用户ID
        /// </summary>
        /// <value>用户ID</value>
        [DataMember(Name="userid", EmitDefaultValue=false)]
        public string Userid { get; set; }

        /// <summary>
        /// 所有者的继承路径，被设置为当前文档为空
        /// </summary>
        /// <value>所有者的继承路径，被设置为当前文档为空</value>
        [DataMember(Name="inheritpath", EmitDefaultValue=false)]
        public string Inheritpath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OwnerSetReqUserconfig {\n");
            sb.Append("  Userid: ").Append(Userid).Append("\n");
            sb.Append("  Inheritpath: ").Append(Inheritpath).Append("\n");
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
            return this.Equals(input as OwnerSetReqUserconfig);
        }

        /// <summary>
        /// Returns true if OwnerSetReqUserconfig instances are equal
        /// </summary>
        /// <param name="input">Instance of OwnerSetReqUserconfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OwnerSetReqUserconfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Userid == input.Userid ||
                    (this.Userid != null &&
                    this.Userid.Equals(input.Userid))
                ) && 
                (
                    this.Inheritpath == input.Inheritpath ||
                    (this.Inheritpath != null &&
                    this.Inheritpath.Equals(input.Inheritpath))
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
                if (this.Userid != null)
                    hashCode = hashCode * 59 + this.Userid.GetHashCode();
                if (this.Inheritpath != null)
                    hashCode = hashCode * 59 + this.Inheritpath.GetHashCode();
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