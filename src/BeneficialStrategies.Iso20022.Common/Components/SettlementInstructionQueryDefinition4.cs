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
[IsoId("_VSF1oagzEfCXwLUUylXgrQ")]
[DisplayName("Settlement Instruction Query Definition4")]
public record SettlementInstructionQueryDefinition4
{
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_WmMh0agzEfCXwLUUylXgrQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required SettlementQueryType1Code QueryType { get; init; }

    /// <summary>
    /// Defines the criteria to extract the securities settlement instruction information.
    /// </summary>
    [IsoId("_WmMh06gzEfCXwLUUylXgrQ")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required SettlementInstructionQueryCriteria4 SearchCriteria { get; init; }
}
