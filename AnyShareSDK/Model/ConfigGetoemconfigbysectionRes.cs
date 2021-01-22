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
    /// ConfigGetoemconfigbysectionRes
    /// </summary>
    [DataContract]
    public partial class ConfigGetoemconfigbysectionRes :  IEquatable<ConfigGetoemconfigbysectionRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetoemconfigbysectionRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigGetoemconfigbysectionRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetoemconfigbysectionRes" /> class.
        /// </summary>
        /// <param name="backgroundPng">OEM图片资源 (required).</param>
        /// <param name="faviconIco">OEM图片资源 (required).</param>
        /// <param name="logoPng">OEM图片资源 (required).</param>
        /// <param name="orgPng">OEM图片资源 (required).</param>
        /// <param name="helper">帮助文档链接地址 (required).</param>
        /// <param name="organization">组织机构 (required).</param>
        /// <param name="product">产品名称 (required).</param>
        /// <param name="site">官方链接 (required).</param>
        /// <param name="userAgreement">是否开启用户许可协议 (required).</param>
        /// <param name="agreementText">用户许可协议 (required).</param>
        /// <param name="android">开放android客户端下载 (required).</param>
        /// <param name="ios">开放iOS客户端下载 (required).</param>
        /// <param name="office">开放office插件下载 (required).</param>
        /// <param name="mac">开放mac客户端下载 (required).</param>
        /// <param name="windows">开放windows客户端下载 (required).</param>
        /// <param name="allowCn">允许简体中文 (required).</param>
        /// <param name="allowTw">允许繁体中文 (required).</param>
        /// <param name="allowEn">允许英文语言 (required).</param>
        /// <param name="theme">基本颜色值 (required).</param>
        /// <param name="showProduct">显示产品信息 (required).</param>
        /// <param name="showHardware">显示型号信息 (required).</param>
        /// <param name="showLicense">显示授权信息 (required).</param>
        /// <param name="showCopyright">显示版权信息 (required).</param>
        public ConfigGetoemconfigbysectionRes(string backgroundPng = default(string), string faviconIco = default(string), string logoPng = default(string), string orgPng = default(string), string helper = default(string), string organization = default(string), string product = default(string), string site = default(string), string userAgreement = default(string), string agreementText = default(string), string android = default(string), string ios = default(string), string office = default(string), string mac = default(string), string windows = default(string), string allowCn = default(string), string allowTw = default(string), string allowEn = default(string), string theme = default(string), string showProduct = default(string), string showHardware = default(string), string showLicense = default(string), string showCopyright = default(string))
        {
            this.BackgroundPng = backgroundPng;
            this.FaviconIco = faviconIco;
            this.LogoPng = logoPng;
            this.OrgPng = orgPng;
            this.Helper = helper;
            this.Organization = organization;
            this.Product = product;
            this.Site = site;
            this.UserAgreement = userAgreement;
            this.AgreementText = agreementText;
            this.Android = android;
            this.Ios = ios;
            this.Office = office;
            this.Mac = mac;
            this.Windows = windows;
            this.AllowCn = allowCn;
            this.AllowTw = allowTw;
            this.AllowEn = allowEn;
            this.Theme = theme;
            this.ShowProduct = showProduct;
            this.ShowHardware = showHardware;
            this.ShowLicense = showLicense;
            this.ShowCopyright = showCopyright;
        }
        
        /// <summary>
        /// OEM图片资源
        /// </summary>
        /// <value>OEM图片资源</value>
        [DataMember(Name="background.png", EmitDefaultValue=false)]
        public string BackgroundPng { get; set; }

        /// <summary>
        /// OEM图片资源
        /// </summary>
        /// <value>OEM图片资源</value>
        [DataMember(Name="favicon.ico", EmitDefaultValue=false)]
        public string FaviconIco { get; set; }

        /// <summary>
        /// OEM图片资源
        /// </summary>
        /// <value>OEM图片资源</value>
        [DataMember(Name="logo.png", EmitDefaultValue=false)]
        public string LogoPng { get; set; }

        /// <summary>
        /// OEM图片资源
        /// </summary>
        /// <value>OEM图片资源</value>
        [DataMember(Name="org.png", EmitDefaultValue=false)]
        public string OrgPng { get; set; }

        /// <summary>
        /// 帮助文档链接地址
        /// </summary>
        /// <value>帮助文档链接地址</value>
        [DataMember(Name="helper", EmitDefaultValue=false)]
        public string Helper { get; set; }

        /// <summary>
        /// 组织机构
        /// </summary>
        /// <value>组织机构</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        /// <value>产品名称</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public string Product { get; set; }

        /// <summary>
        /// 官方链接
        /// </summary>
        /// <value>官方链接</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public string Site { get; set; }

        /// <summary>
        /// 是否开启用户许可协议
        /// </summary>
        /// <value>是否开启用户许可协议</value>
        [DataMember(Name="userAgreement", EmitDefaultValue=false)]
        public string UserAgreement { get; set; }

        /// <summary>
        /// 用户许可协议
        /// </summary>
        /// <value>用户许可协议</value>
        [DataMember(Name="agreementText", EmitDefaultValue=false)]
        public string AgreementText { get; set; }

        /// <summary>
        /// 开放android客户端下载
        /// </summary>
        /// <value>开放android客户端下载</value>
        [DataMember(Name="android", EmitDefaultValue=false)]
        public string Android { get; set; }

        /// <summary>
        /// 开放iOS客户端下载
        /// </summary>
        /// <value>开放iOS客户端下载</value>
        [DataMember(Name="ios", EmitDefaultValue=false)]
        public string Ios { get; set; }

        /// <summary>
        /// 开放office插件下载
        /// </summary>
        /// <value>开放office插件下载</value>
        [DataMember(Name="office", EmitDefaultValue=false)]
        public string Office { get; set; }

        /// <summary>
        /// 开放mac客户端下载
        /// </summary>
        /// <value>开放mac客户端下载</value>
        [DataMember(Name="mac", EmitDefaultValue=false)]
        public string Mac { get; set; }

        /// <summary>
        /// 开放windows客户端下载
        /// </summary>
        /// <value>开放windows客户端下载</value>
        [DataMember(Name="windows", EmitDefaultValue=false)]
        public string Windows { get; set; }

        /// <summary>
        /// 允许简体中文
        /// </summary>
        /// <value>允许简体中文</value>
        [DataMember(Name="allowCn", EmitDefaultValue=false)]
        public string AllowCn { get; set; }

        /// <summary>
        /// 允许繁体中文
        /// </summary>
        /// <value>允许繁体中文</value>
        [DataMember(Name="allowTw", EmitDefaultValue=false)]
        public string AllowTw { get; set; }

        /// <summary>
        /// 允许英文语言
        /// </summary>
        /// <value>允许英文语言</value>
        [DataMember(Name="allowEn", EmitDefaultValue=false)]
        public string AllowEn { get; set; }

        /// <summary>
        /// 基本颜色值
        /// </summary>
        /// <value>基本颜色值</value>
        [DataMember(Name="theme", EmitDefaultValue=false)]
        public string Theme { get; set; }

        /// <summary>
        /// 显示产品信息
        /// </summary>
        /// <value>显示产品信息</value>
        [DataMember(Name="showProduct", EmitDefaultValue=false)]
        public string ShowProduct { get; set; }

        /// <summary>
        /// 显示型号信息
        /// </summary>
        /// <value>显示型号信息</value>
        [DataMember(Name="showHardware", EmitDefaultValue=false)]
        public string ShowHardware { get; set; }

        /// <summary>
        /// 显示授权信息
        /// </summary>
        /// <value>显示授权信息</value>
        [DataMember(Name="showLicense", EmitDefaultValue=false)]
        public string ShowLicense { get; set; }

        /// <summary>
        /// 显示版权信息
        /// </summary>
        /// <value>显示版权信息</value>
        [DataMember(Name="showCopyright", EmitDefaultValue=false)]
        public string ShowCopyright { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigGetoemconfigbysectionRes {\n");
            sb.Append("  BackgroundPng: ").Append(BackgroundPng).Append("\n");
            sb.Append("  FaviconIco: ").Append(FaviconIco).Append("\n");
            sb.Append("  LogoPng: ").Append(LogoPng).Append("\n");
            sb.Append("  OrgPng: ").Append(OrgPng).Append("\n");
            sb.Append("  Helper: ").Append(Helper).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  UserAgreement: ").Append(UserAgreement).Append("\n");
            sb.Append("  AgreementText: ").Append(AgreementText).Append("\n");
            sb.Append("  Android: ").Append(Android).Append("\n");
            sb.Append("  Ios: ").Append(Ios).Append("\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
            sb.Append("  Windows: ").Append(Windows).Append("\n");
            sb.Append("  AllowCn: ").Append(AllowCn).Append("\n");
            sb.Append("  AllowTw: ").Append(AllowTw).Append("\n");
            sb.Append("  AllowEn: ").Append(AllowEn).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  ShowProduct: ").Append(ShowProduct).Append("\n");
            sb.Append("  ShowHardware: ").Append(ShowHardware).Append("\n");
            sb.Append("  ShowLicense: ").Append(ShowLicense).Append("\n");
            sb.Append("  ShowCopyright: ").Append(ShowCopyright).Append("\n");
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
            return this.Equals(input as ConfigGetoemconfigbysectionRes);
        }

        /// <summary>
        /// Returns true if ConfigGetoemconfigbysectionRes instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigGetoemconfigbysectionRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigGetoemconfigbysectionRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackgroundPng == input.BackgroundPng ||
                    (this.BackgroundPng != null &&
                    this.BackgroundPng.Equals(input.BackgroundPng))
                ) && 
                (
                    this.FaviconIco == input.FaviconIco ||
                    (this.FaviconIco != null &&
                    this.FaviconIco.Equals(input.FaviconIco))
                ) && 
                (
                    this.LogoPng == input.LogoPng ||
                    (this.LogoPng != null &&
                    this.LogoPng.Equals(input.LogoPng))
                ) && 
                (
                    this.OrgPng == input.OrgPng ||
                    (this.OrgPng != null &&
                    this.OrgPng.Equals(input.OrgPng))
                ) && 
                (
                    this.Helper == input.Helper ||
                    (this.Helper != null &&
                    this.Helper.Equals(input.Helper))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.UserAgreement == input.UserAgreement ||
                    (this.UserAgreement != null &&
                    this.UserAgreement.Equals(input.UserAgreement))
                ) && 
                (
                    this.AgreementText == input.AgreementText ||
                    (this.AgreementText != null &&
                    this.AgreementText.Equals(input.AgreementText))
                ) && 
                (
                    this.Android == input.Android ||
                    (this.Android != null &&
                    this.Android.Equals(input.Android))
                ) && 
                (
                    this.Ios == input.Ios ||
                    (this.Ios != null &&
                    this.Ios.Equals(input.Ios))
                ) && 
                (
                    this.Office == input.Office ||
                    (this.Office != null &&
                    this.Office.Equals(input.Office))
                ) && 
                (
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
                ) && 
                (
                    this.Windows == input.Windows ||
                    (this.Windows != null &&
                    this.Windows.Equals(input.Windows))
                ) && 
                (
                    this.AllowCn == input.AllowCn ||
                    (this.AllowCn != null &&
                    this.AllowCn.Equals(input.AllowCn))
                ) && 
                (
                    this.AllowTw == input.AllowTw ||
                    (this.AllowTw != null &&
                    this.AllowTw.Equals(input.AllowTw))
                ) && 
                (
                    this.AllowEn == input.AllowEn ||
                    (this.AllowEn != null &&
                    this.AllowEn.Equals(input.AllowEn))
                ) && 
                (
                    this.Theme == input.Theme ||
                    (this.Theme != null &&
                    this.Theme.Equals(input.Theme))
                ) && 
                (
                    this.ShowProduct == input.ShowProduct ||
                    (this.ShowProduct != null &&
                    this.ShowProduct.Equals(input.ShowProduct))
                ) && 
                (
                    this.ShowHardware == input.ShowHardware ||
                    (this.ShowHardware != null &&
                    this.ShowHardware.Equals(input.ShowHardware))
                ) && 
                (
                    this.ShowLicense == input.ShowLicense ||
                    (this.ShowLicense != null &&
                    this.ShowLicense.Equals(input.ShowLicense))
                ) && 
                (
                    this.ShowCopyright == input.ShowCopyright ||
                    (this.ShowCopyright != null &&
                    this.ShowCopyright.Equals(input.ShowCopyright))
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
                if (this.BackgroundPng != null)
                    hashCode = hashCode * 59 + this.BackgroundPng.GetHashCode();
                if (this.FaviconIco != null)
                    hashCode = hashCode * 59 + this.FaviconIco.GetHashCode();
                if (this.LogoPng != null)
                    hashCode = hashCode * 59 + this.LogoPng.GetHashCode();
                if (this.OrgPng != null)
                    hashCode = hashCode * 59 + this.OrgPng.GetHashCode();
                if (this.Helper != null)
                    hashCode = hashCode * 59 + this.Helper.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Site != null)
                    hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.UserAgreement != null)
                    hashCode = hashCode * 59 + this.UserAgreement.GetHashCode();
                if (this.AgreementText != null)
                    hashCode = hashCode * 59 + this.AgreementText.GetHashCode();
                if (this.Android != null)
                    hashCode = hashCode * 59 + this.Android.GetHashCode();
                if (this.Ios != null)
                    hashCode = hashCode * 59 + this.Ios.GetHashCode();
                if (this.Office != null)
                    hashCode = hashCode * 59 + this.Office.GetHashCode();
                if (this.Mac != null)
                    hashCode = hashCode * 59 + this.Mac.GetHashCode();
                if (this.Windows != null)
                    hashCode = hashCode * 59 + this.Windows.GetHashCode();
                if (this.AllowCn != null)
                    hashCode = hashCode * 59 + this.AllowCn.GetHashCode();
                if (this.AllowTw != null)
                    hashCode = hashCode * 59 + this.AllowTw.GetHashCode();
                if (this.AllowEn != null)
                    hashCode = hashCode * 59 + this.AllowEn.GetHashCode();
                if (this.Theme != null)
                    hashCode = hashCode * 59 + this.Theme.GetHashCode();
                if (this.ShowProduct != null)
                    hashCode = hashCode * 59 + this.ShowProduct.GetHashCode();
                if (this.ShowHardware != null)
                    hashCode = hashCode * 59 + this.ShowHardware.GetHashCode();
                if (this.ShowLicense != null)
                    hashCode = hashCode * 59 + this.ShowLicense.GetHashCode();
                if (this.ShowCopyright != null)
                    hashCode = hashCode * 59 + this.ShowCopyright.GetHashCode();
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