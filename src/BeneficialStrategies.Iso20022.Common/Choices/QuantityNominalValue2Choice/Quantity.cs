// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.QuantityNominalValue2Choice
{
    /// <summary>
    /// Quantity of the securities other than bonds.
    /// </summary>
    [IsoId("_b3cSocpbEem6kd3Y9uIDqg")]
    [DisplayName("Quantity")]
    public partial record Quantity : QuantityNominalValue2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
