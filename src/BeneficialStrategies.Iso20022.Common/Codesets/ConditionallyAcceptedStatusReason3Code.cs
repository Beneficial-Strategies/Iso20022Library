// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a conditionally accepted status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bA3DZ9p-Ed-ak6NoX_4Aeg_-49397615")]
[Description(@"Specifies the reason for a conditionally accepted status.")]
[DerivedFrom(typeof(ConditionallyAcceptedStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConditionallyAcceptedStatusReason3Code>))]
#endif
public enum ConditionallyAcceptedStatusReason3Code
{
    /// <summary>
    /// Order is pending until documents are completed and received, eg, legal documents from the successor, legal proceeds because of bankruptcy, missing signature.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_bBmqQNp-Ed-ak6NoX_4Aeg_22639830")]
    [Description(
        @"Order is pending until documents are completed and received, eg, legal documents from the successor, legal proceeds because of bankruptcy, missing signature."
    )]
    AwaitingDocuments = ConditionallyAcceptedStatusReasonCode.AwaitingDocuments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription.
    /// Encoded/decoded by serializers as &quot;AWSM&quot;.
    /// </summary>
    [EnumMember(Value = "AWSM")]
    [IsoId("_bBmqQdp-Ed-ak6NoX_4Aeg_22639907")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription."
    )]
    AwaitingSubscriptionMoney = ConditionallyAcceptedStatusReasonCode.AwaitingSubscriptionMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing pending the result of the investigation for possible duplicates.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bBmqQtp-Ed-ak6NoX_4Aeg_22639950")]
    [Description(
        @"Order is accepted for further processing pending the result of the investigation for possible duplicates."
    )]
    PossibleDuplicate = ConditionallyAcceptedStatusReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing pending the extension of the trading limit.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_bBmqQ9p-Ed-ak6NoX_4Aeg_22640002")]
    [Description(
        @"Order is accepted for further processing pending the extension of the trading limit."
    )]
    TradingLimitExceeded = ConditionallyAcceptedStatusReasonCode.TradingLimitExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending the benefit plan investor (BPI) declaration.
    /// Encoded/decoded by serializers as &quot;BPID&quot;.
    /// </summary>
    [EnumMember(Value = "BPID")]
    [IsoId("_bBmqRNp-Ed-ak6NoX_4Aeg_2058481387")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending the benefit plan investor (BPI) declaration."
    )]
    BenefitPlanDeclaration = ConditionallyAcceptedStatusReasonCode.BenefitPlanDeclaration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending the ERISA declaration.
    /// Encoded/decoded by serializers as &quot;ERIS&quot;.
    /// </summary>
    [EnumMember(Value = "ERIS")]
    [IsoId("_bBmqRdp-Ed-ak6NoX_4Aeg_2058481422")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending the ERISA declaration."
    )]
    ERISADeclaration = ConditionallyAcceptedStatusReasonCode.ERISADeclaration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until the required anti-money laundering documentation is presented to the transfer agent.
    /// Encoded/decoded by serializers as &quot;AMLD&quot;.
    /// </summary>
    [EnumMember(Value = "AMLD")]
    [IsoId("_bBmqRtp-Ed-ak6NoX_4Aeg_2058481482")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending until the required anti-money laundering documentation is presented to the transfer agent."
    )]
    AMLDocuments = ConditionallyAcceptedStatusReasonCode.AMLDocuments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_bBwbQNp-Ed-ak6NoX_4Aeg_2058481790")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending the investment manager's approval."
    )]
    AwaitingApproval = ConditionallyAcceptedStatusReasonCode.AwaitingApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the subscription order is pending as additional funding is required.
    /// Encoded/decoded by serializers as &quot;AFUN&quot;.
    /// </summary>
    [EnumMember(Value = "AFUN")]
    [IsoId("_bBwbQdp-Ed-ak6NoX_4Aeg_2058481825")]
    [Description(
        @"Order is accepted for further processing but the execution of the subscription order is pending as additional funding is required."
    )]
    AdditionalFundingRequired = ConditionallyAcceptedStatusReasonCode.AdditionalFundingRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending as the order is below the minimum initial investment amount and is subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_bBwbQtp-Ed-ak6NoX_4Aeg_2058481868")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending as the order is below the minimum initial investment amount and is subject to the investment manager's approval."
    )]
    BelowMinimumInitialInvestmentAmount =
        ConditionallyAcceptedStatusReasonCode.BelowMinimumInitialInvestmentAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the subscription order is pending as the order is below the minimum top-up investment and is subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;BMTO&quot;.
    /// </summary>
    [EnumMember(Value = "BMTO")]
    [IsoId("_bBwbQ9p-Ed-ak6NoX_4Aeg_2058481928")]
    [Description(
        @"Order is accepted for further processing but the execution of the subscription order is pending as the order is below the minimum top-up investment and is subject to the investment manager's approval."
    )]
    BelowMinimumTopUpAmount = ConditionallyAcceptedStatusReasonCode.BelowMinimumTopUpAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending as there is insufficient capacity and the order is subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_bBwbRNp-Ed-ak6NoX_4Aeg_2058481980")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending as there is insufficient capacity and the order is subject to the investment manager's approval."
    )]
    InsufficientCapacity = ConditionallyAcceptedStatusReasonCode.InsufficientCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending because of a percentage holding breach, eg, PPM rules; taxation rules (ERISA).
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_bBwbRdp-Ed-ak6NoX_4Aeg_2058482040")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending because of a percentage holding breach, eg, PPM rules; taxation rules (ERISA)."
    )]
    PercentageHoldingBreach = ConditionallyAcceptedStatusReasonCode.PercentageHoldingBreach, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the redemption order is pending as it is below the minimum redemption amount and subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;BMRA&quot;.
    /// </summary>
    [EnumMember(Value = "BMRA")]
    [IsoId("_bBwbRtp-Ed-ak6NoX_4Aeg_2058482300")]
    [Description(
        @"Order is accepted for further processing but the execution of the redemption order is pending as it is below the minimum redemption amount and subject to the investment manager's approval."
    )]
    BelowMinimumRedemptionAmount =
        ConditionallyAcceptedStatusReasonCode.BelowMinimumRedemptionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the redemption order is pending as the holding will be below the minimum retained value and subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;BMRV&quot;.
    /// </summary>
    [EnumMember(Value = "BMRV")]
    [IsoId("_bBwbR9p-Ed-ak6NoX_4Aeg_2058482352")]
    [Description(
        @"Order is accepted for further processing but the execution of the redemption order is pending as the holding will be below the minimum retained value and subject to the investment manager's approval."
    )]
    BelowMinimumRetainedAmount = ConditionallyAcceptedStatusReasonCode.BelowMinimumRetainedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending as a lock-up period is in place and subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_bBwbSNp-Ed-ak6NoX_4Aeg_2058482430")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending as a lock-up period is in place and subject to the investment manager's approval."
    )]
    LockUp = ConditionallyAcceptedStatusReasonCode.LockUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the redemption order is pending as assets are illiquid and the order is subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;ILLI&quot;.
    /// </summary>
    [EnumMember(Value = "ILLI")]
    [IsoId("_bBwbSdp-Ed-ak6NoX_4Aeg_2059402419")]
    [Description(
        @"Order is accepted for further processing but the execution of the redemption order is pending as assets are illiquid and the order is subject to the investment manager's approval."
    )]
    AssetsIlliquid = ConditionallyAcceptedStatusReasonCode.AssetsIlliquid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the redemption order is pending as it is subject to the investment manager&apos;s discretion.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_bB5lMNp-Ed-ak6NoX_4Aeg_2059402444")]
    [Description(
        @"Order is accepted for further processing but the execution of the redemption order is pending as it is subject to the investment manager's discretion."
    )]
    Discretion = ConditionallyAcceptedStatusReasonCode.Discretion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted for further processing but the execution of the subscription order is pending as the order is below the minimum investment and a top-up is required.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_bB5lMdp-Ed-ak6NoX_4Aeg_93259506")]
    [Description(
        @"Order is accepted for further processing but the execution of the subscription order is pending as the order is below the minimum investment and a top-up is required."
    )]
    SubscriptionTopUpAmount = ConditionallyAcceptedStatusReasonCode.SubscriptionTopUpAmount, // same ordinal as derivation source for type conversions
}
