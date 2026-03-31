// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of debit to be applied to the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JtKwwMmKEeWAGphE2LvqeA")]
[Description(@"Specifies the type of debit to be applied to the payment.")]
[Derivations(typeof(DebitType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DebitTypeCode>))]
#endif
public enum DebitTypeCode
{
    /// <summary>
    /// Debit is performed as a global debit for all instructions in the file.
    /// Encoded/decoded by serializers as &quot;GLBL&quot;.
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_NBtqsMmKEeWAGphE2LvqeA")]
    [Description(@"Debit is performed as a global debit for all instructions in the file.")]
    Global,

    /// <summary>
    /// Debit is performed as an individual single debit for each instruction in the file.
    /// Encoded/decoded by serializers as &quot;SNGL&quot;.
    /// </summary>
    [EnumMember(Value = "SNGL")]
    [IsoId("_P6wUYMmKEeWAGphE2LvqeA")]
    [Description(
        @"Debit is performed as an individual single debit for each instruction in the file."
    )]
    Single,
}
