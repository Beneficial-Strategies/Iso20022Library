// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if the investor was referred.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZaosdNp-Ed-ak6NoX_4Aeg_-241687818")]
[Description(@"Indicates if the investor was referred.")]
[DerivedFrom(typeof(ReferredCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Referred1Code>))]
#endif
public enum Referred1Code
{
    /// <summary>
    /// The investor was referred to the fund by a placement agent.
    /// Encoded/decoded by serializers as &quot;REFR&quot;.
    /// </summary>
    [EnumMember(Value = "REFR")]
    [IsoId("_Zaosddp-Ed-ak6NoX_4Aeg_59379446")]
    [Description(@"The investor was referred to the fund by a placement agent.")]
    Referred = ReferredCode.Referred, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The investor was not referred to the fund by a placement agent.
    /// Encoded/decoded by serializers as &quot;NRFR&quot;.
    /// </summary>
    [EnumMember(Value = "NRFR")]
    [IsoId("_Zaosdtp-Ed-ak6NoX_4Aeg_59379471")]
    [Description(@"The investor was not referred to the fund by a placement agent.")]
    NotReferred = ReferredCode.NotReferred, // same ordinal as derivation source for type conversions

    /// <summary>
    /// It is not known whether the investor was referred to the fund by a placement agent.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_Zaosd9p-Ed-ak6NoX_4Aeg_59379506")]
    [Description(
        @"It is not known whether the investor was referred to the fund by a placement agent."
    )]
    NotKnown = ReferredCode.NotKnown, // same ordinal as derivation source for type conversions
}
