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
[IsoId("_WowJEWdnEemMLeaDfmIfIA")]
[DisplayName("Securities Modification Query Definition1")]
public record SecuritiesModificationQueryDefinition1
{
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_W1DfsWdnEemMLeaDfmIfIA")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required MovementResponseType1Code QueryType { get; init; }

    /// <summary>
    /// Defines the criteria to extract the intra-position movement instruction information.
    /// </summary>
    [IsoId("_W1Dfs2dnEemMLeaDfmIfIA")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required SecuritiesModificationQueryCriteria1 SearchCriteria { get; init; }
}
