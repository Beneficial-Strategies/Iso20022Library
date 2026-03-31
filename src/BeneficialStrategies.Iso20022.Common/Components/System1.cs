// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Search for a system and a member of a system.
/// </summary>
[IsoId("_78osBaMgEeCJ6YNENx4h-w_-1378873885")]
[DisplayName("System")]
public record System1
{
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_78osBqMgEeCJ6YNENx4h-w_-1966603864")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public MarketInfrastructureIdentification1Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_78osB6MgEeCJ6YNENx4h-w_318406574")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public BranchAndFinancialInstitutionIdentification5? MemberIdentification { get; init; }

    /// <summary>
    /// Country in which the system is located.
    /// </summary>
    [IsoId("_78ydAKMgEeCJ6YNENx4h-w_2130304799")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_78ydAaMgEeCJ6YNENx4h-w_-601242164")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }
}
