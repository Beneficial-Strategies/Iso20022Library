// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the status of the confirmation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Rmmu4AKDEeS2H9l84F_isg")]
[Description(@"Identifies the status of the confirmation.")]
[Derivations(typeof(TradeConfirmationStatus1Code))]
public enum TradeConfirmationStatusCode
{
    /// <summary>
    /// Trade information between Central Matching Utility(analogous to virtual matching utility) and the trading member is mismatched.
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_WsBJgAKDEeS2H9l84F_isg")]
    [Description(
        @"Trade information between Central Matching Utility(analogous to virtual matching utility) and the trading member is mismatched."
    )]
    Mismatched,

    /// <summary>
    /// Home party has confirmed, but couterparty is unrecognized.
    /// Encoded/decoded by serializers as &quot;SCCN&quot;.
    /// </summary>
    [EnumMember(Value = "SCCN")]
    [IsoId("_exW48AKDEeS2H9l84F_isg")]
    [Description(@"Home party has confirmed, but couterparty is unrecognized.")]
    SelfConfirmedAndCouterpartyNotConfirmed,

    /// <summary>
    /// Trades are confirmed by Central Matching Utility (analogous to virtual matching utility).
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_g0IB8AKDEeS2H9l84F_isg")]
    [Description(
        @"Trades are confirmed by Central Matching Utility (analogous to virtual matching utility)."
    )]
    Confirmed,

    /// <summary>
    /// Home party has not confirmed, but couterparty is recognized.
    /// Encoded/decoded by serializers as &quot;SNCC&quot;.
    /// </summary>
    [EnumMember(Value = "SNCC")]
    [IsoId("_jfol8AKDEeS2H9l84F_isg")]
    [Description(@"Home party has not confirmed, but couterparty is recognized.")]
    SelfNotConfirmedAndCouterpartyConfirmed,

    /// <summary>
    /// Both the two parties are not confirmed.
    /// Encoded/decoded by serializers as &quot;SNCN&quot;.
    /// </summary>
    [EnumMember(Value = "SNCN")]
    [IsoId("_krnQ4AKDEeS2H9l84F_isg")]
    [Description(@"Both the two parties are not confirmed.")]
    SelfNotConfirmedAndCouterpartyNotConfirmed,

    /// <summary>
    /// Trades are not confirmed by Central Matching Utility(analogous to virtual matching utility).
    /// Encoded/decoded by serializers as &quot;UNCN&quot;.
    /// </summary>
    [EnumMember(Value = "UNCN")]
    [IsoId("_ntLkcAKDEeS2H9l84F_isg")]
    [Description(
        @"Trades are not confirmed by Central Matching Utility(analogous to virtual matching utility)."
    )]
    Unconfirmed,

    /// <summary>
    /// Central Matching Utility (analogous to virtual matching utility) confirms trades in contingency.
    /// Encoded/decoded by serializers as &quot;EMCN&quot;.
    /// </summary>
    [EnumMember(Value = "EMCN")]
    [IsoId("_pGI7cAKDEeS2H9l84F_isg")]
    [Description(
        @"Central Matching Utility (analogous to virtual matching utility) confirms trades in contingency."
    )]
    EmergencyConfirmed,

    /// <summary>
    /// Trade information of the both trading member is unmatched.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_qMxzYAKDEeS2H9l84F_isg")]
    [Description(@"Trade information of the both trading member is unmatched.")]
    Disaccord,

    /// <summary>
    /// All current status of the trade.
    /// Encoded/decoded by serializers as &quot;ALST&quot;.
    /// </summary>
    [EnumMember(Value = "ALST")]
    [IsoId("_sBIF4AKDEeS2H9l84F_isg")]
    [Description(@"All current status of the trade.")]
    AllStatus,
}
