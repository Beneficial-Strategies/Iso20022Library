// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExposureType1Choice
{
    /// <summary>
    /// Collateral movement exposure type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QuOV8dp-Ed-ak6NoX_4Aeg_562710363")]
    [DisplayName("Code")]
    public partial record Code : ExposureType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying business area/type of trade causing the collateral movement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExposureType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
