// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_RtjsBdp-Ed-ak6NoX_4Aeg_1620461659")]
[DisplayName("Charge")]
public record Charge15
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RtjsBtp-Ed-ak6NoX_4Aeg_1620462002")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType9Code Type { get; init; }

    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RtjsB9p-Ed-ak6NoX_4Aeg_-742671573")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_RtjsCNp-Ed-ak6NoX_4Aeg_1620461677")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_RttdANp-Ed-ak6NoX_4Aeg_1460520302")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }

    /// <summary>
    /// Calculation basis for the charge or fee.
    /// </summary>
    [IsoId("_RttdAdp-Ed-ak6NoX_4Aeg_1620462062")]
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    public CalculationBasis2Code? CalculationBasis { get; init; }

    /// <summary>
    /// Calculation basis for the charge or fee.
    /// </summary>
    [IsoId("_RttdAtp-Ed-ak6NoX_4Aeg_-1714808388")]
    [DisplayName("Extended Calculation Basis")]
    [IsoXmlTag("XtndedClctnBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCalculationBasis { get; init; }
}
