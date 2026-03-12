// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity47Choice
{
    /// <summary>
    /// Quantity of delivery.
    /// </summary>
    [IsoId("_cAW1YZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Quantity")]
    public partial record Quantity : Quantity47Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, such as 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
        public required IsoLongFraction19DecimalNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
