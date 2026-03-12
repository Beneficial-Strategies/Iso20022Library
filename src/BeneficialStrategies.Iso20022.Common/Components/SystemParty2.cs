// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the definition of a party within a system. 
/// A party shall denote any legal or organisational entity required in the system. 
/// This entity shall store the parties from the first three levels: the system operator, the central securities depositaries, the participants of the central securities depositaries, the national central banks and payment banks.
/// </summary>
[IsoId("_kmC6Ie5NEeCisYr99QEiWA_-1914948225")]
[DisplayName("System Party")]
public partial record SystemParty2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    [IsoId("_kmC6Iu5NEeCisYr99QEiWA_1131494895")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OpeningDate { get; init; } 
    
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    [IsoId("_kmC6I-5NEeCisYr99QEiWA_-586504225")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; } 
    
    
    #nullable disable
    
}
