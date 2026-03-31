// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports to a corporate on the actual set up up of the account, related services and mandates.
/// </summary>
[IsoId("_w2DnAQ1iEeKGXqvMN6jpiw")]
[DisplayName("Account Report")]
public record AccountReport15
{
    /// <summary>
    /// Characteristics of the account.
    /// </summary>
    [IsoId("_xL0bqQ1iEeKGXqvMN6jpiw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount5 Account { get; init; }

    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_xL0brQ1iEeKGXqvMN6jpiw")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }

    /// <summary>
    /// Specifies target and actual dates.
    /// </summary>
    [IsoId("_xL0bsQ1iEeKGXqvMN6jpiw")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract3? ContractDates { get; init; }

    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_xL0btQ1iEeKGXqvMN6jpiw")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public ValueList<OperationMandate2> Mandate { get; init; } = [];

    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_ahYo0A4XEeKGXqvMN6jpiw")]
    [DisplayName("Group")]
    [IsoXmlTag("Grp")]
    public ValueList<Group1> Group { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_xL0buQ1iEeKGXqvMN6jpiw")]
    [DisplayName("Reference Account")]
    [IsoXmlTag("RefAcct")]
    public CashAccount24? ReferenceAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account where to transfer the balance.
    /// </summary>
    [IsoId("_xL0bvQ1iEeKGXqvMN6jpiw")]
    [DisplayName("Balance Transfer Account")]
    [IsoXmlTag("BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }

    /// <summary>
    /// Identification of the transfer account servicer.
    /// </summary>
    [IsoId("_xL0bwQ1iEeKGXqvMN6jpiw")]
    [DisplayName("Transfer Account Servicer Identification")]
    [IsoXmlTag("TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification5? TransferAccountServicerIdentification { get; init; }
}
