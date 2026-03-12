// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person or an organisation.
/// </summary>
[IsoId("_fZe8sSGYEeWKAaDJcYGKLw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification96
{
    #nullable enable
    
    /// <summary>
    /// Identification of the organisation.
    /// </summary>
    [IsoId("_f2C84SGYEeWKAaDJcYGKLw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification96Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_f2C84yGYEeWKAaDJcYGKLw")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    
    
    #nullable disable
    
}
