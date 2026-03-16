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
[IsoId("_Sl4bKdp-Ed-ak6NoX_4Aeg_1978788372")]
[DisplayName("Tax")]
public record Tax17
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_Sl4bKtp-Ed-ak6NoX_4Aeg_1978788414")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType12Code Type { get; init; }

    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_Sl4bK9p-Ed-ak6NoX_4Aeg_-1751950721")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_SmCMINp-Ed-ak6NoX_4Aeg_1978788709")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    [MinLength(0)]
    [MaxLength(7)]
    public ValueList<ActiveOrHistoricCurrencyAnd13DecimalAmount> Amount { get; init; } = [];

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_SmCMIdp-Ed-ak6NoX_4Aeg_1978788786")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_SmCMItp-Ed-ak6NoX_4Aeg_1978789094")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_SmCMI9p-Ed-ak6NoX_4Aeg_256540868")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation4? TaxCalculationDetails { get; init; }
}
