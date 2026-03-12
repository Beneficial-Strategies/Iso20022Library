// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus43Choice
{
    /// <summary>
    /// Status of the standing settlement instruction, cancellation or deletion is expressed in a bilaterally agreed manner.
    /// </summary>
    [IsoId("_fDHA-VhFEeOMYfRGLS0NbA")]
    [DisplayName("Proprietary Status")]
    public partial record ProprietaryStatus : ProcessingStatus43Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the status of the instruction.
        /// </summary>
        [IsoId("_A0uE0VhHEeOMYfRGLS0NbA")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required GenericIdentification36 Status { get; init; } 
        
        /// <summary>
        /// Proprietary identification of the reason for the status.
        /// </summary>
        [IsoId("_A0uE01hHEeOMYfRGLS0NbA")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required ProprietaryReason1Choice_ Reason { get; init; } 
        
        /// <summary>
        /// Additional information about the processed instruction.
        /// </summary>
        [IsoId("_80za9Vj8EeOgwYxfAV02bg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
