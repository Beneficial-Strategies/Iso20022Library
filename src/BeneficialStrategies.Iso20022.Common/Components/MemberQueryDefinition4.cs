// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the query criteria.
/// </summary>
[IsoId("_iR9okXSbEeiH1ZOt2UD8vQ")]
[DisplayName("Member Query Definition")]
public record MemberQueryDefinition4
{
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_igVbw3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Defines the member query criteria.
    /// </summary>
    [IsoId("_igVbxXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Criteria")]
    [IsoXmlTag("MmbCrit")]
    public MemberCriteriaDefinition2Choice_? MemberCriteria { get; init; }
}
