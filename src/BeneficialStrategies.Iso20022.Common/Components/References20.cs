// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.
/// </summary>
[IsoId("_Sh39oSP0EeWQjryFgN2ITg")]
[DisplayName("References")]
public record References20
{
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_S_VVsSP0EeWQjryFgN2ITg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference6? PoolReference { get; init; }

    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("_S_VVsyP0EeWQjryFgN2ITg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference6? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_S_VVtSP0EeWQjryFgN2ITg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference6? RelatedReference { get; init; }
}
