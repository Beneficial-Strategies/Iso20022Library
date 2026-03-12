// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus19Choice
{
    /// <summary>
    /// Specifies the reason of the pending processing status.
    /// </summary>
    [IsoId("_qTGQaSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Reason")]
    public partial record Reason : PendingProcessingStatus19Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has a pending processing status.
        /// </summary>
        [IsoId("_qTGQdyAdEeuyDZ-ukt4YRg")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingProcessingReason18Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_qTGQfyAdEeuyDZ-ukt4YRg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
