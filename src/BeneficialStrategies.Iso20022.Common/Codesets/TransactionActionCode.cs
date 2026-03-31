// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Action to realise on a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VgL1MNuTEeiB5uLfkg9ZJA")]
[Description(@"Action to realise on a transaction.")]
[Derivations(typeof(TransactionAction1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionActionCode>))]
#endif
public enum TransactionActionCode
{
    /// <summary>
    /// Start a transaction by a swipe ahead mechanism, with the services which are enabled.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_ZrkQgNuTEeiB5uLfkg9ZJA")]
    [Description(
        @"Start a transaction by a swipe ahead mechanism, with the services which are enabled."
    )]
    StartTransaction,

    /// <summary>
    /// Keep quite after a swipe ahead mechanism.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_-0oHoOzHEeiojesOXOKoug")]
    [Description(@"Keep quite after a swipe ahead mechanism.")]
    Stop,
}
