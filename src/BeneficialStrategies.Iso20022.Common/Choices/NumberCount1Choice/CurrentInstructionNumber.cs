// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NumberCount1Choice
{
    /// <summary>
    /// Sequential number of the instruction in a range of linked settlement instructions.
    /// </summary>
    [IsoId("_QrsmaNp-Ed-ak6NoX_4Aeg_1394466276")]
    [DisplayName("Current Instruction Number")]
    public record CurrentInstructionNumber : NumberCount1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with an exact length of 3 digits.
        /// </summary>
        [IsoXmlTag("CurInstrNb")]
        [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
        public required IsoExact3NumericText Value { get; init; }
    }
}
