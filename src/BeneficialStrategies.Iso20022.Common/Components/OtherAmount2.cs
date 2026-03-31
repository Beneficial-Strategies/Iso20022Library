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
[IsoId("_rSQAQFBGEeedyPuM0kK2EQ")]
[DisplayName("Other Amount")]
public record OtherAmount2
{
    /// <summary>
    /// Number of other amounts involved in clearing.
    /// </summary>
    [IsoId("__aYMIFBGEeedyPuM0kK2EQ")]
    [DisplayName("Clearing Count")]
    [IsoXmlTag("ClrCnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ClearingCount { get; init; }

    /// <summary>
    /// Amount of clearing.
    /// </summary>
    [IsoId("_DD7swFBHEeedyPuM0kK2EQ")]
    [DisplayName("Clearing Amount")]
    [IsoXmlTag("ClrAmt")]
    public required Amount14 ClearingAmount { get; init; }

    /// <summary>
    /// Interchange fee.
    /// </summary>
    [IsoId("_JfieQFBHEeedyPuM0kK2EQ")]
    [DisplayName("Interchange Fee")]
    [IsoXmlTag("IntrchngFee")]
    public Amount14? InterchangeFee { get; init; }

    /// <summary>
    /// Agent fee.
    /// </summary>
    [IsoId("_PGyaoFBHEeedyPuM0kK2EQ")]
    [DisplayName("Agent Fee")]
    [IsoXmlTag("AgtFee")]
    public Amount14? AgentFee { get; init; }
}
