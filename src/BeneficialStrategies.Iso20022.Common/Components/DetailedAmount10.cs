// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
/// </summary>
[IsoId("_88EdAXs1EeSTS7uHCe8FPQ")]
[DisplayName("Detailed Amount")]
public record DetailedAmount10
{
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_9Jz-EXs1EeSTS7uHCe8FPQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount6Code Type { get; init; }

    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_9Jz-E3s1EeSTS7uHCe8FPQ")]
    [DisplayName("Additional Type")]
    [IsoXmlTag("AddtlTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalType { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_9Jz-FXs1EeSTS7uHCe8FPQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Short description of the amount to provide to the cardholder.
    /// </summary>
    [IsoId("_9Jz-GXs1EeSTS7uHCe8FPQ")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Label { get; init; }
}
