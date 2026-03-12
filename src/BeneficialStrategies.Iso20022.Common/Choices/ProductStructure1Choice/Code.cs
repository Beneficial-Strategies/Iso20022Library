// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProductStructure1Choice
{
    /// <summary>
    /// Product structure expressed as a code.
    /// </summary>
    [IsoId("_PSZn4KDqEequlaOyi6MUhw")]
    [DisplayName("Code")]
    public partial record Code : ProductStructure1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the structure of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProductStructure1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
