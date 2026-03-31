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
[IsoId("_a_OEo9p-Ed-ak6NoX_4Aeg_1501459302")]
[Description(
    @"Specifies the clearing channel for the routing of the transaction, as part of the payment type identification."
)]
[DerivedFrom(typeof(ClearingChannelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ClearingChannel2Code>))]
#endif
public enum ClearingChannel2Code
{
    /// <summary>
    /// Clearing channel is a real-time gross settlement system.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_a_OEpNp-Ed-ak6NoX_4Aeg_1501459782")]
    [Description(@"Clearing channel is a real-time gross settlement system.")]
    RealTimeGrossSettlementSystem = ClearingChannelCode.RealTimeGrossSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing channel is a real-time net settlement system.
    /// Encoded/decoded by serializers as &quot;RTNS&quot;.
    /// </summary>
    [EnumMember(Value = "RTNS")]
    [IsoId("_a_OEpdp-Ed-ak6NoX_4Aeg_1501460232")]
    [Description(@"Clearing channel is a real-time net settlement system.")]
    RealTimeNetSettlementSystem = ClearingChannelCode.RealTimeNetSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing channel is a mass payment net settlement system.
    /// Encoded/decoded by serializers as &quot;MPNS&quot;.
    /// </summary>
    [EnumMember(Value = "MPNS")]
    [IsoId("_a_OEptp-Ed-ak6NoX_4Aeg_1501460309")]
    [Description(@"Clearing channel is a mass payment net settlement system.")]
    MassPaymentNetSystem = ClearingChannelCode.MassPaymentNetSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment through internal book transfer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_a_OEp9p-Ed-ak6NoX_4Aeg_1524547392")]
    [Description(@"Payment through internal book transfer.")]
    BookTransfer = ClearingChannelCode.BookTransfer, // same ordinal as derivation source for type conversions
}
