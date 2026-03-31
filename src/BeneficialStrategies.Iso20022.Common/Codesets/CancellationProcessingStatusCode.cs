// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXzjwNp-Ed-ak6NoX_4Aeg_664969424")]
[Description(@"Specifies the status of a cancellation request.")]
[Derivations(
    typeof(CancellationProcessingStatus1Code),
    typeof(CancellationProcessingStatus3Code),
    typeof(CancellationProcessingStatus2Code)
)]
public enum CancellationProcessingStatusCode
{
    /// <summary>
    /// Cancellation has been completed.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bXzjwdp-Ed-ak6NoX_4Aeg_723150815")]
    [Description(@"Cancellation has been completed.")]
    CancellationCompleted,

    /// <summary>
    /// Cancellation is pending. It is not known at this time whether cancellation can be affected.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_bXzjwtp-Ed-ak6NoX_4Aeg_821965729")]
    [Description(
        @"Cancellation is pending. It is not known at this time whether cancellation can be affected."
    )]
    PendingCancellation,

    /// <summary>
    /// Cancellation will not be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_bXzjw9p-Ed-ak6NoX_4Aeg_822889281")]
    [Description(@"Cancellation will not be executed.")]
    Denied,

    /// <summary>
    /// Cancellation has been received at the stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_bXzjxNp-Ed-ak6NoX_4Aeg_823812802")]
    [Description(@"Cancellation has been received at the stock exchange.")]
    ReceivedAtStockExchange,

    /// <summary>
    /// Cancellation has been received at the intermediary.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_bXzjxdp-Ed-ak6NoX_4Aeg_824736384")]
    [Description(@"Cancellation has been received at the intermediary.")]
    ReceivedAtIntermediary,

    /// <summary>
    /// Cancellation request has been acknowledged for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bXzjxtp-Ed-ak6NoX_4Aeg_825659813")]
    [Description(
        @"Cancellation request has been acknowledged for further processing by the account servicer."
    )]
    Accepted,

    /// <summary>
    /// Order is partially filled, cancellation processing accepted for the remainder.
    /// Encoded/decoded by serializers as &quot;PARF&quot;.
    /// </summary>
    [EnumMember(Value = "PARF")]
    [IsoId("_bXzjx9p-Ed-ak6NoX_4Aeg_833971349")]
    [Description(@"Order is partially filled, cancellation processing accepted for the remainder.")]
    PartiallyFilled,

    /// <summary>
    /// Cancellation has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bXzjyNp-Ed-ak6NoX_4Aeg_850596197")]
    [Description(@"Cancellation has been rejected for further processing.")]
    Rejected,

    /// <summary>
    /// Cancellation request is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_bX9UwNp-Ed-ak6NoX_4Aeg_851519440")]
    [Description(@"Cancellation request is in repair.")]
    InRepair,
}
