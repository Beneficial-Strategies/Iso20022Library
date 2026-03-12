// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DeemedRateType1Choice
{
    /// <summary>
    /// Standard code to specify the type of deemed rate.
    /// </summary>
    [IsoId("_D-CdNZSmEeeh5JjedkaA_g")]
    [DisplayName("Code")]
    public partial record Code : DeemedRateType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a deemed rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DeemedRateType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
