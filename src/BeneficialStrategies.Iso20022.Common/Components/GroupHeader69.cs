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
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_w_FwIVnLEeOQYsoJizpkVw")]
[DisplayName("Group Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GroupHeader69
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GroupHeader69 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GroupHeader69( System.String reqIdentification,System.DateOnly reqIssuedDate,ExternalDocumentType1Code reqReportCategory,ExternalDocumentType1Code reqTaxReportPurpose )
    {
        Identification = reqIdentification;
        IssuedDate = reqIssuedDate;
        ReportCategory = reqReportCategory;
        TaxReportPurpose = reqTaxReportPurpose;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Report identification, for example invoice number or report number from point of sales system.
    /// </summary>
    [IsoId("_xLvFAVnLEeOQYsoJizpkVw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the status report was created.
    /// </summary>
    [IsoId("_xLvFBVnLEeOQYsoJizpkVw")]
    [DisplayName("Issued Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssdDt")]
    #endif
    [IsoXmlTag("IssdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate IssuedDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly IssuedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly IssuedDate { get; init; } 
    #else
    public System.DateOnly IssuedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the report is based on debit invoice, credit invoice, card transaction or cash transaction.
    /// </summary>
    [IsoId("_QUuWQFnMEeOQYsoJizpkVw")]
    [DisplayName("Report Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptCtgy")]
    #endif
    [IsoXmlTag("RptCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentType1Code ReportCategory { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentType1Code ReportCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentType1Code ReportCategory { get; init; } 
    #else
    public ExternalDocumentType1Code ReportCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the TaxReport is new, correction or remove.
    /// </summary>
    [IsoId("_Dn1M4FnMEeOQYsoJizpkVw")]
    [DisplayName("Tax Report Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRptPurp")]
    #endif
    [IsoXmlTag("TaxRptPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentType1Code TaxReportPurpose { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentType1Code TaxReportPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentType1Code TaxReportPurpose { get; init; } 
    #else
    public ExternalDocumentType1Code TaxReportPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Original tax report identification, used for example original invoice number with credit notes.
    /// </summary>
    [IsoId("_e6lMYFnMEeOQYsoJizpkVw")]
    [DisplayName("Original Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlId")]
    #endif
    [IsoXmlTag("OrgnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalIdentification { get; init; } 
    #else
    public System.String? OriginalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details of tax representative. The corporate (seller) is allowed to use a tax representative for value added tax responsibilities in case the seller is not registered in a specific value added tax registry.
    /// </summary>
    [IsoId("_ocsb0FnMEeOQYsoJizpkVw")]
    [DisplayName("Seller Tax Representative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrTaxRprtv")]
    #endif
    [IsoXmlTag("SellrTaxRprtv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification116? SellerTaxRepresentative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification116? SellerTaxRepresentative { get; init; } 
    #else
    public PartyIdentification116? SellerTaxRepresentative { get; set; } 
    #endif
    
    /// <summary>
    /// Details of tax representative. The corporate (buyer) is allowed to use a tax representative for value added tax responsibilities in case the buyer is not registered in a specific value added tax registry.
    /// </summary>
    [IsoId("_t4-eUFnMEeOQYsoJizpkVw")]
    [DisplayName("Buyer Tax Representative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrTaxRprtv")]
    #endif
    [IsoXmlTag("BuyrTaxRprtv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification116? BuyerTaxRepresentative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification116? BuyerTaxRepresentative { get; init; } 
    #else
    public PartyIdentification116? BuyerTaxRepresentative { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the language used in the message.
    /// </summary>
    [IsoId("_yQ0oUFnMEeOQYsoJizpkVw")]
    [DisplayName("Language Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LangCd")]
    #endif
    [IsoXmlTag("LangCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? LanguageCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LanguageCode { get; init; } 
    #else
    public string? LanguageCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
