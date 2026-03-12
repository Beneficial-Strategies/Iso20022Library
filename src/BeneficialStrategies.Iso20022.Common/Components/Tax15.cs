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
[IsoId("_SmVHGNp-Ed-ak6NoX_4Aeg_886249443")]
[DisplayName("Tax")]
public partial record Tax15
{
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_SmVHGdp-Ed-ak6NoX_4Aeg_887170259")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType13Code Type { get; init; } 
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_SmVHGtp-Ed-ak6NoX_4Aeg_-1033423803")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; } 
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_SmVHG9p-Ed-ak6NoX_4Aeg_887170200")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_SmVHHNp-Ed-ak6NoX_4Aeg_887170554")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis2Code? Basis { get; init; } 
    
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_SmVHHdp-Ed-ak6NoX_4Aeg_-731429970")]
    [DisplayName("Extended Basis")]
    [IsoXmlTag("XtndedBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedBasis { get; init; } 
    
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_SmVHHtp-Ed-ak6NoX_4Aeg_887170940")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_SmVHH9p-Ed-ak6NoX_4Aeg_887170649")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; } 
    
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_Sme4ENp-Ed-ak6NoX_4Aeg_887170957")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public TaxExemptReason1Code? ExemptionReason { get; init; } 
    
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_Sme4Edp-Ed-ak6NoX_4Aeg_-1033423768")]
    [DisplayName("Extended Exemption Reason")]
    [IsoXmlTag("XtndedXmptnRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedExemptionReason { get; init; } 
    
    
    #nullable disable
    
}
