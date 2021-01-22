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
    /// Auth1GetconfigRes
    /// </summary>
    [DataContract]
    public partial class Auth1GetconfigRes :  IEquatable<Auth1GetconfigRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth1GetconfigRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigRes" /> class.
        /// </summary>
        /// <param name="apiVersion">API版本，如6.0.8    当前主版本为6；    当前次版本从0开始，若次版本发生变化，则意味着本版本的API不再向下兼容；    当小版本的格式发生变化，代表服务端升级，但API仍然向下兼容。 (required).</param>
        /// <param name="autoLockRemind">是否开启文件锁提醒，默认开启 (required).</param>
        /// <param name="cadPluginThreshold">浩辰CAD使用大图插件的临界值 (required).</param>
        /// <param name="csfLevelEnum">密级枚举信息 (required).</param>
        /// <param name="deviceInfo">deviceInfo (required).</param>
        /// <param name="dualfactorAuthServerStatus">dualfactorAuthServerStatus (required).</param>
        /// <param name="enableDocComment">是否开启文件评论功能 (required).</param>
        /// <param name="enableDocDueRemind">是否开启文件到期提醒 (required).</param>
        /// <param name="enableExitPwd">是否使用退出口令 (required).</param>
        /// <param name="enableInvitationShare">是否开启共享邀请链接  true表示开启  false表示关闭 (required).</param>
        /// <param name="enableLinkAccessCode">是否启用提取码 true表示启用 false 表示不启用 (required).</param>
        /// <param name="enableMessageNotify">是否启用消息通知功能 (required).</param>
        /// <param name="enableOutlinkWatermark">是否允许用户设置外链水印 (required).</param>
        /// <param name="enableSecretMode">是否开启涉密模式  true表示开启  false表示关闭 (required).</param>
        /// <param name="enableSetFolderSecurityLevel">是否允许设置文件夹密级 (required).</param>
        /// <param name="enableStrongPwd">是否开启强密码配置 (required).</param>
        /// <param name="entrydocViewConfig">Default: 2 返回入口文档视图模式 1 代表旧视图 2 代表新视图（默认） (required).</param>
        /// <param name="extapp">extapp (required).</param>
        /// <param name="fileCrawlStatus">是否开启文件抓取 (required).</param>
        /// <param name="forbidOstype">按bit位计算  IOS &#x3D; 1  ANDROID &#x3D; 2  WINDOWSPHONE &#x3D; 3  WINDOWS &#x3D; 4  MACOSX &#x3D; 5  WEB &#x3D; 6  MOBILEWEB &#x3D; 7 (required).</param>
        /// <param name="https">客户端是否使用https (required).</param>
        /// <param name="idCardLoginStatus">是否使用身份证登录 (required).</param>
        /// <param name="internalLinkPrefix">内链地址的前缀 (required).</param>
        /// <param name="limitRateConfig">limitRateConfig (required).</param>
        /// <param name="onlyShareToUser">是否只允许共享给用户 (required).</param>
        /// <param name="serverVersion">服务器版本信息 (required).</param>
        /// <param name="showKnowledgePage">是否显示知识主页 (required).</param>
        /// <param name="strongPwdLength">强密码最小长度 (required).</param>
        /// <param name="tagMaxNum">标签的最大数量 (required).</param>
        /// <param name="thirdPwdModifyUrl">第三方用户密码修改地址 (required).</param>
        /// <param name="vcodeLoginConfig">vcodeLoginConfig (required).</param>
        /// <param name="windowsAdSso">windowsAdSso (required).</param>
        /// <param name="thirdauth">thirdauth.</param>
        /// <param name="thirdCsfsysConfig">thirdCsfsysConfig.</param>
        /// <param name="customeApplicationConfig">定制化的客户应用配置，用于给客户端做定制化功能的开关，格式为Json字符串。如：{\&quot;appid\&quot;: \&quot;CUFE\&quot;}.</param>
        /// <param name="oemconfig">oemconfig (required).</param>
        /// <param name="smtpServerExists">SMTP服务器是否配置 (required).</param>
        public Auth1GetconfigRes(string apiVersion = default(string), bool? autoLockRemind = default(bool?), long? cadPluginThreshold = default(long?), Object csfLevelEnum = default(Object), Auth1GetconfigResDeviceinfo deviceInfo = default(Auth1GetconfigResDeviceinfo), Auth1GetconfigResDualfactorauthserverstatus dualfactorAuthServerStatus = default(Auth1GetconfigResDualfactorauthserverstatus), bool? enableDocComment = default(bool?), bool? enableDocDueRemind = default(bool?), bool? enableExitPwd = default(bool?), bool? enableInvitationShare = default(bool?), bool? enableLinkAccessCode = default(bool?), bool? enableMessageNotify = default(bool?), bool? enableOutlinkWatermark = default(bool?), bool? enableSecretMode = default(bool?), bool? enableSetFolderSecurityLevel = default(bool?), bool? enableStrongPwd = default(bool?), long? entrydocViewConfig = default(long?), Auth1GetconfigResExtapp extapp = default(Auth1GetconfigResExtapp), bool? fileCrawlStatus = default(bool?), string forbidOstype = default(string), bool? https = default(bool?), bool? idCardLoginStatus = default(bool?), string internalLinkPrefix = default(string), Auth1GetconfigResLimitrateconfig limitRateConfig = default(Auth1GetconfigResLimitrateconfig), bool? onlyShareToUser = default(bool?), string serverVersion = default(string), long? showKnowledgePage = default(long?), long? strongPwdLength = default(long?), long? tagMaxNum = default(long?), string thirdPwdModifyUrl = default(string), Auth1GetconfigResVcodelonginconfig vcodeLoginConfig = default(Auth1GetconfigResVcodelonginconfig), Auth1GetconfigResWindowsadsso windowsAdSso = default(Auth1GetconfigResWindowsadsso), Auth1GetconfigResThirdauth thirdauth = default(Auth1GetconfigResThirdauth), Auth1GetconfigResThirdcsfsysconfig thirdCsfsysConfig = default(Auth1GetconfigResThirdcsfsysconfig), string customeApplicationConfig = default(string), Auth1GetconfigResOemconfig oemconfig = default(Auth1GetconfigResOemconfig), bool? smtpServerExists = default(bool?))
        {
            this.ApiVersion = apiVersion;
            this.AutoLockRemind = autoLockRemind;
            this.CadPluginThreshold = cadPluginThreshold;
            this.CsfLevelEnum = csfLevelEnum;
            this.DeviceInfo = deviceInfo;
            this.DualfactorAuthServerStatus = dualfactorAuthServerStatus;
            this.EnableDocComment = enableDocComment;
            this.EnableDocDueRemind = enableDocDueRemind;
            this.EnableExitPwd = enableExitPwd;
            this.EnableInvitationShare = enableInvitationShare;
            this.EnableLinkAccessCode = enableLinkAccessCode;
            this.EnableMessageNotify = enableMessageNotify;
            this.EnableOutlinkWatermark = enableOutlinkWatermark;
            this.EnableSecretMode = enableSecretMode;
            this.EnableSetFolderSecurityLevel = enableSetFolderSecurityLevel;
            this.EnableStrongPwd = enableStrongPwd;
            this.EntrydocViewConfig = entrydocViewConfig;
            this.Extapp = extapp;
            this.FileCrawlStatus = fileCrawlStatus;
            this.ForbidOstype = forbidOstype;
            this.Https = https;
            this.IdCardLoginStatus = idCardLoginStatus;
            this.InternalLinkPrefix = internalLinkPrefix;
            this.LimitRateConfig = limitRateConfig;
            this.OnlyShareToUser = onlyShareToUser;
            this.ServerVersion = serverVersion;
            this.ShowKnowledgePage = showKnowledgePage;
            this.StrongPwdLength = strongPwdLength;
            this.TagMaxNum = tagMaxNum;
            this.ThirdPwdModifyUrl = thirdPwdModifyUrl;
            this.VcodeLoginConfig = vcodeLoginConfig;
            this.WindowsAdSso = windowsAdSso;
            this.Oemconfig = oemconfig;
            this.SmtpServerExists = smtpServerExists;
            this.Thirdauth = thirdauth;
            this.ThirdCsfsysConfig = thirdCsfsysConfig;
            this.CustomeApplicationConfig = customeApplicationConfig;
        }
        
        /// <summary>
        /// API版本，如6.0.8    当前主版本为6；    当前次版本从0开始，若次版本发生变化，则意味着本版本的API不再向下兼容；    当小版本的格式发生变化，代表服务端升级，但API仍然向下兼容。
        /// </summary>
        /// <value>API版本，如6.0.8    当前主版本为6；    当前次版本从0开始，若次版本发生变化，则意味着本版本的API不再向下兼容；    当小版本的格式发生变化，代表服务端升级，但API仍然向下兼容。</value>
        [DataMember(Name="api_version", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 是否开启文件锁提醒，默认开启
        /// </summary>
        /// <value>是否开启文件锁提醒，默认开启</value>
        [DataMember(Name="auto_lock_remind", EmitDefaultValue=false)]
        public bool? AutoLockRemind { get; set; }

        /// <summary>
        /// 浩辰CAD使用大图插件的临界值
        /// </summary>
        /// <value>浩辰CAD使用大图插件的临界值</value>
        [DataMember(Name="cad_plugin_threshold", EmitDefaultValue=false)]
        public long? CadPluginThreshold { get; set; }

        /// <summary>
        /// 密级枚举信息
        /// </summary>
        /// <value>密级枚举信息</value>
        [DataMember(Name="csf_level_enum", EmitDefaultValue=false)]
        public Object CsfLevelEnum { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInfo
        /// </summary>
        [DataMember(Name="device_info", EmitDefaultValue=false)]
        public Auth1GetconfigResDeviceinfo DeviceInfo { get; set; }

        /// <summary>
        /// Gets or Sets DualfactorAuthServerStatus
        /// </summary>
        [DataMember(Name="dualfactor_auth_server_status", EmitDefaultValue=false)]
        public Auth1GetconfigResDualfactorauthserverstatus DualfactorAuthServerStatus { get; set; }

        /// <summary>
        /// 是否开启文件评论功能
        /// </summary>
        /// <value>是否开启文件评论功能</value>
        [DataMember(Name="enable_doc_comment", EmitDefaultValue=false)]
        public bool? EnableDocComment { get; set; }

        /// <summary>
        /// 是否开启文件到期提醒
        /// </summary>
        /// <value>是否开启文件到期提醒</value>
        [DataMember(Name="enable_doc_due_remind", EmitDefaultValue=false)]
        public bool? EnableDocDueRemind { get; set; }

        /// <summary>
        /// 是否使用退出口令
        /// </summary>
        /// <value>是否使用退出口令</value>
        [DataMember(Name="enable_exit_pwd", EmitDefaultValue=false)]
        public bool? EnableExitPwd { get; set; }

        /// <summary>
        /// 是否开启共享邀请链接  true表示开启  false表示关闭
        /// </summary>
        /// <value>是否开启共享邀请链接  true表示开启  false表示关闭</value>
        [DataMember(Name="enable_invitation_share", EmitDefaultValue=false)]
        public bool? EnableInvitationShare { get; set; }

        /// <summary>
        /// 是否启用提取码 true表示启用 false 表示不启用
        /// </summary>
        /// <value>是否启用提取码 true表示启用 false 表示不启用</value>
        [DataMember(Name="enable_link_access_code", EmitDefaultValue=false)]
        public bool? EnableLinkAccessCode { get; set; }

        /// <summary>
        /// 是否启用消息通知功能
        /// </summary>
        /// <value>是否启用消息通知功能</value>
        [DataMember(Name="enable_message_notify", EmitDefaultValue=false)]
        public bool? EnableMessageNotify { get; set; }

        /// <summary>
        /// 是否允许用户设置外链水印
        /// </summary>
        /// <value>是否允许用户设置外链水印</value>
        [DataMember(Name="enable_outlink_watermark", EmitDefaultValue=false)]
        public bool? EnableOutlinkWatermark { get; set; }

        /// <summary>
        /// 是否开启涉密模式  true表示开启  false表示关闭
        /// </summary>
        /// <value>是否开启涉密模式  true表示开启  false表示关闭</value>
        [DataMember(Name="enable_secret_mode", EmitDefaultValue=false)]
        public bool? EnableSecretMode { get; set; }

        /// <summary>
        /// 是否允许设置文件夹密级
        /// </summary>
        /// <value>是否允许设置文件夹密级</value>
        [DataMember(Name="enable_set_folder_security_level", EmitDefaultValue=false)]
        public bool? EnableSetFolderSecurityLevel { get; set; }

        /// <summary>
        /// 是否开启强密码配置
        /// </summary>
        /// <value>是否开启强密码配置</value>
        [DataMember(Name="enable_strong_pwd", EmitDefaultValue=false)]
        public bool? EnableStrongPwd { get; set; }

        /// <summary>
        /// Default: 2 返回入口文档视图模式 1 代表旧视图 2 代表新视图（默认）
        /// </summary>
        /// <value>Default: 2 返回入口文档视图模式 1 代表旧视图 2 代表新视图（默认）</value>
        [DataMember(Name="entrydoc_view_config", EmitDefaultValue=false)]
        public long? EntrydocViewConfig { get; set; }

        /// <summary>
        /// Gets or Sets Extapp
        /// </summary>
        [DataMember(Name="extapp", EmitDefaultValue=false)]
        public Auth1GetconfigResExtapp Extapp { get; set; }

        /// <summary>
        /// 是否开启文件抓取
        /// </summary>
        /// <value>是否开启文件抓取</value>
        [DataMember(Name="file_crawl_status", EmitDefaultValue=false)]
        public bool? FileCrawlStatus { get; set; }

        /// <summary>
        /// 按bit位计算  IOS &#x3D; 1  ANDROID &#x3D; 2  WINDOWSPHONE &#x3D; 3  WINDOWS &#x3D; 4  MACOSX &#x3D; 5  WEB &#x3D; 6  MOBILEWEB &#x3D; 7
        /// </summary>
        /// <value>按bit位计算  IOS &#x3D; 1  ANDROID &#x3D; 2  WINDOWSPHONE &#x3D; 3  WINDOWS &#x3D; 4  MACOSX &#x3D; 5  WEB &#x3D; 6  MOBILEWEB &#x3D; 7</value>
        [DataMember(Name="forbid_ostype", EmitDefaultValue=false)]
        public string ForbidOstype { get; set; }

        /// <summary>
        /// 客户端是否使用https
        /// </summary>
        /// <value>客户端是否使用https</value>
        [DataMember(Name="https", EmitDefaultValue=false)]
        public bool? Https { get; set; }

        /// <summary>
        /// 是否使用身份证登录
        /// </summary>
        /// <value>是否使用身份证登录</value>
        [DataMember(Name="id_card_login_status", EmitDefaultValue=false)]
        public bool? IdCardLoginStatus { get; set; }

        /// <summary>
        /// 内链地址的前缀
        /// </summary>
        /// <value>内链地址的前缀</value>
        [DataMember(Name="internal_link_prefix", EmitDefaultValue=false)]
        public string InternalLinkPrefix { get; set; }

        /// <summary>
        /// Gets or Sets LimitRateConfig
        /// </summary>
        [DataMember(Name="limit_rate_config", EmitDefaultValue=false)]
        public Auth1GetconfigResLimitrateconfig LimitRateConfig { get; set; }

        /// <summary>
        /// 是否只允许共享给用户
        /// </summary>
        /// <value>是否只允许共享给用户</value>
        [DataMember(Name="only_share_to_user", EmitDefaultValue=false)]
        public bool? OnlyShareToUser { get; set; }

        /// <summary>
        /// 服务器版本信息
        /// </summary>
        /// <value>服务器版本信息</value>
        [DataMember(Name="server_version", EmitDefaultValue=false)]
        public string ServerVersion { get; set; }

        /// <summary>
        /// 是否显示知识主页
        /// </summary>
        /// <value>是否显示知识主页</value>
        [DataMember(Name="show_knowledge_page", EmitDefaultValue=false)]
        public long? ShowKnowledgePage { get; set; }

        /// <summary>
        /// 强密码最小长度
        /// </summary>
        /// <value>强密码最小长度</value>
        [DataMember(Name="strong_pwd_length", EmitDefaultValue=false)]
        public long? StrongPwdLength { get; set; }

        /// <summary>
        /// 标签的最大数量
        /// </summary>
        /// <value>标签的最大数量</value>
        [DataMember(Name="tag_max_num", EmitDefaultValue=false)]
        public long? TagMaxNum { get; set; }

        /// <summary>
        /// 第三方用户密码修改地址
        /// </summary>
        /// <value>第三方用户密码修改地址</value>
        [DataMember(Name="third_pwd_modify_url", EmitDefaultValue=false)]
        public string ThirdPwdModifyUrl { get; set; }

        /// <summary>
        /// Gets or Sets VcodeLoginConfig
        /// </summary>
        [DataMember(Name="vcode_login_config", EmitDefaultValue=false)]
        public Auth1GetconfigResVcodelonginconfig VcodeLoginConfig { get; set; }

        /// <summary>
        /// Gets or Sets WindowsAdSso
        /// </summary>
        [DataMember(Name="windows_ad_sso", EmitDefaultValue=false)]
        public Auth1GetconfigResWindowsadsso WindowsAdSso { get; set; }

        /// <summary>
        /// Gets or Sets Thirdauth
        /// </summary>
        [DataMember(Name="thirdauth", EmitDefaultValue=false)]
        public Auth1GetconfigResThirdauth Thirdauth { get; set; }

        /// <summary>
        /// Gets or Sets ThirdCsfsysConfig
        /// </summary>
        [DataMember(Name="third_csfsys_config", EmitDefaultValue=false)]
        public Auth1GetconfigResThirdcsfsysconfig ThirdCsfsysConfig { get; set; }

        /// <summary>
        /// 定制化的客户应用配置，用于给客户端做定制化功能的开关，格式为Json字符串。如：{\&quot;appid\&quot;: \&quot;CUFE\&quot;}
        /// </summary>
        /// <value>定制化的客户应用配置，用于给客户端做定制化功能的开关，格式为Json字符串。如：{\&quot;appid\&quot;: \&quot;CUFE\&quot;}</value>
        [DataMember(Name="custome_application_config", EmitDefaultValue=false)]
        public string CustomeApplicationConfig { get; set; }

        /// <summary>
        /// Gets or Sets Oemconfig
        /// </summary>
        [DataMember(Name="oemconfig", EmitDefaultValue=false)]
        public Auth1GetconfigResOemconfig Oemconfig { get; set; }

        /// <summary>
        /// SMTP服务器是否配置
        /// </summary>
        /// <value>SMTP服务器是否配置</value>
        [DataMember(Name="smtp_server_exists", EmitDefaultValue=false)]
        public bool? SmtpServerExists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1GetconfigRes {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  AutoLockRemind: ").Append(AutoLockRemind).Append("\n");
            sb.Append("  CadPluginThreshold: ").Append(CadPluginThreshold).Append("\n");
            sb.Append("  CsfLevelEnum: ").Append(CsfLevelEnum).Append("\n");
            sb.Append("  DeviceInfo: ").Append(DeviceInfo).Append("\n");
            sb.Append("  DualfactorAuthServerStatus: ").Append(DualfactorAuthServerStatus).Append("\n");
            sb.Append("  EnableDocComment: ").Append(EnableDocComment).Append("\n");
            sb.Append("  EnableDocDueRemind: ").Append(EnableDocDueRemind).Append("\n");
            sb.Append("  EnableExitPwd: ").Append(EnableExitPwd).Append("\n");
            sb.Append("  EnableInvitationShare: ").Append(EnableInvitationShare).Append("\n");
            sb.Append("  EnableLinkAccessCode: ").Append(EnableLinkAccessCode).Append("\n");
            sb.Append("  EnableMessageNotify: ").Append(EnableMessageNotify).Append("\n");
            sb.Append("  EnableOutlinkWatermark: ").Append(EnableOutlinkWatermark).Append("\n");
            sb.Append("  EnableSecretMode: ").Append(EnableSecretMode).Append("\n");
            sb.Append("  EnableSetFolderSecurityLevel: ").Append(EnableSetFolderSecurityLevel).Append("\n");
            sb.Append("  EnableStrongPwd: ").Append(EnableStrongPwd).Append("\n");
            sb.Append("  EntrydocViewConfig: ").Append(EntrydocViewConfig).Append("\n");
            sb.Append("  Extapp: ").Append(Extapp).Append("\n");
            sb.Append("  FileCrawlStatus: ").Append(FileCrawlStatus).Append("\n");
            sb.Append("  ForbidOstype: ").Append(ForbidOstype).Append("\n");
            sb.Append("  Https: ").Append(Https).Append("\n");
            sb.Append("  IdCardLoginStatus: ").Append(IdCardLoginStatus).Append("\n");
            sb.Append("  InternalLinkPrefix: ").Append(InternalLinkPrefix).Append("\n");
            sb.Append("  LimitRateConfig: ").Append(LimitRateConfig).Append("\n");
            sb.Append("  OnlyShareToUser: ").Append(OnlyShareToUser).Append("\n");
            sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
            sb.Append("  ShowKnowledgePage: ").Append(ShowKnowledgePage).Append("\n");
            sb.Append("  StrongPwdLength: ").Append(StrongPwdLength).Append("\n");
            sb.Append("  TagMaxNum: ").Append(TagMaxNum).Append("\n");
            sb.Append("  ThirdPwdModifyUrl: ").Append(ThirdPwdModifyUrl).Append("\n");
            sb.Append("  VcodeLoginConfig: ").Append(VcodeLoginConfig).Append("\n");
            sb.Append("  WindowsAdSso: ").Append(WindowsAdSso).Append("\n");
            sb.Append("  Thirdauth: ").Append(Thirdauth).Append("\n");
            sb.Append("  ThirdCsfsysConfig: ").Append(ThirdCsfsysConfig).Append("\n");
            sb.Append("  CustomeApplicationConfig: ").Append(CustomeApplicationConfig).Append("\n");
            sb.Append("  Oemconfig: ").Append(Oemconfig).Append("\n");
            sb.Append("  SmtpServerExists: ").Append(SmtpServerExists).Append("\n");
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
            return this.Equals(input as Auth1GetconfigRes);
        }

        /// <summary>
        /// Returns true if Auth1GetconfigRes instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1GetconfigRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1GetconfigRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.AutoLockRemind == input.AutoLockRemind ||
                    (this.AutoLockRemind != null &&
                    this.AutoLockRemind.Equals(input.AutoLockRemind))
                ) && 
                (
                    this.CadPluginThreshold == input.CadPluginThreshold ||
                    (this.CadPluginThreshold != null &&
                    this.CadPluginThreshold.Equals(input.CadPluginThreshold))
                ) && 
                (
                    this.CsfLevelEnum == input.CsfLevelEnum ||
                    (this.CsfLevelEnum != null &&
                    this.CsfLevelEnum.Equals(input.CsfLevelEnum))
                ) && 
                (
                    this.DeviceInfo == input.DeviceInfo ||
                    (this.DeviceInfo != null &&
                    this.DeviceInfo.Equals(input.DeviceInfo))
                ) && 
                (
                    this.DualfactorAuthServerStatus == input.DualfactorAuthServerStatus ||
                    (this.DualfactorAuthServerStatus != null &&
                    this.DualfactorAuthServerStatus.Equals(input.DualfactorAuthServerStatus))
                ) && 
                (
                    this.EnableDocComment == input.EnableDocComment ||
                    (this.EnableDocComment != null &&
                    this.EnableDocComment.Equals(input.EnableDocComment))
                ) && 
                (
                    this.EnableDocDueRemind == input.EnableDocDueRemind ||
                    (this.EnableDocDueRemind != null &&
                    this.EnableDocDueRemind.Equals(input.EnableDocDueRemind))
                ) && 
                (
                    this.EnableExitPwd == input.EnableExitPwd ||
                    (this.EnableExitPwd != null &&
                    this.EnableExitPwd.Equals(input.EnableExitPwd))
                ) && 
                (
                    this.EnableInvitationShare == input.EnableInvitationShare ||
                    (this.EnableInvitationShare != null &&
                    this.EnableInvitationShare.Equals(input.EnableInvitationShare))
                ) && 
                (
                    this.EnableLinkAccessCode == input.EnableLinkAccessCode ||
                    (this.EnableLinkAccessCode != null &&
                    this.EnableLinkAccessCode.Equals(input.EnableLinkAccessCode))
                ) && 
                (
                    this.EnableMessageNotify == input.EnableMessageNotify ||
                    (this.EnableMessageNotify != null &&
                    this.EnableMessageNotify.Equals(input.EnableMessageNotify))
                ) && 
                (
                    this.EnableOutlinkWatermark == input.EnableOutlinkWatermark ||
                    (this.EnableOutlinkWatermark != null &&
                    this.EnableOutlinkWatermark.Equals(input.EnableOutlinkWatermark))
                ) && 
                (
                    this.EnableSecretMode == input.EnableSecretMode ||
                    (this.EnableSecretMode != null &&
                    this.EnableSecretMode.Equals(input.EnableSecretMode))
                ) && 
                (
                    this.EnableSetFolderSecurityLevel == input.EnableSetFolderSecurityLevel ||
                    (this.EnableSetFolderSecurityLevel != null &&
                    this.EnableSetFolderSecurityLevel.Equals(input.EnableSetFolderSecurityLevel))
                ) && 
                (
                    this.EnableStrongPwd == input.EnableStrongPwd ||
                    (this.EnableStrongPwd != null &&
                    this.EnableStrongPwd.Equals(input.EnableStrongPwd))
                ) && 
                (
                    this.EntrydocViewConfig == input.EntrydocViewConfig ||
                    (this.EntrydocViewConfig != null &&
                    this.EntrydocViewConfig.Equals(input.EntrydocViewConfig))
                ) && 
                (
                    this.Extapp == input.Extapp ||
                    (this.Extapp != null &&
                    this.Extapp.Equals(input.Extapp))
                ) && 
                (
                    this.FileCrawlStatus == input.FileCrawlStatus ||
                    (this.FileCrawlStatus != null &&
                    this.FileCrawlStatus.Equals(input.FileCrawlStatus))
                ) && 
                (
                    this.ForbidOstype == input.ForbidOstype ||
                    (this.ForbidOstype != null &&
                    this.ForbidOstype.Equals(input.ForbidOstype))
                ) && 
                (
                    this.Https == input.Https ||
                    (this.Https != null &&
                    this.Https.Equals(input.Https))
                ) && 
                (
                    this.IdCardLoginStatus == input.IdCardLoginStatus ||
                    (this.IdCardLoginStatus != null &&
                    this.IdCardLoginStatus.Equals(input.IdCardLoginStatus))
                ) && 
                (
                    this.InternalLinkPrefix == input.InternalLinkPrefix ||
                    (this.InternalLinkPrefix != null &&
                    this.InternalLinkPrefix.Equals(input.InternalLinkPrefix))
                ) && 
                (
                    this.LimitRateConfig == input.LimitRateConfig ||
                    (this.LimitRateConfig != null &&
                    this.LimitRateConfig.Equals(input.LimitRateConfig))
                ) && 
                (
                    this.OnlyShareToUser == input.OnlyShareToUser ||
                    (this.OnlyShareToUser != null &&
                    this.OnlyShareToUser.Equals(input.OnlyShareToUser))
                ) && 
                (
                    this.ServerVersion == input.ServerVersion ||
                    (this.ServerVersion != null &&
                    this.ServerVersion.Equals(input.ServerVersion))
                ) && 
                (
                    this.ShowKnowledgePage == input.ShowKnowledgePage ||
                    (this.ShowKnowledgePage != null &&
                    this.ShowKnowledgePage.Equals(input.ShowKnowledgePage))
                ) && 
                (
                    this.StrongPwdLength == input.StrongPwdLength ||
                    (this.StrongPwdLength != null &&
                    this.StrongPwdLength.Equals(input.StrongPwdLength))
                ) && 
                (
                    this.TagMaxNum == input.TagMaxNum ||
                    (this.TagMaxNum != null &&
                    this.TagMaxNum.Equals(input.TagMaxNum))
                ) && 
                (
                    this.ThirdPwdModifyUrl == input.ThirdPwdModifyUrl ||
                    (this.ThirdPwdModifyUrl != null &&
                    this.ThirdPwdModifyUrl.Equals(input.ThirdPwdModifyUrl))
                ) && 
                (
                    this.VcodeLoginConfig == input.VcodeLoginConfig ||
                    (this.VcodeLoginConfig != null &&
                    this.VcodeLoginConfig.Equals(input.VcodeLoginConfig))
                ) && 
                (
                    this.WindowsAdSso == input.WindowsAdSso ||
                    (this.WindowsAdSso != null &&
                    this.WindowsAdSso.Equals(input.WindowsAdSso))
                ) && 
                (
                    this.Thirdauth == input.Thirdauth ||
                    (this.Thirdauth != null &&
                    this.Thirdauth.Equals(input.Thirdauth))
                ) && 
                (
                    this.ThirdCsfsysConfig == input.ThirdCsfsysConfig ||
                    (this.ThirdCsfsysConfig != null &&
                    this.ThirdCsfsysConfig.Equals(input.ThirdCsfsysConfig))
                ) && 
                (
                    this.CustomeApplicationConfig == input.CustomeApplicationConfig ||
                    (this.CustomeApplicationConfig != null &&
                    this.CustomeApplicationConfig.Equals(input.CustomeApplicationConfig))
                ) && 
                (
                    this.Oemconfig == input.Oemconfig ||
                    (this.Oemconfig != null &&
                    this.Oemconfig.Equals(input.Oemconfig))
                ) && 
                (
                    this.SmtpServerExists == input.SmtpServerExists ||
                    (this.SmtpServerExists != null &&
                    this.SmtpServerExists.Equals(input.SmtpServerExists))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.AutoLockRemind != null)
                    hashCode = hashCode * 59 + this.AutoLockRemind.GetHashCode();
                if (this.CadPluginThreshold != null)
                    hashCode = hashCode * 59 + this.CadPluginThreshold.GetHashCode();
                if (this.CsfLevelEnum != null)
                    hashCode = hashCode * 59 + this.CsfLevelEnum.GetHashCode();
                if (this.DeviceInfo != null)
                    hashCode = hashCode * 59 + this.DeviceInfo.GetHashCode();
                if (this.DualfactorAuthServerStatus != null)
                    hashCode = hashCode * 59 + this.DualfactorAuthServerStatus.GetHashCode();
                if (this.EnableDocComment != null)
                    hashCode = hashCode * 59 + this.EnableDocComment.GetHashCode();
                if (this.EnableDocDueRemind != null)
                    hashCode = hashCode * 59 + this.EnableDocDueRemind.GetHashCode();
                if (this.EnableExitPwd != null)
                    hashCode = hashCode * 59 + this.EnableExitPwd.GetHashCode();
                if (this.EnableInvitationShare != null)
                    hashCode = hashCode * 59 + this.EnableInvitationShare.GetHashCode();
                if (this.EnableLinkAccessCode != null)
                    hashCode = hashCode * 59 + this.EnableLinkAccessCode.GetHashCode();
                if (this.EnableMessageNotify != null)
                    hashCode = hashCode * 59 + this.EnableMessageNotify.GetHashCode();
                if (this.EnableOutlinkWatermark != null)
                    hashCode = hashCode * 59 + this.EnableOutlinkWatermark.GetHashCode();
                if (this.EnableSecretMode != null)
                    hashCode = hashCode * 59 + this.EnableSecretMode.GetHashCode();
                if (this.EnableSetFolderSecurityLevel != null)
                    hashCode = hashCode * 59 + this.EnableSetFolderSecurityLevel.GetHashCode();
                if (this.EnableStrongPwd != null)
                    hashCode = hashCode * 59 + this.EnableStrongPwd.GetHashCode();
                if (this.EntrydocViewConfig != null)
                    hashCode = hashCode * 59 + this.EntrydocViewConfig.GetHashCode();
                if (this.Extapp != null)
                    hashCode = hashCode * 59 + this.Extapp.GetHashCode();
                if (this.FileCrawlStatus != null)
                    hashCode = hashCode * 59 + this.FileCrawlStatus.GetHashCode();
                if (this.ForbidOstype != null)
                    hashCode = hashCode * 59 + this.ForbidOstype.GetHashCode();
                if (this.Https != null)
                    hashCode = hashCode * 59 + this.Https.GetHashCode();
                if (this.IdCardLoginStatus != null)
                    hashCode = hashCode * 59 + this.IdCardLoginStatus.GetHashCode();
                if (this.InternalLinkPrefix != null)
                    hashCode = hashCode * 59 + this.InternalLinkPrefix.GetHashCode();
                if (this.LimitRateConfig != null)
                    hashCode = hashCode * 59 + this.LimitRateConfig.GetHashCode();
                if (this.OnlyShareToUser != null)
                    hashCode = hashCode * 59 + this.OnlyShareToUser.GetHashCode();
                if (this.ServerVersion != null)
                    hashCode = hashCode * 59 + this.ServerVersion.GetHashCode();
                if (this.ShowKnowledgePage != null)
                    hashCode = hashCode * 59 + this.ShowKnowledgePage.GetHashCode();
                if (this.StrongPwdLength != null)
                    hashCode = hashCode * 59 + this.StrongPwdLength.GetHashCode();
                if (this.TagMaxNum != null)
                    hashCode = hashCode * 59 + this.TagMaxNum.GetHashCode();
                if (this.ThirdPwdModifyUrl != null)
                    hashCode = hashCode * 59 + this.ThirdPwdModifyUrl.GetHashCode();
                if (this.VcodeLoginConfig != null)
                    hashCode = hashCode * 59 + this.VcodeLoginConfig.GetHashCode();
                if (this.WindowsAdSso != null)
                    hashCode = hashCode * 59 + this.WindowsAdSso.GetHashCode();
                if (this.Thirdauth != null)
                    hashCode = hashCode * 59 + this.Thirdauth.GetHashCode();
                if (this.ThirdCsfsysConfig != null)
                    hashCode = hashCode * 59 + this.ThirdCsfsysConfig.GetHashCode();
                if (this.CustomeApplicationConfig != null)
                    hashCode = hashCode * 59 + this.CustomeApplicationConfig.GetHashCode();
                if (this.Oemconfig != null)
                    hashCode = hashCode * 59 + this.Oemconfig.GetHashCode();
                if (this.SmtpServerExists != null)
                    hashCode = hashCode * 59 + this.SmtpServerExists.GetHashCode();
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