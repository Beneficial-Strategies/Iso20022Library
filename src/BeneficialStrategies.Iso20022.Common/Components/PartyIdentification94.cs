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
[IsoId("_lTBtZkyiEeWw591U1lOHyQ")]
[DisplayName("Party Identification")]
public partial record PartyIdentification94
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    [IsoId("_lTBtZ0yiEeWw591U1lOHyQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party1? Identification { get; init; } 
    
    
    #nullable disable
    
}
