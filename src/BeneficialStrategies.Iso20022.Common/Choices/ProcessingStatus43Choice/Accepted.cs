// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus43Choice
{
    /// <summary>
    /// Status of the standing settlement instruction, cancellation or deletion is 
    /// acknowledged/accepted for further processing. The instruction has been received, is processable and has been validated for further processing.
    /// </summary>
    [IsoId("_fDHA8VhFEeOMYfRGLS0NbA")]
    [DisplayName("Accepted")]
    public partial record Accepted : ProcessingStatus43Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the accepted status.
        /// </summary>
        [IsoId("_-wWtP1jyEeOnqqBHs8Gasw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required AcceptedReason8Choice_ Reason { get; init; } 
        
        /// <summary>
        /// Additional information about the processed instruction.
        /// </summary>
        [IsoId("_-wWtQ1jyEeOnqqBHs8Gasw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
