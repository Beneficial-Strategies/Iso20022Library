// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_XaDfZ_WfEemtd4wHZYvFUQ")]
[DisplayName("Organisation Identification")]
public partial record OrganisationIdentification33
{
    #nullable enable
    
    /// <summary>
    /// Business identification code of the organisation.
    /// </summary>
    [IsoId("_XaDfa_WfEemtd4wHZYvFUQ")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public required IsoAnyBICDec2014Identifier AnyBIC { get; init; } 
    
    
    #nullable disable
    
}
