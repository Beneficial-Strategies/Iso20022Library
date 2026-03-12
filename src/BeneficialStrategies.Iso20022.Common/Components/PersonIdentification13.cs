// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_jJrTQa9UEeeJJK1oRb-jTw")]
[DisplayName("Person Identification")]
public partial record PersonIdentification13
{
    #nullable enable
    
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_jU7hA69UEeeJJK1oRb-jTw")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_jU7hBa9UEeeJJK1oRb-jTw")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericPersonIdentification1? Other { get; init; } 
    
    
    #nullable disable
    
}
