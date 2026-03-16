// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes an instance of an intraday margin call being made against a margin account.
/// </summary>
[IsoId("_dC8lAEG6EemxGPEh9hU2Xg")]
[DisplayName("Intra Day Margin Call")]
public record IntraDayMarginCall1
{
    /// <summary>
    /// Identification of the margin account against which the intraday margin call is being made.
    /// </summary>
    [IsoId("_rCkhkEG6EemxGPEh9hU2Xg")]
    [DisplayName("Margin Account Identification")]
    [IsoXmlTag("MrgnAcctId")]
    public required GenericIdentification165 MarginAccountIdentification { get; init; }

    /// <summary>
    /// Value of the call being made.
    /// </summary>
    [IsoId("_7dvTgEG6EemxGPEh9hU2Xg")]
    [DisplayName("Intra Day Call")]
    [IsoXmlTag("IntraDayCall")]
    public required ActiveCurrencyAndAmount IntraDayCall { get; init; }

    /// <summary>
    /// Time at which the margin call was made.
    /// </summary>
    [IsoId("_AaCOYEG7EemxGPEh9hU2Xg")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; }
}
