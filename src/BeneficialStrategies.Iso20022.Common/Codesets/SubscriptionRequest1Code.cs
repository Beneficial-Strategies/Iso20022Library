// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of subscription to market data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQpqBNp-Ed-ak6NoX_4Aeg_-1118188271")]
[Description(@"Type of subscription to market data.")]
[DerivedFrom(typeof(SubscriptionRequestCode))]
public enum SubscriptionRequest1Code
{
    /// <summary>
    /// Specifies that the request is to subscribe to snapshots.
    /// Encoded/decoded by serializers as &quot;SNAP&quot;.
    /// </summary>
    [EnumMember(Value = "SNAP")]
    [IsoId("_ZQpqBdp-Ed-ak6NoX_4Aeg_-1044305239")]
    [Description(@"Specifies that the request is to subscribe to snapshots.")]
    Snapshot = SubscriptionRequestCode.Snapshot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the request is to subscribe to snapshots and updates.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZQpqBtp-Ed-ak6NoX_4Aeg_-1044305197")]
    [Description(@"Specifies that the request is to subscribe to snapshots and updates.")]
    Subscribe = SubscriptionRequestCode.Subscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the request is to disable the previous snapshot subscription and to update the request (unsubscribe).
    /// Encoded/decoded by serializers as &quot;UNSU&quot;.
    /// </summary>
    [EnumMember(Value = "UNSU")]
    [IsoId("_ZQpqB9p-Ed-ak6NoX_4Aeg_-1044305162")]
    [Description(
        @"Specifies that the request is to disable the previous snapshot subscription and to update the request (unsubscribe)."
    )]
    Unsubscribe = SubscriptionRequestCode.Unsubscribe, // same ordinal as derivation source for type conversions
}
