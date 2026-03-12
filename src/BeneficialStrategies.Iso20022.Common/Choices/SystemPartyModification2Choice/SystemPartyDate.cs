// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Specifies the opening and closing dates, as assigned by the system.
    /// </summary>
    [IsoId("_yJhSoYv-Eei289CGNqs21g")]
    [DisplayName("System Party Date")]
    public partial record SystemPartyDate : SystemPartyModification2Choice_
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
