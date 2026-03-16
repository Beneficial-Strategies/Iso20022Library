// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice
{
    /// <summary>
    /// Standing Order.
    /// </summary>
    [DisplayName("Standing Order")]
    public partial record StandingOrder : StandingOrderOrAll4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("StgOrdr")]
        public required StandingOrderIdentification8 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
