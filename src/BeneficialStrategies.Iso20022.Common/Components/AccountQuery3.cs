// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the query criteria.
/// </summary>
[IsoId("_PTgkR249EeiU9cctagi5ow")]
[DisplayName("Account Query")]
public record AccountQuery3
{
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_PhEfE249EeiU9cctagi5ow")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Defines the account query criteria.
    /// </summary>
    [IsoId("_PhEfFW49EeiU9cctagi5ow")]
    [DisplayName("Account Criteria")]
    [IsoXmlTag("AcctCrit")]
    public AccountCriteria3Choice_? AccountCriteria { get; init; }
}
