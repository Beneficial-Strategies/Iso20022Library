// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// indicates if the Trade Regulatory Conditions is solicited or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__yXpItojEeC60axPepSq7g_-160167061")]
[Description(@"indicates if the Trade Regulatory Conditions is solicited or not.")]
[Derivations(typeof(TradeRegulatoryConditions1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeRegulatoryConditionsCode>))]
#endif
public enum TradeRegulatoryConditionsCode
{
    /// <summary>
    /// Trade was solicited by the executing broker. The broker has suggested to his client to buy/sell financial instruments.
    /// Encoded/decoded by serializers as &quot;SOLI&quot;.
    /// </summary>
    [EnumMember(Value = "SOLI")]
    [IsoId("__yXpI9ojEeC60axPepSq7g_-1107312564")]
    [Description(
        @"Trade was solicited by the executing broker. The broker has suggested to his client to buy/sell financial instruments."
    )]
    Solicited,

    /// <summary>
    /// Trade was unsolicited. The client acts on its own without advice from the executing broker.
    /// Encoded/decoded by serializers as &quot;USOL&quot;.
    /// </summary>
    [EnumMember(Value = "USOL")]
    [IsoId("__yXpJNojEeC60axPepSq7g_-1334779676")]
    [Description(
        @"Trade was unsolicited. The client acts on its own without advice from the executing broker."
    )]
    Unsolicited,
}
