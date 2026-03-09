// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies that the buy-in transaction was deferred or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zwlJQJwVEeqtp-LOti013g")]
[Description(@"Specifies that the buy-in transaction was deferred or not.")]
[Derivations(typeof(BuyInDeferral1Code))]
public enum BuyInDeferralCode
{
    /// <summary>
    /// Buy-in is not deferred.
    /// Encoded/decoded by serializers as &quot;DEFN&quot;.
    /// </summary>
    [EnumMember(Value = "DEFN")]
    [IsoId("_4hbCEJwVEeqtp-LOti013g")]
    [Description(@"Buy-in is not deferred.")]
    BuyInNotDeferred,
    
    /// <summary>
    /// Buy-in is deferred.
    /// Encoded/decoded by serializers as &quot;DEFY&quot;.
    /// </summary>
    [EnumMember(Value = "DEFY")]
    [IsoId("_4llwYJwVEeqtp-LOti013g")]
    [Description(@"Buy-in is deferred.|")]
    BuyInDeferred,
    
}
