// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat53Choice
{
    /// <summary>
    /// Type And Identification.
    /// </summary>
    [DisplayName("Type And Identification")]
    public partial record TypeAndIdentification : SafekeepingPlaceFormat53Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("TpAndId")]
        public required SafekeepingPlaceTypeAndIdentification1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
