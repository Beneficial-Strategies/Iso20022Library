// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ShipmentCondition1Choice
{
    /// <summary>
    /// Shipment conditions expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_c0JRgLGdEeuSTr8k0UEM8A")]
    [DisplayName("Code")]
    public partial record Code : ShipmentCondition1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a shipment conditions code, as published in the external ISO 20022 external code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalShipmentCondition1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
