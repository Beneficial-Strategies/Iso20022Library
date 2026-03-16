// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice
{
    /// <summary>
    /// All Standing Orders.
    /// </summary>
    [DisplayName("All Standing Orders")]
    public partial record AllStandingOrders : StandingOrderOrAll4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AllStgOrdrs")]
        public required StandingOrderIdentification9 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
