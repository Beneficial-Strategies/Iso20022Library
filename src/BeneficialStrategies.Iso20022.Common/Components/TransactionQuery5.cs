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
[IsoId("_OHgrZ249EeiU9cctagi5ow")]
[DisplayName("Transaction Query")]
public record TransactionQuery5
{
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_OV994249EeiU9cctagi5ow")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Defines the payment transaction query criteria.
    /// </summary>
    [IsoId("_OV995W49EeiU9cctagi5ow")]
    [DisplayName("Transaction Criteria")]
    [IsoXmlTag("TxCrit")]
    public TransactionCriteria5Choice_? TransactionCriteria { get; init; }
}
