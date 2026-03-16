// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[IsoId("_mPQ7EQgMEeSFYfyUKDXKaw")]
[DisplayName("ISA Transfer")]
public record ISATransfer20
{
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_mp5oowgMEeSFYfyUKDXKaw")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_mp5opQgMEeSFYfyUKDXKaw")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public ValueList<ISATransfer18> ProductTransfer { get; init; } = [];
    // ID for the above is _mp5opQgMEeSFYfyUKDXKaw
}
