// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of the side of the indication.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adZJ8tp-Ed-ak6NoX_4Aeg_336256305")]
[Description(@"Indicates the type of the side of the indication.")]
[DerivedFrom(typeof(SideCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<IOISideTypeCode>))]
#endif
public enum IOISideTypeCode
{
    /// <summary>
    /// Order is buy driven.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_adZJ89p-Ed-ak6NoX_4Aeg_336256306")]
    [Description(@"Order is buy driven.")]
    Buy = SideCode.Buy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is sell driven.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_adZJ9Np-Ed-ak6NoX_4Aeg_336256307")]
    [Description(@"Order is sell driven.")]
    Sell = SideCode.Sell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The side of the indication of interest is not disclosed.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("_adZJ9dp-Ed-ak6NoX_4Aeg_336256308")]
    [Description(@"The side of the indication of interest is not disclosed.")]
    Undisclosed = SideCode.Undisclosed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates, in the case of a multileg instrument,that the sides of the legs are the same as defined at the creation of the multileg instrument.
    /// Encoded/decoded by serializers as &quot;DEFI&quot;.
    /// </summary>
    [EnumMember(Value = "DEFI")]
    [IsoId("_adZJ9tp-Ed-ak6NoX_4Aeg_336256309")]
    [Description(
        @"Indicates, in the case of a multileg instrument,that the sides of the legs are the same as defined at the creation of the multileg instrument."
    )]
    AsDefined = SideCode.AsDefined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates, in the case of a multileg instrument,that the sides of the legs are the opposite of their definition at the creation of the multileg instrument.
    /// Encoded/decoded by serializers as &quot;OPPO&quot;.
    /// </summary>
    [EnumMember(Value = "OPPO")]
    [IsoId("_adZJ99p-Ed-ak6NoX_4Aeg_336256310")]
    [Description(
        @"Indicates, in the case of a multileg instrument,that the sides of the legs are the opposite of their definition at the creation of the multileg instrument."
    )]
    Opposite = SideCode.Opposite, // same ordinal as derivation source for type conversions
}
