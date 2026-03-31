// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the corporate action event type, as published in an external corporate action event type code set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalCorporateActionEventTypeCode")]
[Description(
    @"Specifies the corporate action event type, as published in an external corporate action event type code set."
)]
public enum ExternalCorporateActionEventTypeCode
{
    /// <summary>
    /// Funds related event in which the income that accrues during an accounting period is retained within the fund instead of being paid away to investors.
    /// Encoded/decoded by serializers as &quot;ACCU&quot;.
    /// </summary>
    [EnumMember(Value = "ACCU")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Accumulation")]
    [Description(
        @"Funds related event in which the income that accrues during an accounting period is retained within the fund instead of being paid away to investors."
    )]
    Accumulation,

    /// <summary>
    /// Trading in the security has commenced or security has been re-activated after a suspension in trading.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ExternalCorporateActionEventTypeCode_ActiveTradingStatus")]
    [Description(
        @"Trading in the security has commenced or security has been re-activated after a suspension in trading."
    )]
    ActiveTradingStatus,

    /// <summary>
    /// Combination of different security types to create a unit.
    /// Encoded/decoded by serializers as &quot;ATTI&quot;.
    /// </summary>
    [EnumMember(Value = "ATTI")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Attachment")]
    [Description(@"Combination of different security types to create a unit.")]
    Attachment,

    /// <summary>
    /// Repurchase offer / issuer bid / reverse rights. Offer to existing holders by the issuing company to repurchase its own securities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_ExternalCorporateActionEventTypeCode_RepurchaseOffer")]
    [Description(
        @"Repurchase offer / issuer bid / reverse rights. Offer to existing holders by the issuing company to repurchase its own securities."
    )]
    RepurchaseOffer,

    /// <summary>
    /// Bonus or capitalisation issue. Security holders receive additional assets free of payment from the issuer, in proportion to their holding.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_ExternalCorporateActionEventTypeCode_BonusIssue")]
    [Description(
        @"Bonus or capitalisation issue. Security holders receive additional assets free of payment from the issuer, in proportion to their holding."
    )]
    BonusIssue,

    /// <summary>
    /// Early redemption of a security at the election of the holder subject to the terms and condition of the issue with no reduction in nominal value.
    /// Encoded/decoded by serializers as &quot;BPUT&quot;.
    /// </summary>
    [EnumMember(Value = "BPUT")]
    [IsoId("_ExternalCorporateActionEventTypeCode_PutRedemption")]
    [Description(
        @"Early redemption of a security at the election of the holder subject to the terms and condition of the issue with no reduction in nominal value."
    )]
    PutRedemption,

    /// <summary>
    /// Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.
    /// Encoded/decoded by serializers as &quot;BRUP&quot;.
    /// </summary>
    [EnumMember(Value = "BRUP")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Bankruptcy")]
    [Description(
        @"Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless."
    )]
    Bankruptcy,

    /// <summary>
    /// Corporate event pays shareholders an amount in cash issued from the capital account.
    /// Encoded/decoded by serializers as &quot;CAPD&quot;.
    /// </summary>
    [EnumMember(Value = "CAPD")]
    [IsoId("_ExternalCorporateActionEventTypeCode_CapitalDistribution")]
    [Description(
        @"Corporate event pays shareholders an amount in cash issued from the capital account."
    )]
    CapitalDistribution,

    /// <summary>
    /// Event is the distribution of profits resulting from the sale of securities.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_ExternalCorporateActionEventTypeCode_CapitalGainsDistribution")]
    [Description(@"Event is the distribution of profits resulting from the sale of securities.")]
    CapitalGainsDistribution,

    /// <summary>
    /// Increase of the current principal of a debt instrument without increasing the nominal value.
    /// Encoded/decoded by serializers as &quot;CAPI&quot;.
    /// </summary>
    [EnumMember(Value = "CAPI")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Capitalisation")]
    [Description(
        @"Increase of the current principal of a debt instrument without increasing the nominal value."
    )]
    Capitalisation,

    /// <summary>
    /// Non-US beneficial owner certification requirement for exchange of temporary to permanent notes.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_ExternalCorporateActionEventTypeCode_NonUSTEFRADCertification")]
    [Description(
        @"Non-US beneficial owner certification requirement for exchange of temporary to permanent notes."
    )]
    NonUSTEFRADCertification,

    /// <summary>
    /// Information regarding a change further described in the corporate action details.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Change")]
    [Description(
        @"Information regarding a change further described in the corporate action details."
    )]
    Change,

    /// <summary>
    /// Situation where interested parties seek restitution for financial loss.
    /// Encoded/decoded by serializers as &quot;CLSA&quot;.
    /// </summary>
    [EnumMember(Value = "CLSA")]
    [IsoId("_ExternalCorporateActionEventTypeCode_ClassActionProposedSettlement")]
    [Description(@"Situation where interested parties seek restitution for financial loss.")]
    ClassActionProposedSettlement,

    /// <summary>
    /// Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Consent")]
    [Description(
        @"Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting."
    )]
    Consent,

    /// <summary>
    /// Conversion of securities (generally convertible bonds or preferred shares) into another form of securities.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Conversion")]
    [Description(
        @"Conversion of securities (generally convertible bonds or preferred shares) into another form of securities."
    )]
    Conversion,

    /// <summary>
    /// Company option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("_ExternalCorporateActionEventTypeCode_CompanyOption")]
    [Description(
        @"Company option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company."
    )]
    CompanyOption,

    /// <summary>
    /// Occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations.
    /// Encoded/decoded by serializers as &quot;CREV&quot;.
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("_ExternalCorporateActionEventTypeCode_CreditEvent")]
    [Description(
        @"Occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations."
    )]
    CreditEvent,

    /// <summary>
    /// Reduction of face value of a single share or the value of fund assets.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_ExternalCorporateActionEventTypeCode_DecreaseInValue")]
    [Description(@"Reduction of face value of a single share or the value of fund assets.")]
    DecreaseInValue,

    /// <summary>
    /// Separation of components that comprise a security.
    /// Encoded/decoded by serializers as &quot;DETI&quot;.
    /// </summary>
    [EnumMember(Value = "DETI")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Detachment")]
    [Description(@"Separation of components that comprise a security.")]
    Detachment,

    /// <summary>
    /// Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_ExternalCorporateActionEventTypeCode_BondDefault")]
    [Description(
        @"Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied."
    )]
    BondDefault,

    /// <summary>
    /// Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.
    /// Encoded/decoded by serializers as &quot;DLST&quot;.
    /// </summary>
    [EnumMember(Value = "DLST")]
    [IsoId("_ExternalCorporateActionEventTypeCode_TradingStatusDelisted")]
    [Description(
        @"Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation."
    )]
    TradingStatusDelisted,

    /// <summary>
    /// Securities are redeemed in part before the scheduled final maturity date without any pool factor reduction.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Drawing")]
    [Description(
        @"Securities are redeemed in part before the scheduled final maturity date without any pool factor reduction."
    )]
    Drawing,

    /// <summary>
    /// Distribution to shareholders of cash resulting from the selling of non-eligible securities.
    /// Encoded/decoded by serializers as &quot;DRCA&quot;.
    /// </summary>
    [EnumMember(Value = "DRCA")]
    [IsoId("_ExternalCorporateActionEventTypeCode_CashDistributionFromNonEligibleSecuritiesSales")]
    [Description(
        @"Distribution to shareholders of cash resulting from the selling of non-eligible securities."
    )]
    CashDistributionFromNonEligibleSecuritiesSales,

    /// <summary>
    /// Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_ExternalCorporateActionEventTypeCode_DividendReinvestment")]
    [Description(
        @"Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares."
    )]
    DividendReinvestment,

    /// <summary>
    /// Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.
    /// Encoded/decoded by serializers as &quot;DSCL&quot;.
    /// </summary>
    [EnumMember(Value = "DSCL")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Disclosure")]
    [Description(
        @"Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer."
    )]
    Disclosure,

    /// <summary>
    /// Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_ExternalCorporateActionEventTypeCode_DutchAuction")]
    [Description(
        @"Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range."
    )]
    DutchAuction,

    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_ExternalCorporateActionEventTypeCode_CashDividend")]
    [Description(@"Distribution of cash to shareholders, in proportion to their equity holding.")]
    CashDividend,

    /// <summary>
    /// Distribution of a dividend to shareholders with a choice of benefit to receive.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_ExternalCorporateActionEventTypeCode_DividendOption")]
    [Description(
        @"Distribution of a dividend to shareholders with a choice of benefit to receive."
    )]
    DividendOption,

    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_ExternalCorporateActionEventTypeCode_ScripDividend")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividend,

    /// <summary>
    /// Dividend paid to shareholders in the form of equities of the issuing corporation.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_ExternalCorporateActionEventTypeCode_StockDividend")]
    [Description(
        @"Dividend paid to shareholders in the form of equities of the issuing corporation."
    )]
    StockDividend,

    /// <summary>
    /// Exchange of holdings for other securities and/or cash.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Exchange")]
    [Description(@"Exchange of holdings for other securities and/or cash.")]
    Exchange,

    /// <summary>
    /// Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_ExternalCorporateActionEventTypeCode_CallOnIntermediateSecurities")]
    [Description(
        @"Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution."
    )]
    CallOnIntermediateSecurities,

    /// <summary>
    /// The issuer or the holder may prolong the maturity date of a security.
    /// Encoded/decoded by serializers as &quot;EXTM&quot;.
    /// </summary>
    [EnumMember(Value = "EXTM")]
    [IsoId("_ExternalCorporateActionEventTypeCode_MaturityExtension")]
    [Description(@"The issuer or the holder may prolong the maturity date of a security.")]
    MaturityExtension,

    /// <summary>
    /// Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity.
    /// Encoded/decoded by serializers as &quot;EXWA&quot;.
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("_ExternalCorporateActionEventTypeCode_WarrantExercise")]
    [Description(
        @"Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity."
    )]
    WarrantExercise,

    /// <summary>
    /// Increase in the face value of a single security. The number of circulating securities remains unchanged.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_ExternalCorporateActionEventTypeCode_IncreaseInValue")]
    [Description(
        @"Increase in the face value of a single security. The number of circulating securities remains unchanged."
    )]
    IncreaseInValue,

    /// <summary>
    /// Information provided by the issuer having no accounting/financial impact on the holder.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Information")]
    [Description(
        @"Information provided by the issuer having no accounting/financial impact on the holder."
    )]
    Information,

    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_ExternalCorporateActionEventTypeCode_InterestPayment")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment,

    /// <summary>
    /// Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_ExternalCorporateActionEventTypeCode_LiquidationDividend")]
    [Description(
        @"Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security."
    )]
    LiquidationDividend,

    /// <summary>
    /// Redemption of an entire issue outstanding of securities by the issuer or its agent before final maturity.
    /// Encoded/decoded by serializers as &quot;MCAL&quot;.
    /// </summary>
    [EnumMember(Value = "MCAL")]
    [IsoId("_ExternalCorporateActionEventTypeCode_FullCall")]
    [Description(
        @"Redemption of an entire issue outstanding of securities by the issuer or its agent before final maturity."
    )]
    FullCall,

    /// <summary>
    /// Exchange of outstanding securities, initiated by the issuer, as the result of two or more companies combining assets.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Merger")]
    [Description(
        @"Exchange of outstanding securities, initiated by the issuer, as the result of two or more companies combining assets."
    )]
    Merger,

    /// <summary>
    /// Offers that are not supervised or regulated by an official entity and being offered by a party usually at a discount price.
    /// Encoded/decoded by serializers as &quot;NOOF&quot;.
    /// </summary>
    [EnumMember(Value = "NOOF")]
    [IsoId("_ExternalCorporateActionEventTypeCode_NonOfficialOffer")]
    [Description(
        @"Offers that are not supervised or regulated by an official entity and being offered by a party usually at a discount price."
    )]
    NonOfficialOffer,

    /// <summary>
    /// Sale or purchase of odd-lots to/from the issuing company.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_ExternalCorporateActionEventTypeCode_OddLotSalePurchase")]
    [Description(@"Sale or purchase of odd-lots to/from the issuing company.")]
    OddLotSalePurchase,

    /// <summary>
    /// Other event, use only when no other event type applies, for example, a new event type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ExternalCorporateActionEventTypeCode_OtherEvent")]
    [Description(
        @"Other event, use only when no other event type applies, for example, a new event type."
    )]
    OtherEvent,

    /// <summary>
    /// Occurs when securities with different characteristics become identical in all respects.
    /// Encoded/decoded by serializers as &quot;PARI&quot;.
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_ExternalCorporateActionEventTypeCode_PariPassu")]
    [Description(
        @"Occurs when securities with different characteristics become identical in all respects."
    )]
    PariPassu,

    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date without any pool factor reduction.
    /// Encoded/decoded by serializers as &quot;PCAL&quot;.
    /// </summary>
    [EnumMember(Value = "PCAL")]
    [IsoId("_ExternalCorporateActionEventTypeCode_PartialRedemptionWithoutPoolFactorReduction")]
    [Description(
        @"Securities are redeemed in part before their scheduled final maturity date without any pool factor reduction."
    )]
    PartialRedemptionWithoutPoolFactorReduction,

    /// <summary>
    /// Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Prefunding")]
    [Description(
        @"Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue."
    )]
    Prefunding,

    /// <summary>
    /// Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("_ExternalCorporateActionEventTypeCode_PayInKind")]
    [Description(
        @"Interest payment, in any kind except cash, distributed to holders of an interest bearing asset."
    )]
    PayInKind,

    /// <summary>
    /// Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_ExternalCorporateActionEventTypeCode_PlaceOfIncorporation")]
    [Description(
        @"Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies."
    )]
    PlaceOfIncorporation,

    /// <summary>
    /// Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.
    /// Encoded/decoded by serializers as &quot;PPMT&quot;.
    /// </summary>
    [EnumMember(Value = "PPMT")]
    [IsoId("_ExternalCorporateActionEventTypeCode_InstalmentCall")]
    [Description(
        @"Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser."
    )]
    InstalmentCall,

    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date. The redemption is reflected in a pool factor reduction.
    /// Encoded/decoded by serializers as &quot;PRED&quot;.
    /// </summary>
    [EnumMember(Value = "PRED")]
    [IsoId("_ExternalCorporateActionEventTypeCode_PartialRedemptionWithPoolFactorReduction")]
    [Description(
        @"Securities are redeemed in part before their scheduled final maturity date. The redemption is reflected in a pool factor reduction."
    )]
    PartialRedemptionWithPoolFactorReduction,

    /// <summary>
    /// Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_ExternalCorporateActionEventTypeCode_PriorityIssue")]
    [Description(
        @"Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders."
    )]
    PriorityIssue,

    /// <summary>
    /// Redemption of an entire issue outstanding of securities by the issuer or its agent at final maturity.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ExternalCorporateActionEventTypeCode_FinalMaturity")]
    [Description(
        @"Redemption of an entire issue outstanding of securities by the issuer or its agent at final maturity."
    )]
    FinalMaturity,

    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a security is restated.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Redenomination")]
    [Description(@"Event by which the unit (currency and/or nominal) of a security is restated.")]
    Redenomination,

    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;REMK&quot;.
    /// </summary>
    [EnumMember(Value = "REMK")]
    [IsoId("_ExternalCorporateActionEventTypeCode_RemarketingAgreement")]
    [Description(
        @"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders."
    )]
    RemarketingAgreement,

    /// <summary>
    /// Distribution of intermediate securities that gives the holder the right to take part in a future event.
    /// Encoded/decoded by serializers as &quot;RHDI&quot;.
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("_ExternalCorporateActionEventTypeCode_IntermediateSecuritiesDistribution")]
    [Description(
        @"Distribution of intermediate securities that gives the holder the right to take part in a future event."
    )]
    IntermediateSecuritiesDistribution,

    /// <summary>
    /// Offer to holders of a security to subscribe for additional securities via the distribution of an intermediate security.
    /// Encoded/decoded by serializers as &quot;RHTS&quot;.
    /// </summary>
    [EnumMember(Value = "RHTS")]
    [IsoId("_ExternalCorporateActionEventTypeCode_RightsIssue")]
    [Description(
        @"Offer to holders of a security to subscribe for additional securities via the distribution of an intermediate security."
    )]
    RightsIssue,

    /// <summary>
    /// Corporate event pays shareholders an amount in cash issued from the shares premium reserve.
    /// Encoded/decoded by serializers as &quot;SHPR&quot;.
    /// </summary>
    [EnumMember(Value = "SHPR")]
    [IsoId("_ExternalCorporateActionEventTypeCode_SharesPremiumDividend")]
    [Description(
        @"Corporate event pays shareholders an amount in cash issued from the shares premium reserve."
    )]
    SharesPremiumDividend,

    /// <summary>
    /// Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_ExternalCorporateActionEventTypeCode_SmallestNegotiableUnit")]
    [Description(
        @"Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit."
    )]
    SmallestNegotiableUnit,

    /// <summary>
    /// Distribution of securities issued by another company. For example, spin-off, demerger, unbundling, divestment.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_ExternalCorporateActionEventTypeCode_SpinOff")]
    [Description(
        @"Distribution of securities issued by another company. For example, spin-off, demerger, unbundling, divestment."
    )]
    SpinOff,

    /// <summary>
    /// Increase in a corporation’s number of outstanding equities without any change in the shareholder’s equity or the aggregate market value at the time of the split.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_ExternalCorporateActionEventTypeCode_StockSplit")]
    [Description(
        @"Increase in a corporation’s number of outstanding equities without any change in the shareholder’s equity or the aggregate market value at the time of the split."
    )]
    StockSplit,

    /// <summary>
    /// Decrease in a company’s number of outstanding equities without any change in the shareholder’s equity or the aggregate market value at the time of the split.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("_ExternalCorporateActionEventTypeCode_ReverseStockSplit")]
    [Description(
        @"Decrease in a company’s number of outstanding equities without any change in the shareholder’s equity or the aggregate market value at the time of the split."
    )]
    ReverseStockSplit,

    /// <summary>
    /// Trading in the security has been suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_ExternalCorporateActionEventTypeCode_TradingStatusSuspended")]
    [Description(@"Trading in the security has been suspended.")]
    TradingStatusSuspended,

    /// <summary>
    /// Offer made to holders by a third party, requesting them to sell (tender) or exchange their securities.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Tender")]
    [Description(
        @"Offer made to holders by a third party, requesting them to sell (tender) or exchange their securities."
    )]
    Tender,

    /// <summary>
    /// Taxable component on non-distributed proceeds, for example, Australian deemed income or US 871m income regulation.
    /// Encoded/decoded by serializers as &quot;TNDP&quot;.
    /// </summary>
    [EnumMember(Value = "TNDP")]
    [IsoId("_ExternalCorporateActionEventTypeCode_TaxOnNonDistributedProceeds")]
    [Description(
        @"Taxable component on non-distributed proceeds, for example, Australian deemed income or US 871m income regulation."
    )]
    TaxOnNonDistributedProceeds,

    /// <summary>
    /// Event related to tax reclaim activities.
    /// Encoded/decoded by serializers as &quot;TREC&quot;.
    /// </summary>
    [EnumMember(Value = "TREC")]
    [IsoId("_ExternalCorporateActionEventTypeCode_TaxReclaim")]
    [Description(@"Event related to tax reclaim activities.")]
    TaxReclaim,

    /// <summary>
    /// Booking out of valueless securities.
    /// Encoded/decoded by serializers as &quot;WRTH&quot;.
    /// </summary>
    [EnumMember(Value = "WRTH")]
    [IsoId("_ExternalCorporateActionEventTypeCode_Worthless")]
    [Description(@"Booking out of valueless securities.")]
    Worthless,

    /// <summary>
    /// Certification process for withholding tax reduction or exemption based on the tax status of the holder.
    /// Encoded/decoded by serializers as &quot;WTRC&quot;.
    /// </summary>
    [EnumMember(Value = "WTRC")]
    [IsoId("_ExternalCorporateActionEventTypeCode_WithholdingTaxReliefCertification")]
    [Description(
        @"Certification process for withholding tax reduction or exemption based on the tax status of the holder."
    )]
    WithholdingTaxReliefCertification,
}
