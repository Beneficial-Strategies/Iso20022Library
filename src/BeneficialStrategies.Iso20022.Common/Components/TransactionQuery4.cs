// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the query criteria.
/// </summary>
[IsoId("_UpdMG5lQEee-Zps0fZQaFQ")]
[DisplayName("Transaction Query")]
public partial record TransactionQuery4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_Uxo3s5lQEee-Zps0fZQaFQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    /// Defines the payment transaction query criteria.
    /// </summary>
    [IsoId("_Uxo3tZlQEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Criteria")]
    [IsoXmlTag("TxCrit")]
    public TransactionCriteria4Choice_? TransactionCriteria { get; init; } 
    
    
    #nullable disable
    
}
