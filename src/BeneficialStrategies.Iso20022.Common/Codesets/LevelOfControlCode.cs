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
[IsoId("_Y7LFQCDDEeWPMvNwVtiMsA")]
[Description(@"Specifies the level of control.")]
[Derivations(typeof(LevelOfControl1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LevelOfControlCode>))]
#endif
public enum LevelOfControlCode
{
    /// <summary>
    /// Account may be viewed only.
    /// Encoded/decoded by serializers as &quot;VIEW&quot;.
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_dyic0CDDEeWPMvNwVtiMsA")]
    [Description(@"Account may be viewed only.")]
    View,

    /// <summary>
    /// Transactions are permitted on the account.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_gcSGQCDDEeWPMvNwVtiMsA")]
    [Description(@"Transactions are permitted on the account.")]
    Transactions,
}
