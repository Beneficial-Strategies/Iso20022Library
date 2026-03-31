// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayZwotp-Ed-ak6NoX_4Aeg_-1375472823")]
[Description(@"Specifies a type of date.")]
[DerivedFrom(typeof(DateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DateType3Code>))]
#endif
public enum DateType3Code
{
    /// <summary>
    /// Partial trades have occurred over a period of two or more days.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_ayZwo9p-Ed-ak6NoX_4Aeg_-1348690126")]
    [Description(@"Partial trades have occurred over a period of two or more days.")]
    Various = DateTypeCode.Various, // same ordinal as derivation source for type conversions
}
