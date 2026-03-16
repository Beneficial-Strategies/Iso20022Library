// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Card Reader Application Protocol Data Unit Request message.
/// </summary>
[IsoId("_m22qMN7BEeiwsev40qZGEQ")]
[DisplayName("Device Send Application Protocol Data Unit Card Reader Request")]
public record DeviceSendApplicationProtocolDataUnitCardReaderRequest1
{
    /// <summary>
    /// Class field of the Application Protocol Data Unit command (CLA).
    /// </summary>
    [IsoId("_sVzmMN7BEeiwsev40qZGEQ")]
    [DisplayName("Class")]
    [IsoXmlTag("Clss")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    public required IsoMin1Max256Binary Class { get; init; }

    /// <summary>
    /// Instruction field of the Application Protocol Data Unit command (INS).
    /// </summary>
    [IsoId("_u3PoMN7BEeiwsev40qZGEQ")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    public required IsoMin1Max256Binary Instruction { get; init; }

    /// <summary>
    /// Parameter 1 field of the Application Protocol Data Unit command
    /// </summary>
    [IsoId("_xNyBwN7BEeiwsev40qZGEQ")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param1")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    public required IsoMin1Max256Binary Parameter1 { get; init; }

    /// <summary>
    /// Parameter 2 field of the Application Protocol Data Unit command
    /// </summary>
    [IsoId("_0qCoEe15Eei-V5h0ja04AA")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param2")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    public required IsoMin1Max256Binary Parameter2 { get; init; }

    /// <summary>
    /// Data field of the Application Protocol Data Unit command to send including the length.
    /// </summary>
    [IsoId("_APE2sN7CEeiwsev40qZGEQ")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    public IsoMin1Max256Binary? Data { get; init; }

    /// <summary>
    /// Expected length of the data field of the Application Protocol Data Unit response to the command.
    /// </summary>
    [IsoId("_DORLsN7CEeiwsev40qZGEQ")]
    [DisplayName("Expected Length")]
    [IsoXmlTag("XpctdLngth")]
    [IsoSimpleType(IsoSimpleType.Min1Max256Binary)]
    public IsoMin1Max256Binary? ExpectedLength { get; init; }
}
