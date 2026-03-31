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
[IsoId("_YgFItdp-Ed-ak6NoX_4Aeg_-2065088389")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Status4Code>))]
#endif
public enum Status4Code
{
    /// <summary>
    /// Instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_YgFIttp-Ed-ak6NoX_4Aeg_703110423")]
    [Description(@"Instruction has been rejected.")]
    Rejected = StatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_YgFIt9p-Ed-ak6NoX_4Aeg_-1140758566")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusCode.Accepted, // same ordinal as derivation source for type conversions
}
