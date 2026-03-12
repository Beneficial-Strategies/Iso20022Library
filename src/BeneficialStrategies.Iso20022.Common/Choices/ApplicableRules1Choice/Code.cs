// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ApplicableRules1Choice
{
    /// <summary>
    /// Applicable rules expressed as a code.
    /// </summary>
    [IsoId("_zP4owFNeEeijdq8ilaxyOA")]
    [DisplayName("Code")]
    public partial record Code : ApplicableRules1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies applicable rules.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ApplicableRules1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
