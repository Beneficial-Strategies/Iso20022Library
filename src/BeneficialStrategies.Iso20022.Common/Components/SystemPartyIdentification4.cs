// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the executing system, to unambiguously identify the party in the system.
/// </summary>
[IsoId("_jPKmw-5NEeCisYr99QEiWA_578360019")]
[DisplayName("System Party Identification")]
public partial record SystemPartyIdentification4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_jPKmxO5NEeCisYr99QEiWA_1870157368")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public required IsoBICFIIdentifier Identification { get; init; } 
    
    /// <summary>
    /// Unique identification of the party responsible (national central bank or central securities depositary) for the party reference data.
    /// </summary>
    [IsoId("_jPUXwO5NEeCisYr99QEiWA_-1904747478")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public CSDOrNCB1Choice_? ResponsiblePartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
