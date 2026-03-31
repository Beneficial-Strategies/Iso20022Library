// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the status of a transfer instruction and its reason.
/// </summary>
[IsoId("_q-YLIRwjEeOIveEnnb_1-A")]
[DisplayName("Transfer Status And Reason")]
public record TransferStatusAndReason3
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_rWCdNRwjEeOIveEnnb_1-A")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_rWCdNxwjEeOIveEnnb_1-A")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_rWCdORwjEeOIveEnnb_1-A")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_rWCdOxwjEeOIveEnnb_1-A")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_3m1gcBwjEeOIveEnnb_1-A")]
    [DisplayName("Transfer Status")]
    [IsoXmlTag("TrfSts")]
    public required TransferStatus1Choice_ TransferStatus { get; init; }

    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_rWCdTxwjEeOIveEnnb_1-A")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("_rWCdURwjEeOIveEnnb_1-A")]
    [DisplayName("Send Out Date")]
    [IsoXmlTag("SndOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SendOutDate { get; init; }

    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_rWCdUxwjEeOIveEnnb_1-A")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; }
}
