// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limits and amounts not part of the transaction amount.
/// </summary>
[IsoId("_tSAeoUTEEeiTBYbU3rWV0A")]
[DisplayName("Additional Amounts")]
public record AdditionalAmounts2
{
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_td6MoUTEEeiTBYbU3rWV0A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount17Code Type { get; init; }

    /// <summary>
    /// Other type of amount.
    /// </summary>
    [IsoId("_td6Mo0TEEeiTBYbU3rWV0A")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Amount of one occurrence of the breakdown amount.
    /// </summary>
    [IsoId("_td6MpUTEEeiTBYbU3rWV0A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount14 Amount { get; init; }

    /// <summary>
    /// Short description of the additional amount.
    /// </summary>
    [IsoId("_td6Mp0TEEeiTBYbU3rWV0A")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Label { get; init; }
}
