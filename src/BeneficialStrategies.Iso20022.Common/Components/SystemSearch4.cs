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
[IsoId("_-HV9wW49EeiU9cctagi5ow")]
[DisplayName("System Search")]
public record SystemSearch4
{
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_-RLPI249EeiU9cctagi5ow")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public ClearingSystemIdentification3Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_-RLPJW49EeiU9cctagi5ow")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public BranchAndFinancialInstitutionIdentification6? MemberIdentification { get; init; }

    /// <summary>
    /// Country in which the system is located.
    /// </summary>
    [IsoId("_-RLPJ249EeiU9cctagi5ow")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_-RLPKW49EeiU9cctagi5ow")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }
}
