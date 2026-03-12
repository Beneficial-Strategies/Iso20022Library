// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionType1Choice
{
    /// <summary>
    /// Identifies the meeting instruction message for which the status is provided.
    /// </summary>
    [IsoId("_RCWL1dp-Ed-ak6NoX_4Aeg_2129843244")]
    [DisplayName("Instruction Identification")]
    public partial record InstructionIdentification : InstructionType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// String of characters that uniquely identifies a message.
        /// </summary>
        [IsoId("_Q6vvANp-Ed-ak6NoX_4Aeg_1505878618")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        
        #nullable disable
        
    }
}
