// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation4Choice
{
    /// <summary>
    /// Default.
    /// </summary>
    [DisplayName("Default")]
    public partial record Default : CurrentOrDefaultReservation4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Dflt")]
        public required ReservationIdentification4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
