// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DeliveryInterconnectionPoint1Choice
{
    /// <summary>
    /// Identification of delivery/interconnection point or zone as a code.
    /// </summary>
    [IsoId("_oI0MQIOsEeWqmeP8QNJBew")]
    [DisplayName("Code")]
    public partial record Code : DeliveryInterconnectionPoint1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Energy identification coding scheme.
        /// </summary>
        [IsoXmlTag("Cd")]
        [IsoSimpleType(IsoSimpleType.EICIdentifier)]
        public required IsoEICIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
