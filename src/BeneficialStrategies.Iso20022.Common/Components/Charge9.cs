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
[IsoId("_VI5xhNp-Ed-ak6NoX_4Aeg_-1042251660")]
[DisplayName("Charge")]
public record Charge9
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_VI5xhdp-Ed-ak6NoX_4Aeg_-1042250955")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType2 Type { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_VI5xhtp-Ed-ak6NoX_4Aeg_-1042251305")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Calculation basis for the charge or fee.
    /// </summary>
    [IsoId("_VI5xh9p-Ed-ak6NoX_4Aeg_2089145008")]
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    public CalculationBasis1? CalculationBasis { get; init; }
}
