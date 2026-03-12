// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyOrOperationalError1Choice
{
    /// <summary>
    /// Report information about party reference data.
    /// </summary>
    [IsoId("_kniH5O5NEeCisYr99QEiWA_-1882219329")]
    [DisplayName("Party Report")]
    public partial record PartyReport : PartyOrOperationalError1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification to unambiguously identify the party within the system.
        /// </summary>
        [IsoId("_knr44e5NEeCisYr99QEiWA_-521330042")]
        [DisplayName("Party Identification")]
        [IsoXmlTag("PtyId")]
        public required SystemPartyIdentification3 PartyIdentification { get; init; } 
        
        /// <summary>
        /// Identifies the returned party reference data or error information.
        /// </summary>
        [IsoId("_knr44u5NEeCisYr99QEiWA_1062655976")]
        [DisplayName("Party Or Error")]
        [IsoXmlTag("PtyOrErr")]
        public required PartyOrBusinessError1Choice_ PartyOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
