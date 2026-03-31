// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the transfer in.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iCdscCVOEeWI0orciOKunQ")]
[Description(@"Specifies the function of the transfer in.")]
[DerivedFrom(typeof(TransferInFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransferInFunction1Code>))]
#endif
public enum TransferInFunction1Code
{
    /// <summary>
    /// The transfer-in is an advice and request, that is, the message is used to inform the receiver to expect an unsolicited transfer in confirmation and to request account information for the transfer.
    /// Encoded/decoded by serializers as &quot;ADRE&quot;.
    /// </summary>
    [EnumMember(Value = "ADRE")]
    [IsoId("_nxMJ0SVOEeWI0orciOKunQ")]
    [Description(
        @"The transfer-in is an advice and request, that is, the message is used to inform the receiver to expect an unsolicited transfer in confirmation and to request account information for the transfer."
    )]
    AdviceAndRequest = TransferInFunctionCode.AdviceAndRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The transfer-in is an instruction.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_n5X1cSVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in is an instruction.")]
    Instruction = TransferInFunctionCode.Instruction, // same ordinal as derivation source for type conversions
}
