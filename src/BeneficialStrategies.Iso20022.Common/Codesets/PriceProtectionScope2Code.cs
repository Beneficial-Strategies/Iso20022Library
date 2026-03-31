// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of price protection the customer requires on their order. Defines the scope of the &quot;related to&quot; price of the peg or the scope of &quot;related to&quot; price of the discretion (for example, local, global etc).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aI1PMdp-Ed-ak6NoX_4Aeg_-86829705")]
[Description(
    @"Defines the type of price protection the customer requires on their order. Defines the scope of the ""related to"" price of the peg or the scope of ""related to"" price of the discretion (for example, local, global etc)."
)]
[DerivedFrom(typeof(PriceProtectionScopeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PriceProtectionScope2Code>))]
#endif
public enum PriceProtectionScope2Code
{
    /// <summary>
    /// Price protection is local (for example, Exchange, ECN, ATS).
    /// Encoded/decoded by serializers as &quot;LOCA&quot;.
    /// </summary>
    [EnumMember(Value = "LOCA")]
    [IsoId("_aI1PMtp-Ed-ak6NoX_4Aeg_-40654570")]
    [Description(@"Price protection is local (for example, Exchange, ECN, ATS).")]
    Local = PriceProtectionScopeCode.Local, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price protection is national (across all national markets).
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_aI1PM9p-Ed-ak6NoX_4Aeg_-40654240")]
    [Description(@"Price protection is national (across all national markets).")]
    National = PriceProtectionScopeCode.National, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price protection is global (across all markets).
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_aI1PNNp-Ed-ak6NoX_4Aeg_-40654239")]
    [Description(@"Price protection is global (across all markets).")]
    Global = PriceProtectionScopeCode.Global, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price protection is national (across all national markets) excluding local price protection.
    /// Encoded/decoded by serializers as &quot;NAEL&quot;.
    /// </summary>
    [EnumMember(Value = "NAEL")]
    [IsoId("_aI1PNdp-Ed-ak6NoX_4Aeg_-40654215")]
    [Description(
        @"Price protection is national (across all national markets) excluding local price protection."
    )]
    NationalExcludingLocal = PriceProtectionScopeCode.NationalExcludingLocal, // same ordinal as derivation source for type conversions
}
