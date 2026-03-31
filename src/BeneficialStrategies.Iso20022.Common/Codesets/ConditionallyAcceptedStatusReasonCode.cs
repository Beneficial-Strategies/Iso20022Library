// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a conditionally accepted status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bB5lMtp-Ed-ak6NoX_4Aeg_-838964064")]
[Description(@"Specifies the reason for a conditionally accepted status.")]
[Derivations(
    typeof(ConditionallyAcceptedStatusReason2Code),
    typeof(ConditionallyAcceptedStatusReason3Code),
    typeof(ConditionallyAcceptedStatusReason1Code)
)]
public enum ConditionallyAcceptedStatusReasonCode
{
    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_bB5lM9p-Ed-ak6NoX_4Aeg_-782627470")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription."
    )]
    AwaitingMoney,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there are enough funds in the account to complete it.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_bB5lNNp-Ed-ak6NoX_4Aeg_-782627453")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending until there are enough funds in the account to complete it."
    )]
    AwaitingFunds,

    /// <summary>
    /// Order is pending until documents are completed and received, eg, legal documents from the successor, legal proceeds because of bankruptcy, missing signature.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_bB5lNdp-Ed-ak6NoX_4Aeg_-782627452")]
    [Description(
        @"Order is pending until documents are completed and received, eg, legal documents from the successor, legal proceeds because of bankruptcy, missing signature."
    )]
    AwaitingDocuments,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there are enough funds in the account to complete the redemption.
    /// Encoded/decoded by serializers as &quot;AWRM&quot;.
    /// </summary>
    [EnumMember(Value = "AWRM")]
    [IsoId("_bB5lNtp-Ed-ak6NoX_4Aeg_-1993504155")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending until there are enough funds in the account to complete the redemption."
    )]
    AwaitingRedemptionMoney,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription.
    /// Encoded/decoded by serializers as &quot;AWSM&quot;.
    /// </summary>
    [EnumMember(Value = "AWSM")]
    [IsoId("_bB5lN9p-Ed-ak6NoX_4Aeg_-1903923146")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending until there is enough cash in the account to pay the subscription."
    )]
    AwaitingSubscriptionMoney,

    /// <summary>
    /// Another reason for the conditionally accepted status.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bB5lONp-Ed-ak6NoX_4Aeg_-782627435")]
    [Description(@"Another reason for the conditionally accepted status.")]
    Other,

    /// <summary>
    /// Order is accepted for further processing pending the result of the investigation for possible duplicates.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bB5lOdp-Ed-ak6NoX_4Aeg_-503710616")]
    [Description(
        @"Order is accepted for further processing pending the result of the investigation for possible duplicates."
    )]
    PossibleDuplicate,

    /// <summary>
    /// Order is accepted for further processing pending the extension of the trading limit.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_bCDWMNp-Ed-ak6NoX_4Aeg_-503710599")]
    [Description(
        @"Order is accepted for further processing pending the extension of the trading limit."
    )]
    TradingLimitExceeded,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending the benefit plan investor (BPI) declaration.
    /// Encoded/decoded by serializers as &quot;BPID&quot;.
    /// </summary>
    [EnumMember(Value = "BPID")]
    [IsoId("_bCDWMdp-Ed-ak6NoX_4Aeg_-622659162")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending the benefit plan investor (BPI) declaration."
    )]
    BenefitPlanDeclaration,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending the ERISA declaration.
    /// Encoded/decoded by serializers as &quot;ERIS&quot;.
    /// </summary>
    [EnumMember(Value = "ERIS")]
    [IsoId("_bCDWMtp-Ed-ak6NoX_4Aeg_-622659102")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending the ERISA declaration."
    )]
    ERISADeclaration,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending until the required anti-money laundering documentation is presented to the transfer agent.
    /// Encoded/decoded by serializers as &quot;AMLD&quot;.
    /// </summary>
    [EnumMember(Value = "AMLD")]
    [IsoId("_bCDWM9p-Ed-ak6NoX_4Aeg_-622658808")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending until the required anti-money laundering documentation is presented to the transfer agent."
    )]
    AMLDocuments,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_bCDWNNp-Ed-ak6NoX_4Aeg_-622658730")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending the investment manager's approval."
    )]
    AwaitingApproval,

    /// <summary>
    /// Order is accepted for further processing but the execution of the subscription order is pending as additional funding is required.
    /// Encoded/decoded by serializers as &quot;AFUN&quot;.
    /// </summary>
    [EnumMember(Value = "AFUN")]
    [IsoId("_bCDWNdp-Ed-ak6NoX_4Aeg_-621738681")]
    [Description(
        @"Order is accepted for further processing but the execution of the subscription order is pending as additional funding is required."
    )]
    AdditionalFundingRequired,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending as the order is below the minimum initial investment amount and is subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_bCDWNtp-Ed-ak6NoX_4Aeg_-621738544")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending as the order is below the minimum initial investment amount and is subject to the investment manager's approval."
    )]
    BelowMinimumInitialInvestmentAmount,

    /// <summary>
    /// Order is accepted for further processing but the execution of the subscription order is pending as the order is below the minimum top-up investment and is subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;BMTO&quot;.
    /// </summary>
    [EnumMember(Value = "BMTO")]
    [IsoId("_bCDWN9p-Ed-ak6NoX_4Aeg_-621738466")]
    [Description(
        @"Order is accepted for further processing but the execution of the subscription order is pending as the order is below the minimum top-up investment and is subject to the investment manager's approval."
    )]
    BelowMinimumTopUpAmount,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending as there is insufficient capacity and the order is subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_bCDWONp-Ed-ak6NoX_4Aeg_-621738172")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending as there is insufficient capacity and the order is subject to the investment manager's approval."
    )]
    InsufficientCapacity,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending because of a percentage holding breach, eg, PPM rules; taxation rules (ERISA).
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_bCDWOdp-Ed-ak6NoX_4Aeg_-621738077")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending because of a percentage holding breach, eg, PPM rules; taxation rules (ERISA)."
    )]
    PercentageHoldingBreach,

    /// <summary>
    /// Order is accepted for further processing but the execution of the redemption order is pending as it is below the minimum redemption amount and subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;BMRA&quot;.
    /// </summary>
    [EnumMember(Value = "BMRA")]
    [IsoId("_bCNHMNp-Ed-ak6NoX_4Aeg_-621737709")]
    [Description(
        @"Order is accepted for further processing but the execution of the redemption order is pending as it is below the minimum redemption amount and subject to the investment manager's approval."
    )]
    BelowMinimumRedemptionAmount,

    /// <summary>
    /// Order is accepted for further processing but the execution of the redemption order is pending as the holding will be below the minimum retained value and subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;BMRV&quot;.
    /// </summary>
    [EnumMember(Value = "BMRV")]
    [IsoId("_bCNHMdp-Ed-ak6NoX_4Aeg_-621737613")]
    [Description(
        @"Order is accepted for further processing but the execution of the redemption order is pending as the holding will be below the minimum retained value and subject to the investment manager's approval."
    )]
    BelowMinimumRetainedAmount,

    /// <summary>
    /// Order is accepted for further processing but the execution of the order is pending as a lock-up period is in place and subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_bCNHMtp-Ed-ak6NoX_4Aeg_-621737510")]
    [Description(
        @"Order is accepted for further processing but the execution of the order is pending as a lock-up period is in place and subject to the investment manager's approval."
    )]
    LockUp,

    /// <summary>
    /// Order is accepted for further processing but the execution of the redemption order is pending as assets are illiquid and the order is subject to the investment manager&apos;s approval.
    /// Encoded/decoded by serializers as &quot;ILLI&quot;.
    /// </summary>
    [EnumMember(Value = "ILLI")]
    [IsoId("_bCNHM9p-Ed-ak6NoX_4Aeg_-621737198")]
    [Description(
        @"Order is accepted for further processing but the execution of the redemption order is pending as assets are illiquid and the order is subject to the investment manager's approval."
    )]
    AssetsIlliquid,

    /// <summary>
    /// Order is accepted for further processing but the execution of the redemption order is pending as it is subject to the investment manager&apos;s discretion.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_bCNHNNp-Ed-ak6NoX_4Aeg_-621737103")]
    [Description(
        @"Order is accepted for further processing but the execution of the redemption order is pending as it is subject to the investment manager's discretion."
    )]
    Discretion,

    /// <summary>
    /// Order is accepted for further processing but the execution of the subscription order is pending as the order is below the minimum investment and a top-up is required.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_bCNHNdp-Ed-ak6NoX_4Aeg_-621736735")]
    [Description(
        @"Order is accepted for further processing but the execution of the subscription order is pending as the order is below the minimum investment and a top-up is required."
    )]
    SubscriptionTopUpAmount,
}
