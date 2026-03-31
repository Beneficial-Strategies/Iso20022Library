// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies charges linked to the type of service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a9IZ89p-Ed-ak6NoX_4Aeg_1894313694")]
[Description(@"Identifies charges linked to the type of service.")]
[DerivedFrom(typeof(ChargeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChargeType14Code>))]
#endif
public enum ChargeType14Code
{
    /// <summary>
    /// Charge linked to an ADR (American Depositary Receipt).
    /// Encoded/decoded by serializers as &quot;ADRF&quot;.
    /// </summary>
    [EnumMember(Value = "ADRF")]
    [IsoId("_a9IZ9Np-Ed-ak6NoX_4Aeg_1905396008")]
    [Description(@"Charge linked to an ADR (American Depositary Receipt).")]
    ADRFee = ChargeTypeCode.ADRFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee linked to the cancellation of an issuance.
    /// Encoded/decoded by serializers as &quot;ISSC&quot;.
    /// </summary>
    [EnumMember(Value = "ISSC")]
    [IsoId("_a9IZ9dp-Ed-ak6NoX_4Aeg_1919247879")]
    [Description(@"Fee linked to the cancellation of an issuance.")]
    IssuanceCancellationFee = ChargeTypeCode.IssuanceCancellationFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid to a custodian in respect of custodial services.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_a9IZ9tp-Ed-ak6NoX_4Aeg_1935869866")]
    [Description(@"Fee paid to a custodian in respect of custodial services.")]
    CustodyFee = ChargeTypeCode.CustodyFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a9IZ99p-Ed-ak6NoX_4Aeg_-2057106020")]
    [Description(@"Fee paid for the provision of financial services.")]
    ServiceProvisionFee = ChargeTypeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous fee.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_a9IZ-Np-Ed-ak6NoX_4Aeg_-2043252398")]
    [Description(@"Miscellaneous fee.")]
    MiscellaneousFee = ChargeTypeCode.MiscellaneousFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge linked to the issuance of security.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_a9SK8Np-Ed-ak6NoX_4Aeg_-1972140796")]
    [Description(@"Charge linked to the issuance of security.")]
    IssuanceFee = ChargeTypeCode.IssuanceFee, // same ordinal as derivation source for type conversions
}
