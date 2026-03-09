// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJk2Ftp-Ed-ak6NoX_4Aeg_-608123494")]
[Description(@"Specifies the value of a price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType6Code
{
    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aJk2F9p-Ed-ak6NoX_4Aeg_-608123492")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown = PriceValueTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_aJk2GNp-Ed-ak6NoX_4Aeg_-608123463")]
    [Description(@"Price has not been established.")]
    OpenDated = PriceValueTypeCode.OpenDated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is not required to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_aJunENp-Ed-ak6NoX_4Aeg_-608123462")]
    [Description(@"Price is not required to be specified by account owner.")]
    Unspecified = PriceValueTypeCode.Unspecified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;TBSP&quot;.
    /// </summary>
    [EnumMember(Value = "TBSP")]
    [IsoId("_aJunEdp-Ed-ak6NoX_4Aeg_-608123441")]
    [Description(@"Price to be specified by account owner.")]
    ToBeSpecified = PriceValueTypeCode.ToBeSpecified, // same ordinal as derivation source for type conversions
    
}
