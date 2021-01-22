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
    /// 描述CA信息，如果服务器未设置过CA信息，该字段不会出现
    /// </summary>
    [DataContract]
    public partial class CaGetResCainfo :  IEquatable<CaGetResCainfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaGetResCainfo" /> class.
        /// </summary>
        /// <param name="vender">厂商ID.</param>
        /// <param name="description">厂商描述.</param>
        /// <param name="server">CA服务器信息.</param>
        /// <param name="appid">CA服务器分配的appid.</param>
        /// <param name="appkey">CA服务器分配的appkey.</param>
        public CaGetResCainfo(string vender = default(string), string description = default(string), string server = default(string), string appid = default(string), string appkey = default(string))
        {
            this.Vender = vender;
            this.Description = description;
            this.Server = server;
            this.Appid = appid;
            this.Appkey = appkey;
        }
        
        /// <summary>
        /// 厂商ID
        /// </summary>
        /// <value>厂商ID</value>
        [DataMember(Name="vender", EmitDefaultValue=false)]
        public string Vender { get; set; }

        /// <summary>
        /// 厂商描述
        /// </summary>
        /// <value>厂商描述</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// CA服务器信息
        /// </summary>
        /// <value>CA服务器信息</value>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public string Server { get; set; }

        /// <summary>
        /// CA服务器分配的appid
        /// </summary>
        /// <value>CA服务器分配的appid</value>
        [DataMember(Name="appid", EmitDefaultValue=false)]
        public string Appid { get; set; }

        /// <summary>
        /// CA服务器分配的appkey
        /// </summary>
        /// <value>CA服务器分配的appkey</value>
        [DataMember(Name="appkey", EmitDefaultValue=false)]
        public string Appkey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaGetResCainfo {\n");
            sb.Append("  Vender: ").Append(Vender).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Appid: ").Append(Appid).Append("\n");
            sb.Append("  Appkey: ").Append(Appkey).Append("\n");
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
            return this.Equals(input as CaGetResCainfo);
        }

        /// <summary>
        /// Returns true if CaGetResCainfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CaGetResCainfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaGetResCainfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vender == input.Vender ||
                    (this.Vender != null &&
                    this.Vender.Equals(input.Vender))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.Appid == input.Appid ||
                    (this.Appid != null &&
                    this.Appid.Equals(input.Appid))
                ) && 
                (
                    this.Appkey == input.Appkey ||
                    (this.Appkey != null &&
                    this.Appkey.Equals(input.Appkey))
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
                if (this.Vender != null)
                    hashCode = hashCode * 59 + this.Vender.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.Appid != null)
                    hashCode = hashCode * 59 + this.Appid.GetHashCode();
                if (this.Appkey != null)
                    hashCode = hashCode * 59 + this.Appkey.GetHashCode();
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
