// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DividendTypeFormat3Choice
{
    /// <summary>
    /// Standard code to specify the frequency of the corporate action event.
    /// </summary>
    [IsoId("_KsR2M93iEd-KAqAOGQOnnw")]
    [DisplayName("Code")]
    public partial record Code : DividendTypeFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the frequency of a CA event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionFrequencyType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
