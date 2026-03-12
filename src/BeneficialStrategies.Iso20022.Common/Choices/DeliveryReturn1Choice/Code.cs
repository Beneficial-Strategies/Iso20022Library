// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DeliveryReturn1Choice
{
    /// <summary>
    /// Delivery return expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QuOV9Np-Ed-ak6NoX_4Aeg_1548361835")]
    [DisplayName("Code")]
    public partial record Code : DeliveryReturn1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of delivery return.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DeliveryReturn1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
