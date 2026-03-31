// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a trading venue which can submit the report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p3TiYF0gEeWErPfQ7BYx8A")]
[Description(@"Specifies the type of a trading venue which can submit the report.")]
[DerivedFrom(typeof(TradingVenueCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradingVenue2Code>))]
#endif
public enum TradingVenue2Code
{
    /// <summary>
    /// Person authorised under the provisions established in the regulation to provide the service of publishing trade reports on behalf of investment firms.
    /// Encoded/decoded by serializers as &quot;APPA&quot;.
    /// </summary>
    [EnumMember(Value = "APPA")]
    [IsoId("_dy31QV0iEeWErPfQ7BYx8A")]
    [Description(
        @"Person authorised under the provisions established in the regulation to provide the service of publishing trade reports on behalf of investment firms."
    )]
    ApprovedPublicationArrangement = TradingVenueCode.ApprovedPublicationArrangement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Provider which will consolidate post-trade information into a continuous electronic data stream and make it publicly available as close to real time as technologically possible on a reasonable commercial basis and free of charge after 15 minutes.
    /// Encoded/decoded by serializers as &quot;CTPS&quot;.
    /// </summary>
    [EnumMember(Value = "CTPS")]
    [IsoId("_F8rOgb4BEeWvRsMSLyTf-A")]
    [Description(
        @"Provider which will consolidate post-trade information into a continuous electronic data stream and make it publicly available as close to real time as technologically possible on a reasonable commercial basis and free of charge after 15 minutes."
    )]
    ConsolidatedTapeProvider = TradingVenueCode.ConsolidatedTapeProvider, // same ordinal as derivation source for type conversions
}
