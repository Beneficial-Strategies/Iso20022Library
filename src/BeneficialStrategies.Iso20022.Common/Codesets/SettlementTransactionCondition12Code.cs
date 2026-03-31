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
[IsoId("_2qssKQllEeuQ1MenzX1l-g")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementTransactionCondition12Code>))]
#endif
public enum SettlementTransactionCondition12Code
{
    /// <summary>
    /// Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_2qssMQllEeuQ1MenzX1l-g")]
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
    [IsoId("_2qssPgllEeuQ1MenzX1l-g")]
    [Description(
        @"Transfer of ownership of the asset to another party during the closing of an option."
    )]
    Assignement = SettlementTransactionConditionCode.Assignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a buy to cover.
    /// Encoded/decoded by serializers as &quot;BUTC&quot;.
    /// </summary>
    [EnumMember(Value = "BUTC")]
    [IsoId("_2qssLAllEeuQ1MenzX1l-g")]
    [Description(@"Transaction is a buy to cover.")]
    BuytoCover = SettlementTransactionConditionCode.BuytoCover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_2qssQAllEeuQ1MenzX1l-g")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    Clean = SettlementTransactionConditionCode.Clean, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as &quot;DLWM&quot;.
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("_2qssOwllEeuQ1MenzX1l-g")]
    [Description(
        @"Matching receipt instruction not required (only for concerned international or national central securities depositories)."
    )]
    DeliveryWithoutMatching = SettlementTransactionConditionCode.DeliveryWithoutMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_2qssNwllEeuQ1MenzX1l-g")]
    [Description(@"Taxable financial instruments are to be settled.")]
    Dirty = SettlementTransactionConditionCode.Dirty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_2qssMwllEeuQ1MenzX1l-g")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SettlementTransactionConditionCode.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_2qssPQllEeuQ1MenzX1l-g")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are exercised."
    )]
    Exercised = SettlementTransactionConditionCode.Exercised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that have expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_2qssOgllEeuQ1MenzX1l-g")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that have expired."
    )]
    Expired = SettlementTransactionConditionCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as &quot;FRCL&quot;.
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("_2qssNgllEeuQ1MenzX1l-g")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement = SettlementTransactionConditionCode.FreeCleanSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as &quot;KNOC&quot;.
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_2qssPwllEeuQ1MenzX1l-g")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are expired worthless."
    )]
    KnockedOut = SettlementTransactionConditionCode.KnockedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No market claim should be automatically generated.
    /// Encoded/decoded by serializers as &quot;NOMC&quot;.
    /// </summary>
    [EnumMember(Value = "NOMC")]
    [IsoId("_2qssLgllEeuQ1MenzX1l-g")]
    [Description(@"No market claim should be automatically generated.")]
    NoAutomaticMarketClaim = SettlementTransactionConditionCode.NoAutomaticMarketClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security transaction is not for accounting.
    /// Encoded/decoded by serializers as &quot;NACT&quot;.
    /// </summary>
    [EnumMember(Value = "NACT")]
    [IsoId("_2qssKwllEeuQ1MenzX1l-g")]
    [Description(@"Security transaction is not for accounting.")]
    NotAccountingRelated = SettlementTransactionConditionCode.NotAccountingRelated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position to cover the pending sale will be available by contractual settlement date (accounting information).
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_2qssMgllEeuQ1MenzX1l-g")]
    [Description(
        @"Position to cover the pending sale will be available by contractual settlement date (accounting information)."
    )]
    PendingSale = SettlementTransactionConditionCode.PendingSale, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_2qssKgllEeuQ1MenzX1l-g")]
    [Description(@"Securities are to be physically settled.")]
    Physical = SettlementTransactionConditionCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral position is available for other purposes (for example, onwards delivery).
    /// Encoded/decoded by serializers as &quot;RHYP&quot;.
    /// </summary>
    [EnumMember(Value = "RHYP")]
    [IsoId("_2qssLQllEeuQ1MenzX1l-g")]
    [Description(
        @"Collateral position is available for other purposes (for example, onwards delivery)."
    )]
    Rehypothecation = SettlementTransactionConditionCode.Rehypothecation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_2qssPAllEeuQ1MenzX1l-g")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting = SettlementTransactionConditionCode.Reporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as &quot;RESI&quot;.
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_2qssNQllEeuQ1MenzX1l-g")]
    [Description(
        @"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository."
    )]
    Residual = SettlementTransactionConditionCode.Residual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_2qssMAllEeuQ1MenzX1l-g")]
    [Description(@"Account is used for short sale orders.")]
    ShortSell = SettlementTransactionConditionCode.ShortSell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as &quot;SPDL&quot;.
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("_2qssLwllEeuQ1MenzX1l-g")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery = SettlementTransactionConditionCode.SpecialDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as &quot;SPST&quot;.
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("_2qssOAllEeuQ1MenzX1l-g")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement = SettlementTransactionConditionCode.SplitSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction resulting from a transformation.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_2qssQQllEeuQ1MenzX1l-g")]
    [Description(@"Transaction resulting from a transformation.")]
    Transformation = SettlementTransactionConditionCode.Transformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are not be delivered but segregated following triparty collateral transaction.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_2qssNAllEeuQ1MenzX1l-g")]
    [Description(
        @"Securities are not be delivered but segregated following triparty collateral transaction."
    )]
    TripartySegregation = SettlementTransactionConditionCode.TripartySegregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as &quot;UNEX&quot;.
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("_2qssOQllEeuQ1MenzX1l-g")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed = SettlementTransactionConditionCode.Unexposed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction was settled by the settlement internaliser/account servicer (eg custodian) in its own books and not through a securities settlement system (e.g. CSD system).
    /// Encoded/decoded by serializers as &quot;INTS&quot;.
    /// </summary>
    [EnumMember(Value = "INTS")]
    [IsoId("_7kKVYQllEeuQ1MenzX1l-g")]
    [Description(
        @"The instruction was settled by the settlement internaliser/account servicer (eg custodian) in its own books and not through a securities settlement system (e.g. CSD system)."
    )]
    InternalisedSettlement = SettlementTransactionConditionCode.InternalisedSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of settlement instructions created as a result of a partial successful buy-in.
    /// Encoded/decoded by serializers as &quot;BPSS&quot;.
    /// </summary>
    [EnumMember(Value = "BPSS")]
    [IsoId("_zia1MQzWEeuUZuaHWzkTew")]
    [Description(
        @"Identification of settlement instructions created as a result of a partial successful buy-in."
    )]
    PartialSuccessfulBuyIn = SettlementTransactionConditionCode.PartialSuccessfulBuyIn, // same ordinal as derivation source for type conversions
}
