// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer in transaction.
/// </summary>
[IsoId("_5lLMYSPvEeWQjryFgN2ITg")]
[DisplayName("Transfer In")]
public record TransferIn16
{
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_6BlbgyPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_6BlbhSPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public ValueList<Transfer32> TransferDetails { get; init; } = [];
    // ID for the above is _6BlbhSPvEeWQjryFgN2ITg
}
