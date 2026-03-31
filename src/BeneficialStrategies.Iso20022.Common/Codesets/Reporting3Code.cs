// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies to which institution the reporting must be done.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4mWQgNB4EeihG9bKfarOOA")]
[Description(@"Identifies to which institution the reporting must be done.")]
[DerivedFrom(typeof(ReportingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Reporting3Code>))]
#endif
public enum Reporting3Code
{
    /// <summary>
    /// Relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_7EMzAdB4EeihG9bKfarOOA")]
    [Description(@"Relates to a buy-in by the market following a delivery transaction failure.")]
    BuyIn = ReportingCode.BuyIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report is deferred, for example, because the order was executed in partial fills.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_7Nt7YdB4EeihG9bKfarOOA")]
    [Description(
        @"Report is deferred, for example, because the order was executed in partial fills."
    )]
    DeferredReport = ReportingCode.DeferredReport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade details are to be reported to a regulatory organisation.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_7UkKQdB4EeihG9bKfarOOA")]
    [Description(@"Trade details are to be reported to a regulatory organisation.")]
    RegulatoryOrganisation = ReportingCode.RegulatoryOrganisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade details are to be reported to a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_7a9GIdB4EeihG9bKfarOOA")]
    [Description(@"Trade details are to be reported to a stock exchange.")]
    StockExchange = ReportingCode.StockExchange, // same ordinal as derivation source for type conversions
}
