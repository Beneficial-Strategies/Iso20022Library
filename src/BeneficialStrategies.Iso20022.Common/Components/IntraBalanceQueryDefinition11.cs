// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Balance Query Definition11.
/// </summary>
[IsoId("_7BmXUTEyEe6g-ffJsqGiSA")]
[DisplayName("Intra Balance Query Definition11")]
public record IntraBalanceQueryDefinition11
{
    /// <summary>
    /// Query Type.
    /// </summary>
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required MovementResponseType1Code QueryType { get; init; }

    /// <summary>
    /// Search Criteria.
    /// </summary>
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required IntraBalanceQueryCriteria11 SearchCriteria { get; init; }
}
