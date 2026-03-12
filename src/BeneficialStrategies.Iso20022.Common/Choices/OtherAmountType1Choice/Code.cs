// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OtherAmountType1Choice
{
    /// <summary>
    /// Type of amount expressed as a code.
    /// </summary>
    [IsoId("_fJLzgI2NEeeNN9vGwZc5aA")]
    [DisplayName("Code")]
    public partial record Code : OtherAmountType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of other amount.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OtherAmountType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
