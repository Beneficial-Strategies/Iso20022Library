// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the confirmation of a transfer out transaction.
/// </summary>
[IsoId("_-GjFxSPvEeWQjryFgN2ITg")]
[DisplayName("Transfer Out")]
public record TransferOut16
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_-kKO1yPvEeWQjryFgN2ITg")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_-kKO2SPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public ValueList<Transfer31> TransferDetails { get; init; } = [];

    // ID for the above is _-kKO2SPvEeWQjryFgN2ITg

    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    [IsoId("_-kKO2yPvEeWQjryFgN2ITg")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount54 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_-kKO3SPvEeWQjryFgN2ITg")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public ReceiveInformation17? SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-kKO3yPvEeWQjryFgN2ITg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
