// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExposureType21Choice
{
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure expressed as a code.
    /// </summary>
    [IsoId("_2WM6sSW1EeyT3chuyX0PgA")]
    [DisplayName("Code")]
    public partial record Code : ExposureType21Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying business area/type of trade causing the collateral movement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExposureType11Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
