// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the classification and thus the restrictions associated with an order (for regulatory purposes).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aReN09p-Ed-ak6NoX_4Aeg_-414935483")]
[Description(
    @"Identifies the classification and thus the restrictions associated with an order (for regulatory purposes)."
)]
[DerivedFrom(typeof(OrderClassificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OrderRestrictions1Code>))]
#endif
public enum OrderRestrictions1Code
{
    /// <summary>
    /// Purchase or sale of a large number of stocks. Originally called program trading when index funds and other institutional|investors began to embark on large-scale buying and selling campaigns or programs to replicate a target stock index. The|term includes computer aided stock market buying or selling programs, portfolio insurance and index arbitrage.
    /// Encoded/decoded by serializers as &quot;PROG&quot;.
    /// </summary>
    [EnumMember(Value = "PROG")]
    [IsoId("_aReN1Np-Ed-ak6NoX_4Aeg_1960362266")]
    [Description(
        @"Purchase or sale of a large number of stocks. Originally called program trading when index funds and other institutional|investors began to embark on large-scale buying and selling campaigns or programs to replicate a target stock index. The|term includes computer aided stock market buying or selling programs, portfolio insurance and index arbitrage."
    )]
    ProgramTrade = OrderClassificationCode.ProgramTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Program trade on a stock index. Simultaneous purchase and sale of an index future and the index underlying securities to|profit from intermarket spreads between the future and the index itself.
    /// Encoded/decoded by serializers as &quot;ARBT&quot;.
    /// </summary>
    [EnumMember(Value = "ARBT")]
    [IsoId("_aReN1dp-Ed-ak6NoX_4Aeg_1960362301")]
    [Description(
        @"Program trade on a stock index. Simultaneous purchase and sale of an index future and the index underlying securities to|profit from intermarket spreads between the future and the index itself."
    )]
    IndexArbitrage = OrderClassificationCode.IndexArbitrage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Simultaneous purchase and sale of a large number of securities to profit from intermarket spreads between financial|instruments that do not include stock indexes.
    /// Encoded/decoded by serializers as &quot;NARB&quot;.
    /// </summary>
    [EnumMember(Value = "NARB")]
    [IsoId("_aReN1tp-Ed-ak6NoX_4Aeg_1960362319")]
    [Description(
        @"Simultaneous purchase and sale of a large number of securities to profit from intermarket spreads between financial|instruments that do not include stock indexes."
    )]
    NonIndexArbitrage = OrderClassificationCode.NonIndexArbitrage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specialist or market maker registered as such on a registered stock exchange, or a market maker bidding and offering over-the-counter.
    /// Encoded/decoded by serializers as &quot;CMAR&quot;.
    /// </summary>
    [EnumMember(Value = "CMAR")]
    [IsoId("_aReN19p-Ed-ak6NoX_4Aeg_1960362379")]
    [Description(
        @"Specialist or market maker registered as such on a registered stock exchange, or a market maker bidding and offering over-the-counter."
    )]
    CompetingMarketMaker = OrderClassificationCode.CompetingMarketMaker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specialist or market maker registered as such on a registered stock exchange, or a market maker acting based on a set of|rules applicable to a defined security.
    /// Encoded/decoded by serializers as &quot;SSPE&quot;.
    /// </summary>
    [EnumMember(Value = "SSPE")]
    [IsoId("_aReN2Np-Ed-ak6NoX_4Aeg_1960362421")]
    [Description(
        @"Specialist or market maker registered as such on a registered stock exchange, or a market maker acting based on a set of|rules applicable to a defined security."
    )]
    SpecialistInSecurity = OrderClassificationCode.SpecialistInSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specialist or market maker registered as such on a registered stock exchange, or a market maker acting based on a set of|rules applicable to a defined underlying security of a derivative product.
    /// Encoded/decoded by serializers as &quot;USPE&quot;.
    /// </summary>
    [EnumMember(Value = "USPE")]
    [IsoId("_aRn-0Np-Ed-ak6NoX_4Aeg_1960362456")]
    [Description(
        @"Specialist or market maker registered as such on a registered stock exchange, or a market maker acting based on a set of|rules applicable to a defined underlying security of a derivative product."
    )]
    SpecialistInUnderlyingSecurity = OrderClassificationCode.SpecialistInUnderlyingSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non domestic business entity, foreign government or regulatory jurisdiction.
    /// Encoded/decoded by serializers as &quot;FORE&quot;.
    /// </summary>
    [EnumMember(Value = "FORE")]
    [IsoId("_aRn-0dp-Ed-ak6NoX_4Aeg_1960362516")]
    [Description(@"Non domestic business entity, foreign government or regulatory jurisdiction.")]
    ForeignEntity = OrderClassificationCode.ForeignEntity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participating entity not registered on an exchange.
    /// Encoded/decoded by serializers as &quot;EXMA&quot;.
    /// </summary>
    [EnumMember(Value = "EXMA")]
    [IsoId("_aRn-0tp-Ed-ak6NoX_4Aeg_1960362776")]
    [Description(@"Participating entity not registered on an exchange.")]
    ExternalMarketParticipant = OrderClassificationCode.ExternalMarketParticipant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participating entity linked but not registered on an exchange.
    /// Encoded/decoded by serializers as &quot;MALI&quot;.
    /// </summary>
    [EnumMember(Value = "MALI")]
    [IsoId("_aRn-09p-Ed-ak6NoX_4Aeg_1960362828")]
    [Description(@"Participating entity linked but not registered on an exchange.")]
    ExternalInterConnectedMarketLinkage =
        OrderClassificationCode.ExternalInterConnectedMarketLinkage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Risk-free transaction consisting of purchasing an asset at one price and simultaneously selling that same asset at a higher|price, generating a profit on the difference.
    /// Encoded/decoded by serializers as &quot;RARB&quot;.
    /// </summary>
    [EnumMember(Value = "RARB")]
    [IsoId("_aRn-1Np-Ed-ak6NoX_4Aeg_1960362888")]
    [Description(
        @"Risk-free transaction consisting of purchasing an asset at one price and simultaneously selling that same asset at a higher|price, generating a profit on the difference."
    )]
    RisklessArbitrage = OrderClassificationCode.RisklessArbitrage, // same ordinal as derivation source for type conversions
}
