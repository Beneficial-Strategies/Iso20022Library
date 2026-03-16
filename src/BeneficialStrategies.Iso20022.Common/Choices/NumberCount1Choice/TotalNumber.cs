// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NumberCount1Choice
{
    /// <summary>
    /// Total numbers of settlement transactions, receipts and deliveries, and the concerned settlement transaction number.
    /// </summary>
    [IsoId("_Qrsmadp-Ed-ak6NoX_4Aeg_-2040702072")]
    [DisplayName("Total Number")]
    public record TotalNumber : NumberCount1Choice_
    {
        /// <summary>
        /// Sequential number of the instruction in a range of linked settlement instructions.
        /// </summary>
        [IsoId("_Qr_hWdp-Ed-ak6NoX_4Aeg_-2082263388")]
        [DisplayName("Current Instruction Number")]
        [IsoXmlTag("CurInstrNb")]
        [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
        public required IsoExact3NumericText CurrentInstructionNumber { get; init; }

        /// <summary>
        /// Total number of settlement instructions that are linked together.
        /// </summary>
        [IsoId("_Qr_hWtp-Ed-ak6NoX_4Aeg_-1935589206")]
        [DisplayName("Total Of Linked Instructions")]
        [IsoXmlTag("TtlOfLkdInstrs")]
        [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
        public required IsoExact3NumericText TotalOfLinkedInstructions { get; init; }
    }
}
