// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification259Choice
{
    /// <summary>
    /// Individual Owner Identification.
    /// </summary>
    [DisplayName("Individual Owner Identification")]
    public partial record IndividualOwnerIdentification : PartyIdentification259Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IndvOwnrId")]
        public required AlternatePartyIdentification11 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
