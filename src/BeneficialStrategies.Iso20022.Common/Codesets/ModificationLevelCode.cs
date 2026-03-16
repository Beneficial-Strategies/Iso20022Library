// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction or position level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZzzfsQ3mEeWc7_0KPiuk6w")]
[Description(@"Specifies the transaction or position level.")]
[Derivations(typeof(ModificationLevel1Code))]
public enum ModificationLevelCode
{
    /// <summary>
    /// Modification applies to a position.
    /// Encoded/decoded by serializers as &quot;PSTN&quot;.
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_d8LDQA3mEeWc7_0KPiuk6w")]
    [Description(@"Modification applies to a position.")]
    Position,

    /// <summary>
    /// Modification applies to a transaction.
    /// Encoded/decoded by serializers as &quot;TCTN&quot;.
    /// </summary>
    [EnumMember(Value = "TCTN")]
    [IsoId("_ea0uIA3mEeWc7_0KPiuk6w")]
    [Description(@"Modification applies to a transaction.")]
    Transaction,
}
