// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.YieldedOrValueType2Choice
{
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_VBLs0wycEeuG8M5giQ2e0w")]
    [DisplayName("Value Type")]
    public partial record ValueType : YieldedOrValueType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Price will not be paid.
        /// </summary>
        [IsoXmlTag("ValTp")]
        public required PriceValueType12Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
