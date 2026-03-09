// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wahTcCXWEeOL3KXg7zAfKA")]
[Description(@"Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.")]
[DerivedFrom(typeof(DistributionTypeCode))]
public enum DistributionType3Code
{
    /// <summary>
    /// Final payment.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_5ixRYSXWEeOL3KXg7zAfKA")]
    [Description(@"Final payment.")]
    Final = DistributionTypeCode.Final, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interim payment.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_5nYEkSXWEeOL3KXg7zAfKA")]
    [Description(@"Interim payment.")]
    Interim = DistributionTypeCode.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is ongoing for acceptance on an unsolicited basis.
    /// Encoded/decoded by serializers as &quot;ONGO&quot;.
    /// </summary>
    [EnumMember(Value = "ONGO")]
    [IsoId("_5uOTcSXWEeOL3KXg7zAfKA")]
    [Description(@"Event is ongoing for acceptance on an unsolicited basis.")]
    Ongoing = DistributionTypeCode.Ongoing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_5y1GoSXWEeOL3KXg7zAfKA")]
    [Description(@"Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.")]
    RollingBasis = DistributionTypeCode.RollingBasis, // same ordinal as derivation source for type conversions
    
}
