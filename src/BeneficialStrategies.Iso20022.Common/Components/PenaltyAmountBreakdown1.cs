// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the breakdown of the penalty into sub-amounts.
/// </summary>
[IsoId("_iT97kDkbEem897H7zB2RJg")]
[DisplayName("Penalty Amount Breakdown1")]
public record PenaltyAmountBreakdown1
{
    /// <summary>
    /// Penalty amount defined per amount type.
    /// </summary>
    [IsoId("_qjBnsDkbEem897H7zB2RJg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Amount type for the penalty breakdown.
    /// </summary>
    [IsoId("_tkl7QDkbEem897H7zB2RJg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PenaltyAmountType1Code? Type { get; init; }
}
