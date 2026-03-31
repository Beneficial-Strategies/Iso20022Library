// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Identification8.
/// </summary>
[IsoId("_0WRu0TEyEe6g-ffJsqGiSA")]
[DisplayName("Limit Identification8")]
public record LimitIdentification8
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Bilateral Limit Counterparty Identification.
    /// </summary>
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public BranchAndFinancialInstitutionIdentification8? BilateralLimitCounterpartyIdentification { get; init; }

    /// <summary>
    /// System Identification.
    /// </summary>
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required LimitType1Choice_ Type { get; init; }
}
