// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the additional identification type, for example NAICS, etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H-KG4C7SEemIy6A-26wnAg")]
[Description(@"Contains the additional identification type, for example NAICS, etc.")]
[DerivedFrom(typeof(AdditionalIdentificationTypeCode))]
public enum AdditionalIdentificationType1Code
{
    /// <summary>
    /// Other Additional Identification defined at a private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_JyUzMS7SEemIy6A-26wnAg")]
    [Description(@"Other Additional Identification defined at a private level.")]
    OtherPrivate = AdditionalIdentificationTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other Additional Identification defined at a national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_J2Pp4S7SEemIy6A-26wnAg")]
    [Description(@"Other Additional Identification defined at a national level.")]
    OtherNational = AdditionalIdentificationTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains the North American Industry Classification System (NAICS) code assigned to the card acceptor.
    /// Encoded/decoded by serializers as &quot;ICSN&quot;.
    /// </summary>
    [EnumMember(Value = "ICSN")]
    [IsoId("_J38TAS7SEemIy6A-26wnAg")]
    [Description(@"Contains the North American Industry Classification System (NAICS) code assigned to the card acceptor.")]
    NAICS = AdditionalIdentificationTypeCode.NAICS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains the Austin-Tetra Number assigned to the card acceptor.
    /// Encoded/decoded by serializers as &quot;ATNU&quot;.
    /// </summary>
    [EnumMember(Value = "ATNU")]
    [IsoId("_J7TwES7SEemIy6A-26wnAg")]
    [Description(@"Contains the Austin-Tetra Number assigned to the card acceptor.")]
    AustinTetra = AdditionalIdentificationTypeCode.AustinTetra, // same ordinal as derivation source for type conversions
    
}
