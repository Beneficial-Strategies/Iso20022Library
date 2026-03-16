// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZlEa09p-Ed-ak6NoX_4Aeg_2116688390")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason5Code
{
    /// <summary>
    /// Exchange on which the financial instrument is traded is closed.
    /// Encoded/decoded by serializers as &quot;EXCL&quot;.
    /// </summary>
    [EnumMember(Value = "EXCL")]
    [IsoId("_ZlEa1Np-Ed-ak6NoX_4Aeg_-2083157274")]
    [Description(@"Exchange on which the financial instrument is traded is closed.")]
    ClosedExchange = RejectionReasonCode.ClosedExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZlEa1dp-Ed-ak6NoX_4Aeg_-2078541558")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol = RejectionReasonCode.UnknownSymbol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.
    /// Encoded/decoded by serializers as &quot;EXLI&quot;.
    /// </summary>
    [EnumMember(Value = "EXLI")]
    [IsoId("_ZlEa1tp-Ed-ak6NoX_4Aeg_-2064686590")]
    [Description(
        @"Countervalue of the order exceeds the allowed trading limit or quote exceeds limit."
    )]
    ExceedsLimit = RejectionReasonCode.ExceedsLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request has exceeded the allowed time frame.
    /// Encoded/decoded by serializers as &quot;TOLA&quot;.
    /// </summary>
    [EnumMember(Value = "TOLA")]
    [IsoId("_ZlEa19p-Ed-ak6NoX_4Aeg_-2053605493")]
    [Description(@"Request has exceeded the allowed time frame.")]
    TooLate = RejectionReasonCode.TooLate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price does not comply with the financial instrument&apos;s characteristics.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_ZlEa2Np-Ed-ak6NoX_4Aeg_-2040676063")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice = RejectionReasonCode.InvalidPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZlOL0Np-Ed-ak6NoX_4Aeg_-1736835393")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonCode.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agreement start date is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ASTM&quot;.
    /// </summary>
    [EnumMember(Value = "ASTM")]
    [IsoId("_ZlOL0dp-Ed-ak6NoX_4Aeg_-1592766517")]
    [Description(@"Agreement start date is missing or invalid.")]
    AgreementStartDate = RejectionReasonCode.AgreementStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ZlOL0tp-Ed-ak6NoX_4Aeg_-1592766474")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RejectionReasonCode.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZlOL09p-Ed-ak6NoX_4Aeg_-1592766414")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonCode.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZlOL1Np-Ed-ak6NoX_4Aeg_-1592766379")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZlOL1dp-Ed-ak6NoX_4Aeg_-1592766102")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RejectionReasonCode.ForfeitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid delivering custodian.
    /// Encoded/decoded by serializers as &quot;DCUS&quot;.
    /// </summary>
    [EnumMember(Value = "DCUS")]
    [IsoId("_ZlOL1tp-Ed-ak6NoX_4Aeg_-1592766067")]
    [Description(@"Unrecognised or invalid delivering custodian.")]
    DeliveringCustodian = RejectionReasonCode.DeliveringCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid receiving agent.
    /// Encoded/decoded by serializers as &quot;RCUS&quot;.
    /// </summary>
    [EnumMember(Value = "RCUS")]
    [IsoId("_ZlOL19p-Ed-ak6NoX_4Aeg_-1592766006")]
    [Description(@"Unrecognised or invalid receiving agent.")]
    ReceivingCustodian = RejectionReasonCode.ReceivingCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request has been rejected since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_ZlOL2Np-Ed-ak6NoX_4Aeg_-1591845975")]
    [Description(
        @"Cancellation request has been rejected since the instruction could not be found."
    )]
    NotFoundRejection = RejectionReasonCode.NotFoundRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as &quot;QUNP&quot;.
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("_ZlOL2dp-Ed-ak6NoX_4Aeg_-1591845915")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType = RejectionReasonCode.QuantityUnitType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZlXVwNp-Ed-ak6NoX_4Aeg_-1591845862")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RejectionReasonCode.TerminationTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ZlXVwdp-Ed-ak6NoX_4Aeg_-1591845820")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RejectionReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_ZlXVwtp-Ed-ak6NoX_4Aeg_-1591845802")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RejectionReasonCode.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_ZlXVw9p-Ed-ak6NoX_4Aeg_-1591845777")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RejectionReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_ZlXVxNp-Ed-ak6NoX_4Aeg_-1591845742")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RejectionReasonCode.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZlXVxdp-Ed-ak6NoX_4Aeg_-1591845490")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate = RejectionReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_ZlXVxtp-Ed-ak6NoX_4Aeg_-1591845448")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent = RejectionReasonCode.ReceivingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZlXVx9p-Ed-ak6NoX_4Aeg_-1591845353")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary = RejectionReasonCode.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZlXVyNp-Ed-ak6NoX_4Aeg_-1591845335")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent = RejectionReasonCode.DeliveringAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZlhGwNp-Ed-ak6NoX_4Aeg_-1591845002")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_ZlhGwdp-Ed-ak6NoX_4Aeg_-1591844985")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown = RejectionReasonCode.InvestorNameAddressUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_ZlhGwtp-Ed-ak6NoX_4Aeg_-380186469")]
    [Description(
        @"Cancellation request was rejected since the instruction has already been cancelled."
    )]
    RejectedSinceAlreadyCancelled = RejectionReasonCode.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_ZlhGw9p-Ed-ak6NoX_4Aeg_-375566929")]
    [Description(
        @"Cancellation request has been rejected because the instruction process is in progress or has been processed."
    )]
    RejectedSinceInProgress = RejectionReasonCode.RejectedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_ZlhGxNp-Ed-ak6NoX_4Aeg_1943381003")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference = RejectionReasonCode.InvalidReference, // same ordinal as derivation source for type conversions
}
