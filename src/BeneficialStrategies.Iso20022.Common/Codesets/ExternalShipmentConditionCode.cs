// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a shipment conditions code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AFUk0e8hEemHC5W45DWzKA")]
[Description(
    @"Specifies a shipment conditions code, as published in the external ISO 20022 external code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalShipmentCondition1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalShipmentConditionCode>))]
#endif
public enum ExternalShipmentConditionCode
{
    /// <summary>
    /// Goods/service delivered after payment
    /// Encoded/decoded by serializers as &quot;ADVN&quot;.
    /// </summary>
    [EnumMember(Value = "ADVN")]
    [IsoId("_uUDnefRYEeuLhpyIdtJzwg")]
    [Description(@"Goods/service delivered after payment")]
    AdvancePayment,

    /// <summary>
    /// Goods/service delivered at the same time as payment.
    /// Encoded/decoded by serializers as &quot;PMNT&quot;.
    /// </summary>
    [EnumMember(Value = "PMNT")]
    [IsoId("_uUDnfPRYEeuLhpyIdtJzwg")]
    [Description(@"Goods/service delivered at the same time as payment.")]
    DeliveryversusPayment,

    /// <summary>
    /// Goods/service delivered before payment
    /// Encoded/decoded by serializers as &quot;TRLN&quot;.
    /// </summary>
    [EnumMember(Value = "TRLN")]
    [IsoId("_uUMxYPRYEeuLhpyIdtJzwg")]
    [Description(@"Goods/service delivered before payment")]
    TradeLoan,
}
