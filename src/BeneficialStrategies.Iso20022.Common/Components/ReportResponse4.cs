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
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
[IsoId("_g59rYS5LEeunNvJlR_vCbg")]
[DisplayName("Report Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportResponse4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportResponse4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportResponse4( CardPaymentEnvironment77 reqEnvironment,CardPaymentContext28 reqContext,RetailerService7Code reqServiceContent,ResponseType11 reqResponse )
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
    [IsoId("_hIRNIS5LEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment77 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment77 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment77 Environment { get; init; } 
    #else
    public CardPaymentEnvironment77 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_hIRNIy5LEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext28 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext28 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext28 Context { get; init; } 
    #else
    public CardPaymentContext28 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_hIRNJS5LEeunNvJlR_vCbg")]
    [DisplayName("Service Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCntt")]
    #endif
    [IsoXmlTag("SvcCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService7Code ServiceContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerService7Code ServiceContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService7Code ServiceContent { get; init; } 
    #else
    public RetailerService7Code ServiceContent { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Transaction Report Response message.
    /// </summary>
    [IsoId("_hIRNJy5LEeunNvJlR_vCbg")]
    [DisplayName("Report Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptTxRspn")]
    #endif
    [IsoXmlTag("RptTxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportTransactionResponse3? ReportTransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportTransactionResponse3? ReportTransactionResponse { get; init; } 
    #else
    public ReportTransactionResponse3? ReportTransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    [IsoId("_hIRNKS5LEeunNvJlR_vCbg")]
    [DisplayName("Report Get Totals Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptGetTtlsRspn")]
    #endif
    [IsoXmlTag("RptGetTtlsRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; init; } 
    #else
    public ReportGetTotalsResponse1? ReportGetTotalsResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_hIRNKy5LEeunNvJlR_vCbg")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType11 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType11 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType11 Response { get; init; } 
    #else
    public ResponseType11 Response { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_hIRNLS5LEeunNvJlR_vCbg")]
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
