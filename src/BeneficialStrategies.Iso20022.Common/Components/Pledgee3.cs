// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the entity to which the financial instruments are pledged.
/// </summary>
[IsoId("_X818odLGEeiN28wlpBQScw")]
[DisplayName("Pledgee")]
public partial record Pledgee3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_YdRwM9LGEeiN28wlpBQScw")]
    [DisplayName("Pledgee Type And Identification")]
    [IsoXmlTag("PldgeeTpAndId")]
    public PledgeeFormat5Choice_? PledgeeTypeAndIdentification { get; init; } 
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_YdRwNdLGEeiN28wlpBQScw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    
    #nullable disable
    
}
