// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bHRNZtp-Ed-ak6NoX_4Aeg_-1565392153")]
[Description(@"Specifies the type of corporate action event.")]
[Derivations(typeof(CorporateActionEventType1Code))]
public enum CorporateActionEventTypeCode
{
    /// <summary>
    /// Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_bHRNZ9p-Ed-ak6NoX_4Aeg_-1708530250")]
    [Description(@"Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.")]
    DividendReinvestment,
    
    /// <summary>
    /// Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_bHRNaNp-Ed-ak6NoX_4Aeg_-1708530249")]
    [Description(@"Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.")]
    CapitalGainsDistribution,
    
    /// <summary>
    /// Event is a distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. The shareholder must take cash and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_bHRNadp-Ed-ak6NoX_4Aeg_-1708530219")]
    [Description(@"Event is a distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. The shareholder must take cash and is not offered a choice in the form of distribution.")]
    CashDividend,
    
    /// <summary>
    /// Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_bHaXUNp-Ed-ak6NoX_4Aeg_-1708530218")]
    [Description(@"Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.")]
    DividendOption,
    
    /// <summary>
    /// Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_bHaXUdp-Ed-ak6NoX_4Aeg_-1708530188")]
    [Description(@"Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.")]
    StockDividend,
    
    /// <summary>
    /// Event is a liquidating dividend or liquidation that consists of a distribution of cash, assets, or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security. The security holder may be able to choose the form of liquidation distribution.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_bHaXUtp-Ed-ak6NoX_4Aeg_-1708530165")]
    [Description(@"Event is a liquidating dividend or liquidation that consists of a distribution of cash, assets, or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security. The security holder may be able to choose the form of liquidation distribution.")]
    Liquidation,
    
    /// <summary>
    /// Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_bHaXU9p-Ed-ak6NoX_4Aeg_-1708530134")]
    [Description(@"Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.")]
    Merger,
    
    /// <summary>
    /// Event is a name change. The issuing company changes its name. The event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.
    /// Encoded/decoded by serializers as &quot;NAME&quot;.
    /// </summary>
    [EnumMember(Value = "NAME")]
    [IsoId("_bHaXVNp-Ed-ak6NoX_4Aeg_-1708530126")]
    [Description(@"Event is a name change. The issuing company changes its name. The event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.")]
    NameChange,
    
    /// <summary>
    /// Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_bHaXVdp-Ed-ak6NoX_4Aeg_-1708530103")]
    [Description(@"Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.")]
    SpinOff,
    
    /// <summary>
    /// Event is a change in nominal value, a subdivision. It is an increase in a corporation&apos;s number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_bHaXVtp-Ed-ak6NoX_4Aeg_-1708529856")]
    [Description(@"Event is a change in nominal value, a subdivision. It is an increase in a corporation's number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.")]
    StockSplit,
    
    /// <summary>
    /// Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("_bHaXV9p-Ed-ak6NoX_4Aeg_-1708529825")]
    [Description(@"Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.")]
    ReverseStockSplit,
    
    /// <summary>
    /// Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_bHaXWNp-Ed-ak6NoX_4Aeg_-1708529795")]
    [Description(@"Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.")]
    Tender,
    
    /// <summary>
    /// Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn&apos;t change. Holder may be offered choice of form.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_bHaXWdp-Ed-ak6NoX_4Aeg_-1708529764")]
    [Description(@"Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn't change. Holder may be offered choice of form.")]
    BonusIssue,
    
    /// <summary>
    /// Event is the distribution of rights to shareholders, in proportion to their equity holding.
    /// Encoded/decoded by serializers as &quot;RHDI&quot;.
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("_bHkIUNp-Ed-ak6NoX_4Aeg_-1707609732")]
    [Description(@"Event is the distribution of rights to shareholders, in proportion to their equity holding.")]
    RightsDistribution,
    
    /// <summary>
    /// Event is a call or exercise on nil-paid securities or rights resulting from a rights distribution (RHDI). This is to be used for the second event in those cases where the rights issue is dealt with in two events, the first event being the rights distribution (RHDI).
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_bHkIUdp-Ed-ak6NoX_4Aeg_-1707609701")]
    [Description(@"Event is a call or exercise on nil-paid securities or rights resulting from a rights distribution (RHDI). This is to be used for the second event in those cases where the rights issue is dealt with in two events, the first event being the rights distribution (RHDI).")]
    CallOnRights,
    
    /// <summary>
    /// Event is a generic change. For example, a change in the terms of an issue, a change in the identification of a security, change of a board lot, a change from global to definitive.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_bHkIUtp-Ed-ak6NoX_4Aeg_-1707609670")]
    [Description(@"Event is a generic change. For example, a change in the terms of an issue, a change in the identification of a security, change of a board lot, a change from global to definitive.")]
    Change,
    
    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a financial instrument is restated, eg, the debt in a national currency is restated in euro.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("_bHkIU9p-Ed-ak6NoX_4Aeg_-1707609640")]
    [Description(@"Event by which the unit (currency and/or nominal) of a financial instrument is restated, eg, the debt in a national currency is restated in euro.")]
    Redenomination,
    
    /// <summary>
    /// Event is an option for the shareholders to exchange their securities for other securities and/or cash. Exchange options are mentioned in the terms and conditions of a security and are valid during the whole lifetime of a security.
    /// Encoded/decoded by serializers as &quot;EXOP&quot;.
    /// </summary>
    [EnumMember(Value = "EXOP")]
    [IsoId("_bHkIVNp-Ed-ak6NoX_4Aeg_-1707609579")]
    [Description(@"Event is an option for the shareholders to exchange their securities for other securities and/or cash. Exchange options are mentioned in the terms and conditions of a security and are valid during the whole lifetime of a security.")]
    ExchangeOption,
    
    /// <summary>
    /// Event is an exchange offer or capital reorganisation.|It is an offer to shareholders to exchange their holdings for other securities and/or cash. Exchange offers are usually voluntary involving the exchange of outstanding security for a different security or securities and/or cash.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_bHkIVdp-Ed-ak6NoX_4Aeg_-1707609548")]
    [Description(@"Event is an exchange offer or capital reorganisation.|It is an offer to shareholders to exchange their holdings for other securities and/or cash. Exchange offers are usually voluntary involving the exchange of outstanding security for a different security or securities and/or cash.")]
    ExchangeOffer,
    
    /// <summary>
    /// Event is a reduction of the share capital and face value of a single share. The number of the circulating shares remains unchanged. It may include a capital pay-out to shareholder.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_bHkIVtp-Ed-ak6NoX_4Aeg_-1707609517")]
    [Description(@"Event is a reduction of the share capital and face value of a single share. The number of the circulating shares remains unchanged. It may include a capital pay-out to shareholder.")]
    DecreaseInValue,
    
    /// <summary>
    /// This includes drawing, partial and full call, put.|Redemption in part or full before the scheduled final maturity date of a security, subject to the terms and conditions of the issue. |Drawing - Securities are redeemed in part by lottery.|Partial Call - Securities are redeemed in part by reducing proportionally the outstanding amount of securities.|Put - Early redemption of a bond at the election of the bondholder.|Full Call - The entire outstanding of a security is redeemed by the issuer.
    /// Encoded/decoded by serializers as &quot;ERED&quot;.
    /// </summary>
    [EnumMember(Value = "ERED")]
    [IsoId("_bHkIV9p-Ed-ak6NoX_4Aeg_-1707609456")]
    [Description(@"This includes drawing, partial and full call, put.|Redemption in part or full before the scheduled final maturity date of a security, subject to the terms and conditions of the issue. |Drawing - Securities are redeemed in part by lottery.|Partial Call - Securities are redeemed in part by reducing proportionally the outstanding amount of securities.|Put - Early redemption of a bond at the election of the bondholder.|Full Call - The entire outstanding of a security is redeemed by the issuer.")]
    EarlyRedemption,
    
    /// <summary>
    /// Redemption of an entire issue outstanding of securities by the issuer at final maturity.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_bHkIWNp-Ed-ak6NoX_4Aeg_-1707609178")]
    [Description(@"Redemption of an entire issue outstanding of securities by the issuer at final maturity.")]
    FinalMaturity,
    
    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_bHkIWdp-Ed-ak6NoX_4Aeg_-1707609147")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment,
    
    /// <summary>
    /// Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_bHt5UNp-Ed-ak6NoX_4Aeg_-1707609093")]
    [Description(@"Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.")]
    Prefunding,
    
    /// <summary>
    /// A payment of a portion of the principal of an interest bearing asset, in addition to the interest payment.
    /// Encoded/decoded by serializers as &quot;PRII&quot;.
    /// </summary>
    [EnumMember(Value = "PRII")]
    [IsoId("_bHt5Udp-Ed-ak6NoX_4Aeg_-1707608784")]
    [Description(@"A payment of a portion of the principal of an interest bearing asset, in addition to the interest payment.")]
    PrincipalAndInterestPaydown,
    
    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;RMRK&quot;.
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_bHt5Utp-Ed-ak6NoX_4Aeg_-1707608753")]
    [Description(@"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.")]
    Remarketing,
    
    /// <summary>
    /// The ability for security holders to purchase (additional or new) securities at a certain price, in proportion to their holding.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_bHt5U9p-Ed-ak6NoX_4Aeg_-1707608631")]
    [Description(@"The ability for security holders to purchase (additional or new) securities at a certain price, in proportion to their holding.")]
    Subscription,
    
    /// <summary>
    /// The combination of different security types to create a unit. Units are usually comprised of warrants and bond or warrants and equity. Securities may be combined at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;ATTI&quot;.
    /// </summary>
    [EnumMember(Value = "ATTI")]
    [IsoId("_bHt5VNp-Ed-ak6NoX_4Aeg_-1707608569")]
    [Description(@"The combination of different security types to create a unit. Units are usually comprised of warrants and bond or warrants and equity. Securities may be combined at the request of the security holder or based on market convention.")]
    Attachment,
    
    /// <summary>
    /// Conversion of securities (generally convertible bonds or preferred shares) into another form of securities (usually common shares) at a pre-stated price.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_bHt5Vdp-Ed-ak6NoX_4Aeg_-1707608508")]
    [Description(@"Conversion of securities (generally convertible bonds or preferred shares) into another form of securities (usually common shares) at a pre-stated price.")]
    Conversion,
    
    /// <summary>
    /// Separation of components that comprise a security usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;DETI&quot;.
    /// </summary>
    [EnumMember(Value = "DETI")]
    [IsoId("_bHt5Vtp-Ed-ak6NoX_4Aeg_-1707608230")]
    [Description(@"Separation of components that comprise a security usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.")]
    Detachment,
    
    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_bHt5V9p-Ed-ak6NoX_4Aeg_-1707608169")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividend,
    
    /// <summary>
    /// Also called Assimilation or Enfranchisement. Occurs when securities with different characteristics, for example, equities with different entitlements to dividend or voting rights, are assimilated, ie, become identical in all respects. The event may be scheduled in advance or be the result of an outside event.
    /// Encoded/decoded by serializers as &quot;PARI&quot;.
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_bHt5WNp-Ed-ak6NoX_4Aeg_-1707607829")]
    [Description(@"Also called Assimilation or Enfranchisement. Occurs when securities with different characteristics, for example, equities with different entitlements to dividend or voting rights, are assimilated, ie, become identical in all respects. The event may be scheduled in advance or be the result of an outside event.")]
    PariPassu,
    
    /// <summary>
    /// Form of open or public offer where priority is given to existing shareholders due to limited amount of securities available in the offer. Shareholders can buy a type of security during a short period of time.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_bHt5Wdp-Ed-ak6NoX_4Aeg_-1707607768")]
    [Description(@"Form of open or public offer where priority is given to existing shareholders due to limited amount of securities available in the offer. Shareholders can buy a type of security during a short period of time.")]
    PriorityIssue,
    
    /// <summary>
    /// Also called Issuer Bid or Reverse Rights.|Offer to existing shareholders by the issuing company to repurchase equity or other securities convertible into equity. The objective of the offer is to reduce the number of outstanding equities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_bHt5Wtp-Ed-ak6NoX_4Aeg_-1707607706")]
    [Description(@"Also called Issuer Bid or Reverse Rights.|Offer to existing shareholders by the issuing company to repurchase equity or other securities convertible into equity. The objective of the offer is to reduce the number of outstanding equities.")]
    BidRepurchaseOffer,
    
    /// <summary>
    /// Warrant conversion. Option offered to security holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).
    /// Encoded/decoded by serializers as &quot;EXWA&quot;.
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("_bH3DQNp-Ed-ak6NoX_4Aeg_-1707607645")]
    [Description(@"Warrant conversion. Option offered to security holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).")]
    CallOnWarrants,
    
    /// <summary>
    /// Sale to or purchase of odd-lots from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_bH3DQdp-Ed-ak6NoX_4Aeg_-1707607561")]
    [Description(@"Sale to or purchase of odd-lots from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.")]
    OddLotSalePurchase,
    
}
