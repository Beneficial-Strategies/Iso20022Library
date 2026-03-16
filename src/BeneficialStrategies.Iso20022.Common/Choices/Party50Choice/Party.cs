// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party50Choice
{
    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    public partial record Party : Party50Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Pty")]
        public required PartyIdentification272 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
