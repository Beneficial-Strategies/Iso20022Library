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
/// This component define the type of admin service to be used with this message.
/// </summary>
[IsoId("_OOb0YYYBEemxIqbaFEE8-w")]
[DisplayName("Session Management Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SessionManagementResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SessionManagementResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SessionManagementResponse2( CardPaymentEnvironment73 reqEnvironment,CardPaymentContext27 reqContext,RetailerService5Code reqServiceContent,ResponseType9 reqResponse )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        ServiceContent = reqServiceContent;
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_OYyqQYYBEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment73 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment73 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment73 Environment { get; init; } 
    #else
    public CardPaymentEnvironment73 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_OYyqQ4YBEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext27 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext27 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext27 Context { get; init; } 
    #else
    public CardPaymentContext27 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_OYyqRYYBEemxIqbaFEE8-w")]
    [DisplayName("Service Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCntt")]
    #endif
    [IsoXmlTag("SvcCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService5Code ServiceContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerService5Code ServiceContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService5Code ServiceContent { get; init; } 
    #else
    public RetailerService5Code ServiceContent { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Login Response message.
    /// </summary>
    [IsoId("_OYyqR4YBEemxIqbaFEE8-w")]
    [DisplayName("Login Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LgnRspn")]
    #endif
    [IsoXmlTag("LgnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoginResponse1? LoginResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoginResponse1? LoginResponse { get; init; } 
    #else
    public LoginResponse1? LoginResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Diagnosis Response message.
    /// </summary>
    [IsoId("_OYyqSYYBEemxIqbaFEE8-w")]
    [DisplayName("Diagnosis Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgnssRspn")]
    #endif
    [IsoXmlTag("DgnssRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DiagnosisResponse1? DiagnosisResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DiagnosisResponse1? DiagnosisResponse { get; init; } 
    #else
    public DiagnosisResponse1? DiagnosisResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_OYyqS4YBEemxIqbaFEE8-w")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType9 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType9 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType9 Response { get; init; } 
    #else
    public ResponseType9 Response { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_OYyqTYYBEemxIqbaFEE8-w")]
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
