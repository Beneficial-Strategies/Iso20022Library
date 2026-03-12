// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_w_FwIVnLEeOQYsoJizpkVw")]
[DisplayName("Group Header")]
public partial record GroupHeader69
{
    #nullable enable
    
    /// <summary>
    /// Report identification, for example invoice number or report number from point of sales system.
    /// </summary>
    [IsoId("_xLvFAVnLEeOQYsoJizpkVw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date at which the status report was created.
    /// </summary>
    [IsoId("_xLvFBVnLEeOQYsoJizpkVw")]
    [DisplayName("Issued Date")]
    [IsoXmlTag("IssdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssuedDate { get; init; } 
    
    /// <summary>
    /// Specifies if the report is based on debit invoice, credit invoice, card transaction or cash transaction.
    /// </summary>
    [IsoId("_QUuWQFnMEeOQYsoJizpkVw")]
    [DisplayName("Report Category")]
    [IsoXmlTag("RptCtgy")]
    public required ExternalDocumentType1Code ReportCategory { get; init; } 
    
    /// <summary>
    /// Specifies if the TaxReport is new, correction or remove.
    /// </summary>
    [IsoId("_Dn1M4FnMEeOQYsoJizpkVw")]
    [DisplayName("Tax Report Purpose")]
    [IsoXmlTag("TaxRptPurp")]
    public required ExternalDocumentType1Code TaxReportPurpose { get; init; } 
    
    /// <summary>
    /// Original tax report identification, used for example original invoice number with credit notes.
    /// </summary>
    [IsoId("_e6lMYFnMEeOQYsoJizpkVw")]
    [DisplayName("Original Identification")]
    [IsoXmlTag("OrgnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalIdentification { get; init; } 
    
    /// <summary>
    /// Details of tax representative. The corporate (seller) is allowed to use a tax representative for value added tax responsibilities in case the seller is not registered in a specific value added tax registry.
    /// </summary>
    [IsoId("_ocsb0FnMEeOQYsoJizpkVw")]
    [DisplayName("Seller Tax Representative")]
    [IsoXmlTag("SellrTaxRprtv")]
    public PartyIdentification116? SellerTaxRepresentative { get; init; } 
    
    /// <summary>
    /// Details of tax representative. The corporate (buyer) is allowed to use a tax representative for value added tax responsibilities in case the buyer is not registered in a specific value added tax registry.
    /// </summary>
    [IsoId("_t4-eUFnMEeOQYsoJizpkVw")]
    [DisplayName("Buyer Tax Representative")]
    [IsoXmlTag("BuyrTaxRprtv")]
    public PartyIdentification116? BuyerTaxRepresentative { get; init; } 
    
    /// <summary>
    /// Specifies the language used in the message.
    /// </summary>
    [IsoId("_yQ0oUFnMEeOQYsoJizpkVw")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; } 
    
    
    #nullable disable
    
}
