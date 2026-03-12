// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax region that levies a tax on the services in a statement.
/// </summary>
[IsoId("_t3QwgeDzEeim_fWj9imBTA")]
[DisplayName("Billing Tax Region")]
public partial record BillingTaxRegion2
{
    #nullable enable
    
    /// <summary>
    /// Specifies a particular unique zone of taxes assigned by taxing authorities. A tax region number is unique. Every account is considered to reside within a tax region, although some tax regions may not charge taxes on services.
    /// </summary>
    [IsoId("_uEFrkeDzEeim_fWj9imBTA")]
    [DisplayName("Region Number")]
    [IsoXmlTag("RgnNb")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public required IsoMax40Text RegionNumber { get; init; } 
    
    /// <summary>
    /// Name associated with a specific tax region number.
    /// </summary>
    [IsoId("_uEFrk-DzEeim_fWj9imBTA")]
    [DisplayName("Region Name")]
    [IsoXmlTag("RgnNm")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public required IsoMax40Text RegionName { get; init; } 
    
    /// <summary>
    /// Specifies the financial institution’s customer tax identification number. ||Usage: |This is the number passed from the financial institution to the taxing authority to indicate the specific customer tied to the taxes calculated for this tax region and group of delivered services. It is typically the tax identification tied to a customer’s account.
    /// </summary>
    [IsoId("_uEFrleDzEeim_fWj9imBTA")]
    [DisplayName("Customer Tax Identification")]
    [IsoXmlTag("CstmrTaxId")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public required IsoMax40Text CustomerTaxIdentification { get; init; } 
    
    /// <summary>
    /// Date on which the tax calculation was performed. ||Usage: |This date can be used to verify the tax rate value on the calculation date.
    /// </summary>
    [IsoId("_uEFrl-DzEeim_fWj9imBTA")]
    [DisplayName("Point Date")]
    [IsoXmlTag("PtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PointDate { get; init; } 
    
    /// <summary>
    /// Tax information that relates to the sending financial institution.
    /// </summary>
    [IsoId("_uEFrmeDzEeim_fWj9imBTA")]
    [DisplayName("Sending Financial Institution")]
    [IsoXmlTag("SndgFI")]
    public BillingTaxIdentification2? SendingFinancialInstitution { get; init; } 
    
    /// <summary>
    /// Unique number to be used by the customer to cross-reference between the tax region information and a tax invoice or notice.
    /// </summary>
    [IsoId("_uEFrm-DzEeim_fWj9imBTA")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public IsoMax40Text? InvoiceNumber { get; init; } 
    
    /// <summary>
    /// Tax values are based on tax calculation method C.
    /// </summary>
    [IsoId("_uEFrneDzEeim_fWj9imBTA")]
    [DisplayName("Method C")]
    [IsoXmlTag("MtdC")]
    public BillingMethod4? MethodC { get; init; } 
    
    /// <summary>
    /// Total tax amount expressed in the account’s settlement (or charging) currency. ||Usage: This total sums the individual service level taxes as calculated for each service by methods A, B and D. The sum of these amounts across all tax regions for the statement is displayed as the tax total sum in the compensation section.
    /// </summary>
    [IsoId("_uEFrn-DzEeim_fWj9imBTA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection34 SettlementAmount { get; init; } 
    
    /// <summary>
    /// Total amount of all taxes for a specific customer within the tax region expressed in the tax region’s host currency. ||Usage: It is the same value as total tax amount and is included for the specific use of tax calculation methods A, B and D.
    /// </summary>
    [IsoId("_uEFroeDzEeim_fWj9imBTA")]
    [DisplayName("Tax Due To Region")]
    [IsoXmlTag("TaxDueToRgn")]
    public required AmountAndDirection34 TaxDueToRegion { get; init; } 
    
    
    #nullable disable
    
}
