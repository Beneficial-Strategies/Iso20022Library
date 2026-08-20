// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the identification details to uniquely identify a limit within the system.
/// </summary>
[IsoId("_0WRu0TEyEe6g-ffJsqGiSA")]
[DisplayName("Limit Identification8")]
public record LimitIdentification8
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public BranchAndFinancialInstitutionIdentification8? BilateralLimitCounterpartyIdentification { get; init; }

    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Nature of the risk management limit.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required LimitType1Choice_ Type { get; init; }
}
