// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a person or an organisation.
/// </summary>
[IsoId("_DnnxDVtjEeSwKe7KuKvXhg")]
[DisplayName("Party Identification")]
public partial record PartyIdentification71
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_EEU7I1tjEeSwKe7KuKvXhg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification40Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Ancillary identification information about the party.
    /// </summary>
    [IsoId("_EEU7JVtjEeSwKe7KuKvXhg")]
    [DisplayName("Additional Identification Information")]
    [IsoXmlTag("AddtlIdInf")]
    public PartyAdditionalIdentification2Choice_? AdditionalIdentificationInformation { get; init; } 
    
    
    #nullable disable
    
}
