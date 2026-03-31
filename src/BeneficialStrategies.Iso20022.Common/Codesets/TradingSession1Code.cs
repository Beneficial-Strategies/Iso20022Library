// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the factors that are/were applied in the event of pre-allocation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdcnYg93EeGeV5vP7Mvdig_-213678965")]
[Description(@"Indicates the factors that are/were applied in the event of pre-allocation.")]
[DerivedFrom(typeof(TradingSessionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradingSession1Code>))]
#endif
public enum TradingSession1Code
{
    /// <summary>
    /// Orders that are traded in regularly occuring auctions: orders are accumulated and executed on basis of defined algorithms.
    /// Encoded/decoded by serializers as &quot;AUCT&quot;.
    /// </summary>
    [EnumMember(Value = "AUCT")]
    [IsoId("_zdcnYw93EeGeV5vP7Mvdig_407428199")]
    [Description(
        @"Orders that are traded in regularly occuring auctions: orders are accumulated and executed on basis of defined algorithms."
    )]
    Auction = TradingSessionCode.Auction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading process where orders are executed directly against each others as they hit the marketplace.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_zdcnZA93EeGeV5vP7Mvdig_574841635")]
    [Description(
        @"Trading process where orders are executed directly against each others as they hit the marketplace."
    )]
    Continuous = TradingSessionCode.Continuous, // same ordinal as derivation source for type conversions
}
