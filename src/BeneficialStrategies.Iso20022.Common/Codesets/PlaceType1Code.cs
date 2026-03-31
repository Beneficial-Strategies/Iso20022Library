// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHWBcdp-Ed-ak6NoX_4Aeg_-1566893898")]
[Description(@"Type of date.")]
[DerivedFrom(typeof(PlaceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PlaceType1Code>))]
#endif
public enum PlaceType1Code
{
    /// <summary>
    /// The type of place is unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aHWBctp-Ed-ak6NoX_4Aeg_-1566893880")]
    [Description(@"The type of place is unknown.")]
    Unknown = PlaceTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
