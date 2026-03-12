// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_k4nFNZKuEeGnRMFvqYmPBQ")]
[DisplayName("Party And Signature")]
public partial record PartyAndSignature2
{
    #nullable enable
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_k4nFOJKuEeGnRMFvqYmPBQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification43 Party { get; init; } 
    
    /// <summary>
    /// Signature of a party.
    /// </summary>
    [IsoId("_k4nFO5KuEeGnRMFvqYmPBQ")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public required ProprietaryData3 Signature { get; init; } 
    
    
    #nullable disable
    
}
