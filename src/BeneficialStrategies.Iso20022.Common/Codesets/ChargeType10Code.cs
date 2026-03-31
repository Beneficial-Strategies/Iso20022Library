// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8YzFNp-Ed-ak6NoX_4Aeg_1180340724")]
[Description(@"Specifies the type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChargeType10Code>))]
#endif
public enum ChargeType10Code
{
    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_a8YzFdp-Ed-ak6NoX_4Aeg_1180340741")]
    [Description(
        @"Sales charge paid by the investor when redeeming an investment such as an investment fund."
    )]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a8YzFtp-Ed-ak6NoX_4Aeg_1180341007")]
    [Description(
        @"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund."
    )]
    FrontEndLoad = ChargeTypeCode.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_a8YzF9p-Ed-ak6NoX_4Aeg_-434933629")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty = ChargeTypeCode.Penalty, // same ordinal as derivation source for type conversions
}
