// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a securities identification.
/// </summary>
[IsoId("_vPvfoa5nEeuo-IflVgGqiA")]
[DisplayName("Compare Security Identification")]
public partial record CompareSecurityIdentification4
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_veyoQa5nEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public SecurityIdentification26Choice_? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second of the transaction.
    /// </summary>
    [IsoId("_veyoQ65nEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public SecurityIdentification26Choice_? Value2 { get; init; } 
    
    
    #nullable disable
    
}
