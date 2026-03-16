// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity breakdown information for a specific securities balance.
/// </summary>
[IsoId("_M_8f0TqFEemJ3KLLPeYl6g")]
[DisplayName("Cash Sub Balance Type And Quantity Breakdown")]
public record CashSubBalanceTypeAndQuantityBreakdown3
{
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_NLbXETqFEemJ3KLLPeYl6g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CashBalanceType3Choice_ Type { get; init; }

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_NLbXEzqFEemJ3KLLPeYl6g")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<AmountAndQuantityBreakdown1> QuantityBreakdown { get; init; } = [];
}
