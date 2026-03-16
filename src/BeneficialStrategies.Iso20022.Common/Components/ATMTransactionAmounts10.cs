// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction Amounts10.
/// </summary>
[IsoId("_XZkYoZ9MEe-nbM0aSPcoiQ")]
[DisplayName("ATM Transaction Amounts10")]
public record ATMTransactionAmounts10
{
    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Display Flag.
    /// </summary>
    [DisplayName("Display Flag")]
    [IsoXmlTag("DispFlg")]
    public IsoTrueFalseIndicator? DisplayFlag { get; init; }

    /// <summary>
    /// Maximum Number.
    /// </summary>
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    public IsoNumber? MaximumNumber { get; init; }

    /// <summary>
    /// Media Type.
    /// </summary>
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public required ATMMediaType4Code MediaType { get; init; }

    /// <summary>
    /// Minimum Number.
    /// </summary>
    [DisplayName("Minimum Number")]
    [IsoXmlTag("MinNb")]
    public IsoNumber? MinimumNumber { get; init; }
}
