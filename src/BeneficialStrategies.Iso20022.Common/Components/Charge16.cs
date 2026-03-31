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
[IsoId("_RuTS79p-Ed-ak6NoX_4Aeg_758291100")]
[DisplayName("Charge")]
public record Charge16
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RudD4Np-Ed-ak6NoX_4Aeg_758291507")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType10Code Type { get; init; }

    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RudD4dp-Ed-ak6NoX_4Aeg_758291542")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_RudD4tp-Ed-ak6NoX_4Aeg_758291567")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_RudD49p-Ed-ak6NoX_4Aeg_758291584")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }
}
