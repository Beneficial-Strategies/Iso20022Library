// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus34Choice
{
    /// <summary>
    /// Specifies the reason of the rejection status.
    /// </summary>
    [IsoId("_UVa1kxIwEeydmIVkS03esw")]
    [DisplayName("Reason")]
    public partial record Reason : RejectionStatus34Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction/request has a repair or rejection status.
        /// </summary>
        [IsoId("_Uq4IMRIwEeydmIVkS03esw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason40Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_Uq4IMxIwEeydmIVkS03esw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
