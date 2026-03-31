// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level of control.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kcJ1ICDDEeWPMvNwVtiMsA")]
[Description(@"Specifies the level of control.")]
[DerivedFrom(typeof(LevelOfControlCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LevelOfControl1Code>))]
#endif
public enum LevelOfControl1Code
{
    /// <summary>
    /// Transactions are permitted on the account.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_mhS8sSDDEeWPMvNwVtiMsA")]
    [Description(@"Transactions are permitted on the account.")]
    Transactions = LevelOfControlCode.Transactions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account may be viewed only.
    /// Encoded/decoded by serializers as &quot;VIEW&quot;.
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_mpeoUSDDEeWPMvNwVtiMsA")]
    [Description(@"Account may be viewed only.")]
    View = LevelOfControlCode.View, // same ordinal as derivation source for type conversions
}
