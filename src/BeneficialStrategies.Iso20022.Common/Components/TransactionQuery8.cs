// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Query8.
/// </summary>
[IsoId("_3GZtETEyEe6g-ffJsqGiSA")]
[DisplayName("Transaction Query8")]
public partial record TransactionQuery8
{
    #nullable enable

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

    
    #nullable disable
    
}
