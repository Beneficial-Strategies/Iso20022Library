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
[IsoId("_aK655tp-Ed-ak6NoX_4Aeg_-1877116911")]
[Description(@"Specifies the processing position.")]
[DerivedFrom(typeof(ProcessingPositionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProcessingPosition3Code>))]
#endif
public enum ProcessingPosition3Code
{
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed after the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;AFTE&quot;.
    /// </summary>
    [EnumMember(Value = "AFTE")]
    [IsoId("_aK6559p-Ed-ak6NoX_4Aeg_-1877116893")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed after the linked transaction/instruction."
    )]
    After = ProcessingPositionCode.After, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the transaction/instruction is to be executed with the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aK656Np-Ed-ak6NoX_4Aeg_-1877116876")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed with the linked transaction/instruction."
    )]
    With = ProcessingPositionCode.With, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the transaction/instruction is to be executed before the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;BEFO&quot;.
    /// </summary>
    [EnumMember(Value = "BEFO")]
    [IsoId("_aLED0Np-Ed-ak6NoX_4Aeg_-1877116833")]
    [Description(
        @"Specifies that the transaction/instruction is to be executed before the linked transaction/instruction."
    )]
    Before = ProcessingPositionCode.Before, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the transactions/instructions are linked for information purposes only.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_aLED0dp-Ed-ak6NoX_4Aeg_-1877116816")]
    [Description(
        @"Specifies that the transactions/instructions are linked for information purposes only."
    )]
    Information = ProcessingPositionCode.Information, // same ordinal as derivation source for type conversions
}
