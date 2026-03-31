// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how a charge is to be deducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gJ_qoGAPEeiNMJ262H2pWg")]
[Description(@"Specifies how a charge is to be deducted.")]
[DerivedFrom(typeof(AnnualChargePaymentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AnnualChargePaymentType1Code>))]
#endif
public enum AnnualChargePaymentType1Code
{
    /// <summary>
    /// Annual charge is deducted from the fund capital.
    /// Encoded/decoded by serializers as &quot;CAPL&quot;.
    /// </summary>
    [EnumMember(Value = "CAPL")]
    [IsoId("_iTTggGAPEeiNMJ262H2pWg")]
    [Description(@"Annual charge is deducted from the fund capital.")]
    Capital = AnnualChargePaymentTypeCode.Capital, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Annual charge is deducted from the fund income.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_iXy-8WAPEeiNMJ262H2pWg")]
    [Description(@"Annual charge is deducted from the fund income.")]
    Income = AnnualChargePaymentTypeCode.Income, // same ordinal as derivation source for type conversions
}
