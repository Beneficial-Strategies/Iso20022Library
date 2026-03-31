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
[IsoId("_i_EmMXSbEeiH1ZOt2UD8vQ")]
[DisplayName("Member Search Criteria")]
public record MemberSearchCriteria4
{
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_jUYH0XSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<MemberIdentification3Choice_> Identification { get; init; } = [];

    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    [IsoId("_jUYH03SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValueList<SystemMemberType1Choice_> Type { get; init; } = [];

    /// <summary>
    /// Status of a member in a system, such as enabled or deleted.
    /// </summary>
    [IsoId("_jUYH1XSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public ValueList<SystemMemberStatus1Choice_> Status { get; init; } = [];
}
