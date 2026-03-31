// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing channel for the routing of the transaction, as part of the payment type identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_X1oNp-Ed-ak6NoX_4Aeg_-75802580")]
[Description(
    @"Specifies the clearing channel for the routing of the transaction, as part of the payment type identification."
)]
[Derivations(typeof(ClearingChannel2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ClearingChannelCode>))]
#endif
public enum ClearingChannelCode
{
    /// <summary>
    /// Clearing channel is a real-time gross settlement system.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_a_X1odp-Ed-ak6NoX_4Aeg_349344962")]
    [Description(@"Clearing channel is a real-time gross settlement system.")]
    RealTimeGrossSettlementSystem,

    /// <summary>
    /// Clearing channel is a real-time net settlement system.
    /// Encoded/decoded by serializers as &quot;RTNS&quot;.
    /// </summary>
    [EnumMember(Value = "RTNS")]
    [IsoId("_a_X1otp-Ed-ak6NoX_4Aeg_419533382")]
    [Description(@"Clearing channel is a real-time net settlement system.")]
    RealTimeNetSettlementSystem,

    /// <summary>
    /// Clearing channel is a mass payment net settlement system.
    /// Encoded/decoded by serializers as &quot;MPNS&quot;.
    /// </summary>
    [EnumMember(Value = "MPNS")]
    [IsoId("_a_X1o9p-Ed-ak6NoX_4Aeg_496187714")]
    [Description(@"Clearing channel is a mass payment net settlement system.")]
    MassPaymentNetSystem,

    /// <summary>
    /// Payment through internal book transfer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_a_X1pNp-Ed-ak6NoX_4Aeg_-537955381")]
    [Description(@"Payment through internal book transfer.")]
    BookTransfer,
}
