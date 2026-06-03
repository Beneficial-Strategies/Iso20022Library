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
[IsoId("_YKC8sWdnEemMLeaDfmIfIA")]
[DisplayName("Securities Cancellation Query Definition1")]
public record SecuritiesCancellationQueryDefinition1
{
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_YaxgUWdnEemMLeaDfmIfIA")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required MovementResponseType1Code QueryType { get; init; }

    /// <summary>
    /// Defines the criteria to extract the cancellation instructions for intra-position movements or settlement instructions information.
    /// </summary>
    [IsoId("_YaxgU2dnEemMLeaDfmIfIA")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required SecuritiesCancellationQueryCriteria1 SearchCriteria { get; init; }
}
