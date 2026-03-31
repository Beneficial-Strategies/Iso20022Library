// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXgo0tp-Ed-ak6NoX_4Aeg_2094579534")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(CancellationProcessingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CancellationProcessingStatus1Code>))]
#endif
public enum CancellationProcessingStatus1Code
{
    /// <summary>
    /// Cancellation has been completed.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bXgo09p-Ed-ak6NoX_4Aeg_2094579543")]
    [Description(@"Cancellation has been completed.")]
    CancellationCompleted = CancellationProcessingStatusCode.CancellationCompleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation is pending. It is not known at this time whether cancellation can be affected.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_bXgo1Np-Ed-ak6NoX_4Aeg_2094579544")]
    [Description(
        @"Cancellation is pending. It is not known at this time whether cancellation can be affected."
    )]
    PendingCancellation = CancellationProcessingStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation will not be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_bXgo1dp-Ed-ak6NoX_4Aeg_2094579564")]
    [Description(@"Cancellation will not be executed.")]
    Denied = CancellationProcessingStatusCode.Denied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation has been received at the stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_bXgo1tp-Ed-ak6NoX_4Aeg_2094579565")]
    [Description(@"Cancellation has been received at the stock exchange.")]
    ReceivedAtStockExchange = CancellationProcessingStatusCode.ReceivedAtStockExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation has been received at the intermediary.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_bXgo19p-Ed-ak6NoX_4Aeg_2094579595")]
    [Description(@"Cancellation has been received at the intermediary.")]
    ReceivedAtIntermediary = CancellationProcessingStatusCode.ReceivedAtIntermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request has been acknowledged for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bXqZ0Np-Ed-ak6NoX_4Aeg_2094579596")]
    [Description(
        @"Cancellation request has been acknowledged for further processing by the account servicer."
    )]
    Accepted = CancellationProcessingStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is partially filled, cancellation processing accepted for the remainder.
    /// Encoded/decoded by serializers as &quot;PARF&quot;.
    /// </summary>
    [EnumMember(Value = "PARF")]
    [IsoId("_bXqZ0dp-Ed-ak6NoX_4Aeg_2094579626")]
    [Description(@"Order is partially filled, cancellation processing accepted for the remainder.")]
    PartiallyFilled = CancellationProcessingStatusCode.PartiallyFilled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bXqZ0tp-Ed-ak6NoX_4Aeg_2094579627")]
    [Description(@"Cancellation has been rejected for further processing.")]
    Rejected = CancellationProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_bXqZ09p-Ed-ak6NoX_4Aeg_2094579656")]
    [Description(@"Cancellation request is in repair.")]
    InRepair = CancellationProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions
}
