// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of a payment instruction at a specified time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7MgQNp-Ed-ak6NoX_4Aeg_1461915358")]
[Description(@"Specifies the state of a payment instruction at a specified time.")]
[Derivations(typeof(CashPaymentStatus2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CashPaymentStatusCode>))]
#endif
public enum CashPaymentStatusCode
{
    /// <summary>
    /// The payment is awaiting settlement.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_a7MgQdp-Ed-ak6NoX_4Aeg_1461915359")]
    [Description(@"The payment is awaiting settlement.")]
    Pending,

    /// <summary>
    /// The payment has been settled or stopped.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_a7MgQtp-Ed-ak6NoX_4Aeg_1461915360")]
    [Description(@"The payment has been settled or stopped.")]
    Final,

    /// <summary>
    /// The payment is cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_a7MgQ9p-Ed-ak6NoX_4Aeg_-167740139")]
    [Description(@"The payment is cancelled.")]
    Cancelled,
}
