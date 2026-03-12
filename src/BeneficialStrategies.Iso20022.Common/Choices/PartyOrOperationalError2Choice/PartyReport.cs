// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyOrOperationalError2Choice
{
    /// <summary>
    /// Report information about party reference data.
    /// </summary>
    [IsoId("_enGS0fAzEeWPfa2xBhBfLQ")]
    [DisplayName("Party Report")]
    public partial record PartyReport : PartyOrOperationalError2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification to unambiguously identify the party within the system.
        /// </summary>
        [IsoId("_ewUgQfAzEeWPfa2xBhBfLQ")]
        [DisplayName("Party Identification")]
        [IsoXmlTag("PtyId")]
        public required SystemPartyIdentification3 PartyIdentification { get; init; } 
        
        /// <summary>
        /// Identifies the returned party reference data or error information.
        /// </summary>
        [IsoId("_ewUgQ_AzEeWPfa2xBhBfLQ")]
        [DisplayName("Party Or Error")]
        [IsoXmlTag("PtyOrErr")]
        public required PartyOrBusinessError2Choice_ PartyOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
