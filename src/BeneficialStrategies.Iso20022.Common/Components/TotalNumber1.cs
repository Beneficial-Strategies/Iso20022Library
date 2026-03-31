// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement transaction numbering information.
/// </summary>
[IsoId("_Qr_hWNp-Ed-ak6NoX_4Aeg_-606322098")]
[DisplayName("Total Number")]
public record TotalNumber1
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
