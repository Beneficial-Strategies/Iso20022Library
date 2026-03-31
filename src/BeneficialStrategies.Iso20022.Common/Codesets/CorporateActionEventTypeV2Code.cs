// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bH3DQtp-Ed-ak6NoX_4Aeg_-1996839615")]
[Description(@"Specifies the corporate action event type.")]
[Derivations(typeof(CorporateActionEventType3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionEventTypeV2Code>))]
#endif
public enum CorporateActionEventTypeV2Code
{
    /// <summary>
    /// Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_bH3DQ9p-Ed-ak6NoX_4Aeg_645290500")]
    [Description(
        @"Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company."
    )]
    DividendReinvestment,

    /// <summary>
    /// Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_bH3DRNp-Ed-ak6NoX_4Aeg_645290684")]
    [Description(
        @"Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund."
    )]
    CapitalGainsDistribution,

    /// <summary>
    /// Event is a distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. The shareholder must take cash and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_bH3DRdp-Ed-ak6NoX_4Aeg_645291517")]
    [Description(
        @"Event is a distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. The shareholder must take cash and is not offered a choice in the form of distribution."
    )]
    CashDividend,

    /// <summary>
    /// Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_bH3DRtp-Ed-ak6NoX_4Aeg_645291723")]
    [Description(
        @"Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both."
    )]
    DividendOption,

    /// <summary>
    /// Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_bH3DR9p-Ed-ak6NoX_4Aeg_645292433")]
    [Description(
        @"Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution."
    )]
    StockDividend,

    /// <summary>
    /// Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_bH3DSNp-Ed-ak6NoX_4Aeg_646213196")]
    [Description(
        @"Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange."
    )]
    Merger,

    /// <summary>
    /// Event is a name change. The issuing company changes its name. The event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.
    /// Encoded/decoded by serializers as &quot;NAME&quot;.
    /// </summary>
    [EnumMember(Value = "NAME")]
    [IsoId("_bIA0QNp-Ed-ak6NoX_4Aeg_646213627")]
    [Description(
        @"Event is a name change. The issuing company changes its name. The event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar."
    )]
    NameChange,

    /// <summary>
    /// Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_bIA0Qdp-Ed-ak6NoX_4Aeg_646214113")]
    [Description(
        @"Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder."
    )]
    SpinOff,

    /// <summary>
    /// Event is a change in nominal value, a subdivision. It is an increase in a corporation&apos;s number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_bIA0Qtp-Ed-ak6NoX_4Aeg_646214545")]
    [Description(
        @"Event is a change in nominal value, a subdivision. It is an increase in a corporation's number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly."
    )]
    StockSplit,

    /// <summary>
    /// Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("_bIA0Q9p-Ed-ak6NoX_4Aeg_646215191")]
    [Description(
        @"Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly."
    )]
    ReverseStockSplit,

    /// <summary>
    /// Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_bIA0RNp-Ed-ak6NoX_4Aeg_646215614")]
    [Description(
        @"Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company."
    )]
    Tender,

    /// <summary>
    /// Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn&apos;t change. Holder may be offered choice of form.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_bIA0Rdp-Ed-ak6NoX_4Aeg_646216107")]
    [Description(
        @"Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn't change. Holder may be offered choice of form."
    )]
    BonusIssue,

    /// <summary>
    /// Event is the distribution of rights to shareholders, in proportion to their equity holding.
    /// Encoded/decoded by serializers as &quot;RHDI&quot;.
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("_bIA0Rtp-Ed-ak6NoX_4Aeg_646216562")]
    [Description(
        @"Event is the distribution of rights to shareholders, in proportion to their equity holding."
    )]
    RightsDistribution,

    /// <summary>
    /// Event is a call or exercise on nil-paid securities or rights resulting from a rights distribution (RHDI). This is to be used for the second event in those cases where the rights issue is dealt with in two events, the first event being the rights distribution (RHDI).
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_bIA0R9p-Ed-ak6NoX_4Aeg_647137148")]
    [Description(
        @"Event is a call or exercise on nil-paid securities or rights resulting from a rights distribution (RHDI). This is to be used for the second event in those cases where the rights issue is dealt with in two events, the first event being the rights distribution (RHDI)."
    )]
    CallOnRights,

    /// <summary>
    /// Event is a generic change. For example, a change in the terms of an issue, a change in the identification of a security, change of a board lot, a change from global to definitive.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_bIA0SNp-Ed-ak6NoX_4Aeg_647139105")]
    [Description(
        @"Event is a generic change. For example, a change in the terms of an issue, a change in the identification of a security, change of a board lot, a change from global to definitive."
    )]
    Change,

    /// <summary>
    /// Event is an exchange offer or capital reorganisation. It is an offer to shareholders to exchange their holdings for other securities and/or cash. Exchange offers are usually voluntary involving the exchange of outstanding security for a different security or securities and/or cash.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_bIKlQNp-Ed-ak6NoX_4Aeg_648985601")]
    [Description(
        @"Event is an exchange offer or capital reorganisation. It is an offer to shareholders to exchange their holdings for other securities and/or cash. Exchange offers are usually voluntary involving the exchange of outstanding security for a different security or securities and/or cash."
    )]
    ExchangeOffer,

    /// <summary>
    /// Event is a reduction of the share capital and face value of a single share. The number of the circulating shares remains unchanged. It may include a capital pay-out to shareholder.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_bIKlQdp-Ed-ak6NoX_4Aeg_656372050")]
    [Description(
        @"Event is a reduction of the share capital and face value of a single share. The number of the circulating shares remains unchanged. It may include a capital pay-out to shareholder."
    )]
    DecreaseInValue,

    /// <summary>
    /// This includes drawing, partial and full call, put. Redemption in part or full before the scheduled final maturity date of a security, subject to the terms and conditions of the issue. Drawing - Securities are redeemed in part by lottery. Partial Call - Securities are redeemed in part by reducing proportionally the outstanding amount of securities. Put - Early redemption of a bond at the election of the bondholder. Full Call - The entire outstanding of a security is redeemed by the issuer.
    /// Encoded/decoded by serializers as &quot;ERED&quot;.
    /// </summary>
    [EnumMember(Value = "ERED")]
    [IsoId("_bIKlQtp-Ed-ak6NoX_4Aeg_656374685")]
    [Description(
        @"This includes drawing, partial and full call, put. Redemption in part or full before the scheduled final maturity date of a security, subject to the terms and conditions of the issue. Drawing - Securities are redeemed in part by lottery. Partial Call - Securities are redeemed in part by reducing proportionally the outstanding amount of securities. Put - Early redemption of a bond at the election of the bondholder. Full Call - The entire outstanding of a security is redeemed by the issuer."
    )]
    EarlyRedemption,

    /// <summary>
    /// Redemption of an entire issue outstanding of securities by the issuer at final maturity.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_bIKlQ9p-Ed-ak6NoX_4Aeg_657296828")]
    [Description(
        @"Redemption of an entire issue outstanding of securities by the issuer at final maturity."
    )]
    FinalMaturity,

    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_bIKlRNp-Ed-ak6NoX_4Aeg_658219000")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment,

    /// <summary>
    /// Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_bIKlRdp-Ed-ak6NoX_4Aeg_658221296")]
    [Description(
        @"Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity."
    )]
    Prefunding,

    /// <summary>
    /// A payment of a portion of the principal of an interest bearing asset, in addition to the interest payment.
    /// Encoded/decoded by serializers as &quot;PRII&quot;.
    /// </summary>
    [EnumMember(Value = "PRII")]
    [IsoId("_bIKlRtp-Ed-ak6NoX_4Aeg_659143469")]
    [Description(
        @"A payment of a portion of the principal of an interest bearing asset, in addition to the interest payment."
    )]
    PrincipalAndInterestPaydown,

    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;RMRK&quot;.
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_bIKlR9p-Ed-ak6NoX_4Aeg_660065889")]
    [Description(
        @"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders."
    )]
    Remarketing,

    /// <summary>
    /// The ability for security holders to purchase (additional or new) securities at a certain price, in proportion to their holding.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_bIKlSNp-Ed-ak6NoX_4Aeg_660068307")]
    [Description(
        @"The ability for security holders to purchase (additional or new) securities at a certain price, in proportion to their holding."
    )]
    Subscription,

    /// <summary>
    /// The combination of different security types to create a unit. Units are usually comprised of warrants and bond or warrants and equity. Securities may be combined at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;ATTI&quot;.
    /// </summary>
    [EnumMember(Value = "ATTI")]
    [IsoId("_bIKlSdp-Ed-ak6NoX_4Aeg_660990480")]
    [Description(
        @"The combination of different security types to create a unit. Units are usually comprised of warrants and bond or warrants and equity. Securities may be combined at the request of the security holder or based on market convention."
    )]
    Attachment,

    /// <summary>
    /// Conversion of securities (generally convertible bonds or preferred shares) into another form of securities (usually common shares) at a pre-stated price.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_bITvMNp-Ed-ak6NoX_4Aeg_669301099")]
    [Description(
        @"Conversion of securities (generally convertible bonds or preferred shares) into another form of securities (usually common shares) at a pre-stated price."
    )]
    Conversion,

    /// <summary>
    /// Separation of components that comprise a security usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;DETI&quot;.
    /// </summary>
    [EnumMember(Value = "DETI")]
    [IsoId("_bITvMdp-Ed-ak6NoX_4Aeg_669303517")]
    [Description(
        @"Separation of components that comprise a security usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention."
    )]
    Detachment,

    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_bITvMtp-Ed-ak6NoX_4Aeg_670225721")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividend,

    /// <summary>
    /// Also called Assimilation or Enfranchisement. Occurs when securities with different characteristics, for example, equities with different entitlements to dividend or voting rights, are assimilated, that is, become identical in all respects. The event may be scheduled in advance or be the result of an outside event.
    /// Encoded/decoded by serializers as &quot;PARI&quot;.
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_bITvM9p-Ed-ak6NoX_4Aeg_670228017")]
    [Description(
        @"Also called Assimilation or Enfranchisement. Occurs when securities with different characteristics, for example, equities with different entitlements to dividend or voting rights, are assimilated, that is, become identical in all respects. The event may be scheduled in advance or be the result of an outside event."
    )]
    PariPassu,

    /// <summary>
    /// Form of open or public offer where priority is given to existing shareholders due to limited amount of securities available in the offer. Shareholders can buy a type of security during a short period of time.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_bITvNNp-Ed-ak6NoX_4Aeg_671150228")]
    [Description(
        @"Form of open or public offer where priority is given to existing shareholders due to limited amount of securities available in the offer. Shareholders can buy a type of security during a short period of time."
    )]
    PriorityIssue,

    /// <summary>
    /// Also called Issuer Bid or Reverse Rights. Offer to existing shareholders by the issuing company to repurchase equity or other securities convertible into equity. The objective of the offer is to reduce the number of outstanding equities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_bITvNdp-Ed-ak6NoX_4Aeg_672072671")]
    [Description(
        @"Also called Issuer Bid or Reverse Rights. Offer to existing shareholders by the issuing company to repurchase equity or other securities convertible into equity. The objective of the offer is to reduce the number of outstanding equities."
    )]
    BidRepurchaseOffer,

    /// <summary>
    /// Warrant conversion. Option offered to security holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).
    /// Encoded/decoded by serializers as &quot;EXWA&quot;.
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("_bITvNtp-Ed-ak6NoX_4Aeg_672074757")]
    [Description(
        @"Warrant conversion. Option offered to security holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue)."
    )]
    CallOnWarrants,

    /// <summary>
    /// Sale to or purchase of odd-lots from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_bITvN9p-Ed-ak6NoX_4Aeg_672997178")]
    [Description(
        @"Sale to or purchase of odd-lots from the issuing company, initiated either by the holder of the security or through an offer made by the issuer."
    )]
    OddLotSalePurchase,

    /// <summary>
    /// Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.
    /// Encoded/decoded by serializers as &quot;CLSA&quot;.
    /// </summary>
    [EnumMember(Value = "CLSA")]
    [IsoId("_bITvONp-Ed-ak6NoX_4Aeg_132469828")]
    [Description(
        @"Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction."
    )]
    ClassActionProposedSettlement,

    /// <summary>
    /// Trading in security has commenced or security has been reactivated after a suspension in trading.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_bITvOdp-Ed-ak6NoX_4Aeg_314403838")]
    [Description(
        @"Trading in security has commenced or security has been reactivated after a suspension in trading."
    )]
    ActiveTradingStatus,

    /// <summary>
    /// Early redemption of a security at the election of the holder subject to the terms and condition of the issue.
    /// Encoded/decoded by serializers as &quot;BPUT&quot;.
    /// </summary>
    [EnumMember(Value = "BPUT")]
    [IsoId("_bIdgMNp-Ed-ak6NoX_4Aeg_316250850")]
    [Description(
        @"Early redemption of a security at the election of the holder subject to the terms and condition of the issue."
    )]
    PutRedemption,

    /// <summary>
    /// Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.
    /// Encoded/decoded by serializers as &quot;BRUP&quot;.
    /// </summary>
    [EnumMember(Value = "BRUP")]
    [IsoId("_bIdgMdp-Ed-ak6NoX_4Aeg_316253391")]
    [Description(
        @"Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless."
    )]
    Bankruptcy,

    /// <summary>
    /// Non US Tax Equity and Fiscal Responsibility Act (TEFRA) D certification. Non US beneficial owner certification requirement for exchange of temporary to permanent notes.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_bIdgMtp-Ed-ak6NoX_4Aeg_524968097")]
    [Description(
        @"Non US Tax Equity and Fiscal Responsibility Act (TEFRA) D certification. Non US beneficial owner certification requirement for exchange of temporary to permanent notes."
    )]
    NonUSTEFRADCertification,

    /// <summary>
    /// Announcement of a meeting at a Court.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_bIdgM9p-Ed-ak6NoX_4Aeg_525890549")]
    [Description(@"Announcement of a meeting at a Court.")]
    CourtMeeting,

    /// <summary>
    /// Procedure that aims to obtain the consent of holders, without a formal general meeting, to a proposal by the issuer or a third party.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_bIdgNNp-Ed-ak6NoX_4Aeg_525893028")]
    [Description(
        @"Procedure that aims to obtain the consent of holders, without a formal general meeting, to a proposal by the issuer or a third party."
    )]
    Consent,

    /// <summary>
    /// Company option may be granted by the company, allowing the holder to take up shares at some future date(s) at a prearranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("_bIdgNdp-Ed-ak6NoX_4Aeg_527737805")]
    [Description(
        @"Company option may be granted by the company, allowing the holder to take up shares at some future date(s) at a prearranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date."
    )]
    CompanyOption,

    /// <summary>
    /// Coupon stripping is the process whereby interest coupons for future payment dates are separated from the security corpus that entitles the holder to the principal repayment.
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_bIdgNtp-Ed-ak6NoX_4Aeg_528660286")]
    [Description(
        @"Coupon stripping is the process whereby interest coupons for future payment dates are separated from the security corpus that entitles the holder to the principal repayment."
    )]
    CouponStripping,

    /// <summary>
    /// Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_bIdgN9p-Ed-ak6NoX_4Aeg_529585588")]
    [Description(
        @"Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied."
    )]
    BondDefault,

    /// <summary>
    /// Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.
    /// Encoded/decoded by serializers as &quot;DLST&quot;.
    /// </summary>
    [EnumMember(Value = "DLST")]
    [IsoId("_bIdgONp-Ed-ak6NoX_4Aeg_530508093")]
    [Description(
        @"Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation."
    )]
    TradingStatusDelisted,

    /// <summary>
    /// Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and results are confirmed to bondholder.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_bIdgOdp-Ed-ak6NoX_4Aeg_530510263")]
    [Description(
        @"Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and results are confirmed to bondholder."
    )]
    Drawing,

    /// <summary>
    /// Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.
    /// Encoded/decoded by serializers as &quot;DSCL&quot;.
    /// </summary>
    [EnumMember(Value = "DSCL")]
    [IsoId("_bIdgOtp-Ed-ak6NoX_4Aeg_531432775")]
    [Description(
        @"Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer."
    )]
    Disclosure,

    /// <summary>
    /// Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_bImqINp-Ed-ak6NoX_4Aeg_532355196")]
    [Description(
        @"Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer."
    )]
    DutchAuction,

    /// <summary>
    /// As stipulated in a bond&apos;s terms and conditions, the issuer or the bond holder may prolong the maturity date of a bond. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder&apos;s approval.
    /// Encoded/decoded by serializers as &quot;EXTM&quot;.
    /// </summary>
    [EnumMember(Value = "EXTM")]
    [IsoId("_bImqIdp-Ed-ak6NoX_4Aeg_533280218")]
    [Description(
        @"As stipulated in a bond's terms and conditions, the issuer or the bond holder may prolong the maturity date of a bond. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder's approval."
    )]
    MaturityExtension,

    /// <summary>
    /// Increase in the face value of a single security. The number of circulating securities remains unchanged.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_bImqItp-Ed-ak6NoX_4Aeg_541589580")]
    [Description(
        @"Increase in the face value of a single security. The number of circulating securities remains unchanged."
    )]
    IncreaseInValue,

    /// <summary>
    /// Redemption of an entire issue outstanding of bonds/preferred equity by the issuer before final maturity. Also known as early redemption.
    /// Encoded/decoded by serializers as &quot;MCAL&quot;.
    /// </summary>
    [EnumMember(Value = "MCAL")]
    [IsoId("_bImqI9p-Ed-ak6NoX_4Aeg_542514821")]
    [Description(
        @"Redemption of an entire issue outstanding of bonds/preferred equity by the issuer before final maturity. Also known as early redemption."
    )]
    FullCall,

    /// <summary>
    /// General meeting taking place on annual basis.
    /// Encoded/decoded by serializers as &quot;MEET&quot;.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_bImqJNp-Ed-ak6NoX_4Aeg_543436955")]
    [Description(@"General meeting taking place on annual basis.")]
    AnnualGeneralMeeting,

    /// <summary>
    /// Ordinary general meeting.
    /// Encoded/decoded by serializers as &quot;OMET&quot;.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_bImqJdp-Ed-ak6NoX_4Aeg_544362069")]
    [Description(@"Ordinary general meeting.")]
    OrdinaryGeneralMeeting,

    /// <summary>
    /// Other event, use only when no other event type applies, for example, a new event type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bImqJtp-Ed-ak6NoX_4Aeg_545284613")]
    [Description(
        @"Other event, use only when no other event type applies, for example, a new event type."
    )]
    OtherEvent,

    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally.
    /// Encoded/decoded by serializers as &quot;PCAL&quot;.
    /// </summary>
    [EnumMember(Value = "PCAL")]
    [IsoId("_bImqJ9p-Ed-ak6NoX_4Aeg_553598112")]
    [Description(
        @"Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally."
    )]
    PartialRedemptionWithNominalValueReduction,

    /// <summary>
    /// Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("_bImqKNp-Ed-ak6NoX_4Aeg_555443714")]
    [Description(
        @"Interest payment, in any kind except cash, distributed to holders of an interest bearing asset."
    )]
    PayInKind,

    /// <summary>
    /// Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_bImqKdp-Ed-ak6NoX_4Aeg_556366402")]
    [Description(
        @"Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar."
    )]
    PlaceOfIncorporation,

    /// <summary>
    /// Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.
    /// Encoded/decoded by serializers as &quot;PPMT&quot;.
    /// </summary>
    [EnumMember(Value = "PPMT")]
    [IsoId("_bIwbINp-Ed-ak6NoX_4Aeg_557289346")]
    [Description(
        @"Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser."
    )]
    InstalmentCall,

    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date without reduction of the nominal value of the shares. This is commonly done by pool factor reduction.
    /// Encoded/decoded by serializers as &quot;PRED&quot;.
    /// </summary>
    [EnumMember(Value = "PRED")]
    [IsoId("_bIwbIdp-Ed-ak6NoX_4Aeg_557291856")]
    [Description(
        @"Securities are redeemed in part before their scheduled final maturity date without reduction of the nominal value of the shares. This is commonly done by pool factor reduction."
    )]
    PartialRedemptionWithoutNominalValueReduction,

    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;REMK&quot;.
    /// </summary>
    [EnumMember(Value = "REMK")]
    [IsoId("_bIwbItp-Ed-ak6NoX_4Aeg_560061926")]
    [Description(
        @"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders."
    )]
    RemarketingAgreement,

    /// <summary>
    /// Distribution of a security or privilege that gives the holder an entitlement or right to take part in a future event. Also known as subscription rights or rights offer.
    /// Encoded/decoded by serializers as &quot;RHTS&quot;.
    /// </summary>
    [EnumMember(Value = "RHTS")]
    [IsoId("_bIwbI9p-Ed-ak6NoX_4Aeg_561906920")]
    [Description(
        @"Distribution of a security or privilege that gives the holder an entitlement or right to take part in a future event. Also known as subscription rights or rights offer."
    )]
    RightsIssue,

    /// <summary>
    /// Corporate event that pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications.
    /// Encoded/decoded by serializers as &quot;SHPR&quot;.
    /// </summary>
    [EnumMember(Value = "SHPR")]
    [IsoId("_bIwbJNp-Ed-ak6NoX_4Aeg_561909400")]
    [Description(
        @"Corporate event that pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications."
    )]
    SharesPremiumDividend,

    /// <summary>
    /// Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_bIwbJdp-Ed-ak6NoX_4Aeg_569296560")]
    [Description(
        @"Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit."
    )]
    SmallestNegotiableUnit,

    /// <summary>
    /// Trading in the security has been suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_bIwbJtp-Ed-ak6NoX_4Aeg_570218793")]
    [Description(@"Trading in the security has been suspended.")]
    TradingStatusSuspended,

    /// <summary>
    /// Event related to tax reclaim activities.
    /// Encoded/decoded by serializers as &quot;TREC&quot;.
    /// </summary>
    [EnumMember(Value = "TREC")]
    [IsoId("_bIwbJ9p-Ed-ak6NoX_4Aeg_570221606")]
    [Description(@"Event related to tax reclaim activities.")]
    TaxReclaim,

    /// <summary>
    /// Booking out of valueless securities.
    /// Encoded/decoded by serializers as &quot;WRTH&quot;.
    /// </summary>
    [EnumMember(Value = "WRTH")]
    [IsoId("_bIwbKNp-Ed-ak6NoX_4Aeg_571144179")]
    [Description(@"Booking out of valueless securities.")]
    Worthless,

    /// <summary>
    /// Certification request for withholding tax reduction or exemption based on the tax status of the holder.
    /// Encoded/decoded by serializers as &quot;WTRC&quot;.
    /// </summary>
    [EnumMember(Value = "WTRC")]
    [IsoId("_bIwbKdp-Ed-ak6NoX_4Aeg_572066630")]
    [Description(
        @"Certification request for withholding tax reduction or exemption based on the tax status of the holder."
    )]
    WithholdingTaxReliefCertification,

    /// <summary>
    /// Extraordinary or special general meeting.
    /// Encoded/decoded by serializers as &quot;XMET&quot;.
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_bI6MINp-Ed-ak6NoX_4Aeg_572989173")]
    [Description(@"Extraordinary or special general meeting.")]
    ExtraordinaryGeneralMeeting,

    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("_bI6MIdp-Ed-ak6NoX_4Aeg_1473423027")]
    [Description(
        @"Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency."
    )]
    Redenomination,

    /// <summary>
    /// Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_bI6MItp-Ed-ak6NoX_4Aeg_1529759857")]
    [Description(
        @"Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security."
    )]
    LiquidationDividend,

    /// <summary>
    /// Event is an option for the shareholders to exchange their securities for other securities and/or cash. Exchange options are mentioned in the terms and conditions of a security and are valid during the whole lifetime of a security.
    /// Encoded/decoded by serializers as &quot;EXOP&quot;.
    /// </summary>
    [EnumMember(Value = "EXOP")]
    [IsoId("_bI6MI9p-Ed-ak6NoX_4Aeg_1958271125")]
    [Description(
        @"Event is an option for the shareholders to exchange their securities for other securities and/or cash. Exchange options are mentioned in the terms and conditions of a security and are valid during the whole lifetime of a security."
    )]
    ExchangeOption,

    /// <summary>
    /// Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, for example, capitalisation, and negative amortisation.
    /// Encoded/decoded by serializers as &quot;CAPI&quot;.
    /// </summary>
    [EnumMember(Value = "CAPI")]
    [IsoId("_bI6MJNp-Ed-ak6NoX_4Aeg_2105501315")]
    [Description(
        @"Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, for example, capitalisation, and negative amortisation."
    )]
    Capitalisation,
}
