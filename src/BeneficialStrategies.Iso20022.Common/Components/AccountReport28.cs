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
[IsoId("_esTmIdcZEeqRFcf2R4bPBw")]
[DisplayName("Account Report")]
public record AccountReport28
{
    /// <summary>
    /// Characteristics of the account.
    /// </summary>
    [IsoId("_et8k5dcZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount5 Account { get; init; }

    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_et8k59cZEeqRFcf2R4bPBw")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }

    /// <summary>
    /// Specifies target and actual dates.
    /// </summary>
    [IsoId("_et8k6dcZEeqRFcf2R4bPBw")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract3? ContractDates { get; init; }

    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_et8k69cZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public OperationMandate4? Mandate { get; init; }

    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_et8k7dcZEeqRFcf2R4bPBw")]
    [DisplayName("Group")]
    [IsoXmlTag("Grp")]
    public Group4? Group { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_et8k79cZEeqRFcf2R4bPBw")]
    [DisplayName("Reference Account")]
    [IsoXmlTag("RefAcct")]
    public CashAccount40? ReferenceAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account where to transfer the balance.
    /// </summary>
    [IsoId("_et8k8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Balance Transfer Account")]
    [IsoXmlTag("BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }

    /// <summary>
    /// Identification of the transfer account servicer.
    /// </summary>
    [IsoId("_et8k89cZEeqRFcf2R4bPBw")]
    [DisplayName("Transfer Account Servicer Identification")]
    [IsoXmlTag("TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification6? TransferAccountServicerIdentification { get; init; }
}
