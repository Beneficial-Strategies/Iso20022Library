// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Query4.
/// </summary>
[IsoId("_6Kcs4TEyEe6g-ffJsqGiSA")]
[DisplayName("Account Query4")]
public partial record AccountQuery4
{
    /// <summary>
    /// Query Type.
    /// </summary>
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Account Criteria.
    /// </summary>
    [DisplayName("Account Criteria")]
    [IsoXmlTag("AcctCrit")]
    public AccountCriteria4Choice_? AccountCriteria { get; init; }
}
