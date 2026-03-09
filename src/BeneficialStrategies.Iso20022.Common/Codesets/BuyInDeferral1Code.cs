// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the buy-in transaction was deferred or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KuU3YJwWEeqtp-LOti013g")]
[Description(@"Specifies if the buy-in transaction was deferred or not.")]
[DerivedFrom(typeof(BuyInDeferralCode))]
public enum BuyInDeferral1Code
{
    /// <summary>
    /// Buy-in is deferred.
    /// Encoded/decoded by serializers as &quot;DEFY&quot;.
    /// </summary>
    [EnumMember(Value = "DEFY")]
    [IsoId("_L555sZwWEeqtp-LOti013g")]
    [Description(@"Buy-in is deferred.|")]
    BuyInDeferred = BuyInDeferralCode.BuyInDeferred, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Buy-in is not deferred.
    /// Encoded/decoded by serializers as &quot;DEFN&quot;.
    /// </summary>
    [EnumMember(Value = "DEFN")]
    [IsoId("_L-gs4ZwWEeqtp-LOti013g")]
    [Description(@"Buy-in is not deferred.")]
    BuyInNotDeferred = BuyInDeferralCode.BuyInNotDeferred, // same ordinal as derivation source for type conversions
    
}
