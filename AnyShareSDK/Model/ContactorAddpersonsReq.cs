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
    /// ContactorAddpersonsReq
    /// </summary>
    [DataContract]
    public partial class ContactorAddpersonsReq :  IEquatable<ContactorAddpersonsReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactorAddpersonsReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactorAddpersonsReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactorAddpersonsReq" /> class.
        /// </summary>
        /// <param name="groupid">联系人组唯一标识 (required).</param>
        /// <param name="userids">待添加的联系人id (required).</param>
        public ContactorAddpersonsReq(string groupid = default(string), List<string> userids = default(List<string>))
        {
            this.Groupid = groupid;
            this.Userids = userids;
        }
        
        /// <summary>
        /// 联系人组唯一标识
        /// </summary>
        /// <value>联系人组唯一标识</value>
        [DataMember(Name="groupid", EmitDefaultValue=false)]
        public string Groupid { get; set; }

        /// <summary>
        /// 待添加的联系人id
        /// </summary>
        /// <value>待添加的联系人id</value>
        [DataMember(Name="userids", EmitDefaultValue=false)]
        public List<string> Userids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactorAddpersonsReq {\n");
            sb.Append("  Groupid: ").Append(Groupid).Append("\n");
            sb.Append("  Userids: ").Append(Userids).Append("\n");
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
            return this.Equals(input as ContactorAddpersonsReq);
        }

        /// <summary>
        /// Returns true if ContactorAddpersonsReq instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactorAddpersonsReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactorAddpersonsReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Groupid == input.Groupid ||
                    (this.Groupid != null &&
                    this.Groupid.Equals(input.Groupid))
                ) && 
                (
                    this.Userids == input.Userids ||
                    this.Userids != null &&
                    input.Userids != null &&
                    this.Userids.SequenceEqual(input.Userids)
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
                if (this.Groupid != null)
                    hashCode = hashCode * 59 + this.Groupid.GetHashCode();
                if (this.Userids != null)
                    hashCode = hashCode * 59 + this.Userids.GetHashCode();
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
