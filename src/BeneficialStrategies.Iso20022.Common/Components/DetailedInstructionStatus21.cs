// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed Instruction Status21.
/// </summary>
[IsoId("_Yi4uMYY_Ee-5eN4DwJpixA")]
[DisplayName("Detailed Instruction Status21")]
public record DetailedInstructionStatus21
{
    /// <summary>
    /// Single Instruction Identification.
    /// </summary>
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    public required Max35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public Max35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Sub Account Identification.
    /// </summary>
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public Max35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Instruction Status.
    /// </summary>
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionStatus13Choice_ InstructionStatus { get; init; }
}
