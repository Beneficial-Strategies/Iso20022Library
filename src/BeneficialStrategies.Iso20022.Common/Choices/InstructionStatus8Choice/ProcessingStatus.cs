// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus8Choice
{
    /// <summary>
    /// Status advising on the processing of the instruction.
    /// </summary>
    [IsoId("_9DhyU6-nEemJ1NnLPsTFaw")]
    [DisplayName("Processing Status")]
    public partial record ProcessingStatus : InstructionStatus8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Status code.
        /// </summary>
        [IsoId("_9YNB0a-nEemJ1NnLPsTFaw")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required Status8Code Status { get; init; } 
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_9YNB06-nEemJ1NnLPsTFaw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
