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
/// Information about a payment against a commercial invoice.
/// </summary>
[IsoId("_Tn5Ry9p-Ed-ak6NoX_4Aeg_-104260942")]
[DisplayName("Report Line")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportLine4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportLine4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportLine4( InvoiceIdentification1 reqCommercialDocumentReference,CurrencyAndAmount reqNetAmount )
    {
        CommercialDocumentReference = reqCommercialDocumentReference;
        NetAmount = reqNetAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the underlying commercial document.
    /// </summary>
    [IsoId("_ToDCwNp-Ed-ak6NoX_4Aeg_-104260933")]
    [DisplayName("Commercial Document Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclDocRef")]
    #endif
    [IsoXmlTag("ComrclDocRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    #else
    public InvoiceIdentification1 CommercialDocumentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    [IsoId("_ToDCwdp-Ed-ak6NoX_4Aeg_1409515872")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment4? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment4? Adjustment { get; init; } 
    #else
    public Adjustment4? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    [IsoId("_ToDCwtp-Ed-ak6NoX_4Aeg_-104260900")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount NetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount NetAmount { get; init; } 
    #else
    public CurrencyAndAmount NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the net amount to be paid is related to different purchase orders.
    /// </summary>
    [IsoId("_ToDCw9p-Ed-ak6NoX_4Aeg_202348166")]
    [DisplayName("Breakdown By Purchase Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkdwnByPurchsOrdr")]
    #endif
    [IsoXmlTag("BrkdwnByPurchsOrdr")]
    public ValueList<ReportLine2> BreakdownByPurchaseOrder { get; init; } = new ValueList<ReportLine2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ToDCw9p-Ed-ak6NoX_4Aeg_202348166
    
    
    #nullable disable
    
}
