// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Jasdec codes for the specific use of pro ration.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cnUUEDFsEeGKkIZzgd38VA")]
[Description(@"Jasdec codes for the specific use of pro ration.")]
[DerivedFrom(typeof(ProrationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProrationType1Code>))]
#endif
public enum ProrationType1Code
{
    /// <summary>
    /// Pro ration is not decided.
    /// Encoded/decoded by serializers as &quot;PRND&quot;.
    /// </summary>
    [EnumMember(Value = "PRND")]
    [IsoId("_d7XV5jFsEeGKkIZzgd38VA")]
    [Description(@"Pro ration is not decided.")]
    NotDecided = ProrationTypeCode.NotDecided, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pro ration is not used.
    /// Encoded/decoded by serializers as &quot;PRNU&quot;.
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_DIpHtjVFEeGIoujPqYSZDw")]
    [Description(@"Pro ration is not used.")]
    NotUsed = ProrationTypeCode.NotUsed, // same ordinal as derivation source for type conversions
}
