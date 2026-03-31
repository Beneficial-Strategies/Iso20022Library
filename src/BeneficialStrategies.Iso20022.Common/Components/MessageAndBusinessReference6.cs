// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the message for which the status is requested and the business reference of the transfer instruction.
/// </summary>
[IsoId("_Sww1ctp-Ed-ak6NoX_4Aeg_2114109590")]
[DisplayName("Message And Business Reference")]
public record MessageAndBusinessReference6
{
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_SxqNUNp-Ed-ak6NoX_4Aeg_2114109977")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message sent in a proprietary way or the reference of a system.
    /// </summary>
    [IsoId("_SxqNUdp-Ed-ak6NoX_4Aeg_2114110012")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    public AdditionalReference3? OtherReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_SxqNUtp-Ed-ak6NoX_4Aeg_-1528390570")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SxqNU9p-Ed-ak6NoX_4Aeg_2114109856")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_SxzXQNp-Ed-ak6NoX_4Aeg_-1517308554")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SxzXQdp-Ed-ak6NoX_4Aeg_-636730208")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Investment account information of the transfer message for which the status is requested.
    /// </summary>
    [IsoId("_SxzXQtp-Ed-ak6NoX_4Aeg_2114109899")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount22? InvestmentAccountDetails { get; init; }
}
