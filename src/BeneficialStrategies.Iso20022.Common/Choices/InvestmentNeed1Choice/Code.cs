// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestmentNeed1Choice
{
    /// <summary>
    /// Investment need expressed as a code.
    /// </summary>
    [IsoId("_PXfw0DcdEeidBoT_PugKiA")]
    [DisplayName("Code")]
    public partial record Code : InvestmentNeed1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an investment need.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentNeed1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
