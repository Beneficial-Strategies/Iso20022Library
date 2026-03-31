// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for which a request has not been accepted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zk6p0Np-Ed-ak6NoX_4Aeg_336258976")]
[Description(@"Specifies the reason for which a request has not been accepted.")]
[DerivedFrom(typeof(RejectionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason3Code>))]
#endif
public enum RejectionReason3Code
{
    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_Zk6p0dp-Ed-ak6NoX_4Aeg_336258984")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol = RejectionReasonCode.UnknownSymbol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange on which the financial instrument is traded is closed.
    /// Encoded/decoded by serializers as &quot;EXCL&quot;.
    /// </summary>
    [EnumMember(Value = "EXCL")]
    [IsoId("_Zk6p0tp-Ed-ak6NoX_4Aeg_336258985")]
    [Description(@"Exchange on which the financial instrument is traded is closed.")]
    ClosedExchange = RejectionReasonCode.ClosedExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.
    /// Encoded/decoded by serializers as &quot;EXLI&quot;.
    /// </summary>
    [EnumMember(Value = "EXLI")]
    [IsoId("_Zk6p09p-Ed-ak6NoX_4Aeg_336258986")]
    [Description(
        @"Countervalue of the order exceeds the allowed trading limit or quote exceeds limit."
    )]
    ExceedsLimit = RejectionReasonCode.ExceedsLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request has exceeded the allowed time frame.
    /// Encoded/decoded by serializers as &quot;TOLA&quot;.
    /// </summary>
    [EnumMember(Value = "TOLA")]
    [IsoId("_Zk6p1Np-Ed-ak6NoX_4Aeg_336258987")]
    [Description(@"Request has exceeded the allowed time frame.")]
    TooLate = RejectionReasonCode.TooLate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price does not comply with the financial instrument&apos;s characteristics.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_Zk6p1dp-Ed-ak6NoX_4Aeg_336258988")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice = RejectionReasonCode.InvalidPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Permission to be processed is not granted.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_Zk6p1tp-Ed-ak6NoX_4Aeg_336258989")]
    [Description(@"Permission to be processed is not granted.")]
    NotAuthorised = RejectionReasonCode.NotAuthorised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No counterparty order has been identified.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_Zk6p19p-Ed-ak6NoX_4Aeg_336258998")]
    [Description(@"No counterparty order has been identified.")]
    NoMatchInquiry = RejectionReasonCode.NoMatchInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referred instrument does not exist in combination with the mentioned market.
    /// Encoded/decoded by serializers as &quot;NINS&quot;.
    /// </summary>
    [EnumMember(Value = "NINS")]
    [IsoId("_Zk6p2Np-Ed-ak6NoX_4Aeg_336258999")]
    [Description(@"Referred instrument does not exist in combination with the mentioned market.")]
    NoInstrumentMarket = RejectionReasonCode.NoInstrumentMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested financial instrument is not available.
    /// Encoded/decoded by serializers as &quot;NINV&quot;.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_ZlEa0Np-Ed-ak6NoX_4Aeg_336259000")]
    [Description(@"Requested financial instrument is not available.")]
    NoInventory = RejectionReasonCode.NoInventory, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is not interested in the transaction.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ZlEa0dp-Ed-ak6NoX_4Aeg_336259001")]
    [Description(@"Counterparty is not interested in the transaction.")]
    Pass = RejectionReasonCode.Pass, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requestor has no insufficient credit to make the trade.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_ZlEa0tp-Ed-ak6NoX_4Aeg_-941797784")]
    [Description(@"Requestor has no insufficient credit to make the trade.")]
    InsufficientCredit = RejectionReasonCode.InsufficientCredit, // same ordinal as derivation source for type conversions
}
