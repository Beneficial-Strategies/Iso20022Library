// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on the actual set up of the account, related services and mandates.
/// </summary>
[IsoId("_1Pl8dTEyEe6g-ffJsqGiSA")]
[DisplayName("Account Report34")]
public record AccountReport34
{
    /// <summary>
    /// Characteristics of the account.
    /// </summary>
    [IsoId("_1R0xFTEyEe6g-ffJsqGiSA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount8 Account { get; init; }

    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_1R0xFzEyEe6g-ffJsqGiSA")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }

    /// <summary>
    /// Specifies target and actual dates.
    /// </summary>
    [IsoId("_1R0xGTEyEe6g-ffJsqGiSA")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract3? ContractDates { get; init; }

    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_1R0xGzEyEe6g-ffJsqGiSA")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public ValueList<OperationMandate7> Mandate { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_1R0xHTEyEe6g-ffJsqGiSA")]
    [DisplayName("Reference Account")]
    [IsoXmlTag("RefAcct")]
    public CashAccount40? ReferenceAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account where to transfer the balance.
    /// </summary>
    [IsoId("_1R0xHzEyEe6g-ffJsqGiSA")]
    [DisplayName("Balance Transfer Account")]
    [IsoXmlTag("BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }

    /// <summary>
    /// Identification of the transfer account servicer.
    /// </summary>
    [IsoId("_1R0xITEyEe6g-ffJsqGiSA")]
    [DisplayName("Transfer Account Servicer Identification")]
    [IsoXmlTag("TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification8? TransferAccountServicerIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_1R0xIzEyEe6g-ffJsqGiSA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public OrganisationIdentification39? AccountOwner { get; init; }

    /// <summary>
    /// Proprietary characteristics of the account.
    /// </summary>
    [IsoId("_1R0xJTEyEe6g-ffJsqGiSA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<GenericIdentification1> Proprietary { get; init; } = [];

    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_1R0xJzEyEe6g-ffJsqGiSA")]
    [DisplayName("Group")]
    [IsoXmlTag("Grp")]
    public ValueList<Group6> Group { get; init; } = [];
}
