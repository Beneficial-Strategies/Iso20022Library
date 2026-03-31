// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_SmoCANp-Ed-ak6NoX_4Aeg_-1632227217")]
[DisplayName("Tax")]
public record Tax14
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_SmoCAdp-Ed-ak6NoX_4Aeg_-1632227200")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType11Code Type { get; init; }

    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_SmoCAtp-Ed-ak6NoX_4Aeg_-1264604318")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_SmoCA9p-Ed-ak6NoX_4Aeg_-1632227182")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_SmoCBNp-Ed-ak6NoX_4Aeg_-1632227165")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_SmoCBdp-Ed-ak6NoX_4Aeg_1725707372")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_SmoCBtp-Ed-ak6NoX_4Aeg_-1632227147")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_SmoCB9p-Ed-ak6NoX_4Aeg_-1632227122")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_SmoCCNp-Ed-ak6NoX_4Aeg_-576582554")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public TaxExemptReason1Code? ExemptionReason { get; init; }

    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_SmoCCdp-Ed-ak6NoX_4Aeg_-576582519")]
    [DisplayName("Extended Exemption Reason")]
    [IsoXmlTag("XtndedXmptnRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedExemptionReason { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_SmxzANp-Ed-ak6NoX_4Aeg_-1632226843")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation6? TaxCalculationDetails { get; init; }
}
