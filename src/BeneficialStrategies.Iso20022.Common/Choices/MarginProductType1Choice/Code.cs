// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MarginProductType1Choice
{
    /// <summary>
    /// Specifies the underlying product of the margin using a code.
    /// </summary>
    [IsoId("_Qk_hddp-Ed-ak6NoX_4Aeg_-96904731")]
    [DisplayName("Code")]
    public partial record Code : MarginProductType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying product of the margin.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarginProduct1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
