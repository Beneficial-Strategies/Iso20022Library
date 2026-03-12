// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InformationDistribution1Choice
{
    /// <summary>
    /// Information distribution expressed as a code.
    /// </summary>
    [IsoId("_HJm3ACCVEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public partial record Code : InformationDistribution1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies how information is to be distributed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InformationDistribution2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
