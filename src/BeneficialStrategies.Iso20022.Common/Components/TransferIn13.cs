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
[IsoId("_iAR8NT8BEeSIqOPJHpnleA")]
[DisplayName("Transfer In")]
public record TransferIn13
{
    /// <summary>
    /// Requested date at which the instructing party places the transfer instruction.
    /// </summary>
    [IsoId("_iaw4xT8BEeSIqOPJHpnleA")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public DateFormat1Choice_? RequestedTransferDate { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_iaw4xz8BEeSIqOPJHpnleA")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Details of the transfer and cancellation.
    /// </summary>
    [IsoId("_iaw4yT8BEeSIqOPJHpnleA")]
    [DisplayName("Transfer And References")]
    [IsoXmlTag("TrfAndRefs")]
    public ValueList<TransferIn11> TransferAndReferences { get; init; } = [];

    // ID for the above is _iaw4yT8BEeSIqOPJHpnleA

    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    [IsoId("_iaw4yz8BEeSIqOPJHpnleA")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount40 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_iaw4zT8BEeSIqOPJHpnleA")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public DeliverInformation15? SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_iaw4zz8BEeSIqOPJHpnleA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
