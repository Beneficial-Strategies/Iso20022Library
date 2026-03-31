// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQggEtp-Ed-ak6NoX_4Aeg_-1064258208")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Status3Code>))]
#endif
public enum Status3Code
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_ZQggE9p-Ed-ak6NoX_4Aeg_-780737301")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = StatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZQggFNp-Ed-ak6NoX_4Aeg_-763187538")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No instruction has been received (to be used in a reminder).
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_ZQggFdp-Ed-ak6NoX_4Aeg_-748412104")]
    [Description(@"No instruction has been received (to be used in a reminder).")]
    NotReceived = StatusCode.NotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ZQggFtp-Ed-ak6NoX_4Aeg_-734560081")]
    [Description(@"Processing has been completed.")]
    Completed = StatusCode.Completed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been received by Issuer.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_ZQggF9p-Ed-ak6NoX_4Aeg_-719784966")]
    [Description(@"Instruction has been received by Issuer.")]
    ReceivedByIssuerOrRegistrar = StatusCode.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_ZQggGNp-Ed-ak6NoX_4Aeg_-695771510")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction = StatusCode.StandingInstruction, // same ordinal as derivation source for type conversions
}
