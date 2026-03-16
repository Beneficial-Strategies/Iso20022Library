// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the references of an account management instruction message.
/// </summary>
[IsoId("_Fl7lsVSfEeatgN-VQ0eFlQ")]
[DisplayName("Account Management Message Reference")]
public record AccountManagementMessageReference4
{
    /// <summary>
    /// Reference to a linked message.
    /// </summary>
    [IsoId("_F-U3mVSfEeatgN-VQ0eFlQ")]
    [DisplayName("Linked Reference")]
    [IsoXmlTag("LkdRef")]
    public LinkedMessage4Choice_? LinkedReference { get; init; }

    /// <summary>
    /// Type of account management instruction for which the status is requested or a request to know the status of the account.
    /// </summary>
    [IsoId("_F-U3m1SfEeatgN-VQ0eFlQ")]
    [DisplayName("Status Request Type")]
    [IsoXmlTag("StsReqTp")]
    public required AccountManagementType3Code StatusRequestType { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    [IsoId("_F-U3nVSfEeatgN-VQ0eFlQ")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_F-U3n1SfEeatgN-VQ0eFlQ")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    public Account23? ExistingAccountIdentification { get; init; }

    /// <summary>
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    [IsoId("_F-U3oVSfEeatgN-VQ0eFlQ")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount53? InvestmentAccount { get; init; }
}
