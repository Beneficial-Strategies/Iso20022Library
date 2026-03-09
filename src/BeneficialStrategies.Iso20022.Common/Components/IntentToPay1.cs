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
/// Specifies the details of an intention to pay based on purchase orders or commercial invoice.
/// </summary>
[IsoId("_PzEVSdp-Ed-ak6NoX_4Aeg_-1491388962")]
[DisplayName("Intent To Pay")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntentToPay1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntentToPay1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntentToPay1( ReportLine3 reqByPurchaseOrder,ReportLine4 reqByCommercialInvoice,System.DateOnly reqExpectedPaymentDate )
    {
        ByPurchaseOrder = reqByPurchaseOrder;
        ByCommercialInvoice = reqByCommercialInvoice;
        ExpectedPaymentDate = reqExpectedPaymentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The intention to pay is based on a purchase order.
    /// </summary>
    [IsoId("_PzEVStp-Ed-ak6NoX_4Aeg_1426935583")]
    [DisplayName("By Purchase Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ByPurchsOrdr")]
    #endif
    [IsoXmlTag("ByPurchsOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportLine3 ByPurchaseOrder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportLine3 ByPurchaseOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportLine3 ByPurchaseOrder { get; init; } 
    #else
    public ReportLine3 ByPurchaseOrder { get; set; } 
    #endif
    
    /// <summary>
    /// The intention to pay is based on a commercial invoice.
    /// </summary>
    [IsoId("_PzEVS9p-Ed-ak6NoX_4Aeg_1432476294")]
    [DisplayName("By Commercial Invoice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ByComrclInvc")]
    #endif
    [IsoXmlTag("ByComrclInvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportLine4 ByCommercialInvoice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportLine4 ByCommercialInvoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportLine4 ByCommercialInvoice { get; init; } 
    #else
    public ReportLine4 ByCommercialInvoice { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the payment would be effected.
    /// </summary>
    [IsoId("_PzEVTNp-Ed-ak6NoX_4Aeg_-1088733127")]
    [DisplayName("Expected Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdPmtDt")]
    #endif
    [IsoXmlTag("XpctdPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ExpectedPaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ExpectedPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ExpectedPaymentDate { get; init; } 
    #else
    public System.DateOnly ExpectedPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the beneficiary&apos;s account information.
    /// </summary>
    [IsoId("_PzOGQNp-Ed-ak6NoX_4Aeg_-1728337681")]
    [DisplayName("Settlement Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTerms")]
    #endif
    [IsoXmlTag("SttlmTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTerms2? SettlementTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTerms2? SettlementTerms { get; init; } 
    #else
    public SettlementTerms2? SettlementTerms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
