// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_SmCMKtp-Ed-ak6NoX_4Aeg_-535677127")]
[DisplayName("Tax")]
public partial record Tax16
{
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_SmCMK9p-Ed-ak6NoX_4Aeg_-535677101")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType10Code Type { get; init; } 
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_SmCMLNp-Ed-ak6NoX_4Aeg_1412358865")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; } 
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_SmCMLdp-Ed-ak6NoX_4Aeg_-535677085")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_SmL9INp-Ed-ak6NoX_4Aeg_-535677067")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_SmL9Idp-Ed-ak6NoX_4Aeg_1510528516")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_SmL9Itp-Ed-ak6NoX_4Aeg_-535676825")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_SmL9I9p-Ed-ak6NoX_4Aeg_-535676808")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; } 
    
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_SmL9JNp-Ed-ak6NoX_4Aeg_-535676790")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public TaxExemptReason1Code? ExemptionReason { get; init; } 
    
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_SmL9Jdp-Ed-ak6NoX_4Aeg_-1751778954")]
    [DisplayName("Extended Exemption Reason")]
    [IsoXmlTag("XtndedXmptnRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedExemptionReason { get; init; } 
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_SmL9Jtp-Ed-ak6NoX_4Aeg_399091127")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation5? TaxCalculationDetails { get; init; } 
    
    
    #nullable disable
    
}
