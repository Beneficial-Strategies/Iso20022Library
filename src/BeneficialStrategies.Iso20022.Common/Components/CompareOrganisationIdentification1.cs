// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an organisation identification.
/// </summary>
[IsoId("_NQB58bQ5EemI67HK7aviyg")]
[DisplayName("Compare Organisation Identification")]
public partial record CompareOrganisationIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_NUWZQbQ5EemI67HK7aviyg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public OrganisationIdentification9Choice_? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_NUWZQ7Q5EemI67HK7aviyg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public OrganisationIdentification9Choice_? Value2 { get; init; } 
    
    
    #nullable disable
    
}
