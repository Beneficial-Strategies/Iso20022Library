// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the status of the confirmation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cU5H8IBCEeSUJZYcWGKkkw")]
[Description(@"Identifies the status of the confirmation.")]
[DerivedFrom(typeof(TradeConfirmationStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeConfirmationStatus1Code>))]
#endif
public enum TradeConfirmationStatus1Code
{
    /// <summary>
    /// All current status of the trade.
    /// Encoded/decoded by serializers as &quot;ALST&quot;.
    /// </summary>
    [EnumMember(Value = "ALST")]
    [IsoId("_hJ9SEYBFEeSUJZYcWGKkkw")]
    [Description(@"All current status of the trade.")]
    AllStatus = TradeConfirmationStatusCode.AllStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trades are confirmed by Central Matching Utility (analogous to virtual matching utility).
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_hO3nQYBFEeSUJZYcWGKkkw")]
    [Description(
        @"Trades are confirmed by Central Matching Utility (analogous to virtual matching utility)."
    )]
    Confirmed = TradeConfirmationStatusCode.Confirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade information of the both trading member is unmatched.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_hTuSEYBFEeSUJZYcWGKkkw")]
    [Description(@"Trade information of the both trading member is unmatched.")]
    Disaccord = TradeConfirmationStatusCode.Disaccord, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Matching Utility (analogous to virtual matching utility) confirms trades in contingency.
    /// Encoded/decoded by serializers as &quot;EMCN&quot;.
    /// </summary>
    [EnumMember(Value = "EMCN")]
    [IsoId("_hYigoYBFEeSUJZYcWGKkkw")]
    [Description(
        @"Central Matching Utility (analogous to virtual matching utility) confirms trades in contingency."
    )]
    EmergencyConfirmed = TradeConfirmationStatusCode.EmergencyConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade information between Central Matching Utility(analogous to virtual matching utility) and the trading member is mismatched.
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_hdZLcYBFEeSUJZYcWGKkkw")]
    [Description(
        @"Trade information between Central Matching Utility(analogous to virtual matching utility) and the trading member is mismatched."
    )]
    Mismatched = TradeConfirmationStatusCode.Mismatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Home party has confirmed, but couterparty is unrecognized.
    /// Encoded/decoded by serializers as &quot;SCCN&quot;.
    /// </summary>
    [EnumMember(Value = "SCCN")]
    [IsoId("_hijYQYBFEeSUJZYcWGKkkw")]
    [Description(@"Home party has confirmed, but couterparty is unrecognized.")]
    SelfConfirmedAndCouterpartyNotConfirmed =
        TradeConfirmationStatusCode.SelfConfirmedAndCouterpartyNotConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Home party has not confirmed, but couterparty is recognized.
    /// Encoded/decoded by serializers as &quot;SNCC&quot;.
    /// </summary>
    [EnumMember(Value = "SNCC")]
    [IsoId("_hnzrsYBFEeSUJZYcWGKkkw")]
    [Description(@"Home party has not confirmed, but couterparty is recognized.")]
    SelfNotConfirmedAndCouterpartyConfirmed =
        TradeConfirmationStatusCode.SelfNotConfirmedAndCouterpartyConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Both the two parties are not confirmed.
    /// Encoded/decoded by serializers as &quot;SNCN&quot;.
    /// </summary>
    [EnumMember(Value = "SNCN")]
    [IsoId("_hszgcYBFEeSUJZYcWGKkkw")]
    [Description(@"Both the two parties are not confirmed.")]
    SelfNotConfirmedAndCouterpartyNotConfirmed =
        TradeConfirmationStatusCode.SelfNotConfirmedAndCouterpartyNotConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trades are not confirmed by Central Matching Utility(analogous to virtual matching utility).
    /// Encoded/decoded by serializers as &quot;UNCN&quot;.
    /// </summary>
    [EnumMember(Value = "UNCN")]
    [IsoId("_hxrZYYBFEeSUJZYcWGKkkw")]
    [Description(
        @"Trades are not confirmed by Central Matching Utility(analogous to virtual matching utility)."
    )]
    Unconfirmed = TradeConfirmationStatusCode.Unconfirmed, // same ordinal as derivation source for type conversions
}
