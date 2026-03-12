// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ThresholdBasis1Choice
{
    /// <summary>
    /// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings and provided as a code value.
    /// </summary>
    [IsoId("_4JOLYBuMEeyhRdHRjakS2w")]
    [DisplayName("Code")]
    public partial record Code : ThresholdBasis1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ThresholdBasis1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
