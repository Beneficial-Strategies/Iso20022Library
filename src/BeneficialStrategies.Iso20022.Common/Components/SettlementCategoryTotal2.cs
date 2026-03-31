// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement totals
/// </summary>
[IsoId("_-LcTQZMmEeuleeHpFMMhmQ")]
[DisplayName("Settlement Category Total")]
public record SettlementCategoryTotal2
{
    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_-SNpoZMmEeuleeHpFMMhmQ")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Count { get; init; }

    /// <summary>
    /// Gross amount.
    /// </summary>
    [IsoId("_-SNpo5MmEeuleeHpFMMhmQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// Interchange fee amount.
    /// </summary>
    [IsoId("_-SNppZMmEeuleeHpFMMhmQ")]
    [DisplayName("Interchange Fee")]
    [IsoXmlTag("IntrchngFee")]
    public Amount17? InterchangeFee { get; init; }

    /// <summary>
    /// Processing fee.
    /// </summary>
    [IsoId("_-SNpp5MmEeuleeHpFMMhmQ")]
    [DisplayName("Processing Fee")]
    [IsoXmlTag("PrcgFee")]
    public Amount17? ProcessingFee { get; init; }
}
