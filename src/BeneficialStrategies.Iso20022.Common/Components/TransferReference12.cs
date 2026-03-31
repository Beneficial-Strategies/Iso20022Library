// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of a transfer and of a transfer confirmation.
/// </summary>
[IsoId("_1LZXYYi0EeefvMoXmllHqg")]
[DisplayName("Transfer Reference")]
public record TransferReference12
{
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction for which the confirmation reversal is sent, as assigned by the instructing party.
    /// </summary>
    [IsoId("_1bXtFYi0EeefvMoXmllHqg")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_1bXtF4i0EeefvMoXmllHqg")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference8? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the transfer execution for which the confirmation reversal is sent, as assigned by the confirming party.
    /// </summary>
    [IsoId("_1bXtGYi0EeefvMoXmllHqg")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransferConfirmationReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_1bXtG4i0EeefvMoXmllHqg")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference8? CounterpartyReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the reversal as assigned by the confirming party.
    /// </summary>
    [IsoId("_V76nIIi1EeefvMoXmllHqg")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Reason for the reversal of confirmation.
    /// </summary>
    [IsoId("_iPdggY5UEeeNN9vGwZc5aA")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalReason { get; init; }
}
