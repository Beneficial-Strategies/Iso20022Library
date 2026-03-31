// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an instruction is for a market or client side transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YJO4wJ05Eeet_4BCDEBLdQ")]
[Description(@"Specifies if an instruction is for a market or client side transaction.")]
[DerivedFrom(typeof(MarketClientSideCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarketClientSide1Code>))]
#endif
public enum MarketClientSide1Code
{
    /// <summary>
    /// Instruction is for a client side transaction.
    /// Encoded/decoded by serializers as &quot;CLNT&quot;.
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("_ZWTI0Z05Eeet_4BCDEBLdQ")]
    [Description(@"Instruction is for a client side transaction.")]
    ClientSide = MarketClientSideCode.ClientSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is for a market side transaction.
    /// Encoded/decoded by serializers as &quot;MAKT&quot;.
    /// </summary>
    [EnumMember(Value = "MAKT")]
    [IsoId("_ZbqJ8Z05Eeet_4BCDEBLdQ")]
    [Description(@"Instruction is for a market side transaction.")]
    MarketSide = MarketClientSideCode.MarketSide, // same ordinal as derivation source for type conversions
}
