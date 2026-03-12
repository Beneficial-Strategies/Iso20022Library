// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus18Choice
{
    /// <summary>
    /// Specifies the reason of the pending processing status.
    /// </summary>
    [IsoId("_6vhl2QpJEeup4r-PFG2T5Q")]
    [DisplayName("Reason")]
    public partial record Reason : PendingProcessingStatus18Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has a pending processing status.
        /// </summary>
        [IsoId("_68BwwQpJEeup4r-PFG2T5Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingProcessingReason17Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_68BwyQpJEeup4r-PFG2T5Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
