// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the balance sub-type, as published in an external balance sub-type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amL5k9p-Ed-ak6NoX_4Aeg_-1218783633")]
[Description(
    @"Specifies the balance sub-type, as published in an external balance sub-type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalBalanceSubTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalBalanceSubType1Code>))]
#endif
public enum ExternalBalanceSubType1Code
{
    /// <summary>
    /// Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank&apos;s balance is equal to the reserve due during the remaining days of the maintenance period.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_teji1fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank's balance is equal to the reserve due during the remaining days of the maintenance period."
    )]
    Adjustment = ExternalBalanceSubTypeCode.Adjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the amount in the domestic or base accounting currency.
    /// Encoded/decoded by serializers as &quot;BCUR&quot;.
    /// </summary>
    [EnumMember(Value = "BCUR")]
    [IsoId("_tetT0vRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the amount in the domestic or base accounting currency. ")]
    BaseCurrency = ExternalBalanceSubTypeCode.BaseCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a &apos;reserve&apos; balance.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_tetT1fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance."
    )]
    Blocked = ExternalBalanceSubTypeCode.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing funds that cannot be touched by the account owner.
    /// Encoded/decoded by serializers as &quot;BLKD&quot;.
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_te3E0vRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing funds that cannot be touched by the account owner.")]
    BlockedFunds = ExternalBalanceSubTypeCode.BlockedFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as &quot;DLOD&quot;.
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_te3E1fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day."
    )]
    DaylightOverdraft = ExternalBalanceSubTypeCode.DaylightOverdraft, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.
    /// Encoded/decoded by serializers as &quot;EAST&quot;.
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_te3E2PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank."
    )]
    EligibleAssets = ExternalBalanceSubTypeCode.EligibleAssets, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral.
    /// Encoded/decoded by serializers as &quot;FCOL&quot;.
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_tfAOwvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral."
    )]
    FirmCollateralization = ExternalBalanceSubTypeCode.FirmCollateralization, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.
    /// Encoded/decoded by serializers as &quot;FCOU&quot;.
    /// </summary>
    [EnumMember(Value = "FCOU")]
    [IsoId("_tfAOxfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral."
    )]
    AmountsThatHaveBeenUsedToServeAsFirmCollateral =
        ExternalBalanceSubTypeCode.AmountsThatHaveBeenUsedToServeAsFirmCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total of all balance types representing the forecast of transactions to settle, blocked items, custody transactions and corporate actions cash disbursements.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_tfAOyPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total of all balance types representing the forecast of transactions to settle, blocked items, custody transactions and corporate actions cash disbursements."
    )]
    SecuritiesForecast = ExternalBalanceSubTypeCode.SecuritiesForecast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the net amount to be funded resulting from the difference between the total of all transactions with a cash impact and the existing cash coverage.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_tfJ_wvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the net amount to be funded resulting from the difference between the total of all transactions with a cash impact and the existing cash coverage."
    )]
    NetFunding = ExternalBalanceSubTypeCode.NetFunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing an intermediate amount such as the opening or closing balance incrementally carried forward from one page to the next in a multi-page statement or report.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_tfJ_xfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing an intermediate amount such as the opening or closing balance incrementally carried forward from one page to the next in a multi-page statement or report."
    )]
    Intermediate = ExternalBalanceSubTypeCode.Intermediate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the amount in the local market currency for which the asset is held.
    /// Encoded/decoded by serializers as &quot;LCUR&quot;.
    /// </summary>
    [EnumMember(Value = "LCUR")]
    [IsoId("_tfJ_yPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the amount in the local market currency for which the asset is held. "
    )]
    LocalCurrency = ExternalBalanceSubTypeCode.LocalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as &quot;LRLD&quot;.
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_tfTJsvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit."
    )]
    LimitRelated = ExternalBalanceSubTypeCode.LimitRelated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available. In the context of CSDs, reservation of liquidity made to meet settlement obligations.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_tfTJtfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available. In the context of CSDs, reservation of liquidity made to meet settlement obligations."
    )]
    ReservedLiquidity = ExternalBalanceSubTypeCode.ReservedLiquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities pending delivery, such as orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_tfTJuPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of securities pending delivery, such as orders to sell securities have been executed but settlement of the open transactions has not been confirmed."
    )]
    SecuritiesPending = ExternalBalanceSubTypeCode.SecuritiesPending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the fictive amount of automated direct debits or payment based on standing arrangements between the CSD and the user. Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as &quot;PIPO&quot;.
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_tfTJu_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the fictive amount of automated direct debits or payment based on standing arrangements between the CSD and the user. Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds."
    )]
    PayInPayOut = ExternalBalanceSubTypeCode.PayInPayOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as &quot;PRAV&quot;.
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_tfc6svRYEeuLhpyIdtJzwg")]
    [Description(
        @"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period."
    )]
    ProgressiveAverage = ExternalBalanceSubTypeCode.ProgressiveAverage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes.
    /// Encoded/decoded by serializers as &quot;RESV&quot;.
    /// </summary>
    [EnumMember(Value = "RESV")]
    [IsoId("_tfc6tfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. "
    )]
    Reserve = ExternalBalanceSubTypeCode.Reserve, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.
    /// Encoded/decoded by serializers as &quot;SCOL&quot;.
    /// </summary>
    [EnumMember(Value = "SCOL")]
    [IsoId("_tfc6uPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at."
    )]
    SelfCollateralization = ExternalBalanceSubTypeCode.SelfCollateralization, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.
    /// Encoded/decoded by serializers as &quot;SCOU&quot;.
    /// </summary>
    [EnumMember(Value = "SCOU")]
    [IsoId("_tfc6u_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process. "
    )]
    AmountsThatHaveBeenUsedToServeAsSelfCollateral =
        ExternalBalanceSubTypeCode.AmountsThatHaveBeenUsedToServeAsSelfCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_tfc6vvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit."
    )]
    Threshold = ExternalBalanceSubTypeCode.Threshold, // same ordinal as derivation source for type conversions
}
