// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information relative to the processing of the trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aO8eQNp-Ed-ak6NoX_4Aeg_492685359")]
[Description(@"Specifies additional information relative to the processing of the trade.")]
[Derivations(typeof(OpeningClosing1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OpeningClosingCode>))]
#endif
public enum OpeningClosingCode
{
    /// <summary>
    /// Indicates that the trade is to close a position.
    /// Encoded/decoded by serializers as &quot;CLOP&quot;.
    /// </summary>
    [EnumMember(Value = "CLOP")]
    [IsoId("_aO8eQdp-Ed-ak6NoX_4Aeg_-1120350445")]
    [Description(@"Indicates that the trade is to close a position.")]
    ClosePosition,

    /// <summary>
    /// Indicates that the trade is to open a position.
    /// Encoded/decoded by serializers as &quot;OPEP&quot;.
    /// </summary>
    [EnumMember(Value = "OPEP")]
    [IsoId("_aO8eQtp-Ed-ak6NoX_4Aeg_-724160897")]
    [Description(@"Indicates that the trade is to open a position.")]
    OpenPosition,
}
