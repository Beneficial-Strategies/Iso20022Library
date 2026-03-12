// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NumberCount2Choice
{
    /// <summary>
    /// Total numbers of settlement transactions, receipts and deliveries, and the concerned settlement transaction number.
    /// </summary>
    [IsoId("_JaoZeygdEey2k_sfZmJz4g")]
    [DisplayName("Total Number")]
    public partial record TotalNumber : NumberCount2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sequential number of the instruction in a range of linked settlement instructions.
        /// </summary>
        [IsoId("_JyxMpSgdEey2k_sfZmJz4g")]
        [DisplayName("Current Instruction Number")]
        [IsoXmlTag("CurInstrNb")]
        [IsoSimpleType(IsoSimpleType.Max6NumericText)]
        public required IsoMax6NumericText CurrentInstructionNumber { get; init; } 
        
        /// <summary>
        /// Total number of settlement instructions that are linked together.
        /// </summary>
        [IsoId("_JyxMrSgdEey2k_sfZmJz4g")]
        [DisplayName("Total Of Linked Instructions")]
        [IsoXmlTag("TtlOfLkdInstrs")]
        [IsoSimpleType(IsoSimpleType.Max6NumericText)]
        public required IsoMax6NumericText TotalOfLinkedInstructions { get; init; } 
        
        
        #nullable disable
        
    }
}
