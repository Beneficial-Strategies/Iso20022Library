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
[IsoId("_a_WqsZS-EemqYPWMBuVawg")]
[DisplayName("Account Management Confirmation")]
public record AccountManagementConfirmation5
{
    /// <summary>
    /// Specifies the confirmation type.
    /// </summary>
    [IsoId("_bT4wQZS-EemqYPWMBuVawg")]
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required ConfirmationType1Choice_ ConfirmationType { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_bT4wQ5S-EemqYPWMBuVawg")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a transaction, for example, a transfer, as assigned by the investor or account owner.
    /// </summary>
    [IsoId("_bT4wRZS-EemqYPWMBuVawg")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    [IsoId("_bT4wR5S-EemqYPWMBuVawg")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference13? CounterpartyReference { get; init; }

    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_bT4wSZS-EemqYPWMBuVawg")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    public Account23? ExistingAccountIdentification { get; init; }
}
