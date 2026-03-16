// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification259Choice
{
    /// <summary>
    /// Proprietary Identification.
    /// </summary>
    [DisplayName("Proprietary Identification")]
    public partial record ProprietaryIdentification : PartyIdentification259Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrtryId")]
        public required GenericIdentification84 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
