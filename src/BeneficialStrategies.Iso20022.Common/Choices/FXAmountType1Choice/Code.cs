// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FXAmountType1Choice
{
    /// <summary>
    /// Specifies a commission or fee type.
    /// </summary>
    [IsoId("_Z-9lhQN2Ee2-vqzwMUAewg")]
    [DisplayName("Code")]
    public partial record Code : FXAmountType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of amount for foreign exchange commissions or fees.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FXAmountType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
