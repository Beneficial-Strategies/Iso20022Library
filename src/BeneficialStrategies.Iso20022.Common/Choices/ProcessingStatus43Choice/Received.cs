// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus43Choice
{
    /// <summary>
    /// Status of the standing settlement instruction, cancellation or deletion is received for further processing.
    /// </summary>
    [IsoId("_T_H5oVhGEeOMYfRGLS0NbA")]
    [DisplayName("Received")]
    public partial record Received : ProcessingStatus43Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the received status.
        /// </summary>
        [IsoId("_Kak_EFj7EeOgwYxfAV02bg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required ReceivedReason1Choice_ Reason { get; init; } 
        
        /// <summary>
        /// Additional information about the processed instruction.
        /// </summary>
        [IsoId("_Kak_C1j7EeOgwYxfAV02bg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
