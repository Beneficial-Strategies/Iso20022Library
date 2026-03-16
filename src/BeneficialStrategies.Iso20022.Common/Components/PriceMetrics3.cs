// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables consisting in interest rates, lending fees or haircuts, calculated as weighted averages.
/// </summary>
[IsoId("_rpb5cc-nEeufOvGsyZiDWA")]
[DisplayName("Price Metrics")]
public record PriceMetrics3
{
    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    [IsoId("_rsBTY8-nEeufOvGsyZiDWA")]
    [DisplayName("Rates")]
    [IsoXmlTag("Rates")]
    public Rates3? Rates { get; init; }

    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    [IsoId("_rsBTZc-nEeufOvGsyZiDWA")]
    [DisplayName("Lending Fee")]
    [IsoXmlTag("LndgFee")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? LendingFee { get; init; }
}
