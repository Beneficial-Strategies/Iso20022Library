// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OriginalEnrolment3Choice
{
    /// <summary>
    /// Original Enrolment Data.
    /// </summary>
    [DisplayName("Original Enrolment Data")]
    public partial record OriginalEnrolmentData : OriginalEnrolment3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlEnrlmntData")]
        public required CreditorEnrolment5 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
