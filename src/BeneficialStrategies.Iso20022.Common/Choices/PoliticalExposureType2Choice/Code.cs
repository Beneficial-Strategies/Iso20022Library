// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PoliticalExposureType2Choice
{
    /// <summary>
    /// Type of political exposure expressed as a code.
    /// </summary>
    [IsoId("_wk5jQZUgEemC09f0MxYkRg")]
    [DisplayName("Code")]
    public partial record Code : PoliticalExposureType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the political exposure type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PoliticalExposureType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
