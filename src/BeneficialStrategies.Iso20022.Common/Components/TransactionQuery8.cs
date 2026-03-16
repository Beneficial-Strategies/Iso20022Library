// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Query8.
/// </summary>
[IsoId("_3GZtETEyEe6g-ffJsqGiSA")]
[DisplayName("Transaction Query8")]
public record TransactionQuery8
{
    /// <summary>
    /// Query Type.
    /// </summary>
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Transaction Criteria.
    /// </summary>
    [DisplayName("Transaction Criteria")]
    [IsoXmlTag("TxCrit")]
    public TransactionCriteria8Choice_? TransactionCriteria { get; init; }
}
