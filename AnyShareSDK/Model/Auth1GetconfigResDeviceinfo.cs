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
    /// 设备信息
    /// </summary>
    [DataContract]
    public partial class Auth1GetconfigResDeviceinfo :  IEquatable<Auth1GetconfigResDeviceinfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigResDeviceinfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth1GetconfigResDeviceinfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigResDeviceinfo" /> class.
        /// </summary>
        /// <param name="authDays">授权天数 (required).</param>
        /// <param name="authStatus">授权状态 1未授权 2已授权 3已过期 4已失效 (required).</param>
        /// <param name="authType">授权类型 1未授权 2测试授权 3正式授权 (required).</param>
        /// <param name="hardwareType">设备型号 (required).</param>
        /// <param name="softwareType">当前产品类型信息  EDMS: 涉密一体机  ASE：AnyShare Enterprise  ASS：AnyShare Express  ASC：AnyShare Cloud (required).</param>
        public Auth1GetconfigResDeviceinfo(long? authDays = default(long?), long? authStatus = default(long?), long? authType = default(long?), string hardwareType = default(string), string softwareType = default(string))
        {
            this.AuthDays = authDays;
            this.AuthStatus = authStatus;
            this.AuthType = authType;
            this.HardwareType = hardwareType;
            this.SoftwareType = softwareType;
        }
        
        /// <summary>
        /// 授权天数
        /// </summary>
        /// <value>授权天数</value>
        [DataMember(Name="auth_days", EmitDefaultValue=false)]
        public long? AuthDays { get; set; }

        /// <summary>
        /// 授权状态 1未授权 2已授权 3已过期 4已失效
        /// </summary>
        /// <value>授权状态 1未授权 2已授权 3已过期 4已失效</value>
        [DataMember(Name="auth_status", EmitDefaultValue=false)]
        public long? AuthStatus { get; set; }

        /// <summary>
        /// 授权类型 1未授权 2测试授权 3正式授权
        /// </summary>
        /// <value>授权类型 1未授权 2测试授权 3正式授权</value>
        [DataMember(Name="auth_type", EmitDefaultValue=false)]
        public long? AuthType { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        /// <value>设备型号</value>
        [DataMember(Name="hardware_type", EmitDefaultValue=false)]
        public string HardwareType { get; set; }

        /// <summary>
        /// 当前产品类型信息  EDMS: 涉密一体机  ASE：AnyShare Enterprise  ASS：AnyShare Express  ASC：AnyShare Cloud
        /// </summary>
        /// <value>当前产品类型信息  EDMS: 涉密一体机  ASE：AnyShare Enterprise  ASS：AnyShare Express  ASC：AnyShare Cloud</value>
        [DataMember(Name="software_type", EmitDefaultValue=false)]
        public string SoftwareType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1GetconfigResDeviceinfo {\n");
            sb.Append("  AuthDays: ").Append(AuthDays).Append("\n");
            sb.Append("  AuthStatus: ").Append(AuthStatus).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  HardwareType: ").Append(HardwareType).Append("\n");
            sb.Append("  SoftwareType: ").Append(SoftwareType).Append("\n");
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
            return this.Equals(input as Auth1GetconfigResDeviceinfo);
        }

        /// <summary>
        /// Returns true if Auth1GetconfigResDeviceinfo instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1GetconfigResDeviceinfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1GetconfigResDeviceinfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthDays == input.AuthDays ||
                    (this.AuthDays != null &&
                    this.AuthDays.Equals(input.AuthDays))
                ) && 
                (
                    this.AuthStatus == input.AuthStatus ||
                    (this.AuthStatus != null &&
                    this.AuthStatus.Equals(input.AuthStatus))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.HardwareType == input.HardwareType ||
                    (this.HardwareType != null &&
                    this.HardwareType.Equals(input.HardwareType))
                ) && 
                (
                    this.SoftwareType == input.SoftwareType ||
                    (this.SoftwareType != null &&
                    this.SoftwareType.Equals(input.SoftwareType))
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
                if (this.AuthDays != null)
                    hashCode = hashCode * 59 + this.AuthDays.GetHashCode();
                if (this.AuthStatus != null)
                    hashCode = hashCode * 59 + this.AuthStatus.GetHashCode();
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.HardwareType != null)
                    hashCode = hashCode * 59 + this.HardwareType.GetHashCode();
                if (this.SoftwareType != null)
                    hashCode = hashCode * 59 + this.SoftwareType.GetHashCode();
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
