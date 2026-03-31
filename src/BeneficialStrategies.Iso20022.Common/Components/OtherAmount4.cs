// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other amount in clearing record data.
/// </summary>
[IsoId("_L8b4wZM5EeuleeHpFMMhmQ")]
[DisplayName("Other Amount")]
public record OtherAmount4
{
    /// <summary>
    /// Number of other amounts involved in clearing.
    /// </summary>
    [IsoId("_MBFvQZM5EeuleeHpFMMhmQ")]
    [DisplayName("Clearing Count")]
    [IsoXmlTag("ClrCnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ClearingCount { get; init; }

    /// <summary>
    /// Amount of clearing.
    /// </summary>
    [IsoId("_MBFvQ5M5EeuleeHpFMMhmQ")]
    [DisplayName("Clearing Amount")]
    [IsoXmlTag("ClrAmt")]
    public required Amount17 ClearingAmount { get; init; }

    /// <summary>
    /// Interchange fee.
    /// </summary>
    [IsoId("_MBFvRZM5EeuleeHpFMMhmQ")]
    [DisplayName("Interchange Fee")]
    [IsoXmlTag("IntrchngFee")]
    public Amount17? InterchangeFee { get; init; }

    /// <summary>
    /// Agent fee.
    /// </summary>
    [IsoId("_MBFvR5M5EeuleeHpFMMhmQ")]
    [DisplayName("Agent Fee")]
    [IsoXmlTag("AgtFee")]
    public Amount17? AgentFee { get; init; }
}
