// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal fees, accepted by the customer.
/// </summary>
[IsoId("_67OOka4uEeWLdt0vLARX2Q")]
[DisplayName("Detailed Amount")]
public record DetailedAmount18
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_7HvAka4uEeWLdt0vLARX2Q")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_7HvAk64uEeWLdt0vLARX2Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// True if amount charged to the source account.
    /// </summary>
    [IsoId("_Jz8WUK4vEeWLdt0vLARX2Q")]
    [DisplayName("Charge Account To")]
    [IsoXmlTag("ChrgAcctTo")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ChargeAccountTo { get; init; }

    /// <summary>
    /// Short description of the amount to display or print.
    /// </summary>
    [IsoId("_7HvAla4uEeWLdt0vLARX2Q")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Label { get; init; }
}
