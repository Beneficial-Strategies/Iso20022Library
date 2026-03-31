// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// System3.
/// </summary>
[IsoId("_1uCzDzEyEe6g-ffJsqGiSA")]
[DisplayName("System3")]
public record System3
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Member Identification.
    /// </summary>
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public BranchAndFinancialInstitutionIdentification8? MemberIdentification { get; init; }

    /// <summary>
    /// System Identification.
    /// </summary>
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public MarketInfrastructureIdentification1Choice_? SystemIdentification { get; init; }
}
