// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NumberCount2Choice
{
    /// <summary>
    /// Sequential number of the instruction in a range of linked settlement instructions.
    /// </summary>
    [IsoId("_JaoZcygdEey2k_sfZmJz4g")]
    [DisplayName("Current Instruction Number")]
    public partial record CurrentInstructionNumber : NumberCount2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a maximum length of 6 digits.
        /// </summary>
        [IsoXmlTag("CurInstrNb")]
        [IsoSimpleType(IsoSimpleType.Max6NumericText)]
        public required IsoMax6NumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
