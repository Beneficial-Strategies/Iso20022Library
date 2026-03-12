// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains all needed party details for tax agency (sender of the TaxReport) and tax authority (receiver of the TaxReport) and the details of the reported sales transaction and calculated tax related that specific business transaction.
/// </summary>
[IsoId("_oAv2w1m4EeOQYsoJizpkVw")]
[DisplayName("Tax Report")]
public partial record TaxReport1
{
    #nullable enable
    
    /// <summary>
    /// Basic report details.
    /// </summary>
    [IsoId("_trTl01m4EeOQYsoJizpkVw")]
    [DisplayName("Tax Report Header")]
    [IsoXmlTag("TaxRptHdr")]
    public required GroupHeader69 TaxReportHeader { get; init; } 
    
    /// <summary>
    /// Tax reporting agent, for example seller.
    /// Responsible to issue tax reporting to tax authority.
    /// </summary>
    [IsoId("_3-XxEFm4EeOQYsoJizpkVw")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification72 Seller { get; init; } 
    
    /// <summary>
    /// Specifies the buyer of goods/service reported in this message.
    /// </summary>
    [IsoId("_7BHwYFm4EeOQYsoJizpkVw")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PartyIdentification72? Buyer { get; init; } 
    
    /// <summary>
    /// Contains the details of the business transactions reported in the message.
    /// </summary>
    [IsoId("_LaSXMFm5EeOQYsoJizpkVw")]
    [DisplayName("Trade Settlement")]
    [IsoXmlTag("TradSttlm")]
    public required TradeSettlement2 TradeSettlement { get; init; } 
    
    /// <summary>
    /// Reserved for parties that may be required by a specific tax authority.
    /// </summary>
    [IsoId("_ErRwwJD1EeSZY4BVJy2t3A")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public PartyIdentification72? OtherParty { get; init; } 
    
    /// <summary>
    /// Additional reference like site key or identifier.
    /// </summary>
    [IsoId("_zSTYoFm6EeOQYsoJizpkVw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation1? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Structure to deliver link to external attachment or deliver base64-coded attachment inside message.
    /// </summary>
    [IsoId("_5Jz-kFm6EeOQYsoJizpkVw")]
    [DisplayName("Additional Reference")]
    [IsoXmlTag("AddtlRef")]
    public DocumentGeneralInformation2? AdditionalReference { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nHYhsEjvEeaOe8w0NJ11wQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
