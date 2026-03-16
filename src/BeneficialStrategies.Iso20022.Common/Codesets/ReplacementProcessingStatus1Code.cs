// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of the replacement request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZwPwF9p-Ed-ak6NoX_4Aeg_-1450819640")]
[Description(@"Specifies the processing status of the replacement request.")]
[DerivedFrom(typeof(ReplacementProcessingStatusCode))]
public enum ReplacementProcessingStatus1Code
{
    /// <summary>
    /// Replacement request cannot be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZwPwGNp-Ed-ak6NoX_4Aeg_-1450819609")]
    [Description(@"Replacement request cannot be executed.")]
    Denied = ReplacementProcessingStatusCode.Denied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement request previously received from you has been received at the stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_ZwPwGdp-Ed-ak6NoX_4Aeg_-1450819608")]
    [Description(
        @"Replacement request previously received from you has been received at the stock exchange."
    )]
    ReceivedAtStockExchange = ReplacementProcessingStatusCode.ReceivedAtStockExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement request previously received from you has been received at intermediary (if not stock exchange).
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZwY6ANp-Ed-ak6NoX_4Aeg_-1450819607")]
    [Description(
        @"Replacement request previously received from you has been received at intermediary (if not stock exchange)."
    )]
    ReceivedAtIntermediary = ReplacementProcessingStatusCode.ReceivedAtIntermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement request has been accepted for further processing by the account servicer (technical receipt).
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZwY6Adp-Ed-ak6NoX_4Aeg_-1450819587")]
    [Description(
        @"Replacement request has been accepted for further processing by the account servicer (technical receipt)."
    )]
    Accepted = ReplacementProcessingStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is partially filled, replacement processing accepted for the remaining.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZwY6Atp-Ed-ak6NoX_4Aeg_-1450819578")]
    [Description(@"Order is partially filled, replacement processing accepted for the remaining.")]
    PartialReplacementAccepted = ReplacementProcessingStatusCode.PartialReplacementAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement request is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZwY6A9p-Ed-ak6NoX_4Aeg_-1450819556")]
    [Description(@"Replacement request is pending.")]
    Pending = ReplacementProcessingStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement request has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZwY6BNp-Ed-ak6NoX_4Aeg_-1450819547")]
    [Description(@"Replacement request has been rejected for further processing.")]
    Rejected = ReplacementProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement request has been completed.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_ZwY6Bdp-Ed-ak6NoX_4Aeg_-1450819525")]
    [Description(@"Replacement request has been completed.")]
    Completed = ReplacementProcessingStatusCode.Completed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement request previously received from you is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_ZwY6Btp-Ed-ak6NoX_4Aeg_-1450819516")]
    [Description(@"Replacement request previously received from you is in repair.")]
    InRepair = ReplacementProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions
}
