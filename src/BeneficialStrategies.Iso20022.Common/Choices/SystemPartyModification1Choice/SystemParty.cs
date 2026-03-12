// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification1Choice
{
    /// <summary>
    /// Specifies the party reference data, as assigned by the system.
    /// </summary>
    [IsoId("_kouatO5NEeCisYr99QEiWA_769363521")]
    [DisplayName("System Party")]
    public partial record SystemParty : SystemPartyModification1Choice_
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
}
