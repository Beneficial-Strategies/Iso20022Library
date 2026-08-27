// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a trading venue which must use the market identification code (MIC).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Liu7QYTPEfClBYp_xDbOWg")]
[Description(@"Specifies the type of a trading venue which must use the market identification code (MIC).")]
[DerivedFrom(typeof(TradingVenueCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingVenue5Code>))]
public enum TradingVenue5Code
{
    /// <summary>
    /// Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_Ljvn4YTPEfClBYp_xDbOWg")]
    [Description(
        @"Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system."
    )]
    SystematicInternaliser = TradingVenueCode.SystematicInternaliser,
}
