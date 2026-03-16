// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the oversubscription type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rW2QTL3EeKU9IrkkToqcw_-402247570")]
[Description(@"Specifies the oversubscription type.")]
[DerivedFrom(typeof(OversubscriptionTypeCode))]
public enum OversubscriptionType1Code
{
    /// <summary>
    /// Unlimited oversubscription.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_1rW2QjL3EeKU9IrkkToqcw_490787890")]
    [Description(@"Unlimited oversubscription.")]
    Unlimited = OversubscriptionTypeCode.Unlimited, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The subscription is limited by quantity or percentage.
    /// Encoded/decoded by serializers as &quot;LTDB&quot;.
    /// </summary>
    [EnumMember(Value = "LTDB")]
    [IsoId("_1rW2QzL3EeKU9IrkkToqcw_-1016864815")]
    [Description(@"The subscription is limited by quantity or percentage.")]
    LimitedByQuantityOrPercentage = OversubscriptionTypeCode.LimitedByQuantityOrPercentage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No oversubscription is allowed.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_1rW2RDL3EeKU9IrkkToqcw_-1130703881")]
    [Description(@"No oversubscription is allowed.")]
    NoOversubscription = OversubscriptionTypeCode.NoOversubscription, // same ordinal as derivation source for type conversions
}
