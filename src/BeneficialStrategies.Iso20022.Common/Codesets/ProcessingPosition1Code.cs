// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates when an instruction is to be executed relative to a linked instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKxI5tp-Ed-ak6NoX_4Aeg_1002961302")]
[Description(@"Indicates when an instruction is to be executed relative to a linked instruction.")]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum ProcessingPosition1Code
{
    /// <summary>
    /// Indicates that the instruction is to be executed after the linked instruction.
    /// Encoded/decoded by serializers as &quot;AFTR&quot;.
    /// </summary>
    [EnumMember(Value = "AFTR")]
    [IsoId("_aKxI59p-Ed-ak6NoX_4Aeg_1050983994")]
    [Description(@"Indicates that the instruction is to be executed after the linked instruction.")]
    After,

    /// <summary>
    /// Indicates that the instruction is to be executed with the linked instruction.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aKxI6Np-Ed-ak6NoX_4Aeg_1067607065")]
    [Description(@"Indicates that the instruction is to be executed with the linked instruction.")]
    With,

    /// <summary>
    /// Indicates that the instruction is to be executed before the linked instruction.
    /// Encoded/decoded by serializers as &quot;BEFR&quot;.
    /// </summary>
    [EnumMember(Value = "BEFR")]
    [IsoId("_aK654Np-Ed-ak6NoX_4Aeg_1089773397")]
    [Description(
        @"Indicates that the instruction is to be executed before the linked instruction."
    )]
    Before,
}
