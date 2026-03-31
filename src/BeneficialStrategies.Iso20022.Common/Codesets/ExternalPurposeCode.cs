// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external purpose code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HWFp4IKZEeeCI5iKR7LsYQ")]
[Description(
    @"Specifies the external purpose code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalPurpose1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalPurposeCode>))]
#endif
public enum ExternalPurposeCode
{
    /// <summary>
    /// Delayed draw funding. Certain issuers may utilize delayed draw loans whereby the lender is committed to fund cash|within a specified period once a call is made by the issuer. The lender receives a fee for entering into such a|commitment
    /// Encoded/decoded by serializers as &quot;BKDF&quot;.
    /// </summary>
    [EnumMember(Value = "BKDF")]
    [IsoId("_tst6o_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Delayed draw funding. Certain issuers may utilize delayed draw loans whereby the lender is committed to fund cash|within a specified period once a call is made by the issuer. The lender receives a fee for entering into such a|commitment"
    )]
    BankLoanDelayedDrawFunding,

    /// <summary>
    /// Bank loan fees. Cash activity related to specific bank loan fees, including (a) agent / assignment fees; (b) amendment fees; (c) commitment fees; (d) consent fees; (e) cost of carry fees; (f) delayed compensation fees; (g)|facility fees; (h) fronting fees; (i) funding fees; (j) letter of credit assignment fees
    /// Encoded/decoded by serializers as &quot;BKFE&quot;.
    /// </summary>
    [EnumMember(Value = "BKFE")]
    [IsoId("_tst6pvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Bank loan fees. Cash activity related to specific bank loan fees, including (a) agent / assignment fees; (b) amendment fees; (c) commitment fees; (d) consent fees; (e) cost of carry fees; (f) delayed compensation fees; (g)|facility fees; (h) fronting fees; (i) funding fees; (j) letter of credit assignment fees"
    )]
    BankLoanFees,

    /// <summary>
    /// Bank loan funding memo. Net cash movement for the loan contract final notification when sent separately from the|loan contract final notification instruction.
    /// Encoded/decoded by serializers as &quot;BKFM&quot;.
    /// </summary>
    [EnumMember(Value = "BKFM")]
    [IsoId("_tst6qfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Bank loan funding memo. Net cash movement for the loan contract final notification when sent separately from the|loan contract final notification instruction."
    )]
    BankLoanFundingMemo,

    /// <summary>
    /// Accrued interest payments. Specific to bank loans.
    /// Encoded/decoded by serializers as &quot;BKIP&quot;.
    /// </summary>
    [EnumMember(Value = "BKIP")]
    [IsoId("_ts3EkPRYEeuLhpyIdtJzwg")]
    [Description(@"Accrued interest payments. Specific to bank loans.")]
    BankLoanAccruedInterestPayment,

    /// <summary>
    /// Principal paydowns. Specific to bank loans
    /// Encoded/decoded by serializers as &quot;BKPP&quot;.
    /// </summary>
    [EnumMember(Value = "BKPP")]
    [IsoId("_ts3Ek_RYEeuLhpyIdtJzwg")]
    [Description(@"Principal paydowns. Specific to bank loans")]
    BankLoanPrincipalPaydown,

    /// <summary>
    /// A Service that is settling money for a bulk of card transactions, while referring to a specific transaction file or other information like terminal ID, card acceptor ID or other transaction details.
    /// Encoded/decoded by serializers as &quot;CBLK&quot;.
    /// </summary>
    [EnumMember(Value = "CBLK")]
    [IsoId("_ts3ElvRYEeuLhpyIdtJzwg")]
    [Description(
        @"A Service that is settling money for a bulk of card transactions, while referring to a specific transaction file or other information like terminal ID, card acceptor ID or other transaction details."
    )]
    CardBulkClearing,

    /// <summary>
    /// Purchase of Goods and Services with additional Cash disbursement at the POI (Cashback)
    /// Encoded/decoded by serializers as &quot;CDCB&quot;.
    /// </summary>
    [EnumMember(Value = "CDCB")]
    [IsoId("_ts3EmfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Purchase of Goods and Services with additional Cash disbursement at the POI (Cashback)"
    )]
    CardPaymentWithCashBack,

    /// <summary>
    /// ATM Cash Withdrawal in an unattended or Cash Advance in an attended environment (POI or bank counter)
    /// Encoded/decoded by serializers as &quot;CDCD&quot;.
    /// </summary>
    [EnumMember(Value = "CDCD")]
    [IsoId("_ts3EnPRYEeuLhpyIdtJzwg")]
    [Description(
        @"ATM Cash Withdrawal in an unattended or Cash Advance in an attended environment (POI or bank counter)"
    )]
    CashDisbursementCashSettlement,

    /// <summary>
    /// ATM Cash Withdrawal in an unattended or Cash Advance in an attended environment (POI or bank counter) with surcharging.
    /// Encoded/decoded by serializers as &quot;CDCS&quot;.
    /// </summary>
    [EnumMember(Value = "CDCS")]
    [IsoId("_ttA1kPRYEeuLhpyIdtJzwg")]
    [Description(
        @"ATM Cash Withdrawal in an unattended or Cash Advance in an attended environment (POI or bank counter) with surcharging."
    )]
    CashDisbursementWithSurcharging,

    /// <summary>
    /// A combined service which enables the card acceptor to perform an authorisation for a temporary amount and a completion for the final amount within a limited time frame. Deferred Payment is only available in the unattended environment.|Examples where this service is widely used are unattended petrol pumps and phone booths
    /// Encoded/decoded by serializers as &quot;CDDP&quot;.
    /// </summary>
    [EnumMember(Value = "CDDP")]
    [IsoId("_ttA1k_RYEeuLhpyIdtJzwg")]
    [Description(
        @"A combined service which enables the card acceptor to perform an authorisation for a temporary amount and a completion for the final amount within a limited time frame. Deferred Payment is only available in the unattended environment.|Examples where this service is widely used are unattended petrol pumps and phone booths"
    )]
    CardDeferredPayment,

    /// <summary>
    /// A service which allows the card acceptor to effect a credit to a cardholder&apos; account. Unlike a Merchant Refund, an Original Credit is not preceded by a card payment. This service is used for example for crediting winnings from gaming.
    /// Encoded/decoded by serializers as &quot;CDOC&quot;.
    /// </summary>
    [EnumMember(Value = "CDOC")]
    [IsoId("_ttA1lvRYEeuLhpyIdtJzwg")]
    [Description(
        @"A service which allows the card acceptor to effect a credit to a cardholder' account. Unlike a Merchant Refund, an Original Credit is not preceded by a card payment. This service is used for example for crediting winnings from gaming."
    )]
    OriginalCredit,

    /// <summary>
    /// Purchase of Goods which are equivalent to cash like coupons in casinos.
    /// Encoded/decoded by serializers as &quot;CDQC&quot;.
    /// </summary>
    [EnumMember(Value = "CDQC")]
    [IsoId("_ttA1mfRYEeuLhpyIdtJzwg")]
    [Description(@"Purchase of Goods which are equivalent to cash like coupons in casinos.")]
    QuasiCash,

    /// <summary>
    /// Transaction is related to a Service that is first reserving money from a card account and then is loading an e-purse application by this amount.
    /// Encoded/decoded by serializers as &quot;ETUP&quot;.
    /// </summary>
    [EnumMember(Value = "ETUP")]
    [IsoId("_ttKmkPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a Service that is first reserving money from a card account and then is loading an e-purse application by this amount."
    )]
    EPurseTopUp,

    /// <summary>
    /// A Service that is settling card transaction related fees between two parties.
    /// Encoded/decoded by serializers as &quot;FCOL&quot;.
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_ttKmk_RYEeuLhpyIdtJzwg")]
    [Description(@"A Service that is settling card transaction related fees between two parties.")]
    FeeCollection,

    /// <summary>
    /// A Service that is first reserving money from a card account and then is loading a prepaid mobile phone amount by this amount.
    /// Encoded/decoded by serializers as &quot;MTUP&quot;.
    /// </summary>
    [EnumMember(Value = "MTUP")]
    [IsoId("_ttKmlvRYEeuLhpyIdtJzwg")]
    [Description(
        @"A Service that is first reserving money from a card account and then is loading a prepaid mobile phone amount by this amount."
    )]
    MobileTopUp,

    /// <summary>
    /// Transaction moves funds between 2 accounts of same account holder at the same bank.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_ttKmmfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction moves funds between 2 accounts of same account holder at the same bank."
    )]
    AccountManagement,

    /// <summary>
    /// Transaction is a general cash management instruction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ttKmnPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a general cash management instruction.")]
    CashManagementTransfer,

    /// <summary>
    /// Transaction is a collection of funds initiated via a credit transfer or direct debit.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_ttTwgPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is a collection of funds initiated via a credit transfer or direct debit."
    )]
    CollectionPayment,

    /// <summary>
    /// Transaction is related to cash disbursement.
    /// Encoded/decoded by serializers as &quot;CSDB&quot;.
    /// </summary>
    [EnumMember(Value = "CSDB")]
    [IsoId("_ttTwg_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to cash disbursement.")]
    CashDisbursementCashManagement,

    /// <summary>
    /// Transaction is releted to a payment of deposit.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ttTwhvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is releted to a payment of deposit.")]
    Deposit,

    /// <summary>
    /// Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_ttTwifRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group."
    )]
    IntraCompanyPayment,

    /// <summary>
    /// Transaction is a payment between two accounts belonging to the same party (intra-party payment), where party is a natural person (identified by a private ID, not organisation ID).
    /// Encoded/decoded by serializers as &quot;INTP&quot;.
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_ttdhgPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is a payment between two accounts belonging to the same party (intra-party payment), where party is a natural person (identified by a private ID, not organisation ID)."
    )]
    IntraPartyPayment,

    /// <summary>
    /// Bank initiated account transfer to support zero target balance management, pooling or sweeping.
    /// Encoded/decoded by serializers as &quot;LIMA&quot;.
    /// </summary>
    [EnumMember(Value = "LIMA")]
    [IsoId("_ttdhg_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Bank initiated account transfer to support zero target balance management, pooling or sweeping."
    )]
    LiquidityManagement,

    /// <summary>
    /// Transaction is related to a netting operation.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ttdhhvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a netting operation.")]
    Netting,

    /// <summary>
    /// Cash collateral related to any securities traded out beyond 3 days which include treasury notes, JGBs and Gilts.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("_ttdhifRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral related to any securities traded out beyond 3 days which include treasury notes, JGBs and Gilts."
    )]
    BondForward,

    /// <summary>
    /// Cash Collateral related to a Cross Currency Interest Rate Swap, indicating the exchange of fixed interest payments in one currency for those in another.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("_ttdhjPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash Collateral related to a Cross Currency Interest Rate Swap, indicating the exchange of fixed interest payments in one currency for those in another."
    )]
    CrossCurrencyIRS,

    /// <summary>
    /// Cash Collateral associated with an ISDA or Central Clearing Agreement that is covering the initial margin requirements for OTC trades clearing through a CCP.
    /// Encoded/decoded by serializers as &quot;CCPC&quot;.
    /// </summary>
    [EnumMember(Value = "CCPC")]
    [IsoId("_ttmrcPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash Collateral associated with an ISDA or Central Clearing Agreement that is covering the initial margin requirements for OTC trades clearing through a CCP. "
    )]
    CCPClearedInitialMargin,

    /// <summary>
    /// Cash Collateral associated with an ISDA or Central Clearing Agreement that is covering the variation margin requirements for OTC trades clearing through a CCP.
    /// Encoded/decoded by serializers as &quot;CCPM&quot;.
    /// </summary>
    [EnumMember(Value = "CCPM")]
    [IsoId("_ttmrc_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash Collateral associated with an ISDA or Central Clearing Agreement that is covering the variation margin requirements for OTC trades clearing through a CCP. "
    )]
    CCPClearedVariationMargin,

    /// <summary>
    /// CCP Segregated initial margin: Initial margin on OTC Derivatives cleared through a CCP that requires segregation
    /// Encoded/decoded by serializers as &quot;CCSM&quot;.
    /// </summary>
    [EnumMember(Value = "CCSM")]
    [IsoId("_ttmrdvRYEeuLhpyIdtJzwg")]
    [Description(
        @"CCP Segregated initial margin: Initial margin on OTC Derivatives cleared through a CCP that requires segregation"
    )]
    CCPClearedInitialMarginSegregatedCash,

    /// <summary>
    /// Cash collateral related to trading of credit default swap.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_ttwccPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to trading of credit default swap.")]
    CreditDefaultSwap,

    /// <summary>
    /// Cash collateral related to a combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("_ttwcc_RYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to a combination of various types of trades.")]
    CrossProduct,

    /// <summary>
    /// Cash collateral related to cash lending/borrowing; letter of Credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("_ttwcdvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral related to cash lending/borrowing; letter of Credit; signing of master agreement."
    )]
    CreditSupport,

    /// <summary>
    /// Cash collateral related to opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("_ttwcefRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to opening of a credit line before trading.")]
    CreditLine,

    /// <summary>
    /// Cash collateral related to trading of equity option (Also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("_ttwcfPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral related to trading of equity option (Also known as stock options)."
    )]
    EquityOption,

    /// <summary>
    /// Cash collateral related to equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("_tt6NcPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral related to equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest."
    )]
    EquitySwap,

    /// <summary>
    /// Cash collateral related to trading of an exotic option for example a non-standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_tt6Nc_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral related to trading of an exotic option for example a non-standard option."
    )]
    ExoticOption,

    /// <summary>
    /// Cash collateral related to trading of exchanged traded derivatives in general (Opposite to Over the Counter (OTC)).
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_tt6NdvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral related to trading of exchanged traded derivatives in general (Opposite to Over the Counter (OTC))."
    )]
    ExchangeTradedDerivatives,

    /// <summary>
    /// Cash collateral related to a fixed income instrument
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_tt6NefRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to a fixed income instrument")]
    FixedIncome,

    /// <summary>
    /// Cash collateral payment against a Master Forward Agreement (MFA) where the cash is held in a segregated account and is not available for use by the client. Includes any instruments with a forward settling date such TBAs, repurchase agreements and bond forwards
    /// Encoded/decoded by serializers as &quot;FWBC&quot;.
    /// </summary>
    [EnumMember(Value = "FWBC")]
    [IsoId("_tuD-cPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payment against a Master Forward Agreement (MFA) where the cash is held in a segregated account and is not available for use by the client. Includes any instruments with a forward settling date such TBAs, repurchase agreements and bond forwards"
    )]
    ForwardBrokerOwnedCashCollateral,

    /// <summary>
    /// Cash collateral payment against a Master Forward Agreement (MFA) where the cash is owned and may be used by the client when returned. Includes any instruments with a forward settling date such TBAs, repurchase agreements and bond forwards
    /// Encoded/decoded by serializers as &quot;FWCC&quot;.
    /// </summary>
    [EnumMember(Value = "FWCC")]
    [IsoId("_tuD-c_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payment against a Master Forward Agreement (MFA) where the cash is owned and may be used by the client when returned. Includes any instruments with a forward settling date such TBAs, repurchase agreements and bond forwards"
    )]
    ForwardClientOwnedCashCollateral,

    /// <summary>
    /// Any cash payment related to the collateral for a Master Agreement forward, which is segregated, and not available for use by the client. Example master agreement forwards include TBA, repo and Bond Forwards.
    /// Encoded/decoded by serializers as &quot;FWSB&quot;.
    /// </summary>
    [EnumMember(Value = "FWSB")]
    [IsoId("_tuD-dvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Any cash payment related to the collateral for a Master Agreement forward, which is segregated, and not available for use by the client. Example master agreement forwards include TBA, repo and Bond Forwards."
    )]
    ForwardBrokerOwnedCashCollateralSegregated,

    /// <summary>
    /// Any cash payment related to the collateral for a Master agreement forward, which is owned by the client and is available for use by the client when it is returned to them from the segregated account. Example master agreement forwards include TBA, repo and Bond Forwards.
    /// Encoded/decoded by serializers as &quot;FWSC&quot;.
    /// </summary>
    [EnumMember(Value = "FWSC")]
    [IsoId("_tuD-efRYEeuLhpyIdtJzwg")]
    [Description(
        @"Any cash payment related to the collateral for a Master agreement forward, which is owned by the client and is available for use by the client when it is returned to them from the segregated account. Example master agreement forwards include TBA, repo and Bond Forwards."
    )]
    ForwardClientOwnedSegregatedCashCollateral,

    /// <summary>
    /// Daily margin on listed derivatives – not segregated as collateral associated with an FCM agreement. Examples|include listed futures and options margin payments; premiums for listed options not covered in the MT54X message
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_tuD-fPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Daily margin on listed derivatives – not segregated as collateral associated with an FCM agreement. Examples|include listed futures and options margin payments; premiums for listed options not covered in the MT54X message"
    )]
    DailyMarginOnListedDerivatives,

    /// <summary>
    /// MBS Broker Owned Segregated (40Act/Dodd Frank) Cash Collateral - Any cash payment related to the collateral for a Mortgage Back Security, which is segregated, and not available for use by the client.
    /// Encoded/decoded by serializers as &quot;MBSB&quot;.
    /// </summary>
    [EnumMember(Value = "MBSB")]
    [IsoId("_tuNIYPRYEeuLhpyIdtJzwg")]
    [Description(
        @"MBS Broker Owned Segregated (40Act/Dodd Frank) Cash Collateral - Any cash payment related to the collateral for a Mortgage Back Security, which is segregated, and not available for use by the client."
    )]
    MBSBrokerOwnedCashCollateral,

    /// <summary>
    /// MBS Client Owned Cash Segregated (40Act/Dodd Frank) Cash Collateral - Any cash payment related to the collateral for a Mortgage Back Security, which is owned by the client and is available for use by the client when it is returned to them from the segregated account
    /// Encoded/decoded by serializers as &quot;MBSC&quot;.
    /// </summary>
    [EnumMember(Value = "MBSC")]
    [IsoId("_tuNIY_RYEeuLhpyIdtJzwg")]
    [Description(
        @"MBS Client Owned Cash Segregated (40Act/Dodd Frank) Cash Collateral - Any cash payment related to the collateral for a Mortgage Back Security, which is owned by the client and is available for use by the client when it is returned to them from the segregated account"
    )]
    MBSClientOwnedCashCollateral,

    /// <summary>
    /// Initial futures margin. Where such payment is owned by the client and is available for use by them on return
    /// Encoded/decoded by serializers as &quot;MGCC&quot;.
    /// </summary>
    [EnumMember(Value = "MGCC")]
    [IsoId("_tuNIZvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Initial futures margin. Where such payment is owned by the client and is available for use by them on return"
    )]
    FuturesInitialMargin,

    /// <summary>
    /// Margin Client Owned Segregated Cash Collateral - Any cash payment related to the collateral for initial futures margin, which is owned by the client and is available for use by the client when it is returned to them from the segregated account.
    /// Encoded/decoded by serializers as &quot;MGSC&quot;.
    /// </summary>
    [EnumMember(Value = "MGSC")]
    [IsoId("_tuNIafRYEeuLhpyIdtJzwg")]
    [Description(
        @"Margin Client Owned Segregated Cash Collateral - Any cash payment related to the collateral for initial futures margin, which is owned by the client and is available for use by the client when it is returned to them from the segregated account."
    )]
    FuturesInitialMarginClientOwnedSegregatedCashCollateral,

    /// <summary>
    /// Client owned collateral identified as eligible for OCC pledging
    /// Encoded/decoded by serializers as &quot;OCCC&quot;.
    /// </summary>
    [EnumMember(Value = "OCCC")]
    [IsoId("_tuW5YPRYEeuLhpyIdtJzwg")]
    [Description(@"Client owned collateral identified as eligible for OCC pledging")]
    ClientOwnedOCCPledgedCollateral,

    /// <summary>
    /// Cash collateral payment for OTC options associated with an FCM agreement. Where such payment is segregated and not available for use by the client
    /// Encoded/decoded by serializers as &quot;OPBC&quot;.
    /// </summary>
    [EnumMember(Value = "OPBC")]
    [IsoId("_tuW5Y_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payment for OTC options associated with an FCM agreement. Where such payment is segregated and not available for use by the client"
    )]
    OTCOptionBrokerOwnedCashCollateral,

    /// <summary>
    /// Cash collateral payment for OTC options associated with an FCM agreement. Where such payment is not segregated and is available for use by the client upon return
    /// Encoded/decoded by serializers as &quot;OPCC&quot;.
    /// </summary>
    [EnumMember(Value = "OPCC")]
    [IsoId("_tuW5ZvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payment for OTC options associated with an FCM agreement. Where such payment is not segregated and is available for use by the client upon return"
    )]
    OTCOptionClientOwnedCashCollateral,

    /// <summary>
    /// Option Broker Owned Segregated Cash Collateral - Any cash payment related to the collateral for an OTC option, which is segregated, and not available for use by the client.
    /// Encoded/decoded by serializers as &quot;OPSB&quot;.
    /// </summary>
    [EnumMember(Value = "OPSB")]
    [IsoId("_tuW5afRYEeuLhpyIdtJzwg")]
    [Description(
        @"Option Broker Owned Segregated Cash Collateral - Any cash payment related to the collateral for an OTC option, which is segregated, and not available for use by the client."
    )]
    OTCOptionBrokerOwnedSegregatedCashCollateral,

    /// <summary>
    /// Option Client Owned Cash Segregated Cash Collateral - Any cash payment related to the collateral for an OTC option, which is owned by the client and is available for use by the client when it is returned to them from the segregated account
    /// Encoded/decoded by serializers as &quot;OPSC&quot;.
    /// </summary>
    [EnumMember(Value = "OPSC")]
    [IsoId("_tuW5bPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Option Client Owned Cash Segregated Cash Collateral - Any cash payment related to the collateral for an OTC option, which is owned by the client and is available for use by the client when it is returned to them from the segregated account"
    )]
    OTCOptionClientOwnedCashSegregatedCashCollateral,

    /// <summary>
    /// Cash collateral related to trading of option on Foreign Exchange.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_tugqYPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to trading of option on Foreign Exchange.")]
    FXOption,

    /// <summary>
    /// Cash collateral related to Over-the-counter (OTC) Derivatives in general for example contracts which are traded and privately negotiated.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("_tugqY_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral related to Over-the-counter (OTC) Derivatives in general for example contracts which are traded and privately negotiated."
    )]
    OTCDerivatives,

    /// <summary>
    /// Cash collateral related to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_tugqZvRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to a repurchase agreement transaction.")]
    RepurchaseAgreement,

    /// <summary>
    /// Bi-lateral repo broker owned collateral associated with a repo master agreement – GMRA or MRA Master Repo|Agreements
    /// Encoded/decoded by serializers as &quot;RPBC&quot;.
    /// </summary>
    [EnumMember(Value = "RPBC")]
    [IsoId("_tugqafRYEeuLhpyIdtJzwg")]
    [Description(
        @"Bi-lateral repo broker owned collateral associated with a repo master agreement – GMRA or MRA Master Repo|Agreements"
    )]
    BilateralRepoBrokerOwnedCollateral,

    /// <summary>
    /// Repo client owned collateral associated with a repo master agreement – GMRA or MRA Master Repo Agreements
    /// Encoded/decoded by serializers as &quot;RPCC&quot;.
    /// </summary>
    [EnumMember(Value = "RPCC")]
    [IsoId("_tugqbPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Repo client owned collateral associated with a repo master agreement – GMRA or MRA Master Repo Agreements"
    )]
    RepoClientOwnedCollateral,

    /// <summary>
    /// Bi-lateral repo broker owned segregated cash collateral associated with a repo master agreement
    /// Encoded/decoded by serializers as &quot;RPSB&quot;.
    /// </summary>
    [EnumMember(Value = "RPSB")]
    [IsoId("_tup0UPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Bi-lateral repo broker owned segregated cash collateral associated with a repo master agreement"
    )]
    BilateralRepoBrokerOwnedSegregatedCashCollateral,

    /// <summary>
    /// Repo client owned segregated collateral associated with a repo master agreement
    /// Encoded/decoded by serializers as &quot;RPSC&quot;.
    /// </summary>
    [EnumMember(Value = "RPSC")]
    [IsoId("_tup0U_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Repo client owned segregated collateral associated with a repo master agreement"
    )]
    BilateralRepoClientOwnedSegregatedCashCollateral,

    /// <summary>
    /// Cash collateral related to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_tup0VvRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement,

    /// <summary>
    /// Cash collateral related to a Securities Buy Sell Sell Buy Back
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_tup0WfRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to a Securities Buy Sell Sell Buy Back")]
    SecuritiesBuySellSellBuyBack,

    /// <summary>
    /// Cash collateral related to Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("_tup0XPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic,

    /// <summary>
    /// Cash collateral related to Single Currency Interest Rate Swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("_tuzlUPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to Single Currency Interest Rate Swap.")]
    SingleCurrencyIRS,

    /// <summary>
    /// Cash collateral related to Combination of securities-related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_tuzlU_RYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to Combination of securities-related exposure types.")]
    SecuritiesCrossProducts,

    /// <summary>
    /// Short Sale broker owned collateral associated with a prime broker agreement
    /// Encoded/decoded by serializers as &quot;SHBC&quot;.
    /// </summary>
    [EnumMember(Value = "SHBC")]
    [IsoId("_tuzlVvRYEeuLhpyIdtJzwg")]
    [Description(@"Short Sale broker owned collateral associated with a prime broker agreement")]
    BrokerOwnedCollateralShortSale,

    /// <summary>
    /// Short Sale client owned collateral associated with a prime brokerage agreement
    /// Encoded/decoded by serializers as &quot;SHCC&quot;.
    /// </summary>
    [EnumMember(Value = "SHCC")]
    [IsoId("_tuzlWfRYEeuLhpyIdtJzwg")]
    [Description(@"Short Sale client owned collateral associated with a prime brokerage agreement")]
    ClientOwnedCollateralShortSale,

    /// <summary>
    /// Cash Collateral related to a Short Sell
    /// Encoded/decoded by serializers as &quot;SHSL&quot;.
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("_tuzlXPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash Collateral related to a Short Sell")]
    ShortSell,

    /// <summary>
    /// Cash collateral related to Securities lending and borrowing.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_tu8vQPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to Securities lending and borrowing.")]
    SecuritiesLendingAndBorrowing,

    /// <summary>
    /// Cash collateral related to a Secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("_tu8vQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to a Secured loan.")]
    SecuredLoan,

    /// <summary>
    /// Cash collateral payment for swaps associated with an ISDA agreement. . Where such payment is segregated and|not available for use by the client. Includes any cash collateral payments made under the terms of a CSA agreement|for instruments such as swaps and FX forwards.
    /// Encoded/decoded by serializers as &quot;SWBC&quot;.
    /// </summary>
    [EnumMember(Value = "SWBC")]
    [IsoId("_tu8vRvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payment for swaps associated with an ISDA agreement. . Where such payment is segregated and|not available for use by the client. Includes any cash collateral payments made under the terms of a CSA agreement|for instruments such as swaps and FX forwards."
    )]
    SwapBrokerOwnedCashCollateral,

    /// <summary>
    /// Cash collateral payment for swaps associated with an ISDA agreement. Where such payment is not segregated and|is available for use by the client upon return. Includes any cash collateral payments made under the terms of a CSA|agreement for instruments such as swaps and FX forwards.
    /// Encoded/decoded by serializers as &quot;SWCC&quot;.
    /// </summary>
    [EnumMember(Value = "SWCC")]
    [IsoId("_tu8vSfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payment for swaps associated with an ISDA agreement. Where such payment is not segregated and|is available for use by the client upon return. Includes any cash collateral payments made under the terms of a CSA|agreement for instruments such as swaps and FX forwards."
    )]
    SwapClientOwnedCashCollateral,

    /// <summary>
    /// Cash collateral related to an option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_tvGgQPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to an option on interest rate swap.")]
    Swaption,

    /// <summary>
    /// Swaps Broker Owned Segregated Cash Collateral - Any cash payment related to the collateral for Swap margin ,|which is segregated, and not available for use by the client. This includes any collateral identified in a CSA|agreement such as Swap or FX Forward collateral.
    /// Encoded/decoded by serializers as &quot;SWSB&quot;.
    /// </summary>
    [EnumMember(Value = "SWSB")]
    [IsoId("_tvGgQ_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Swaps Broker Owned Segregated Cash Collateral - Any cash payment related to the collateral for Swap margin ,|which is segregated, and not available for use by the client. This includes any collateral identified in a CSA|agreement such as Swap or FX Forward collateral."
    )]
    SwapsBrokerOwnedSegregatedCashCollateral,

    /// <summary>
    /// Swaps Client Owned Segregated Cash Collateral - Any cash payment related to the collateral for Swap margin,|which is owned by the client and is available for use by the client when returned from the segregated account. This|includes any collateral identified in a CSA agreement such as Swap or FX Forward collateral.
    /// Encoded/decoded by serializers as &quot;SWSC&quot;.
    /// </summary>
    [EnumMember(Value = "SWSC")]
    [IsoId("_tvGgRvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Swaps Client Owned Segregated Cash Collateral - Any cash payment related to the collateral for Swap margin,|which is owned by the client and is available for use by the client when returned from the segregated account. This|includes any collateral identified in a CSA agreement such as Swap or FX Forward collateral."
    )]
    SwapsClientOwnedSegregatedCashCollateral,

    /// <summary>
    /// Cash collateral related to a To Be Announced (TBA)
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("_tvGgSfRYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to a To Be Announced (TBA)")]
    ToBeAnnounced,

    /// <summary>
    /// Cash collateral payment (segregated) for TBA securities associated with a TBA Master Agreement. Where such payment is segregated and not available for use by the client.
    /// Encoded/decoded by serializers as &quot;TBBC&quot;.
    /// </summary>
    [EnumMember(Value = "TBBC")]
    [IsoId("_tvGgTPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payment (segregated) for TBA securities associated with a TBA Master Agreement. Where such payment is segregated and not available for use by the client."
    )]
    TBABrokerOwnedCashCollateral,

    /// <summary>
    /// Cash collateral payment (for use by client)for TBA securities associated with a TBA Master Agreement. Where such payment is not segregated and is available for use by the client upon return.
    /// Encoded/decoded by serializers as &quot;TBCC&quot;.
    /// </summary>
    [EnumMember(Value = "TBCC")]
    [IsoId("_tvPqMPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payment (for use by client)for TBA securities associated with a TBA Master Agreement. Where such payment is not segregated and is available for use by the client upon return."
    )]
    TBAClientOwnedCashCollateral,

    /// <summary>
    /// Cash collateral related to a combination of treasury-related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("_tvPqM_RYEeuLhpyIdtJzwg")]
    [Description(@"Cash collateral related to a combination of treasury-related exposure types.")]
    TreasuryCrossProduct,

    /// <summary>
    /// Transaction is related to the agricultural domain.
    /// Encoded/decoded by serializers as &quot;AGRT&quot;.
    /// </summary>
    [EnumMember(Value = "AGRT")]
    [IsoId("_tvPqNvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the agricultural domain.")]
    AgriculturalTransfer,

    /// <summary>
    /// Transaction is related to a payment associated with an Account Receivable Entry
    /// Encoded/decoded by serializers as &quot;AREN&quot;.
    /// </summary>
    [EnumMember(Value = "AREN")]
    [IsoId("_tvPqOfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment associated with an Account Receivable Entry"
    )]
    AccountsReceivablesEntry,

    /// <summary>
    /// Transaction is related to a payment of business expenses.
    /// Encoded/decoded by serializers as &quot;BEXP&quot;.
    /// </summary>
    [EnumMember(Value = "BEXP")]
    [IsoId("_tvPqPPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of business expenses.")]
    BusinessExpenses,

    /// <summary>
    /// Transaction is related to a payment associated with a Back Office Conversion Entry
    /// Encoded/decoded by serializers as &quot;BOCE&quot;.
    /// </summary>
    [EnumMember(Value = "BOCE")]
    [IsoId("_tvZbMPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment associated with a Back Office Conversion Entry"
    )]
    BackOfficeConversionEntry,

    /// <summary>
    /// Transaction is related to a payment of commercial credit or debit. (formerly CommercialCredit)
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_tvZbM_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment of commercial credit or debit. (formerly CommercialCredit)"
    )]
    CommercialPayment,

    /// <summary>
    /// Transaction is payment of copyright.
    /// Encoded/decoded by serializers as &quot;CPYR&quot;.
    /// </summary>
    [EnumMember(Value = "CPYR")]
    [IsoId("_tvZbNvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment of copyright.")]
    Copyright,

    /// <summary>
    /// Transaction is related to purchase and sale of goods.
    /// Encoded/decoded by serializers as &quot;GDDS&quot;.
    /// </summary>
    [EnumMember(Value = "GDDS")]
    [IsoId("_tvjMMPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to purchase and sale of goods.")]
    PurchaseSaleOfGoods,

    /// <summary>
    /// Transaction is related to purchase and sale of goods and services.
    /// Encoded/decoded by serializers as &quot;GDSV&quot;.
    /// </summary>
    [EnumMember(Value = "GDSV")]
    [IsoId("_tvjMM_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to purchase and sale of goods and services.")]
    PurchaseSaleOfGoodsAndServices,

    /// <summary>
    /// Transaction is related to purchase and sale of goods and services with cash back.
    /// Encoded/decoded by serializers as &quot;GSCB&quot;.
    /// </summary>
    [EnumMember(Value = "GSCB")]
    [IsoId("_tvjMNvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to purchase and sale of goods and services with cash back."
    )]
    PurchaseSaleOfGoodsAndServicesWithCashBack,

    /// <summary>
    /// Transaction is payment of a license fee.
    /// Encoded/decoded by serializers as &quot;LICF&quot;.
    /// </summary>
    [EnumMember(Value = "LICF")]
    [IsoId("_tvjMOfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment of a license fee.")]
    LicenseFee,

    /// <summary>
    /// A service which enables a user to use an app on its mobile to pay a merchant or other business payees by initiating a payment message. Within this context, the account information or an alias of the payee might be transported through different channels to the app, for example QR Code, NFC, Bluetooth, other Networks.
    /// Encoded/decoded by serializers as &quot;MP2B&quot;.
    /// </summary>
    [EnumMember(Value = "MP2B")]
    [IsoId("_tvjMPPRYEeuLhpyIdtJzwg")]
    [Description(
        @"A service which enables a user to use an app on its mobile to pay a merchant or other business payees by initiating a payment message. Within this context, the account information or an alias of the payee might be transported through different channels to the app, for example QR Code, NFC, Bluetooth, other Networks."
    )]
    MobileP2BPayment,

    /// <summary>
    /// Transaction is related to a payment associated with a Point of Purchase Entry.
    /// Encoded/decoded by serializers as &quot;POPE&quot;.
    /// </summary>
    [EnumMember(Value = "POPE")]
    [IsoId("_tvsWIPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment associated with a Point of Purchase Entry.")]
    PointOfPurchaseEntry,

    /// <summary>
    /// Transaction is the payment of royalties.
    /// Encoded/decoded by serializers as &quot;ROYA&quot;.
    /// </summary>
    [EnumMember(Value = "ROYA")]
    [IsoId("_tvsWI_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of royalties.")]
    Royalties,

    /// <summary>
    /// Transaction is related to purchase and sale of services.
    /// Encoded/decoded by serializers as &quot;SCVE&quot;.
    /// </summary>
    [EnumMember(Value = "SCVE")]
    [IsoId("_tvsWJvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to purchase and sale of services.")]
    PurchaseSaleOfServices,

    /// <summary>
    /// Transaction is related to service charges charged by a service provider.
    /// Encoded/decoded by serializers as &quot;SERV&quot;.
    /// </summary>
    [EnumMember(Value = "SERV")]
    [IsoId("_tv2HIPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to service charges charged by a service provider.")]
    ServiceCharges,

    /// <summary>
    /// Transaction is related to a payment of information or entertainment services either in printed or electronic form.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_tv2HI_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment of information or entertainment services either in printed or electronic form."
    )]
    Subscription,

    /// <summary>
    /// Transaction is related to a payment to a supplier.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_tv2HJvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment to a supplier.")]
    SupplierPayment,

    /// <summary>
    /// Transaction is related to a trade services operation.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_tv2HKfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a trade services operation.")]
    Commercial,

    /// <summary>
    /// Transaction is a payment for charity reasons.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_tv_REPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for charity reasons.")]
    CharityPayment,

    /// <summary>
    /// Transaction is a payment used by a third party who can collect funds to pay on behalf of consumers, ie credit counseling or bill payment companies.
    /// Encoded/decoded by serializers as &quot;COMT&quot;.
    /// </summary>
    [EnumMember(Value = "COMT")]
    [IsoId("_tv_RE_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is a payment used by a third party who can collect funds to pay on behalf of consumers, ie credit counseling or bill payment companies."
    )]
    ConsumerThirdPartyConsolidatedPayment,

    /// <summary>
    /// A service which enables a user to use an app on its mobile to initiate moving funds from his/her bank account to another person’s bank account while not using the account number  but an alias information like an MSISDN as account addressing information in his/her app.
    /// Encoded/decoded by serializers as &quot;MP2P&quot;.
    /// </summary>
    [EnumMember(Value = "MP2P")]
    [IsoId("_tv_RFvRYEeuLhpyIdtJzwg")]
    [Description(
        @"A service which enables a user to use an app on its mobile to initiate moving funds from his/her bank account to another person’s bank account while not using the account number  but an alias information like an MSISDN as account addressing information in his/her app."
    )]
    MobileP2PPayment,

    /// <summary>
    /// E-Commerce payment with payment guarantee of the issuing bank.
    /// Encoded/decoded by serializers as &quot;ECPG&quot;.
    /// </summary>
    [EnumMember(Value = "ECPG")]
    [IsoId("_tv_RGfRYEeuLhpyIdtJzwg")]
    [Description(@"E-Commerce payment with payment guarantee of the issuing bank.")]
    GuaranteedEPayment,

    /// <summary>
    /// E-Commerce payment return.
    /// Encoded/decoded by serializers as &quot;ECPR&quot;.
    /// </summary>
    [EnumMember(Value = "ECPR")]
    [IsoId("_tv_RHPRYEeuLhpyIdtJzwg")]
    [Description(@"E-Commerce payment return.")]
    EPaymentReturn,

    /// <summary>
    /// E-Commerce payment without payment guarantee of the issuing bank.
    /// Encoded/decoded by serializers as &quot;ECPU&quot;.
    /// </summary>
    [EnumMember(Value = "ECPU")]
    [IsoId("_twJCEPRYEeuLhpyIdtJzwg")]
    [Description(@"E-Commerce payment without payment guarantee of the issuing bank.")]
    NonGuaranteedEPayment,

    /// <summary>
    /// Transaction is related to ePayment.
    /// Encoded/decoded by serializers as &quot;EPAY&quot;.
    /// </summary>
    [EnumMember(Value = "EPAY")]
    [IsoId("_twJCE_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to ePayment.")]
    Epayment,

    /// <summary>
    /// Transaction is a payment of car loan principal payment.
    /// Encoded/decoded by serializers as &quot;CLPR&quot;.
    /// </summary>
    [EnumMember(Value = "CLPR")]
    [IsoId("_twJCFvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment of car loan principal payment.")]
    CarLoanPrincipalRepayment,

    /// <summary>
    /// Transaction is related to the payment of a compensation relating to interest loss/value date adjustment and can include fees.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_twJCGfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to the payment of a compensation relating to interest loss/value date adjustment and can include fees."
    )]
    CompensationPayment,

    /// <summary>
    /// Collection of funds initiated via a debit transfer.
    /// Encoded/decoded by serializers as &quot;DBTC&quot;.
    /// </summary>
    [EnumMember(Value = "DBTC")]
    [IsoId("_twSzEPRYEeuLhpyIdtJzwg")]
    [Description(@"Collection of funds initiated via a debit transfer.")]
    DebitCollectionPayment,

    /// <summary>
    /// Transaction is related to a payment of government insurance.
    /// Encoded/decoded by serializers as &quot;GOVI&quot;.
    /// </summary>
    [EnumMember(Value = "GOVI")]
    [IsoId("_twSzE_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of government insurance.")]
    GovernmentInsurance,

    /// <summary>
    /// Transaction is related to a payment of property loan.
    /// Encoded/decoded by serializers as &quot;HLRP&quot;.
    /// </summary>
    [EnumMember(Value = "HLRP")]
    [IsoId("_twSzFvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of property loan.")]
    PropertyLoanRepayment,

    /// <summary>
    /// Transaction is related to the settlement of a property loan.
    /// Encoded/decoded by serializers as &quot;HLST&quot;.
    /// </summary>
    [EnumMember(Value = "HLST")]
    [IsoId("_twSzGfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the settlement of a property loan.")]
    PropertyLoanSettlement,

    /// <summary>
    /// Transaction is a payment of car insurance premium.
    /// Encoded/decoded by serializers as &quot;INPC&quot;.
    /// </summary>
    [EnumMember(Value = "INPC")]
    [IsoId("_twSzHPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment of car insurance premium.")]
    InsurancePremiumCar,

    /// <summary>
    /// Transaction is related to an insurance premium refund.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_twckEPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an insurance premium refund.")]
    InsurancePremiumRefund,

    /// <summary>
    /// Transaction is related to the payment of an insurance claim.
    /// Encoded/decoded by serializers as &quot;INSC&quot;.
    /// </summary>
    [EnumMember(Value = "INSC")]
    [IsoId("_twckE_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the payment of an insurance claim.")]
    PaymentOfInsuranceClaim,

    /// <summary>
    /// Transaction is payment of an insurance premium.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_twckFvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment of an insurance premium.")]
    InsurancePremium,

    /// <summary>
    /// Transaction is payment of interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_twluAPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment of interest.")]
    Interest,

    /// <summary>
    /// Transaction is a payment of labor insurance.
    /// Encoded/decoded by serializers as &quot;LBRI&quot;.
    /// </summary>
    [EnumMember(Value = "LBRI")]
    [IsoId("_twluA_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment of labor insurance.")]
    LaborInsurance,

    /// <summary>
    /// Transaction is a payment of life insurance.
    /// Encoded/decoded by serializers as &quot;LIFI&quot;.
    /// </summary>
    [EnumMember(Value = "LIFI")]
    [IsoId("_twluBvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment of life insurance.")]
    LifeInsurance,

    /// <summary>
    /// Transaction is related to transfer of loan to borrower.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_twluCfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to transfer of loan to borrower.")]
    Loan,

    /// <summary>
    /// Transaction is related to repayment of loan to lender.
    /// Encoded/decoded by serializers as &quot;LOAR&quot;.
    /// </summary>
    [EnumMember(Value = "LOAR")]
    [IsoId("_twluDPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to repayment of loan to lender.")]
    LoanRepayment,

    /// <summary>
    /// Payment based on enforcement orders except those arising from judicial alimony decrees.
    /// Encoded/decoded by serializers as &quot;PENO&quot;.
    /// </summary>
    [EnumMember(Value = "PENO")]
    [IsoId("_twvfAPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payment based on enforcement orders except those arising from judicial alimony decrees."
    )]
    PaymentBasedOnEnforcementOrder,

    /// <summary>
    /// Transaction is a payment of property insurance.
    /// Encoded/decoded by serializers as &quot;PPTI&quot;.
    /// </summary>
    [EnumMember(Value = "PPTI")]
    [IsoId("_twvfA_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment of property insurance.")]
    PropertyInsurance,

    /// <summary>
    /// Transaction is for general rental/lease.
    /// Encoded/decoded by serializers as &quot;RELG&quot;.
    /// </summary>
    [EnumMember(Value = "RELG")]
    [IsoId("_twvfBvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is for general rental/lease.")]
    RentalLeaseGeneral,

    /// <summary>
    /// Transaction is related to a payment of a recurring installment made at regular intervals.
    /// Encoded/decoded by serializers as &quot;RINP&quot;.
    /// </summary>
    [EnumMember(Value = "RINP")]
    [IsoId("_twvfCfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment of a recurring installment made at regular intervals."
    )]
    RecurringInstallmentPayment,

    /// <summary>
    /// Transaction is related to a payment of a trust fund.
    /// Encoded/decoded by serializers as &quot;TRFD&quot;.
    /// </summary>
    [EnumMember(Value = "TRFD")]
    [IsoId("_twvfDPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of a trust fund.")]
    TrustFund,

    /// <summary>
    /// FX trades with a value date in the future.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_tw4o8PRYEeuLhpyIdtJzwg")]
    [Description(@"FX trades with a value date in the future.")]
    ForwardForeignExchange,

    /// <summary>
    /// FX netting if cash is moved by separate wire instead of within the closing FX instruction
    /// Encoded/decoded by serializers as &quot;FXNT&quot;.
    /// </summary>
    [EnumMember(Value = "FXNT")]
    [IsoId("_tw4o8_RYEeuLhpyIdtJzwg")]
    [Description(
        @"FX netting if cash is moved by separate wire instead of within the closing FX instruction"
    )]
    ForeignExchangeRelatedNetting,

    /// <summary>
    /// Transaction is related to a payment associated with administrative management.
    /// Encoded/decoded by serializers as &quot;ADMG&quot;.
    /// </summary>
    [EnumMember(Value = "ADMG")]
    [IsoId("_tw4o9vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment associated with administrative management.")]
    AdministrativeManagement,

    /// <summary>
    /// Transaction is an advance payment.
    /// Encoded/decoded by serializers as &quot;ADVA&quot;.
    /// </summary>
    [EnumMember(Value = "ADVA")]
    [IsoId("_tw4o-fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is an advance payment.")]
    AdvancePayment,

    /// <summary>
    /// Transaction is the payment of a domestic bearer cheque.
    /// Encoded/decoded by serializers as &quot;BCDM&quot;.
    /// </summary>
    [EnumMember(Value = "BCDM")]
    [IsoId("_tw4o_PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a domestic bearer cheque.")]
    BearerChequeDomestic,

    /// <summary>
    /// Transaction is the payment of a foreign bearer cheque.
    /// Encoded/decoded by serializers as &quot;BCFG&quot;.
    /// </summary>
    [EnumMember(Value = "BCFG")]
    [IsoId("_txCZ8PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a foreign bearer cheque.")]
    BearerChequeForeign,

    /// <summary>
    /// Transaction is related to a payment associated with building maintenance.
    /// Encoded/decoded by serializers as &quot;BLDM&quot;.
    /// </summary>
    [EnumMember(Value = "BLDM")]
    [IsoId("_txCZ8_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment associated with building maintenance.")]
    BuildingMaintenance,

    /// <summary>
    /// Bond Forward pair-off cash net movement
    /// Encoded/decoded by serializers as &quot;BNET&quot;.
    /// </summary>
    [EnumMember(Value = "BNET")]
    [IsoId("_txCZ9vRYEeuLhpyIdtJzwg")]
    [Description(@"Bond Forward pair-off cash net movement")]
    BondForwardNetting,

    /// <summary>
    /// Transaction is related to capital building fringe fortune, ie capital building in general
    /// Encoded/decoded by serializers as &quot;CBFF&quot;.
    /// </summary>
    [EnumMember(Value = "CBFF")]
    [IsoId("_txMK8PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to capital building fringe fortune, ie capital building in general"
    )]
    CapitalBuilding,

    /// <summary>
    /// Transaction is related to capital building fringe fortune for retirement
    /// Encoded/decoded by serializers as &quot;CBFR&quot;.
    /// </summary>
    [EnumMember(Value = "CBFR")]
    [IsoId("_txMK8_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to capital building fringe fortune for retirement")]
    CapitalBuildingRetirement,

    /// <summary>
    /// Transaction is related to a payment of credit card account.
    /// Encoded/decoded by serializers as &quot;CCRD&quot;.
    /// </summary>
    [EnumMember(Value = "CCRD")]
    [IsoId("_txMK9vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of credit card account.")]
    CreditCardPayment,

    /// <summary>
    /// Transaction is related to a payment of credit card bill.
    /// Encoded/decoded by serializers as &quot;CDBL&quot;.
    /// </summary>
    [EnumMember(Value = "CDBL")]
    [IsoId("_txMK-fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of credit card bill.")]
    CreditCardBill,

    /// <summary>
    /// Transaction is related to a payment of cancellation fee.
    /// Encoded/decoded by serializers as &quot;CFEE&quot;.
    /// </summary>
    [EnumMember(Value = "CFEE")]
    [IsoId("_txMK_PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of cancellation fee.")]
    CancellationFee,

    /// <summary>
    /// Transaction is related to a direct debit where the mandate was generated by using data from a payment card at the point of sale.
    /// Encoded/decoded by serializers as &quot;CGDD&quot;.
    /// </summary>
    [EnumMember(Value = "CGDD")]
    [IsoId("_txVU4PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a direct debit where the mandate was generated by using data from a payment card at the point of sale."
    )]
    CardGeneratedDirectDebit,

    /// <summary>
    /// Transaction is related to settlement of a trade, e.g. a foreign exchange deal or a securities transaction.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_txVU4_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to settlement of a trade, e.g. a foreign exchange deal or a securities transaction."
    )]
    TradeSettlementPayment,

    /// <summary>
    /// Transaction is related to payment of costs.
    /// Encoded/decoded by serializers as &quot;COST&quot;.
    /// </summary>
    [EnumMember(Value = "COST")]
    [IsoId("_txVU5vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payment of costs.")]
    Costs,

    /// <summary>
    /// Transaction is related to carpark charges.
    /// Encoded/decoded by serializers as &quot;CPKC&quot;.
    /// </summary>
    [EnumMember(Value = "CPKC")]
    [IsoId("_txfF4PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to carpark charges.")]
    CarparkCharges,

    /// <summary>
    /// Transaction is related to a debit card payment.
    /// Encoded/decoded by serializers as &quot;DCRD&quot;.
    /// </summary>
    [EnumMember(Value = "DCRD")]
    [IsoId("_txfF4_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a debit card payment.")]
    DebitCardPayment,

    /// <summary>
    /// Transaction is the payment of a disbursement due to a specific type of printed order for a payment of a  specified sum, issued by a bank or a post office (Zahlungsanweisung zur Verrechnung)
    /// Encoded/decoded by serializers as &quot;DSMT&quot;.
    /// </summary>
    [EnumMember(Value = "DSMT")]
    [IsoId("_txfF5vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is the payment of a disbursement due to a specific type of printed order for a payment of a  specified sum, issued by a bank or a post office (Zahlungsanweisung zur Verrechnung)"
    )]
    PrintedOrderDisbursement,

    /// <summary>
    /// Code used to pre-advise the account servicer of a forthcoming deliver against payment instruction.
    /// Encoded/decoded by serializers as &quot;DVPM&quot;.
    /// </summary>
    [EnumMember(Value = "DVPM")]
    [IsoId("_txfF6fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Code used to pre-advise the account servicer of a forthcoming deliver against payment instruction."
    )]
    DeliverAgainstPayment,

    /// <summary>
    /// Transaction is related to a payment of study/tuition fees.
    /// Encoded/decoded by serializers as &quot;EDUC&quot;.
    /// </summary>
    [EnumMember(Value = "EDUC")]
    [IsoId("_txfF7PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of study/tuition fees.")]
    Education,

    /// <summary>
    /// Payment related to a factor update
    /// Encoded/decoded by serializers as &quot;FACT&quot;.
    /// </summary>
    [EnumMember(Value = "FACT")]
    [IsoId("_txo24PRYEeuLhpyIdtJzwg")]
    [Description(@"Payment related to a factor update")]
    FactorUpdateRelatedPayment,

    /// <summary>
    /// Financial aid by State authorities for abolition of consequences of natural disasters.
    /// Encoded/decoded by serializers as &quot;FAND&quot;.
    /// </summary>
    [EnumMember(Value = "FAND")]
    [IsoId("_txo24_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Financial aid by State authorities for abolition of consequences of natural disasters."
    )]
    FinancialAidInCaseOfNaturalDisaster,

    /// <summary>
    /// Transaction is the payment for late fees &amp; charges. E.g Credit card charges
    /// Encoded/decoded by serializers as &quot;FCPM&quot;.
    /// </summary>
    [EnumMember(Value = "FCPM")]
    [IsoId("_txo25vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment for late fees & charges. E.g Credit card charges")]
    LatePaymentOfFeesAndCharges,

    /// <summary>
    /// Payment of fees/charges.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_txo26fRYEeuLhpyIdtJzwg")]
    [Description(@"Payment of fees/charges.")]
    PaymentOfFees,

    /// <summary>
    /// Payment with no commercial or statutory purpose.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_txo27PRYEeuLhpyIdtJzwg")]
    [Description(@"Payment with no commercial or statutory purpose.")]
    Gift,

    /// <summary>
    /// Transaction is a payment to or from a government department.
    /// Encoded/decoded by serializers as &quot;GOVT&quot;.
    /// </summary>
    [EnumMember(Value = "GOVT")]
    [IsoId("_txyA0PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment to or from a government department.")]
    GovernmentPayment,

    /// <summary>
    /// Transaction is reimbursement of credit card payment.
    /// Encoded/decoded by serializers as &quot;ICCP&quot;.
    /// </summary>
    [EnumMember(Value = "ICCP")]
    [IsoId("_txyA0_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is reimbursement of credit card payment.")]
    IrrevocableCreditCardPayment,

    /// <summary>
    /// Transaction is reimbursement of debit card payment.
    /// Encoded/decoded by serializers as &quot;IDCP&quot;.
    /// </summary>
    [EnumMember(Value = "IDCP")]
    [IsoId("_txyA1vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is reimbursement of debit card payment.")]
    IrrevocableDebitCardPayment,

    /// <summary>
    /// Transaction is payment for an installment/hire-purchase agreement.
    /// Encoded/decoded by serializers as &quot;IHRP&quot;.
    /// </summary>
    [EnumMember(Value = "IHRP")]
    [IsoId("_txyA2fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment for an installment/hire-purchase agreement.")]
    InstalmentHirePurchaseAgreement,

    /// <summary>
    /// Transaction is related to a payment of an installment.
    /// Encoded/decoded by serializers as &quot;INSM&quot;.
    /// </summary>
    [EnumMember(Value = "INSM")]
    [IsoId("_txyA3PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of an installment.")]
    Installment,

    /// <summary>
    /// Transaction is the payment for invoices.
    /// Encoded/decoded by serializers as &quot;IVPT&quot;.
    /// </summary>
    [EnumMember(Value = "IVPT")]
    [IsoId("_tx7x0PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment for invoices.")]
    InvoicePayment,

    /// <summary>
    /// Transaction is the payment of a domestic multi-currency cheque
    /// Encoded/decoded by serializers as &quot;MCDM&quot;.
    /// </summary>
    [EnumMember(Value = "MCDM")]
    [IsoId("_tx7x0_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a domestic multi-currency cheque")]
    MultiCurrenyChequeDomestic,

    /// <summary>
    /// Transaction is the payment of a foreign multi-currency cheque
    /// Encoded/decoded by serializers as &quot;MCFG&quot;.
    /// </summary>
    [EnumMember(Value = "MCFG")]
    [IsoId("_tyE7wPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a foreign multi-currency cheque")]
    MultiCurrenyChequeForeign,

    /// <summary>
    /// Transaction is related to a payment for multiple service types.
    /// Encoded/decoded by serializers as &quot;MSVC&quot;.
    /// </summary>
    [EnumMember(Value = "MSVC")]
    [IsoId("_tyE7w_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment for multiple service types.")]
    MultipleServiceTypes,

    /// <summary>
    /// Transaction is related to a payment for type of services not specified elsewhere.
    /// Encoded/decoded by serializers as &quot;NOWS&quot;.
    /// </summary>
    [EnumMember(Value = "NOWS")]
    [IsoId("_tyE7xvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment for type of services not specified elsewhere."
    )]
    NotOtherwiseSpecified,

    /// <summary>
    /// Transaction is the payment of a domestic order cheque
    /// Encoded/decoded by serializers as &quot;OCDM&quot;.
    /// </summary>
    [EnumMember(Value = "OCDM")]
    [IsoId("_tyE7yfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a domestic order cheque")]
    OrderChequeDomestic,

    /// <summary>
    /// Transaction is the payment of a foreign order cheque
    /// Encoded/decoded by serializers as &quot;OCFG&quot;.
    /// </summary>
    [EnumMember(Value = "OCFG")]
    [IsoId("_tyE7zPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a foreign order cheque")]
    OrderChequeForeign,

    /// <summary>
    /// Transaction is related to a payment of opening fee.
    /// Encoded/decoded by serializers as &quot;OFEE&quot;.
    /// </summary>
    [EnumMember(Value = "OFEE")]
    [IsoId("_tyOswPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of opening fee.")]
    OpeningFee,

    /// <summary>
    /// Other payment purpose.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_tyOsw_RYEeuLhpyIdtJzwg")]
    [Description(@"Other payment purpose.")]
    Other,

    /// <summary>
    /// Transaction is related to a pre-authorized debit origination
    /// Encoded/decoded by serializers as &quot;PADD&quot;.
    /// </summary>
    [EnumMember(Value = "PADD")]
    [IsoId("_tyYdwPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a pre-authorized debit origination")]
    PreauthorizedDebit,

    /// <summary>
    /// Transaction is related to payment terms specifications
    /// Encoded/decoded by serializers as &quot;PTSP&quot;.
    /// </summary>
    [EnumMember(Value = "PTSP")]
    [IsoId("_tyYdw_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payment terms specifications")]
    PaymentTerms,

    /// <summary>
    /// Transaction is related to a payment associated with a re-presented check entry
    /// Encoded/decoded by serializers as &quot;RCKE&quot;.
    /// </summary>
    [EnumMember(Value = "RCKE")]
    [IsoId("_tyhnsPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment associated with a re-presented check entry")]
    RepresentedCheckEntry,

    /// <summary>
    /// Transaction is related to a payment of receipt.
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_tyhns_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of receipt.")]
    ReceiptPayment,

    /// <summary>
    /// Transaction is the payment of a rebate.
    /// Encoded/decoded by serializers as &quot;REBT&quot;.
    /// </summary>
    [EnumMember(Value = "REBT")]
    [IsoId("_tyhntvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a rebate.")]
    Rebate,

    /// <summary>
    /// Transaction is the payment of a refund.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_tyhnufRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a refund.")]
    Refund,

    /// <summary>
    /// Transaction is the payment of rent.
    /// Encoded/decoded by serializers as &quot;RENT&quot;.
    /// </summary>
    [EnumMember(Value = "RENT")]
    [IsoId("_tyrYsPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of rent.")]
    Rent,

    /// <summary>
    /// Transaction is for account overdraft repayment
    /// Encoded/decoded by serializers as &quot;REOD&quot;.
    /// </summary>
    [EnumMember(Value = "REOD")]
    [IsoId("_tyrYs_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is for account overdraft repayment")]
    AccountOverdraftRepayment,

    /// <summary>
    /// Transaction is related to a reimbursement of a previous erroneous transaction.
    /// Encoded/decoded by serializers as &quot;RIMB&quot;.
    /// </summary>
    [EnumMember(Value = "RIMB")]
    [IsoId("_ty1JsPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a reimbursement of a previous erroneous transaction.")]
    ReimbursementOfAPreviousErroneousTransaction,

    /// <summary>
    /// Bi-lateral repo interest net/bulk payment at rollover/pair-off or other closing scenarios where applicable
    /// Encoded/decoded by serializers as &quot;RPNT&quot;.
    /// </summary>
    [EnumMember(Value = "RPNT")]
    [IsoId("_ty1Js_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Bi-lateral repo interest net/bulk payment at rollover/pair-off or other closing scenarios where applicable"
    )]
    BilateralRepoInternetNetting,

    /// <summary>
    /// Cash payment resulting from a Round Robin
    /// Encoded/decoded by serializers as &quot;RRBN&quot;.
    /// </summary>
    [EnumMember(Value = "RRBN")]
    [IsoId("_ty1JtvRYEeuLhpyIdtJzwg")]
    [Description(@"Cash payment resulting from a Round Robin")]
    RoundRobin,

    /// <summary>
    /// Transaction is related to a reimbursement for commercial reasons of a correctly received credit transfer.
    /// Encoded/decoded by serializers as &quot;RRCT&quot;.
    /// </summary>
    [EnumMember(Value = "RRCT")]
    [IsoId("_ty-ToPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a reimbursement for commercial reasons of a correctly received credit transfer."
    )]
    ReimbursementReceivedCreditTransfer,

    /// <summary>
    /// Transaction is related to a Request to Pay.
    /// Encoded/decoded by serializers as &quot;RRTP&quot;.
    /// </summary>
    [EnumMember(Value = "RRTP")]
    [IsoId("_ty-To_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a Request to Pay.")]
    RelatedRequestToPay,

    /// <summary>
    /// Code used to pre-advise the account servicer of a forthcoming receive against payment instruction.
    /// Encoded/decoded by serializers as &quot;RVPM&quot;.
    /// </summary>
    [EnumMember(Value = "RVPM")]
    [IsoId("_tzIEoPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Code used to pre-advise the account servicer of a forthcoming receive against payment instruction."
    )]
    ReceiveAgainstPayment,

    /// <summary>
    /// Transaction is payment of a well formatted payment slip.
    /// Encoded/decoded by serializers as &quot;SLPI&quot;.
    /// </summary>
    [EnumMember(Value = "SLPI")]
    [IsoId("_tzIEo_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment of a well formatted payment slip.")]
    PaymentSlipInstruction,

    /// <summary>
    /// Split payments. To be used when cash and security movements for a security trade settlement are instructed|separately.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_tzIEpvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Split payments. To be used when cash and security movements for a security trade settlement are instructed|separately."
    )]
    SplitPayments,

    /// <summary>
    /// Transaction is related to a payment of study/tuition costs.
    /// Encoded/decoded by serializers as &quot;STDY&quot;.
    /// </summary>
    [EnumMember(Value = "STDY")]
    [IsoId("_tzIEqfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of study/tuition costs.")]
    Study,

    /// <summary>
    /// TBA pair-off cash wire net movement
    /// Encoded/decoded by serializers as &quot;TBAN&quot;.
    /// </summary>
    [EnumMember(Value = "TBAN")]
    [IsoId("_tzROkPRYEeuLhpyIdtJzwg")]
    [Description(@"TBA pair-off cash wire net movement")]
    TBAPairOffNetting,

    /// <summary>
    /// Transaction is related to a payment of telecommunications related bill.
    /// Encoded/decoded by serializers as &quot;TBIL&quot;.
    /// </summary>
    [EnumMember(Value = "TBIL")]
    [IsoId("_tzROk_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of telecommunications related bill.")]
    TelecommunicationsBill,

    /// <summary>
    /// Transaction is related to a payment associated with charges levied by a town council.
    /// Encoded/decoded by serializers as &quot;TCSC&quot;.
    /// </summary>
    [EnumMember(Value = "TCSC")]
    [IsoId("_tzROlvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment associated with charges levied by a town council."
    )]
    TownCouncilServiceCharges,

    /// <summary>
    /// Transaction is related to a payment initiated via telephone.
    /// Encoded/decoded by serializers as &quot;TELI&quot;.
    /// </summary>
    [EnumMember(Value = "TELI")]
    [IsoId("_tzROmfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment initiated via telephone.")]
    TelephoneInitiatedTransaction,

    /// <summary>
    /// Cash payment resulting from a TMPG Claim
    /// Encoded/decoded by serializers as &quot;TMPG&quot;.
    /// </summary>
    [EnumMember(Value = "TMPG")]
    [IsoId("_tzROnPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash payment resulting from a TMPG Claim")]
    TMPGClaimPayment,

    /// <summary>
    /// Tri-Party Repo related interest
    /// Encoded/decoded by serializers as &quot;TPRI&quot;.
    /// </summary>
    [EnumMember(Value = "TPRI")]
    [IsoId("_tza_kPRYEeuLhpyIdtJzwg")]
    [Description(@"Tri-Party Repo related interest")]
    TriPartyRepoInterest,

    /// <summary>
    /// Tri-party Repo related net gain/loss cash movement
    /// Encoded/decoded by serializers as &quot;TPRP&quot;.
    /// </summary>
    [EnumMember(Value = "TPRP")]
    [IsoId("_tza_k_RYEeuLhpyIdtJzwg")]
    [Description(@"Tri-party Repo related net gain/loss cash movement")]
    TriPartyRepoNetting,

    /// <summary>
    /// Transaction is payment of a beneficiary prefilled payment slip where beneficiary to payer information is truncated.
    /// Encoded/decoded by serializers as &quot;TRNC&quot;.
    /// </summary>
    [EnumMember(Value = "TRNC")]
    [IsoId("_tzkwkPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is payment of a beneficiary prefilled payment slip where beneficiary to payer information is truncated."
    )]
    TruncatedPaymentSlip,

    /// <summary>
    /// Transaction is the payment of a travellers cheque
    /// Encoded/decoded by serializers as &quot;TRVC&quot;.
    /// </summary>
    [EnumMember(Value = "TRVC")]
    [IsoId("_tzkwk_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a travellers cheque")]
    TravellerCheque,

    /// <summary>
    /// Transaction is related to a payment initiated via internet.
    /// Encoded/decoded by serializers as &quot;WEBI&quot;.
    /// </summary>
    [EnumMember(Value = "WEBI")]
    [IsoId("_tzkwlvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment initiated via internet.")]
    InternetInitiatedTransaction,

    /// <summary>
    /// Transaction in which the amount is available to the payee immediately.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_tzkwmfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction in which the amount is available to the payee immediately.")]
    InstantPayments,

    /// <summary>
    /// Transaction in which the Return of the amount is fully returned.
    /// Encoded/decoded by serializers as &quot;IPCA&quot;.
    /// </summary>
    [EnumMember(Value = "IPCA")]
    [IsoId("_tzt6gPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction in which the Return of the amount is fully returned.")]
    InstantPaymentsCancellation,

    /// <summary>
    /// Transaction in which the amount is available to the payee immediately, done for donations, with sending the address data of the payer.
    /// Encoded/decoded by serializers as &quot;IPDO&quot;.
    /// </summary>
    [EnumMember(Value = "IPDO")]
    [IsoId("_tzt6g_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction in which the amount is available to the payee immediately, done for donations, with sending the address data of the payer."
    )]
    InstantPaymentsForDonations,

    /// <summary>
    /// Transaction in which the amount is available to the payee immediately, done in E-commerce, without sending the address data of the payer.
    /// Encoded/decoded by serializers as &quot;IPEA&quot;.
    /// </summary>
    [EnumMember(Value = "IPEA")]
    [IsoId("_tzt6hvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction in which the amount is available to the payee immediately, done in E-commerce, without sending the address data of the payer."
    )]
    InstantPaymentsInECommerceWithoutAddressData,

    /// <summary>
    /// Transaction in which the amount is available to the payee immediately, done in E-commerce, with sending the address data of the payer.
    /// Encoded/decoded by serializers as &quot;IPEC&quot;.
    /// </summary>
    [EnumMember(Value = "IPEC")]
    [IsoId("_tzt6ifRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction in which the amount is available to the payee immediately, done in E-commerce, with sending the address data of the payer."
    )]
    InstantPaymentsInECommerceWithAddressData,

    /// <summary>
    /// Transaction in which the amount is available to the payee immediately, done in E-commerce.
    /// Encoded/decoded by serializers as &quot;IPEW&quot;.
    /// </summary>
    [EnumMember(Value = "IPEW")]
    [IsoId("_tzt6jPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction in which the amount is available to the payee immediately, done in E-commerce."
    )]
    InstantPaymentsInECommerce,

    /// <summary>
    /// Transaction in which the amount is available to the payee immediately, done at POS.
    /// Encoded/decoded by serializers as &quot;IPPS&quot;.
    /// </summary>
    [EnumMember(Value = "IPPS")]
    [IsoId("_tz3rgPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction in which the amount is available to the payee immediately, done at POS."
    )]
    InstantPaymentsAtPOS,

    /// <summary>
    /// Transaction in which the Return of the amount is fully or partial returned.
    /// Encoded/decoded by serializers as &quot;IPRT&quot;.
    /// </summary>
    [EnumMember(Value = "IPRT")]
    [IsoId("_tz3rg_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction in which the Return of the amount is fully or partial returned.")]
    InstantPaymentsReturn,

    /// <summary>
    /// Transaction is made via an unattending vending machine by using 2-factor-authentification.
    /// Encoded/decoded by serializers as &quot;IPU2&quot;.
    /// </summary>
    [EnumMember(Value = "IPU2")]
    [IsoId("_tz3rhvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is made via an unattending vending machine by using 2-factor-authentification."
    )]
    InstantPaymentsUnattendedVendingMachineWith2FA,

    /// <summary>
    /// Transaction is made via an unattending vending machine by without using 2-factor-authentification.
    /// Encoded/decoded by serializers as &quot;IPUW&quot;.
    /// </summary>
    [EnumMember(Value = "IPUW")]
    [IsoId("_tz3rifRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is made via an unattending vending machine by without using 2-factor-authentification."
    )]
    InstantPaymentsUnattendedVendingMachineWithout2FA,

    /// <summary>
    /// Transaction settles annuity related to credit, insurance, investments, other.n
    /// Encoded/decoded by serializers as &quot;ANNI&quot;.
    /// </summary>
    [EnumMember(Value = "ANNI")]
    [IsoId("_tz3rjPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction settles annuity related to credit, insurance, investments, other.n")]
    Annuity,

    /// <summary>
    /// Transaction is the payment of custodian account management fee where custodian bank and current account servicing bank coincide
    /// Encoded/decoded by serializers as &quot;CAFI&quot;.
    /// </summary>
    [EnumMember(Value = "CAFI")]
    [IsoId("_t0BcgPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is the payment of custodian account management fee where custodian bank and current account servicing bank coincide"
    )]
    CustodianManagementFeeInhouse,

    /// <summary>
    /// Transaction is the payment of capital falling due where custodian bank and current account servicing bank coincide
    /// Encoded/decoded by serializers as &quot;CFDI&quot;.
    /// </summary>
    [EnumMember(Value = "CFDI")]
    [IsoId("_t0Bcg_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is the payment of capital falling due where custodian bank and current account servicing bank coincide"
    )]
    CapitalFallingDueInhouse,

    /// <summary>
    /// Transaction is payment of commodities.
    /// Encoded/decoded by serializers as &quot;CMDT&quot;.
    /// </summary>
    [EnumMember(Value = "CMDT")]
    [IsoId("_t0KmcPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment of commodities.")]
    CommodityTransfer,

    /// <summary>
    /// Transaction is related to a derivatives transaction
    /// Encoded/decoded by serializers as &quot;DERI&quot;.
    /// </summary>
    [EnumMember(Value = "DERI")]
    [IsoId("_t0Kmc_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a derivatives transaction")]
    Derivatives,

    /// <summary>
    /// Transaction is payment of dividends.
    /// Encoded/decoded by serializers as &quot;DIVD&quot;.
    /// </summary>
    [EnumMember(Value = "DIVD")]
    [IsoId("_t0KmdvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment of dividends.")]
    Dividend,

    /// <summary>
    /// Transaction is related to a foreign exchange operation.
    /// Encoded/decoded by serializers as &quot;FREX&quot;.
    /// </summary>
    [EnumMember(Value = "FREX")]
    [IsoId("_t0KmefRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a foreign exchange operation.")]
    ForeignExchange,

    /// <summary>
    /// Transaction is related to a hedging operation.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_t0UXcPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a hedging operation.")]
    Hedging,

    /// <summary>
    /// Transaction is for the payment of mutual funds, investment products and shares
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_t0UXc_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is for the payment of mutual funds, investment products and shares")]
    InvestmentAndSecurities,

    /// <summary>
    /// Transaction is related to a precious metal operation.
    /// Encoded/decoded by serializers as &quot;PRME&quot;.
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_t0dhYPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a precious metal operation.")]
    PreciousMetal,

    /// <summary>
    /// Transfer to savings/retirement account.
    /// Encoded/decoded by serializers as &quot;SAVG&quot;.
    /// </summary>
    [EnumMember(Value = "SAVG")]
    [IsoId("_t0dhY_RYEeuLhpyIdtJzwg")]
    [Description(@"Transfer to savings/retirement account.")]
    Savings,

    /// <summary>
    /// Transaction is the payment of securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_t0dhZvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of securities.")]
    Securities,

    /// <summary>
    /// Transaction is the payment of a purchase of securities where custodian bank and current account servicing bank coincide
    /// Encoded/decoded by serializers as &quot;SEPI&quot;.
    /// </summary>
    [EnumMember(Value = "SEPI")]
    [IsoId("_t0nSYPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is the payment of a purchase of securities where custodian bank and current account servicing bank coincide"
    )]
    SecuritiesPurchaseInhouse,

    /// <summary>
    /// Transaction is related to treasury operations.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_t0nSY_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to treasury operations.")]
    TreasuryPayment,

    /// <summary>
    /// Transaction is purchase of Unit Trust
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_t0nSZvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is purchase of Unit Trust")]
    UnitTrustPurchase,

    /// <summary>
    /// Cash associated with a netting of futures payments. Refer to CCPM codeword for netting of initial and variation margin through a CCP
    /// Encoded/decoded by serializers as &quot;FNET&quot;.
    /// </summary>
    [EnumMember(Value = "FNET")]
    [IsoId("_t0nSafRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash associated with a netting of futures payments. Refer to CCPM codeword for netting of initial and variation margin through a CCP"
    )]
    FuturesNettingPayment,

    /// <summary>
    /// Cash related to futures trading activity.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_t0xDYPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash related to futures trading activity.")]
    Futures,

    /// <summary>
    /// Transaction is a payment for anesthesia services.
    /// Encoded/decoded by serializers as &quot;ANTS&quot;.
    /// </summary>
    [EnumMember(Value = "ANTS")]
    [IsoId("_t0xDY_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for anesthesia services.")]
    AnesthesiaServices,

    /// <summary>
    /// Transaction is a payment for convalescence care facility services.
    /// Encoded/decoded by serializers as &quot;CVCF&quot;.
    /// </summary>
    [EnumMember(Value = "CVCF")]
    [IsoId("_t0xDZvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for convalescence care facility services.")]
    ConvalescentCareFacility,

    /// <summary>
    /// Transaction is a payment is for use of durable medical equipment.
    /// Encoded/decoded by serializers as &quot;DMEQ&quot;.
    /// </summary>
    [EnumMember(Value = "DMEQ")]
    [IsoId("_t0xDafRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment is for use of durable medical equipment.")]
    DurableMedicaleEquipment,

    /// <summary>
    /// Transaction is a payment for dental services.
    /// Encoded/decoded by serializers as &quot;DNTS&quot;.
    /// </summary>
    [EnumMember(Value = "DNTS")]
    [IsoId("_t0xDbPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for dental services.")]
    DentalServices,

    /// <summary>
    /// Transaction is a payment for home health care services.
    /// Encoded/decoded by serializers as &quot;HLTC&quot;.
    /// </summary>
    [EnumMember(Value = "HLTC")]
    [IsoId("_t06NUPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for home health care services.")]
    HomeHealthCare,

    /// <summary>
    /// Transaction is a payment of health insurance.
    /// Encoded/decoded by serializers as &quot;HLTI&quot;.
    /// </summary>
    [EnumMember(Value = "HLTI")]
    [IsoId("_t06NU_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment of health insurance.")]
    HealthInsurance,

    /// <summary>
    /// Transaction is a payment for hospital care services.
    /// Encoded/decoded by serializers as &quot;HSPC&quot;.
    /// </summary>
    [EnumMember(Value = "HSPC")]
    [IsoId("_t06NVvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for hospital care services.")]
    HospitalCare,

    /// <summary>
    /// Transaction is a payment for intermediate care facility services.
    /// Encoded/decoded by serializers as &quot;ICRF&quot;.
    /// </summary>
    [EnumMember(Value = "ICRF")]
    [IsoId("_t1D-UPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for intermediate care facility services.")]
    IntermediateCareFacility,

    /// <summary>
    /// Transaction is a payment for long-term care facility services.
    /// Encoded/decoded by serializers as &quot;LTCF&quot;.
    /// </summary>
    [EnumMember(Value = "LTCF")]
    [IsoId("_t1D-U_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for long-term care facility services.")]
    LongTermCareFacility,

    /// <summary>
    /// Transaction is contribution to medical aid fund.
    /// Encoded/decoded by serializers as &quot;MAFC&quot;.
    /// </summary>
    [EnumMember(Value = "MAFC")]
    [IsoId("_t1NvUPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is contribution to medical aid fund.")]
    MedicalAidFundContribution,

    /// <summary>
    /// Transaction is related to a medical aid refund.
    /// Encoded/decoded by serializers as &quot;MARF&quot;.
    /// </summary>
    [EnumMember(Value = "MARF")]
    [IsoId("_t1NvU_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a medical aid refund.")]
    MedicalAidRefund,

    /// <summary>
    /// Transaction is a payment for medical care services.
    /// Encoded/decoded by serializers as &quot;MDCS&quot;.
    /// </summary>
    [EnumMember(Value = "MDCS")]
    [IsoId("_t1NvVvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for medical care services.")]
    MedicalServices,

    /// <summary>
    /// Transaction is a payment for vision care services.
    /// Encoded/decoded by serializers as &quot;VIEW&quot;.
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_t1W5QPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for vision care services.")]
    VisionCare,

    /// <summary>
    /// Payment related to a credit default event
    /// Encoded/decoded by serializers as &quot;CDEP&quot;.
    /// </summary>
    [EnumMember(Value = "CDEP")]
    [IsoId("_t1W5Q_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment related to a credit default event")]
    CreditDefaultEventPayment,

    /// <summary>
    /// Final payments for a swap contract
    /// Encoded/decoded by serializers as &quot;SWFP&quot;.
    /// </summary>
    [EnumMember(Value = "SWFP")]
    [IsoId("_t1W5RvRYEeuLhpyIdtJzwg")]
    [Description(@"Final payments for a swap contract")]
    SwapContractFinalPayment,

    /// <summary>
    /// Partial payment for a swap contract
    /// Encoded/decoded by serializers as &quot;SWPP&quot;.
    /// </summary>
    [EnumMember(Value = "SWPP")]
    [IsoId("_t1W5SfRYEeuLhpyIdtJzwg")]
    [Description(@"Partial payment for a swap contract")]
    SwapContractPartialPayment,

    /// <summary>
    /// Reset payment for a swap contract
    /// Encoded/decoded by serializers as &quot;SWRS&quot;.
    /// </summary>
    [EnumMember(Value = "SWRS")]
    [IsoId("_t1W5TPRYEeuLhpyIdtJzwg")]
    [Description(@"Reset payment for a swap contract")]
    SwapContractResetPayment,

    /// <summary>
    /// Upfront payment for a swap contract
    /// Encoded/decoded by serializers as &quot;SWUF&quot;.
    /// </summary>
    [EnumMember(Value = "SWUF")]
    [IsoId("_t1gqQPRYEeuLhpyIdtJzwg")]
    [Description(@"Upfront payment for a swap contract")]
    SwapContractUpfrontPayment,

    /// <summary>
    /// Payments for donation, sponsorship, advisory, intellectual and other copyright services.
    /// Encoded/decoded by serializers as &quot;ADCS&quot;.
    /// </summary>
    [EnumMember(Value = "ADCS")]
    [IsoId("_t1gqQ_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Payments for donation, sponsorship, advisory, intellectual and other copyright services."
    )]
    AdvisoryDonationCopyrightServices,

    /// <summary>
    /// Payment concerning active employment policy.
    /// Encoded/decoded by serializers as &quot;AEMP&quot;.
    /// </summary>
    [EnumMember(Value = "AEMP")]
    [IsoId("_t1gqRvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment concerning active employment policy.")]
    ActiveEmploymentPolicy,

    /// <summary>
    /// Transaction is the payment of allowances.
    /// Encoded/decoded by serializers as &quot;ALLW&quot;.
    /// </summary>
    [EnumMember(Value = "ALLW")]
    [IsoId("_t1gqSfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of allowances.")]
    Allowance,

    /// <summary>
    /// Transaction is the payment of alimony.
    /// Encoded/decoded by serializers as &quot;ALMY&quot;.
    /// </summary>
    [EnumMember(Value = "ALMY")]
    [IsoId("_t1p0MPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of alimony.")]
    AlimonyPayment,

    /// <summary>
    /// Transaction is related to a payment made as incentive to encourage parents to have more children
    /// Encoded/decoded by serializers as &quot;BBSC&quot;.
    /// </summary>
    [EnumMember(Value = "BBSC")]
    [IsoId("_t1p0M_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment made as incentive to encourage parents to have more children"
    )]
    BabyBonusScheme,

    /// <summary>
    /// Transaction is related to a payment made to assist parent/guardian to maintain child.
    /// Encoded/decoded by serializers as &quot;BECH&quot;.
    /// </summary>
    [EnumMember(Value = "BECH")]
    [IsoId("_t1p0NvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a payment made to assist parent/guardian to maintain child."
    )]
    ChildBenefit,

    /// <summary>
    /// Transaction is related to a payment to a person who is unemployed/disabled.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_t1p0OfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment to a person who is unemployed/disabled.")]
    UnemploymentDisabilityBenefit,

    /// <summary>
    /// Transaction is related to payment of a bonus.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_t1zlMPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payment of a bonus.")]
    BonusPayment,

    /// <summary>
    /// Payments made by Government institute related to cash compensation, helplessness, disability. These payments are made by the Government institution as a social benefit in addition to regularly paid salary or pension.
    /// Encoded/decoded by serializers as &quot;CCHD&quot;.
    /// </summary>
    [EnumMember(Value = "CCHD")]
    [IsoId("_t1zlM_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Payments made by Government institute related to cash compensation, helplessness, disability. These payments are made by the Government institution as a social benefit in addition to regularly paid salary or pension."
    )]
    CashCompensationHelplessnessDisability,

    /// <summary>
    /// Transaction is payment of commission.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_t1zlNvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment of commission.")]
    Commission,

    /// <summary>
    /// Transaction is a payment by a company to a bank for financing social loans to employees.
    /// Encoded/decoded by serializers as &quot;CSLP&quot;.
    /// </summary>
    [EnumMember(Value = "CSLP")]
    [IsoId("_t1zlOfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is a payment by a company to a bank for financing social loans to employees."
    )]
    CompanySocialLoanPaymentToBank,

    /// <summary>
    /// Compensation to unemployed persons during insolvency procedures.
    /// Encoded/decoded by serializers as &quot;GFRP&quot;.
    /// </summary>
    [EnumMember(Value = "GFRP")]
    [IsoId("_t19WMPRYEeuLhpyIdtJzwg")]
    [Description(@"Compensation to unemployed persons during insolvency procedures.")]
    GuaranteeFundRightsPayment,

    /// <summary>
    /// Transaction is payment to category A Austrian government employees.
    /// Encoded/decoded by serializers as &quot;GVEA&quot;.
    /// </summary>
    [EnumMember(Value = "GVEA")]
    [IsoId("_t19WM_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment to category A Austrian government employees.")]
    AustrianGovernmentEmployeesCategoryA,

    /// <summary>
    /// Transaction is payment to category B Austrian government employees.
    /// Encoded/decoded by serializers as &quot;GVEB&quot;.
    /// </summary>
    [EnumMember(Value = "GVEB")]
    [IsoId("_t19WNvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment to category B Austrian government employees.")]
    AustrianGovernmentEmployeesCategoryB,

    /// <summary>
    /// Transaction is payment to category C Austrian government employees.
    /// Encoded/decoded by serializers as &quot;GVEC&quot;.
    /// </summary>
    [EnumMember(Value = "GVEC")]
    [IsoId("_t19WOfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment to category C Austrian government employees.")]
    AustrianGovernmentEmployeesCategoryC,

    /// <summary>
    /// Transaction is payment to category D Austrian government employees.
    /// Encoded/decoded by serializers as &quot;GVED&quot;.
    /// </summary>
    [EnumMember(Value = "GVED")]
    [IsoId("_t2GgIPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is payment to category D Austrian government employees.")]
    AustrianGovernmentEmployeesCategoryD,

    /// <summary>
    /// Payment to victims of war violence and to disabled soldiers.
    /// Encoded/decoded by serializers as &quot;GWLT&quot;.
    /// </summary>
    [EnumMember(Value = "GWLT")]
    [IsoId("_t2GgI_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment to victims of war violence and to disabled soldiers.")]
    GovermentWarLegislationTransfer,

    /// <summary>
    /// Transaction is a contribution by an employer to the housing expenditures (purchase, construction, renovation) of the employees within a tax free fringe benefit system
    /// Encoded/decoded by serializers as &quot;HREC&quot;.
    /// </summary>
    [EnumMember(Value = "HREC")]
    [IsoId("_t2GgJvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is a contribution by an employer to the housing expenditures (purchase, construction, renovation) of the employees within a tax free fringe benefit system "
    )]
    HousingRelatedContribution,

    /// <summary>
    /// Transaction is related to the payment of payroll.
    /// Encoded/decoded by serializers as &quot;PAYR&quot;.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_t2GgKfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the payment of payroll.")]
    Payroll,

    /// <summary>
    /// Transaction is contribution to pension fund.
    /// Encoded/decoded by serializers as &quot;PEFC&quot;.
    /// </summary>
    [EnumMember(Value = "PEFC")]
    [IsoId("_t2GgLPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is contribution to pension fund.")]
    PensionFundContribution,

    /// <summary>
    /// Transaction is the payment of pension.
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_t2QRIPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of pension.")]
    PensionPayment,

    /// <summary>
    /// Transaction is related to a payment of a price.
    /// Encoded/decoded by serializers as &quot;PRCP&quot;.
    /// </summary>
    [EnumMember(Value = "PRCP")]
    [IsoId("_t2QRI_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of a price.")]
    PricePayment,

    /// <summary>
    /// Benefit for the duration of occupational rehabilitation.
    /// Encoded/decoded by serializers as &quot;RHBS&quot;.
    /// </summary>
    [EnumMember(Value = "RHBS")]
    [IsoId("_t2ZbEPRYEeuLhpyIdtJzwg")]
    [Description(@"Benefit for the duration of occupational rehabilitation.")]
    RehabilitationSupport,

    /// <summary>
    /// Transaction is the payment of salaries.
    /// Encoded/decoded by serializers as &quot;SALA&quot;.
    /// </summary>
    [EnumMember(Value = "SALA")]
    [IsoId("_t2ZbE_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of salaries.")]
    SalaryPayment,

    /// <summary>
    /// Salary or pension payment for more months in one amount or a delayed payment of salaries or pensions.
    /// Encoded/decoded by serializers as &quot;SPSP&quot;.
    /// </summary>
    [EnumMember(Value = "SPSP")]
    [IsoId("_t2jMEPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Salary or pension payment for more months in one amount or a delayed payment of salaries or pensions."
    )]
    SalaryPensionSumPayment,

    /// <summary>
    /// Transaction is a social security benefit, ie payment made by a government to support individuals.
    /// Encoded/decoded by serializers as &quot;SSBE&quot;.
    /// </summary>
    [EnumMember(Value = "SSBE")]
    [IsoId("_t2jME_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is a social security benefit, ie payment made by a government to support individuals."
    )]
    SocialSecurityBenefit,

    /// <summary>
    /// Net payment related to a buy-in. When an investment manager is bought in on a sell trade that fails due to a failed securities lending recall, the IM may seize the underlying collateral to pay for the buy-in. Any difference between the value of the collateral and the sell proceeds would be paid or received under this code
    /// Encoded/decoded by serializers as &quot;LBIN&quot;.
    /// </summary>
    [EnumMember(Value = "LBIN")]
    [IsoId("_t2jMFvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Net payment related to a buy-in. When an investment manager is bought in on a sell trade that fails due to a failed securities lending recall, the IM may seize the underlying collateral to pay for the buy-in. Any difference between the value of the collateral and the sell proceeds would be paid or received under this code"
    )]
    LendingBuyInNetting,

    /// <summary>
    /// Free movement of cash collateral. Cash collateral paid by the borrower is done separately from the delivery of the shares at loan opening or return of collateral done separately from return of the loaned security. Note: common when the currency of the security is different the currency of the cash collateral.
    /// Encoded/decoded by serializers as &quot;LCOL&quot;.
    /// </summary>
    [EnumMember(Value = "LCOL")]
    [IsoId("_t2s9EPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Free movement of cash collateral. Cash collateral paid by the borrower is done separately from the delivery of the shares at loan opening or return of collateral done separately from return of the loaned security. Note: common when the currency of the security is different the currency of the cash collateral."
    )]
    LendingCashCollateralFreeMovement,

    /// <summary>
    /// Fee payments, other than rebates, for securities lending. Includes (a) exclusive fees; (b) transaction fees; (c)|custodian fees; (d) minimum balance fees
    /// Encoded/decoded by serializers as &quot;LFEE&quot;.
    /// </summary>
    [EnumMember(Value = "LFEE")]
    [IsoId("_t2s9E_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Fee payments, other than rebates, for securities lending. Includes (a) exclusive fees; (b) transaction fees; (c)|custodian fees; (d) minimum balance fees"
    )]
    LendingFees,

    /// <summary>
    /// Cash collateral payments resulting from the marked-to-market of a portfolio of loaned equity securities
    /// Encoded/decoded by serializers as &quot;LMEQ&quot;.
    /// </summary>
    [EnumMember(Value = "LMEQ")]
    [IsoId("_t2s9FvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payments resulting from the marked-to-market of a portfolio of loaned equity securities"
    )]
    LendingEquityMarkedToMarketCashCollateral,

    /// <summary>
    /// Cash collateral payments resulting from the marked-to-market of a portfolio of loaned fixed income securities
    /// Encoded/decoded by serializers as &quot;LMFI&quot;.
    /// </summary>
    [EnumMember(Value = "LMFI")]
    [IsoId("_t2s9GfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payments resulting from the marked-to-market of a portfolio of loaned fixed income securities"
    )]
    LendingFixedIncomeMarkedToMarketCashCollateral,

    /// <summary>
    /// Cash collateral payments resulting from the marked-to-market of a portfolio of loaned securities where the instrument|types are not specified
    /// Encoded/decoded by serializers as &quot;LMRK&quot;.
    /// </summary>
    [EnumMember(Value = "LMRK")]
    [IsoId("_t2s9HPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cash collateral payments resulting from the marked-to-market of a portfolio of loaned securities where the instrument|types are not specified"
    )]
    LendingUnspecifiedTypeOfMarkedToMarketCashCollateral,

    /// <summary>
    /// Securities lending rebate payments
    /// Encoded/decoded by serializers as &quot;LREB&quot;.
    /// </summary>
    [EnumMember(Value = "LREB")]
    [IsoId("_t22HAPRYEeuLhpyIdtJzwg")]
    [Description(@"Securities lending rebate payments")]
    LendingRebatePayments,

    /// <summary>
    /// Revenue payments made by the lending agent to the client
    /// Encoded/decoded by serializers as &quot;LREV&quot;.
    /// </summary>
    [EnumMember(Value = "LREV")]
    [IsoId("_t22HA_RYEeuLhpyIdtJzwg")]
    [Description(@"Revenue payments made by the lending agent to the client")]
    LendingRevenuePayments,

    /// <summary>
    /// Payments made by a borrower to a lending agent to satisfy claims made by the investment manager related to sell fails from late loan recall deliveries
    /// Encoded/decoded by serializers as &quot;LSFL&quot;.
    /// </summary>
    [EnumMember(Value = "LSFL")]
    [IsoId("_t22HBvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payments made by a borrower to a lending agent to satisfy claims made by the investment manager related to sell fails from late loan recall deliveries"
    )]
    LendingClaimPayment,

    /// <summary>
    /// Transaction is related to a payment of estate tax.
    /// Encoded/decoded by serializers as &quot;ESTX&quot;.
    /// </summary>
    [EnumMember(Value = "ESTX")]
    [IsoId("_t22HCfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of estate tax.")]
    EstateTax,

    /// <summary>
    /// Transaction is related to a payment of Foreign Worker Levy
    /// Encoded/decoded by serializers as &quot;FWLV&quot;.
    /// </summary>
    [EnumMember(Value = "FWLV")]
    [IsoId("_t2_4APRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of Foreign Worker Levy")]
    ForeignWorkerLevy,

    /// <summary>
    /// Transaction is the payment of Goods &amp; Services Tax
    /// Encoded/decoded by serializers as &quot;GSTX&quot;.
    /// </summary>
    [EnumMember(Value = "GSTX")]
    [IsoId("_t2_4A_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of Goods & Services Tax")]
    GoodsServicesTax,

    /// <summary>
    /// Transaction is related to a payment of housing tax.
    /// Encoded/decoded by serializers as &quot;HSTX&quot;.
    /// </summary>
    [EnumMember(Value = "HSTX")]
    [IsoId("_t2_4BvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of housing tax.")]
    HousingTax,

    /// <summary>
    /// Transaction is related to a payment of income tax.
    /// Encoded/decoded by serializers as &quot;INTX&quot;.
    /// </summary>
    [EnumMember(Value = "INTX")]
    [IsoId("_t2_4CfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of income tax.")]
    IncomeTax,

    /// <summary>
    /// Transaction is related to a payment of net income tax.
    /// Encoded/decoded by serializers as &quot;NITX&quot;.
    /// </summary>
    [EnumMember(Value = "NITX")]
    [IsoId("_t2_4DPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of net income tax.")]
    NetIncomeTax,

    /// <summary>
    /// Transaction is related to a payment of property tax.
    /// Encoded/decoded by serializers as &quot;PTXP&quot;.
    /// </summary>
    [EnumMember(Value = "PTXP")]
    [IsoId("_t3JB8PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of property tax.")]
    PropertyTax,

    /// <summary>
    /// Transaction is related to a payment of road tax.
    /// Encoded/decoded by serializers as &quot;RDTX&quot;.
    /// </summary>
    [EnumMember(Value = "RDTX")]
    [IsoId("_t3JB8_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of road tax.")]
    RoadTax,

    /// <summary>
    /// Transaction is the payment of taxes.
    /// Encoded/decoded by serializers as &quot;TAXS&quot;.
    /// </summary>
    [EnumMember(Value = "TAXS")]
    [IsoId("_t3Sy8PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of taxes.")]
    TaxPayment,

    /// <summary>
    /// Transaction is the payment of value added tax.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_t3Sy8_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of value added tax.")]
    ValueAddedTaxPayment,

    /// <summary>
    /// Transaction is related to a payment of withholding tax.
    /// Encoded/decoded by serializers as &quot;WHLD&quot;.
    /// </summary>
    [EnumMember(Value = "WHLD")]
    [IsoId("_t3Sy9vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of withholding tax.")]
    WithHolding,

    /// <summary>
    /// Transaction is the refund of a tax payment or obligation.
    /// Encoded/decoded by serializers as &quot;TAXR&quot;.
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_t3Sy-fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the refund of a tax payment or obligation.")]
    TaxRefund,

    /// <summary>
    /// US mutual fund trailer fee (12b-1) payment
    /// Encoded/decoded by serializers as &quot;B112&quot;.
    /// </summary>
    [EnumMember(Value = "B112")]
    [IsoId("_t3Sy_PRYEeuLhpyIdtJzwg")]
    [Description(@"US mutual fund trailer fee (12b-1) payment")]
    TrailerFeePayment,

    /// <summary>
    /// US mutual fund trailer fee (12b-1) rebate payment
    /// Encoded/decoded by serializers as &quot;BR12&quot;.
    /// </summary>
    [EnumMember(Value = "BR12")]
    [IsoId("_t3cj8PRYEeuLhpyIdtJzwg")]
    [Description(@"US mutual fund trailer fee (12b-1) rebate payment")]
    TrailerFeeRebate,

    /// <summary>
    /// Any non-US mutual fund trailer fee (retrocession) payment (use ISIN to determine onshore versus offshore designation)
    /// Encoded/decoded by serializers as &quot;TLRF&quot;.
    /// </summary>
    [EnumMember(Value = "TLRF")]
    [IsoId("_t3cj8_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Any non-US mutual fund trailer fee (retrocession) payment (use ISIN to determine onshore versus offshore designation)"
    )]
    NonUSMutualFundTrailerFeePayment,

    /// <summary>
    /// Any non-US mutual fund trailer fee (retrocession) rebate payment (use ISIN to determine onshore versus offshore designation)
    /// Encoded/decoded by serializers as &quot;TLRR&quot;.
    /// </summary>
    [EnumMember(Value = "TLRR")]
    [IsoId("_t3cj9vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Any non-US mutual fund trailer fee (retrocession) rebate payment (use ISIN to determine onshore versus offshore designation)"
    )]
    NonUSMutualFundTrailerFeeRebatePayment,

    /// <summary>
    /// Transaction is a payment for air transport related business.
    /// Encoded/decoded by serializers as &quot;AIRB&quot;.
    /// </summary>
    [EnumMember(Value = "AIRB")]
    [IsoId("_t3cj-fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for air transport related business.")]
    Air,

    /// <summary>
    /// Transaction is a payment for bus transport related business.
    /// Encoded/decoded by serializers as &quot;BUSB&quot;.
    /// </summary>
    [EnumMember(Value = "BUSB")]
    [IsoId("_t3lt4PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for bus transport related business.")]
    Bus,

    /// <summary>
    /// Transaction is a payment for ferry related business.
    /// Encoded/decoded by serializers as &quot;FERB&quot;.
    /// </summary>
    [EnumMember(Value = "FERB")]
    [IsoId("_t3lt4_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for ferry related business.")]
    Ferry,

    /// <summary>
    /// Transaction is a payment for railway transport related business.
    /// Encoded/decoded by serializers as &quot;RLWY&quot;.
    /// </summary>
    [EnumMember(Value = "RLWY")]
    [IsoId("_t3ve4PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment for railway transport related business.")]
    Railway,

    /// <summary>
    /// Transaction is for the payment to top-up pre-paid card and electronic road pricing for the purpose of transportation
    /// Encoded/decoded by serializers as &quot;TRPT&quot;.
    /// </summary>
    [EnumMember(Value = "TRPT")]
    [IsoId("_t3ve4_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is for the payment to top-up pre-paid card and electronic road pricing for the purpose of transportation"
    )]
    RoadPricing,

    /// <summary>
    /// Transaction is related to a payment of cable TV bill.
    /// Encoded/decoded by serializers as &quot;CBTV&quot;.
    /// </summary>
    [EnumMember(Value = "CBTV")]
    [IsoId("_t3ve5vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of cable TV bill.")]
    CableTVBill,

    /// <summary>
    /// Transaction is related to a payment of electricity bill.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_t35P4PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of electricity bill.")]
    ElectricityBill,

    /// <summary>
    /// Transaction is related to a utility operation.
    /// Encoded/decoded by serializers as &quot;ENRG&quot;.
    /// </summary>
    [EnumMember(Value = "ENRG")]
    [IsoId("_t35P4_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a utility operation.")]
    Energies,

    /// <summary>
    /// Transaction is related to a payment of gas bill.
    /// Encoded/decoded by serializers as &quot;GASB&quot;.
    /// </summary>
    [EnumMember(Value = "GASB")]
    [IsoId("_t35P5vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of gas bill.")]
    GasBill,

    /// <summary>
    /// Transaction is related to a payment of network charges.
    /// Encoded/decoded by serializers as &quot;NWCH&quot;.
    /// </summary>
    [EnumMember(Value = "NWCH")]
    [IsoId("_t4DA4PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of network charges.")]
    NetworkCharge,

    /// <summary>
    /// Transaction is related to a payment of network communication.
    /// Encoded/decoded by serializers as &quot;NWCM&quot;.
    /// </summary>
    [EnumMember(Value = "NWCM")]
    [IsoId("_t4MK0PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of network communication.")]
    NetworkCommunication,

    /// <summary>
    /// Transaction is related to a payment of other telecom related bill.
    /// Encoded/decoded by serializers as &quot;OTLC&quot;.
    /// </summary>
    [EnumMember(Value = "OTLC")]
    [IsoId("_t4V70PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of other telecom related bill.")]
    OtherTelecomRelatedBill,

    /// <summary>
    /// Transaction is related to a payment of telephone bill.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_t4V70_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of telephone bill.")]
    TelephoneBill,

    /// <summary>
    /// Transaction is for the payment to common utility provider that provide gas, water and/or electricity.
    /// Encoded/decoded by serializers as &quot;UBIL&quot;.
    /// </summary>
    [EnumMember(Value = "UBIL")]
    [IsoId("_t4fFwPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is for the payment to common utility provider that provide gas, water and/or electricity."
    )]
    Utilities,

    /// <summary>
    /// Transaction is related to a payment of water bill.
    /// Encoded/decoded by serializers as &quot;WTER&quot;.
    /// </summary>
    [EnumMember(Value = "WTER")]
    [IsoId("_t4fFw_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of water bill.")]
    WaterBill,

    /// <summary>
    /// Card Settlement-Settlement of Debit Card transactions.
    /// Encoded/decoded by serializers as &quot;DBCR&quot;.
    /// </summary>
    [EnumMember(Value = "DBCR")]
    [IsoId("_8qNGwAQ0Eey95qpfbNuEwg")]
    [Description(@"Card Settlement-Settlement of Debit Card transactions.")]
    DebitCard,

    /// <summary>
    /// Card Settlement-Settlement of Credit Card transactions.
    /// Encoded/decoded by serializers as &quot;CBCR&quot;.
    /// </summary>
    [EnumMember(Value = "CBCR")]
    [IsoId("_PJgToAQ1Eey95qpfbNuEwg")]
    [Description(@"Card Settlement-Settlement of Credit Card transactions.")]
    CreditCard,

    /// <summary>
    /// Utilities-Settlement of Low value Credit transactions.
    /// Encoded/decoded by serializers as &quot;EFTC&quot;.
    /// </summary>
    [EnumMember(Value = "EFTC")]
    [IsoId("_YcDdEAQ1Eey95qpfbNuEwg")]
    [Description(@"Utilities-Settlement of Low value Credit transactions.")]
    LowValueCredit,

    /// <summary>
    /// Utilities-Settlement of Low value Debit transactions.
    /// Encoded/decoded by serializers as &quot;EFTD&quot;.
    /// </summary>
    [EnumMember(Value = "EFTD")]
    [IsoId("_0-810AQ1Eey95qpfbNuEwg")]
    [Description(@"Utilities-Settlement of Low value Debit transactions.")]
    LowValueDebit,

    /// <summary>
    /// Securities Lending-Settlement of Bond transaction.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_9MNLIAQ1Eey95qpfbNuEwg")]
    [Description(@"Securities Lending-Settlement of Bond transaction.")]
    Bonds,

    /// <summary>
    /// Securities Lending-Settlement of Equities transactions.
    /// Encoded/decoded by serializers as &quot;EQTS&quot;.
    /// </summary>
    [EnumMember(Value = "EQTS")]
    [IsoId("_IXW_gAQ3Eey95qpfbNuEwg")]
    [Description(@"Securities Lending-Settlement of Equities transactions.")]
    Equities,

    /// <summary>
    /// Securities Lending-Settlement of Corporate Actions: Bonds transactions.
    /// Encoded/decoded by serializers as &quot;CABD&quot;.
    /// </summary>
    [EnumMember(Value = "CABD")]
    [IsoId("_fg1cgAQ3Eey95qpfbNuEwg")]
    [Description(@"Securities Lending-Settlement of Corporate Actions: Bonds transactions.")]
    CorporateActions_Bonds,

    /// <summary>
    /// Securities Lending-Settlement of Corporate Actions: Equities transactions.
    /// Encoded/decoded by serializers as &quot;CAEQ&quot;.
    /// </summary>
    [EnumMember(Value = "CAEQ")]
    [IsoId("_6l168AQ3Eey95qpfbNuEwg")]
    [Description(@"Securities Lending-Settlement of Corporate Actions: Equities transactions.")]
    CorporateActions_Equities,

    /// <summary>
    /// Instant Payments-Settlement of Rapid Payment Instruction (RPI) transactions.
    /// Encoded/decoded by serializers as &quot;RAPI&quot;.
    /// </summary>
    [EnumMember(Value = "RAPI")]
    [IsoId("_C6QoMAQ4Eey95qpfbNuEwg")]
    [Description(@"Instant Payments-Settlement of Rapid Payment Instruction (RPI) transactions.")]
    RapidPaymentInstruction,

    /// <summary>
    /// Card Settlement-Settlement of ATM transactions.
    /// Encoded/decoded by serializers as &quot;SASW&quot;.
    /// </summary>
    [EnumMember(Value = "SASW")]
    [IsoId("_YBMlsAQ4Eey95qpfbNuEwg")]
    [Description(@"Card Settlement-Settlement of ATM transactions.")]
    ATM,

    /// <summary>
    /// Utilities-Settlement of Authenticated Collections transactions.
    /// Encoded/decoded by serializers as &quot;AUCO&quot;.
    /// </summary>
    [EnumMember(Value = "AUCO")]
    [IsoId("_f--UkAQ4Eey95qpfbNuEwg")]
    [Description(@"Utilities-Settlement of Authenticated Collections transactions.")]
    AuthenticatedCollections,

    /// <summary>
    /// Card Settlement-Settlement of AMEX transactions.
    /// Encoded/decoded by serializers as &quot;AMEX&quot;.
    /// </summary>
    [EnumMember(Value = "AMEX")]
    [IsoId("_oV6xYAQ4Eey95qpfbNuEwg")]
    [Description(@"Card Settlement-Settlement of AMEX transactions.")]
    Amex,

    /// <summary>
    /// Card Settlement-Settlement of Diners transactions.
    /// Encoded/decoded by serializers as &quot;DICL&quot;.
    /// </summary>
    [EnumMember(Value = "DICL")]
    [IsoId("_JJ8oIAQ5Eey95qpfbNuEwg")]
    [Description(@"Card Settlement-Settlement of Diners transactions.")]
    Diners,

    /// <summary>
    /// Card Settlement-Settlement of Fleet transactions.
    /// Encoded/decoded by serializers as &quot;FLCR&quot;.
    /// </summary>
    [EnumMember(Value = "FLCR")]
    [IsoId("_Rb0-wAQ5Eey95qpfbNuEwg")]
    [Description(@"Card Settlement-Settlement of Fleet transactions.")]
    FleetCard,

    /// <summary>
    /// Securities Lending-ettlement of Money Market PCH.
    /// Encoded/decoded by serializers as &quot;MOMA&quot;.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_Zf3GoAQ5Eey95qpfbNuEwg")]
    [Description(@"Securities Lending-ettlement of Money Market PCH.")]
    MoneyMarket,

    /// <summary>
    /// General-Payments towards a purchase or winnings received from gambling, betting or other wagering activities.
    /// Encoded/decoded by serializers as &quot;GAMB&quot;.
    /// </summary>
    [EnumMember(Value = "GAMB")]
    [IsoId("_HOvxYATWEey95qpfbNuEwg")]
    [Description(
        @"General-Payments towards a purchase or winnings received from gambling, betting or other wagering activities."
    )]
    GamblingOrWageringPayment,

    /// <summary>
    /// General-Payment towards a purchase or winnings received from lottery activities.
    /// Encoded/decoded by serializers as &quot;LOTT&quot;.
    /// </summary>
    [EnumMember(Value = "LOTT")]
    [IsoId("_XBfRYATWEey95qpfbNuEwg")]
    [Description(
        @"General-Payment towards a purchase or winnings received from lottery activities."
    )]
    LotteryPayment,

    /// <summary>
    /// Salary and Benefits-Allowance from government to support family.
    /// Encoded/decoded by serializers as &quot;GAFA&quot;.
    /// </summary>
    [EnumMember(Value = "GAFA")]
    [IsoId("_7n2U0ATXEey95qpfbNuEwg")]
    [Description(@"Salary and Benefits-Allowance from government to support family.")]
    GovernmentFamilyAllowance,

    /// <summary>
    /// Salary and Benefits-Allowance from government to individuals to support payments of housing.
    /// Encoded/decoded by serializers as &quot;GAHO&quot;.
    /// </summary>
    [EnumMember(Value = "GAHO")]
    [IsoId("_Sd8i0ATYEey95qpfbNuEwg")]
    [Description(
        @"Salary and Benefits-Allowance from government to individuals to support payments of housing."
    )]
    GovernmentHousingAllowance,

    /// <summary>
    /// Payment of funds from a lender as part of the issuance of a property loan.
    /// Encoded/decoded by serializers as &quot;PLDS&quot;.
    /// </summary>
    [EnumMember(Value = "PLDS")]
    [IsoId("_ZyCOoBxJEeylJ55yLxtujQ")]
    [Description(@"Payment of funds from a lender as part of the issuance of a property loan.")]
    PropertyLoanDisbursement,

    /// <summary>
    /// Payment of the deposit required towards purchase of a property.
    /// Encoded/decoded by serializers as &quot;PDEP&quot;.
    /// </summary>
    [EnumMember(Value = "PDEP")]
    [IsoId("_NiLKEBxKEeylJ55yLxtujQ")]
    [Description(@"Payment of the deposit required towards purchase of a property.")]
    PropertyDeposit,

    /// <summary>
    /// Final payment to complete the purchase of a property.
    /// Encoded/decoded by serializers as &quot;PCOM&quot;.
    /// </summary>
    [EnumMember(Value = "PCOM")]
    [IsoId("_kRlhQBxKEeylJ55yLxtujQ")]
    [Description(@"Final payment to complete the purchase of a property.")]
    PropertyCompletionPayment,

    /// <summary>
    /// Transfer or extension of a property financing arrangement to a new deal or loan provider, without change of ownership of property.
    /// Encoded/decoded by serializers as &quot;PLRF&quot;.
    /// </summary>
    [EnumMember(Value = "PLRF")]
    [IsoId("_5T75sBxKEeylJ55yLxtujQ")]
    [Description(
        @"Transfer or extension of a property financing arrangement to a new deal or loan provider, without change of ownership of property."
    )]
    PropertyLoanRefinancing,

    /// <summary>
    /// Cash penalties related to securities transaction, including CSDR Settlement Discipline Regime.
    /// Encoded/decoded by serializers as &quot;CPEN&quot;.
    /// </summary>
    [EnumMember(Value = "CPEN")]
    [IsoId("_1SYKgOAjEey0k8vo1GQhqQ")]
    [Description(
        @"Cash penalties related to securities transaction, including CSDR Settlement Discipline Regime."
    )]
    CashPenalties,

    /// <summary>
    /// Transaction is related to a payment concerning dependent support, for example child support or support for a person substantially financially dependent on the support provider.
    /// Encoded/decoded by serializers as &quot;DEPD&quot;.
    /// </summary>
    [EnumMember(Value = "DEPD")]
    [IsoId("_-MDecMlmEe2OhfSCsNFang")]
    [Description(
        @"Transaction is related to a payment concerning dependent support, for example child support or support for a person substantially financially dependent on the support provider."
    )]
    DependentSupportPayment,

    /// <summary>
    /// Retail payment including e-commerce and online shopping.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_b2dR0MlnEe2OhfSCsNFang")]
    [Description(@"Retail payment including e-commerce and online shopping.")]
    RetailPayment,
}
