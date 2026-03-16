// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// On-line and off-line capabilities of the POI (Point Of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2-C6gUeqEee9r7QjOdsbFw")]
[Description(@"On-line and off-line capabilities of the POI (Point Of Interaction).")]
[DerivedFrom(typeof(OnLineCapabilityCode))]
public enum OnLineCapability2Code
{
    /// <summary>
    /// Off-line only capable.
    /// Encoded/decoded by serializers as &quot;OFLN&quot;.
    /// </summary>
    [EnumMember(Value = "OFLN")]
    [IsoId("_umTwMX0lEemfrNOe0zHQyg")]
    [Description(@"Off-line only capable.")]
    OffLine = OnLineCapabilityCode.OffLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On-line only capable.
    /// Encoded/decoded by serializers as &quot;ONLN&quot;.
    /// </summary>
    [EnumMember(Value = "ONLN")]
    [IsoId("_umTwM30lEemfrNOe0zHQyg")]
    [Description(@"On-line only capable.")]
    OnLine = OnLineCapabilityCode.OnLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Both online and offline
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_umTwNX0lEemfrNOe0zHQyg")]
    [Description(@"Both online and offline")]
    BothOnLineAndOffLine = OnLineCapabilityCode.BothOnLineAndOffLine, // same ordinal as derivation source for type conversions
}
