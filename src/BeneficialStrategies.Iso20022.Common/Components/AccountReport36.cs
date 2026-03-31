// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Report36.
/// </summary>
[IsoId("_5ZlQoTEyEe6g-ffJsqGiSA")]
[DisplayName("Account Report36")]
public record AccountReport36
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount5 Account { get; init; }

    /// <summary>
    /// Balance Transfer Account.
    /// </summary>
    [DisplayName("Balance Transfer Account")]
    [IsoXmlTag("BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }

    /// <summary>
    /// Contract Dates.
    /// </summary>
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract3? ContractDates { get; init; }

    /// <summary>
    /// Group.
    /// </summary>
    [DisplayName("Group")]
    [IsoXmlTag("Grp")]
    public ValueList<Group6> Group { get; init; } = [];

    /// <summary>
    /// Mandate.
    /// </summary>
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public ValueList<OperationMandate7> Mandate { get; init; } = [];

    /// <summary>
    /// Reference Account.
    /// </summary>
    [DisplayName("Reference Account")]
    [IsoXmlTag("RefAcct")]
    public CashAccount40? ReferenceAccount { get; init; }

    /// <summary>
    /// Transfer Account Servicer Identification.
    /// </summary>
    [DisplayName("Transfer Account Servicer Identification")]
    [IsoXmlTag("TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification8? TransferAccountServicerIdentification { get; init; }

    /// <summary>
    /// Underlying Master Agreement.
    /// </summary>
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }
}
