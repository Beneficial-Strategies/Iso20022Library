// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus47Choice
{
    /// <summary>
    /// Provides status information related to an instruction request that is accepted. This means that the instruction has been received, is processable and has been validated for further processing.
    /// </summary>
    [IsoId("_KVKx3Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Accepted For Further Processing")]
    public partial record AcceptedForFurtherProcessing : InstructionProcessingStatus47Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_UatOwNp-Ed-ak6NoX_4Aeg_137164408")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        
        
        #nullable disable
        
    }
}
