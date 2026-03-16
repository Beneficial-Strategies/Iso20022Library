// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification255Choice
{
    /// <summary>
    /// BIC.
    /// </summary>
    [DisplayName("BIC")]
    public partial record BIC : PartyIdentification255Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BIC")]
        public required IsoAnyBICDec2014Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
