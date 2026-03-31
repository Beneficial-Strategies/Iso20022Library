// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_00iAEXszEeSTS7uHCe8FPQ")]
[DisplayName("Detailed Amount")]
public record DetailedAmount9
{
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_1CY14XszEeSTS7uHCe8FPQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount5Code Type { get; init; }

    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_XFX9oHs1EeSTS7uHCe8FPQ")]
    [DisplayName("Additional Type")]
    [IsoXmlTag("AddtlTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalType { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_dMd3sHs1EeSTS7uHCe8FPQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Short description of the amount to provide to the cardholder.
    /// </summary>
    [IsoId("_1CY15XszEeSTS7uHCe8FPQ")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Label { get; init; }
}
