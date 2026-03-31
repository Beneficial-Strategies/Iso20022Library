// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RB7AOQzXEeuUZuaHWzkTew")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementTransactionCondition14Code>))]
#endif
public enum SettlementTransactionCondition14Code
{
    /// <summary>
    /// Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_RCEKGAzXEeuUZuaHWzkTew")]
    [Description(
        @"Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline."
    )]
    AcceptAfterRegularSettlementDeadline =
        SettlementTransactionConditionCode.AcceptAfterRegularSettlementDeadline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_RB7AQQzXEeuUZuaHWzkTew")]
    [Description(
        @"Transfer of ownership of the asset to another party during the closing of an option."
    )]
    Assignement = SettlementTransactionConditionCode.Assignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a buy to cover.
    /// Encoded/decoded by serializers as &quot;BUTC&quot;.
    /// </summary>
    [EnumMember(Value = "BUTC")]
    [IsoId("_RB7AQgzXEeuUZuaHWzkTew")]
    [Description(@"Transaction is a buy to cover.")]
    BuytoCover = SettlementTransactionConditionCode.BuytoCover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_RCEKFAzXEeuUZuaHWzkTew")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    Clean = SettlementTransactionConditionCode.Clean, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as &quot;DLWM&quot;.
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("_RCEKEwzXEeuUZuaHWzkTew")]
    [Description(
        @"Matching receipt instruction not required (only for concerned international or national central securities depositories)."
    )]
    DeliveryWithoutMatching = SettlementTransactionConditionCode.DeliveryWithoutMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_RB7APwzXEeuUZuaHWzkTew")]
    [Description(@"Taxable financial instruments are to be settled.")]
    Dirty = SettlementTransactionConditionCode.Dirty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_RB7ARwzXEeuUZuaHWzkTew")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SettlementTransactionConditionCode.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_RB7ARgzXEeuUZuaHWzkTew")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are exercised."
    )]
    Exercised = SettlementTransactionConditionCode.Exercised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that have expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_RB7ASAzXEeuUZuaHWzkTew")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that have expired."
    )]
    Expired = SettlementTransactionConditionCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as &quot;FRCL&quot;.
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("_RCEKEQzXEeuUZuaHWzkTew")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement = SettlementTransactionConditionCode.FreeCleanSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as &quot;KNOC&quot;.
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_RCEKFgzXEeuUZuaHWzkTew")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are expired worthless."
    )]
    KnockedOut = SettlementTransactionConditionCode.KnockedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No market claim should be automatically generated.
    /// Encoded/decoded by serializers as &quot;NOMC&quot;.
    /// </summary>
    [EnumMember(Value = "NOMC")]
    [IsoId("_RCEKFQzXEeuUZuaHWzkTew")]
    [Description(@"No market claim should be automatically generated.")]
    NoAutomaticMarketClaim = SettlementTransactionConditionCode.NoAutomaticMarketClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security transaction is not for accounting.
    /// Encoded/decoded by serializers as &quot;NACT&quot;.
    /// </summary>
    [EnumMember(Value = "NACT")]
    [IsoId("_RB7AOwzXEeuUZuaHWzkTew")]
    [Description(@"Security transaction is not for accounting.")]
    NotAccountingRelated = SettlementTransactionConditionCode.NotAccountingRelated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position to cover the pending sale will be available by contractual settlement date (accounting information).
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_RCEKEgzXEeuUZuaHWzkTew")]
    [Description(
        @"Position to cover the pending sale will be available by contractual settlement date (accounting information)."
    )]
    PendingSale = SettlementTransactionConditionCode.PendingSale, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_RB7AQwzXEeuUZuaHWzkTew")]
    [Description(@"Securities are to be physically settled.")]
    Physical = SettlementTransactionConditionCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral position is available for other purposes (for example, onwards delivery).
    /// Encoded/decoded by serializers as &quot;RHYP&quot;.
    /// </summary>
    [EnumMember(Value = "RHYP")]
    [IsoId("_RB7APAzXEeuUZuaHWzkTew")]
    [Description(
        @"Collateral position is available for other purposes (for example, onwards delivery)."
    )]
    Rehypothecation = SettlementTransactionConditionCode.Rehypothecation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_RB7ARAzXEeuUZuaHWzkTew")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting = SettlementTransactionConditionCode.Reporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as &quot;RESI&quot;.
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_RB7APQzXEeuUZuaHWzkTew")]
    [Description(
        @"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository."
    )]
    Residual = SettlementTransactionConditionCode.Residual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_RCEKFwzXEeuUZuaHWzkTew")]
    [Description(@"Account is used for short sale orders.")]
    ShortSell = SettlementTransactionConditionCode.ShortSell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as &quot;SPDL&quot;.
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("_RB7AQAzXEeuUZuaHWzkTew")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery = SettlementTransactionConditionCode.SpecialDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as &quot;SPST&quot;.
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("_RCEKEAzXEeuUZuaHWzkTew")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement = SettlementTransactionConditionCode.SplitSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction resulting from a transformation.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_RB7APgzXEeuUZuaHWzkTew")]
    [Description(@"Transaction resulting from a transformation.")]
    Transformation = SettlementTransactionConditionCode.Transformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are not be delivered but segregated following triparty collateral transaction.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_RB7ARQzXEeuUZuaHWzkTew")]
    [Description(
        @"Securities are not be delivered but segregated following triparty collateral transaction."
    )]
    TripartySegregation = SettlementTransactionConditionCode.TripartySegregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as &quot;UNEX&quot;.
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("_RB7AOgzXEeuUZuaHWzkTew")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed = SettlementTransactionConditionCode.Unexposed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of settlement instructions created as a result of a partial successful buy-in.
    /// Encoded/decoded by serializers as &quot;BPSS&quot;.
    /// </summary>
    [EnumMember(Value = "BPSS")]
    [IsoId("_Vu5FkQzXEeuUZuaHWzkTew")]
    [Description(
        @"Identification of settlement instructions created as a result of a partial successful buy-in."
    )]
    PartialSuccessfulBuyIn = SettlementTransactionConditionCode.PartialSuccessfulBuyIn, // same ordinal as derivation source for type conversions
}
