// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investment fund commission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VkKxNtp-Ed-ak6NoX_4Aeg_377990975")]
[Description(@"Specifies the type of investment fund commission.")]
[DerivedFrom(typeof(CommissionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CommissionType5Code>))]
#endif
public enum CommissionType5Code
{
    /// <summary>
    /// Type of service for which the commission is asked or paid.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_VkKxN9p-Ed-ak6NoX_4Aeg_445405236")]
    [Description(@"Type of service for which the commission is asked or paid.")]
    FrontEnd = CommissionTypeCode.FrontEnd, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_VkKxONp-Ed-ak6NoX_4Aeg_446328819")]
    [Description(
        @"Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time."
    )]
    BackEnd = CommissionTypeCode.BackEnd, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission is another type of transaction.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VkUiMNp-Ed-ak6NoX_4Aeg_449101350")]
    [Description(@"Commission is another type of transaction.")]
    Other = CommissionTypeCode.Other, // same ordinal as derivation source for type conversions
}
