// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of subscription to market data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQpqCNp-Ed-ak6NoX_4Aeg_336259528")]
[Description(@"Type of subscription to market data.")]
[Derivations(typeof(SubscriptionRequest1Code))]
public enum SubscriptionRequestCode
{
    /// <summary>
    /// Specifies that the request is to subscribe to snapshots.
    /// Encoded/decoded by serializers as &quot;SNAP&quot;.
    /// </summary>
    [EnumMember(Value = "SNAP")]
    [IsoId("_ZQzbANp-Ed-ak6NoX_4Aeg_336259529")]
    [Description(@"Specifies that the request is to subscribe to snapshots.")]
    Snapshot,

    /// <summary>
    /// Specifies that the request is to subscribe to snapshots and updates.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZQzbAdp-Ed-ak6NoX_4Aeg_336259530")]
    [Description(@"Specifies that the request is to subscribe to snapshots and updates.")]
    Subscribe,

    /// <summary>
    /// Specifies that the request is to disable the previous snapshot subscription and to update the request (unsubscribe).
    /// Encoded/decoded by serializers as &quot;UNSU&quot;.
    /// </summary>
    [EnumMember(Value = "UNSU")]
    [IsoId("_ZQzbAtp-Ed-ak6NoX_4Aeg_336259531")]
    [Description(
        @"Specifies that the request is to disable the previous snapshot subscription and to update the request (unsubscribe)."
    )]
    Unsubscribe,
}
