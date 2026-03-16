// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a member.
/// </summary>
[IsoId("_8G7QcaMgEeCJ6YNENx4h-w_1746030860")]
[DisplayName("Member Search Criteria")]
public record MemberSearchCriteria2
{
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_8G7QcqMgEeCJ6YNENx4h-w_-1946163269")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public MemberIdentification2Choice_? Identification { get; init; }

    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    [IsoId("_8G7Qc6MgEeCJ6YNENx4h-w_663964676")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MemberType1Code? Type { get; init; }

    /// <summary>
    /// Status of a member in a system, such as enabled or deleted.
    /// </summary>
    [IsoId("_8G7QdKMgEeCJ6YNENx4h-w_-493200358")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public MemberStatus1Code? Status { get; init; }
}
