// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the information that is searched through the definition of specific criteria.
/// </summary>
[IsoId("_34wQ0eSlEe-qVZLXW4RRBw")]
[DisplayName("Intra Position Query Definition8")]
public record IntraPositionQueryDefinition8
{
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_4CKrgeSlEe-qVZLXW4RRBw")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required MovementResponseType1Code QueryType { get; init; }

    /// <summary>
    /// Defines the criteria to extract the intra-position movement instruction information.
    /// </summary>
    [IsoId("_4CKrg-SlEe-qVZLXW4RRBw")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required IntraPositionQueryCriteria8 SearchCriteria { get; init; }
}
