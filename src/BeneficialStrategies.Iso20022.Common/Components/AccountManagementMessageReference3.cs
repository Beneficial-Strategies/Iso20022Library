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
[IsoId("_dJFMsSFeEeW9XJWqfgXIIA")]
[DisplayName("Account Management Message Reference")]
public record AccountManagementMessageReference3
{
    /// <summary>
    /// Reference to a linked message.
    /// </summary>
    [IsoId("_dqQnISFeEeW9XJWqfgXIIA")]
    [DisplayName("Linked Reference")]
    [IsoXmlTag("LkdRef")]
    public LinkedMessage3Choice_? LinkedReference { get; init; }

    /// <summary>
    /// Specifies if the status request refers to an earlier account opening or modification instruction message.
    /// </summary>
    [IsoId("_dqQnIyFeEeW9XJWqfgXIIA")]
    [DisplayName("Status Request Type")]
    [IsoXmlTag("StsReqTp")]
    public required AccountManagementType1Code StatusRequestType { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    [IsoId("_dqQnJSFeEeW9XJWqfgXIIA")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_s9JIcVxQEeW8MLuBzR10cg")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ExistingAccountIdentification { get; init; }

    /// <summary>
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    [IsoId("_dqQnJyFeEeW9XJWqfgXIIA")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount53? InvestmentAccount { get; init; }
}
