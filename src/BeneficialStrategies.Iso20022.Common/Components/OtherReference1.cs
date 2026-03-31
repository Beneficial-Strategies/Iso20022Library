// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other option to express a reference.
/// </summary>
[IsoId("_6VGSwMeTEeysUoBKYz1Ytw")]
[DisplayName("Other Reference")]
public record OtherReference1
{
    /// <summary>
    /// Type of reference
    /// </summary>
    [IsoId("_GZsGAMeUEeysUoBKYz1Ytw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReferenceType1Choice_ Type { get; init; }

    /// <summary>
    /// Value of the reference
    /// </summary>
    [IsoId("_LuoKYMeUEeysUoBKYz1Ytw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Value { get; init; }
}
