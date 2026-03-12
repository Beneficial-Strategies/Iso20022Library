// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the type of payload.
/// </summary>
[IsoId("_jMCaQe5NEeCisYr99QEiWA_994991099")]
[DisplayName("Payload Type Details")]
public partial record PayloadTypeDetails1
{
    #nullable enable
    
    /// <summary>
    /// Declaration of the payload content. Describes the type of business document being exchanged.
    /// When sending a copy or a duplicate of a previous document set, the document set identification must remain identical.
    /// </summary>
    [IsoId("_jMCaQu5NEeCisYr99QEiWA_851619662")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Type { get; init; } 
    
    
    #nullable disable
    
}
