// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PensionOrderType1Choice
{
    /// <summary>
    /// Type of order attached to the pension policy, plan or scheme expressed as a code.
    /// </summary>
    [IsoId("_BlYN0LTqEeiENt6AoDfPXg")]
    [DisplayName("Code")]
    public partial record Code : PensionOrderType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of order attached to a pension.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PensionOrderType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
