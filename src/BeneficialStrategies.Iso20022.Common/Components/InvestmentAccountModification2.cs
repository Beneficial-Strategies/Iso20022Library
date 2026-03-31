// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the modification of an account.
/// </summary>
[IsoId("_X9WSMSFfEeW9XJWqfgXIIA")]
[DisplayName("Investment Account Modification")]
public record InvestmentAccountModification2
{
    /// <summary>
    /// Reason for the modification to the investment account information.
    /// </summary>
    [IsoId("_YZKrgSFfEeW9XJWqfgXIIA")]
    [DisplayName("Modification Reason")]
    [IsoXmlTag("ModRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? ModificationReason { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account modification request.
    /// </summary>
    [IsoId("_YZKrgyFfEeW9XJWqfgXIIA")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer.
    /// </summary>
    [IsoId("_YZKrhSFfEeW9XJWqfgXIIA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    [IsoId("_YZKrhyFfEeW9XJWqfgXIIA")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference6? CounterpartyReference { get; init; }

    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_ehrkcVxQEeW8MLuBzR10cg")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ExistingAccountIdentification { get; init; }
}
