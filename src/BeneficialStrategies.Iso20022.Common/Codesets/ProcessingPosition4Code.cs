// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_A2UAQBEhEeKG5rB3aM9OkQ")]
[Description(
    @"Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction."
)]
[DerivedFrom(typeof(ProcessingPositionCode))]
public enum ProcessingPosition4Code
{
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed after the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;AFTE&quot;.
    /// </summary>
    [EnumMember(Value = "AFTE")]
    [IsoId("_DsSH0REhEeKG5rB3aM9OkQ")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed after the linked transaction/instruction."
    )]
    After = ProcessingPositionCode.After, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the transaction/instruction is to be executed before the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;BEFO&quot;.
    /// </summary>
    [EnumMember(Value = "BEFO")]
    [IsoId("_D2RKQREhEeKG5rB3aM9OkQ")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed before the linked transaction/instruction."
    )]
    Before = ProcessingPositionCode.Before, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the transaction/instruction is to be executed with the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_EAs4oREhEeKG5rB3aM9OkQ")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed with the linked transaction/instruction."
    )]
    With = ProcessingPositionCode.With, // same ordinal as derivation source for type conversions
}
