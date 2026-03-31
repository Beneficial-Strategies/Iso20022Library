// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the transfer in.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cP0N0CVNEeWI0orciOKunQ")]
[Description(@"Specifies the function of the transfer in.")]
[Derivations(typeof(TransferInFunction1Code), typeof(TransferInFunction2Code))]
public enum TransferInFunctionCode
{
    /// <summary>
    /// The transfer-in is an advice and request, that is, the message is used to inform the receiver to expect an unsolicited transfer in confirmation and to request account information for the transfer.
    /// Encoded/decoded by serializers as &quot;ADRE&quot;.
    /// </summary>
    [EnumMember(Value = "ADRE")]
    [IsoId("_kBA5QCVNEeWI0orciOKunQ")]
    [Description(
        @"The transfer-in is an advice and request, that is, the message is used to inform the receiver to expect an unsolicited transfer in confirmation and to request account information for the transfer."
    )]
    AdviceAndRequest,

    /// <summary>
    /// The transfer-in is an instruction.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_Fq0hcCVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in is an instruction.")]
    Instruction,

    /// <summary>
    /// The transfer-in provides advice about account information for a transfer.
    /// Encoded/decoded by serializers as &quot;ADVI&quot;.
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_KOaocCVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in provides advice about account information for a transfer.")]
    Advice,

    /// <summary>
    /// The transfer-in is a confirmation (rather than an advice).
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_X8MAACVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in is a confirmation (rather than an advice).")]
    Confirmation,
}
