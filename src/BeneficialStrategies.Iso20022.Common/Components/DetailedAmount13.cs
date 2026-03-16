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
[IsoId("_EftDYYolEeSaAcF2oE2GNQ")]
[DisplayName("Detailed Amount")]
public record DetailedAmount13
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_Es38sYolEeSaAcF2oE2GNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_VfPGoIolEeSaAcF2oE2GNQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Short description of the amount to display or print.
    /// </summary>
    [IsoId("_Es38s4olEeSaAcF2oE2GNQ")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Label { get; init; }
}
