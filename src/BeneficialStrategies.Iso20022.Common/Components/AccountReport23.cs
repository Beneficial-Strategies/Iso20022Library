// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports to a corporate on the actual set-up of the account, related services and mandates.
/// </summary>
[IsoId("_IlAr9W49EeiU9cctagi5ow")]
[DisplayName("Account Report")]
public record AccountReport23
{
    /// <summary>
    /// Characteristics of the account.
    /// </summary>
    [IsoId("_IuZ4dW49EeiU9cctagi5ow")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount5 Account { get; init; }

    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_IuZ4d249EeiU9cctagi5ow")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }

    /// <summary>
    /// Specifies target and actual dates.
    /// </summary>
    [IsoId("_IuZ4eW49EeiU9cctagi5ow")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract3? ContractDates { get; init; }

    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_IuZ4e249EeiU9cctagi5ow")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public ValueList<OperationMandate4> Mandate { get; init; } = [];

    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_IuZ4fW49EeiU9cctagi5ow")]
    [DisplayName("Group")]
    [IsoXmlTag("Grp")]
    public ValueList<Group4> Group { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_IuZ4f249EeiU9cctagi5ow")]
    [DisplayName("Reference Account")]
    [IsoXmlTag("RefAcct")]
    public CashAccount38? ReferenceAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account where to transfer the balance.
    /// </summary>
    [IsoId("_IuZ4gW49EeiU9cctagi5ow")]
    [DisplayName("Balance Transfer Account")]
    [IsoXmlTag("BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }

    /// <summary>
    /// Identification of the transfer account servicer.
    /// </summary>
    [IsoId("_IuZ4g249EeiU9cctagi5ow")]
    [DisplayName("Transfer Account Servicer Identification")]
    [IsoXmlTag("TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification6? TransferAccountServicerIdentification { get; init; }
}
