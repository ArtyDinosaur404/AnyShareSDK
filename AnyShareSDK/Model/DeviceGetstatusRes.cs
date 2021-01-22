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
    /// DeviceGetstatusRes
    /// </summary>
    [DataContract]
    public partial class DeviceGetstatusRes :  IEquatable<DeviceGetstatusRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGetstatusRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceGetstatusRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGetstatusRes" /> class.
        /// </summary>
        /// <param name="eraseflag">数据擦除状态  0表示正常  1表示正在请求擦除 (required).</param>
        /// <param name="disableflag">设备禁用状态  0表示正常  1表示处于禁用状态 (required).</param>
        public DeviceGetstatusRes(long? eraseflag = default(long?), long? disableflag = default(long?))
        {
            this.Eraseflag = eraseflag;
            this.Disableflag = disableflag;
        }
        
        /// <summary>
        /// 数据擦除状态  0表示正常  1表示正在请求擦除
        /// </summary>
        /// <value>数据擦除状态  0表示正常  1表示正在请求擦除</value>
        [DataMember(Name="eraseflag", EmitDefaultValue=false)]
        public long? Eraseflag { get; set; }

        /// <summary>
        /// 设备禁用状态  0表示正常  1表示处于禁用状态
        /// </summary>
        /// <value>设备禁用状态  0表示正常  1表示处于禁用状态</value>
        [DataMember(Name="disableflag", EmitDefaultValue=false)]
        public long? Disableflag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceGetstatusRes {\n");
            sb.Append("  Eraseflag: ").Append(Eraseflag).Append("\n");
            sb.Append("  Disableflag: ").Append(Disableflag).Append("\n");
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
            return this.Equals(input as DeviceGetstatusRes);
        }

        /// <summary>
        /// Returns true if DeviceGetstatusRes instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceGetstatusRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceGetstatusRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Eraseflag == input.Eraseflag ||
                    (this.Eraseflag != null &&
                    this.Eraseflag.Equals(input.Eraseflag))
                ) && 
                (
                    this.Disableflag == input.Disableflag ||
                    (this.Disableflag != null &&
                    this.Disableflag.Equals(input.Disableflag))
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
                if (this.Eraseflag != null)
                    hashCode = hashCode * 59 + this.Eraseflag.GetHashCode();
                if (this.Disableflag != null)
                    hashCode = hashCode * 59 + this.Disableflag.GetHashCode();
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