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
[IsoId("_aUTfYdp-Ed-ak6NoX_4Aeg_-982611626")]
[Description(@"Specifies if an instruction is for a market or client side transaction.")]
[Derivations(typeof(MarketClientSide1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarketClientSideCode>))]
#endif
public enum MarketClientSideCode
{
    /// <summary>
    /// Instruction is for a market side transaction.
    /// Encoded/decoded by serializers as &quot;MAKT&quot;.
    /// </summary>
    [EnumMember(Value = "MAKT")]
    [IsoId("_aUTfYtp-Ed-ak6NoX_4Aeg_263219665")]
    [Description(@"Instruction is for a market side transaction.")]
    MarketSide,

    /// <summary>
    /// Instruction is for a client side transaction.
    /// Encoded/decoded by serializers as &quot;CLNT&quot;.
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("_aUTfY9p-Ed-ak6NoX_4Aeg_550432167")]
    [Description(@"Instruction is for a client side transaction.")]
    ClientSide,
}
