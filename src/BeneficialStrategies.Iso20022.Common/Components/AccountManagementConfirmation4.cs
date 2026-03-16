// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the type of request or instruction.
/// </summary>
[IsoId("_ax-xUUzLEeafiMTDrtSnyw")]
[DisplayName("Account Management Confirmation")]
public record AccountManagementConfirmation4
{
    /// <summary>
    /// Specifies the confirmation type.
    /// </summary>
    [IsoId("_bMBB8UzLEeafiMTDrtSnyw")]
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required ConfirmationType1Choice_ ConfirmationType { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_bMBB80zLEeafiMTDrtSnyw")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a transaction, for example, a transfer, as assigned by the investor or account owner.
    /// </summary>
    [IsoId("_bMBB9UzLEeafiMTDrtSnyw")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    [IsoId("_bMBB90zLEeafiMTDrtSnyw")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference6? CounterpartyReference { get; init; }

    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_bMBB-UzLEeafiMTDrtSnyw")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    public Account23? ExistingAccountIdentification { get; init; }
}
