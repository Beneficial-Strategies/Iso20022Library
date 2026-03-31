// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing position.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aK654dp-Ed-ak6NoX_4Aeg_-853418510")]
[Description(@"Specifies the processing position.")]
[DerivedFrom(typeof(ProcessingPositionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProcessingPosition2Code>))]
#endif
public enum ProcessingPosition2Code
{
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed after the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;AFTE&quot;.
    /// </summary>
    [EnumMember(Value = "AFTE")]
    [IsoId("_aK654tp-Ed-ak6NoX_4Aeg_-853418508")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed after the linked transaction/instruction."
    )]
    After = ProcessingPositionCode.After, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the transaction/instruction is to be executed with the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aK6549p-Ed-ak6NoX_4Aeg_-852498516")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed with the linked transaction/instruction."
    )]
    With = ProcessingPositionCode.With, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the transaction/instruction is to be executed before the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;BEFO&quot;.
    /// </summary>
    [EnumMember(Value = "BEFO")]
    [IsoId("_aK655Np-Ed-ak6NoX_4Aeg_-852498508")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed before the linked transaction/instruction."
    )]
    Before = ProcessingPositionCode.Before, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the transactions/instructions are linked for information purposes only.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_aK655dp-Ed-ak6NoX_4Aeg_-852498507")]
    [Description(
        @"Specifies that the transactions/instructions are linked for information purposes only."
    )]
    Information = ProcessingPositionCode.Information, // same ordinal as derivation source for type conversions
}
