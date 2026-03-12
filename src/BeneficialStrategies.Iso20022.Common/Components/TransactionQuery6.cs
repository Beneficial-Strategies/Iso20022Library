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
[IsoId("_gQWLwdcZEeqRFcf2R4bPBw")]
[DisplayName("Transaction Query")]
public partial record TransactionQuery6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_gSybwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    /// Defines the payment transaction query criteria.
    /// </summary>
    [IsoId("_gSybw9cZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Criteria")]
    [IsoXmlTag("TxCrit")]
    public TransactionCriteria6Choice_? TransactionCriteria { get; init; } 
    
    
    #nullable disable
    
}
