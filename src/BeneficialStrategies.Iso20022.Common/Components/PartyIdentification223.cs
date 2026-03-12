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
[IsoId("_Ka3fUa-GEemJ1NnLPsTFaw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification223
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_Kv-Mo6-GEemJ1NnLPsTFaw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification227Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Ancillary identification information about the party.
    /// </summary>
    [IsoId("_Kv-Mpa-GEemJ1NnLPsTFaw")]
    [DisplayName("Additional Identification Information")]
    [IsoXmlTag("AddtlIdInf")]
    public PartyAdditionalIdentification2Choice_? AdditionalIdentificationInformation { get; init; } 
    
    
    #nullable disable
    
}
