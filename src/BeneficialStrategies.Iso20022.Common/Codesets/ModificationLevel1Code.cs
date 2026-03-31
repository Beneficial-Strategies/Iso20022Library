// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction or position level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_khDskA3mEeWc7_0KPiuk6w")]
[Description(@"Specifies the transaction or position level.")]
[DerivedFrom(typeof(ModificationLevelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ModificationLevel1Code>))]
#endif
public enum ModificationLevel1Code
{
    /// <summary>
    /// Modification applies to a position.
    /// Encoded/decoded by serializers as &quot;PSTN&quot;.
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_YvcnEbSZEeeTnocDRx5mhw")]
    [Description(@"Modification applies to a position.")]
    Position = ModificationLevelCode.Position, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification applies to a transaction.
    /// Encoded/decoded by serializers as &quot;TCTN&quot;.
    /// </summary>
    [EnumMember(Value = "TCTN")]
    [IsoId("_Y83YAbSZEeeTnocDRx5mhw")]
    [Description(@"Modification applies to a transaction.")]
    Transaction = ModificationLevelCode.Transaction, // same ordinal as derivation source for type conversions
}
