// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message used to report to a corporate on the actual set up up of the account, related services and mandates.
/// </summary>
[IsoId("_Qoao59p-Ed-ak6NoX_4Aeg_1996281064")]
[DisplayName("Account Report")]
public record AccountReport1
{
    /// <summary>
    /// Characteristics of the account.
    /// </summary>
    [IsoId("_QokZ4Np-Ed-ak6NoX_4Aeg_999208711")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount1 Account { get; init; }

    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_QokZ4dp-Ed-ak6NoX_4Aeg_-1108775061")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }

    /// <summary>
    /// Specifies target and actual dates.
    /// </summary>
    [IsoId("_QokZ4tp-Ed-ak6NoX_4Aeg_-2105847414")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract3? ContractDates { get; init; }

    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_QokZ49p-Ed-ak6NoX_4Aeg_1192047529")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public ValueList<OperationMandate1> Mandate { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_QokZ5Np-Ed-ak6NoX_4Aeg_194975176")]
    [DisplayName("Reference Account")]
    [IsoXmlTag("RefAcct")]
    public CashAccount16? ReferenceAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account where to transfer the balance.
    /// </summary>
    [IsoId("_QokZ5dp-Ed-ak6NoX_4Aeg_-802097177")]
    [DisplayName("Balance Transfer Account")]
    [IsoXmlTag("BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }

    /// <summary>
    /// Identification of the transfer account servicer.
    /// </summary>
    [IsoId("_QokZ5tp-Ed-ak6NoX_4Aeg_-33187087")]
    [DisplayName("Transfer Account Servicer Identification")]
    [IsoXmlTag("TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification4? TransferAccountServicerIdentification { get; init; }
}
