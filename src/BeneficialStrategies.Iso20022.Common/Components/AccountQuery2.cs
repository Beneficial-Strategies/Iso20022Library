// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the query criteria.
/// </summary>
[IsoId("_31xkUZlaEeeE1Ya-LgRsuQ")]
[DisplayName("Account Query")]
public partial record AccountQuery2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_39sKM5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    /// Defines the account query criteria.
    /// </summary>
    [IsoId("_39sKNZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Criteria")]
    [IsoXmlTag("AcctCrit")]
    public AccountCriteria2Choice_? AccountCriteria { get; init; } 
    
    
    #nullable disable
    
}
