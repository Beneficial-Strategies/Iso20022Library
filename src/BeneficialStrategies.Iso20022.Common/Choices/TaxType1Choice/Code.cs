// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxType1Choice
{
    /// <summary>
    /// Type of tax expressed as a code.
    /// </summary>
    [IsoId("_4SMDcBuHEeOqSdXzJ0oydA")]
    [DisplayName("Code")]
    public partial record Code : TaxType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxType16Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
