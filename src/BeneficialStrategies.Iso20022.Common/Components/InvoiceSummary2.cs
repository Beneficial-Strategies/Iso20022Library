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
/// Summary information about the sale
/// </summary>
[IsoId("_BzO2McWkEeuhguwJmlgagQ")]
[DisplayName("Invoice Summary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceSummary2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_B3u7scWkEeuhguwJmlgagQ")]
    [DisplayName("Invoice Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcNb")]
    #endif
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? InvoiceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InvoiceNumber { get; init; } 
    #else
    public System.String? InvoiceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Supplier or the provider of the goods or services.
    /// </summary>
    [IsoId("_B3u7s8WkEeuhguwJmlgagQ")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification259? Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification259? Seller { get; init; } 
    #else
    public PartyIdentification259? Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Buyer or company buying the goods or services.
    /// </summary>
    [IsoId("_B3u7tcWkEeuhguwJmlgagQ")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification259? Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification259? Buyer { get; init; } 
    #else
    public PartyIdentification259? Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Effective billing date.
    /// </summary>
    [IsoId("_B3u7t8WkEeuhguwJmlgagQ")]
    [DisplayName("Invoice Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcDt")]
    #endif
    [IsoXmlTag("InvcDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InvoiceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InvoiceDate { get; init; } 
    #else
    public System.DateOnly? InvoiceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the date and time the electronic invoice was created.
    /// </summary>
    [IsoId("_B3u7ucWkEeuhguwJmlgagQ")]
    [DisplayName("Invoice Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcCreDtTm")]
    #endif
    [IsoXmlTag("InvcCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? InvoiceCreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? InvoiceCreationDateTime { get; init; } 
    #else
    public System.DateTime? InvoiceCreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_B3u7u8WkEeuhguwJmlgagQ")]
    [DisplayName("Summary Commodity Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryCmmdtyId")]
    #endif
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SummaryCommodityIdentification { get; init; } 
    #else
    public System.String? SummaryCommodityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the freight charges for the entire purchase. 
    /// </summary>
    [IsoId("_B3u7vcWkEeuhguwJmlgagQ")]
    [DisplayName("Freight Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrghtAmt")]
    #endif
    [IsoXmlTag("FrghtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? FreightAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? FreightAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? FreightAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the total tax amount for the entire purchase. 
    /// </summary>
    [IsoId("_B3u7v8WkEeuhguwJmlgagQ")]
    [DisplayName("Tax Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTtl")]
    #endif
    [IsoXmlTag("TaxTtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax39? TaxTotal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax39? TaxTotal { get; init; } 
    #else
    public Tax39? TaxTotal { get; set; } 
    #endif
    
    /// <summary>
    /// Code that identifies the disposition of the tax reclaim invoice.
    /// </summary>
    [IsoId("_B3u7wcWkEeuhguwJmlgagQ")]
    [DisplayName("Tax Reclaim Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRclmMtd")]
    #endif
    [IsoXmlTag("TaxRclmMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReclaimMethod1Code? TaxReclaimMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReclaimMethod1Code? TaxReclaimMethod { get; init; } 
    #else
    public TaxReclaimMethod1Code? TaxReclaimMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional details.
    /// </summary>
    [IsoId("_B3u7w8WkEeuhguwJmlgagQ")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
