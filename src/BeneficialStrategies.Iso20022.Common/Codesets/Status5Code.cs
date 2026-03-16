// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yaalktp-Ed-ak6NoX_4Aeg_-277478982")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
public enum Status5Code
{
    /// <summary>
    /// Instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_Yaalk9p-Ed-ak6NoX_4Aeg_1715573718")]
    [Description(@"Instruction has been rejected.")]
    Rejected = StatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_YaallNp-Ed-ak6NoX_4Aeg_832340431")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_Yaalldp-Ed-ak6NoX_4Aeg_-1533344004")]
    [Description(@"Instruction is pending.")]
    Pending = StatusCode.Pending, // same ordinal as derivation source for type conversions
}
