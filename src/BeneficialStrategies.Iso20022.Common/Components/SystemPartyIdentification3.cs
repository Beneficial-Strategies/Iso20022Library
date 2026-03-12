// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification to unambiguously identify the party within the system.
/// </summary>
[IsoId("_knPM8u5NEeCisYr99QEiWA_1121388777")]
[DisplayName("System Party Identification")]
public partial record SystemPartyIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_knPM8-5NEeCisYr99QEiWA_-2106270244")]
    [DisplayName("Related Party Identification")]
    [IsoXmlTag("RltdPtyId")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public required IsoBICFIIdentifier RelatedPartyIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    [IsoId("_knPM9O5NEeCisYr99QEiWA_1566757500")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public required IsoBICFIIdentifier ResponsiblePartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
