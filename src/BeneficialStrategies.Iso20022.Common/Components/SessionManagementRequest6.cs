// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of session management service to be used with this message.
/// </summary>
[IsoId("_flbWgXJKEe299ZbWCkdR_w")]
[DisplayName("Session Management Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SessionManagementRequest6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SessionManagementRequest6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SessionManagementRequest6( CardPaymentEnvironment79 reqEnvironment,CardPaymentContext30 reqContext,RetailerService4Code reqServiceContent )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        ServiceContent = reqServiceContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ftHS4XJKEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment79 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment79 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment79 Environment { get; init; } 
    #else
    public CardPaymentEnvironment79 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_ftHS43JKEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext30 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext30 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext30 Context { get; init; } 
    #else
    public CardPaymentContext30 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_ftHS5XJKEe299ZbWCkdR_w")]
    [DisplayName("Service Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCntt")]
    #endif
    [IsoXmlTag("SvcCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService4Code ServiceContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerService4Code ServiceContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService4Code ServiceContent { get; init; } 
    #else
    public RetailerService4Code ServiceContent { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Login Request message.
    /// </summary>
    [IsoId("_ftHS53JKEe299ZbWCkdR_w")]
    [DisplayName("Login Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LgnReq")]
    #endif
    [IsoXmlTag("LgnReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoginRequest5? LoginRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoginRequest5? LoginRequest { get; init; } 
    #else
    public LoginRequest5? LoginRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Logout Request message.
    /// </summary>
    [IsoId("_ftHS6XJKEe299ZbWCkdR_w")]
    [DisplayName("Logout Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LgtReq")]
    #endif
    [IsoXmlTag("LgtReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LogoutRequest1? LogoutRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LogoutRequest1? LogoutRequest { get; init; } 
    #else
    public LogoutRequest1? LogoutRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Diagnosis Request message.
    /// </summary>
    [IsoId("_ftHS63JKEe299ZbWCkdR_w")]
    [DisplayName("Diagnosis Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgnssReq")]
    #endif
    [IsoXmlTag("DgnssReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DiagnosisRequest1? DiagnosisRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DiagnosisRequest1? DiagnosisRequest { get; init; } 
    #else
    public DiagnosisRequest1? DiagnosisRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_ftHS7XJKEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
