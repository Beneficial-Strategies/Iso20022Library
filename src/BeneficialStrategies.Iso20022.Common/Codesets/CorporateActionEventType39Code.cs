// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sh9E8Y-fEe-PVZsedaAGaA")]
[Description(@"Specifies the corporate action event type.")]
[DerivedFrom(typeof(CorporateActionEventTypeV7Code))]
public enum CorporateActionEventType39Code
{
    /// <summary>
    /// Trading in the security has commenced or security has been re-activated after a suspension in trading.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("")]
    [Description(@"Trading in the security has commenced or security has been re-activated after a suspension in trading.")]
    ActiveTradingStatus = CorporateActionEventTypeV7Code.ActiveTradingStatus, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Combination of different security types to create a unit. Units are usually comprised of warrants and bonds or warrants and equities. Securities may be combined at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;ATTI&quot;.
    /// </summary>
    [EnumMember(Value = "ATTI")]
    [IsoId("")]
    [Description(@"Combination of different security types to create a unit. Units are usually comprised of warrants and bonds or warrants and equities. Securities may be combined at the request of the security holder or based on market convention.")]
    Attachment = CorporateActionEventTypeV7Code.Attachment, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Repurchase offer / issuer bid / reverse rights. Offer to existing holders by the issuing company to repurchase its own securities. The objective of the offer is to reduce the number of outstanding securities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("")]
    [Description(@"Repurchase offer / issuer bid / reverse rights. Offer to existing holders by the issuing company to repurchase its own securities. The objective of the offer is to reduce the number of outstanding securities.")]
    RepurchaseOffer = CorporateActionEventTypeV7Code.RepurchaseOffer, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Bonus or capitalisation issue. Security holders receive additional assets free of payment from the issuer, in proportion to their holding.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("")]
    [Description(@"Bonus or capitalisation issue. Security holders receive additional assets free of payment from the issuer, in proportion to their holding.")]
    BonusIssue = CorporateActionEventTypeV7Code.BonusIssue, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Early redemption of a security at the election of the holder subject to the terms and condition of the issue with no reduction in nominal value.
    /// Encoded/decoded by serializers as &quot;BPUT&quot;.
    /// </summary>
    [EnumMember(Value = "BPUT")]
    [IsoId("")]
    [Description(@"Early redemption of a security at the election of the holder subject to the terms and condition of the issue with no reduction in nominal value.")]
    PutRedemption = CorporateActionEventTypeV7Code.PutRedemption, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.
    /// Encoded/decoded by serializers as &quot;BRUP&quot;.
    /// </summary>
    [EnumMember(Value = "BRUP")]
    [IsoId("")]
    [Description(@"Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.")]
    Bankruptcy = CorporateActionEventTypeV7Code.Bankruptcy, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Corporate event pays shareholders an amount in cash issued from the capital account. There is no reduction to the face value of a single share (or the share has no par value). The number of circulating shares remains unchanged.
    /// Encoded/decoded by serializers as &quot;CAPD&quot;.
    /// </summary>
    [EnumMember(Value = "CAPD")]
    [IsoId("")]
    [Description(@"Corporate event pays shareholders an amount in cash issued from the capital account. There is no reduction to the face value of a single share (or the share has no par value). The number of circulating shares remains unchanged.")]
    CapitalDistribution = CorporateActionEventTypeV7Code.CapitalDistribution, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or SICAVs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("")]
    [Description(@"Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or SICAVs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.")]
    CapitalGainsDistribution = CorporateActionEventTypeV7Code.CapitalGainsDistribution, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, for example, capitalisation, and negative amortisation.
    /// Encoded/decoded by serializers as &quot;CAPI&quot;.
    /// </summary>
    [EnumMember(Value = "CAPI")]
    [IsoId("")]
    [Description(@"Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, for example, capitalisation, and negative amortisation.")]
    Capitalisation = CorporateActionEventTypeV7Code.Capitalisation, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Non-US beneficial owner certification requirement for exchange of temporary to permanent notes.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("")]
    [Description(@"Non-US beneficial owner certification requirement for exchange of temporary to permanent notes.")]
    NonUSTEFRADCertification = CorporateActionEventTypeV7Code.NonUSTEFRADCertification, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Information regarding a change further described in the corporate action details.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("")]
    [Description(@"Information regarding a change further described in the corporate action details.")]
    Change = CorporateActionEventTypeV7Code.Change, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.
    /// Encoded/decoded by serializers as &quot;CLSA&quot;.
    /// </summary>
    [EnumMember(Value = "CLSA")]
    [IsoId("")]
    [Description(@"Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.")]
    ClassActionProposedSettlement = CorporateActionEventTypeV7Code.ClassActionProposedSettlement, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting. For example, consent to change the terms of a bond.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("")]
    [Description(@"Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting. For example, consent to change the terms of a bond.")]
    Consent = CorporateActionEventTypeV7Code.Consent, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Conversion of securities (generally convertible bonds or preferred shares) into another form of securities (usually common shares) at a pre-stated price/ratio.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("")]
    [Description(@"Conversion of securities (generally convertible bonds or preferred shares) into another form of securities (usually common shares) at a pre-stated price/ratio.")]
    Conversion = CorporateActionEventTypeV7Code.Conversion, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Company option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("")]
    [Description(@"Company option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.")]
    CompanyOption = CorporateActionEventTypeV7Code.CompanyOption, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations (as defined in terms and conditions).
    /// Encoded/decoded by serializers as &quot;CREV&quot;.
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("")]
    [Description(@"Occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations (as defined in terms and conditions).")]
    CreditEvent = CorporateActionEventTypeV7Code.CreditEvent, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Reduction of face value of a single share or the value of fund assets. The number of circulating shares/units remains unchanged. This event may include a cash payout to holders.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("")]
    [Description(@"Reduction of face value of a single share or the value of fund assets. The number of circulating shares/units remains unchanged. This event may include a cash payout to holders.")]
    DecreaseInValue = CorporateActionEventTypeV7Code.DecreaseInValue, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Separation of components that comprise a security, for example, usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;DETI&quot;.
    /// </summary>
    [EnumMember(Value = "DETI")]
    [IsoId("")]
    [Description(@"Separation of components that comprise a security, for example, usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.")]
    Detachment = CorporateActionEventTypeV7Code.Detachment, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("")]
    [Description(@"Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.")]
    BondDefault = CorporateActionEventTypeV7Code.BondDefault, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.
    /// Encoded/decoded by serializers as &quot;DLST&quot;.
    /// </summary>
    [EnumMember(Value = "DLST")]
    [IsoId("")]
    [Description(@"Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.")]
    TradingStatusDelisted = CorporateActionEventTypeV7Code.TradingStatusDelisted, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Securities are redeemed in part before the scheduled final maturity date. It is done without any pool factor reduction. The redemption is reflected in a debit of the face amount (FAMT). Drawing is distinct from partial call since drawn bonds are chosen by lottery. Therefore, not every holder is affected in the same way.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("")]
    [Description(@"Securities are redeemed in part before the scheduled final maturity date. It is done without any pool factor reduction. The redemption is reflected in a debit of the face amount (FAMT). Drawing is distinct from partial call since drawn bonds are chosen by lottery. Therefore, not every holder is affected in the same way.")]
    Drawing = CorporateActionEventTypeV7Code.Drawing, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Distribution to shareholders of cash resulting from the selling of non-eligible securities, for example, in the frame of a depositary receipt program.
    /// Encoded/decoded by serializers as &quot;DRCA&quot;.
    /// </summary>
    [EnumMember(Value = "DRCA")]
    [IsoId("")]
    [Description(@"Distribution to shareholders of cash resulting from the selling of non-eligible securities, for example, in the frame of a depositary receipt program.")]
    CashDistributionFromNonEligibleSecuritiesSales = CorporateActionEventTypeV7Code.CashDistributionFromNonEligibleSecuritiesSales, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares in the issuing company. To be distinguished from DVOP as the company invests the dividend in the market rather than creating new share capital in exchange for the dividend.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("")]
    [Description(@"Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares in the issuing company. To be distinguished from DVOP as the company invests the dividend in the market rather than creating new share capital in exchange for the dividend.")]
    DividendReinvestment = CorporateActionEventTypeV7Code.DividendReinvestment, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.
    /// Encoded/decoded by serializers as &quot;DSCL&quot;.
    /// </summary>
    [EnumMember(Value = "DSCL")]
    [IsoId("")]
    [Description(@"Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.")]
    Disclosure = CorporateActionEventTypeV7Code.Disclosure, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("")]
    [Description(@"Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.")]
    DutchAuction = CorporateActionEventTypeV7Code.DutchAuction, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Distribution of cash to holders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Holder must take cash and may be offered a choice of currencies.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("")]
    [Description(@"Distribution of cash to holders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Holder must take cash and may be offered a choice of currencies.")]
    CashDividend = CorporateActionEventTypeV7Code.CashDividend, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Distribution of a dividend to holders with a choice of benefit to receive additional securities or cash. To be distinguished from DRIP as the company creates new share capital in exchange for the dividend rather than investing the dividend in the market.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("")]
    [Description(@"Distribution of a dividend to holders with a choice of benefit to receive additional securities or cash. To be distinguished from DRIP as the company creates new share capital in exchange for the dividend rather than investing the dividend in the market.")]
    DividendOption = CorporateActionEventTypeV7Code.DividendOption, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividend = CorporateActionEventTypeV7Code.ScripDividend, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Dividend paid to shareholders in the form of equities of the issuing corporation.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("")]
    [Description(@"Dividend paid to shareholders in the form of equities of the issuing corporation.")]
    StockDividend = CorporateActionEventTypeV7Code.StockDividend, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example &quot;exchange offer&quot;, &quot;capital reorganisation&quot; or &quot;funds separation&quot;.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("")]
    [Description(@"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation"".")]
    Exchange = CorporateActionEventTypeV7Code.Exchange, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities' issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("")]
    [Description(@"Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities' issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.")]
    CallOnIntermediateSecurities = CorporateActionEventTypeV7Code.CallOnIntermediateSecurities, // same ordinal as derivation source for type conversions


    /// <summary>
    /// As stipulated in the security's Terms and Conditions, the issuer or the holder may prolong the maturity date of a security. After extension, the security details may differ from the original issue. An issuer initiated extension may be subject to holder's approval.
    /// Encoded/decoded by serializers as &quot;EXTM&quot;.
    /// </summary>
    [EnumMember(Value = "EXTM")]
    [IsoId("")]
    [Description(@"As stipulated in the security's Terms and Conditions, the issuer or the holder may prolong the maturity date of a security. After extension, the security details may differ from the original issue. An issuer initiated extension may be subject to holder's approval.")]
    MaturityExtension = CorporateActionEventTypeV7Code.MaturityExtension, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).
    /// Encoded/decoded by serializers as &quot;EXWA&quot;.
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("")]
    [Description(@"Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).")]
    WarrantExercise = CorporateActionEventTypeV7Code.WarrantExercise, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Increase in the face value of a single security. The number of circulating securities remains unchanged.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("")]
    [Description(@"Increase in the face value of a single security. The number of circulating securities remains unchanged.")]
    IncreaseInValue = CorporateActionEventTypeV7Code.IncreaseInValue, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment = CorporateActionEventTypeV7Code.InterestPayment, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("")]
    [Description(@"Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.")]
    LiquidationDividend = CorporateActionEventTypeV7Code.LiquidationDividend, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Redemption of an entire issue outstanding of securities, for example, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager, before final maturity.
    /// Encoded/decoded by serializers as &quot;MCAL&quot;.
    /// </summary>
    [EnumMember(Value = "MCAL")]
    [IsoId("")]
    [Description(@"Redemption of an entire issue outstanding of securities, for example, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager, before final maturity.")]
    FullCall = CorporateActionEventTypeV7Code.FullCall, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("")]
    [Description(@"Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.")]
    Merger = CorporateActionEventTypeV7Code.Merger, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Offers that are not supervised or regulated by an official entity and being offered by a party, for example a broker, usually at a discount price, for example broker offer, mini-tender, mini odd lot offer or third party offer.
    /// Encoded/decoded by serializers as &quot;NOOF&quot;.
    /// </summary>
    [EnumMember(Value = "NOOF")]
    [IsoId("")]
    [Description(@"Offers that are not supervised or regulated by an official entity and being offered by a party, for example a broker, usually at a discount price, for example broker offer, mini-tender, mini odd lot offer or third party offer.")]
    NonOfficialOffer = CorporateActionEventTypeV7Code.NonOfficialOffer, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Sale or purchase of odd-lots to/from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("")]
    [Description(@"Sale or purchase of odd-lots to/from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.")]
    OddLotSalePurchase = CorporateActionEventTypeV7Code.OddLotSalePurchase, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Other event, use only when no other event type applies, for example, a new event type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("")]
    [Description(@"Other event, use only when no other event type applies, for example, a new event type.")]
    OtherEvent = CorporateActionEventTypeV7Code.OtherEvent, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Occurs when securities with different characteristics, for example, shares with different entitlements to dividend or voting rights, become identical in all respects, for example, pari-passu or assimilation. May be scheduled in advance, for example, shares resulting from a bonus may become fungible after a pre-set period of time, or may result from outside events, for example, merger, reorganisation, issue of supplementary tranches.
    /// Encoded/decoded by serializers as &quot;PARI&quot;.
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("")]
    [Description(@"Occurs when securities with different characteristics, for example, shares with different entitlements to dividend or voting rights, become identical in all respects, for example, pari-passu or assimilation. May be scheduled in advance, for example, shares resulting from a bonus may become fungible after a pre-set period of time, or may result from outside events, for example, merger, reorganisation, issue of supplementary tranches.")]
    PariPassu = CorporateActionEventTypeV7Code.PariPassu, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date. It is done without any pool factor reduction. The redemption is reflected in a debit of the face amount (FAMT).
    /// Encoded/decoded by serializers as &quot;PCAL&quot;.
    /// </summary>
    [EnumMember(Value = "PCAL")]
    [IsoId("")]
    [Description(@"Securities are redeemed in part before their scheduled final maturity date. It is done without any pool factor reduction. The redemption is reflected in a debit of the face amount (FAMT).")]
    PartialRedemptionWithoutPoolFactorReduction = CorporateActionEventTypeV7Code.PartialRedemptionWithoutPoolFactorReduction, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("")]
    [Description(@"Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.")]
    Prefunding = CorporateActionEventTypeV7Code.Prefunding, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("")]
    [Description(@"Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.")]
    PayInKind = CorporateActionEventTypeV7Code.PayInKind, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("")]
    [Description(@"Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.")]
    PlaceOfIncorporation = CorporateActionEventTypeV7Code.PlaceOfIncorporation, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.
    /// Encoded/decoded by serializers as &quot;PPMT&quot;.
    /// </summary>
    [EnumMember(Value = "PPMT")]
    [IsoId("")]
    [Description(@"Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.")]
    InstalmentCall = CorporateActionEventTypeV7Code.InstalmentCall, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date. The redemption is reflected in a pool factor reduction. No movement of securities occurs.
    /// Encoded/decoded by serializers as &quot;PRED&quot;.
    /// </summary>
    [EnumMember(Value = "PRED")]
    [IsoId("")]
    [Description(@"Securities are redeemed in part before their scheduled final maturity date. The redemption is reflected in a pool factor reduction. No movement of securities occurs.")]
    PartialRedemptionWithPoolFactorReduction = CorporateActionEventTypeV7Code.PartialRedemptionWithPoolFactorReduction, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("")]
    [Description(@"Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.")]
    PriorityIssue = CorporateActionEventTypeV7Code.PriorityIssue, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Redemption of an entire issue outstanding of securities, for example, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager, at final maturity.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("")]
    [Description(@"Redemption of an entire issue outstanding of securities, for example, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager, at final maturity.")]
    FinalMaturity = CorporateActionEventTypeV7Code.FinalMaturity, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("")]
    [Description(@"Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency.")]
    Redenomination = CorporateActionEventTypeV7Code.Redenomination, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;REMK&quot;.
    /// </summary>
    [EnumMember(Value = "REMK")]
    [IsoId("")]
    [Description(@"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.")]
    RemarketingAgreement = CorporateActionEventTypeV7Code.RemarketingAgreement, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Distribution of intermediate securities that gives the holder the right to take part in a future event.
    /// Encoded/decoded by serializers as &quot;RHDI&quot;.
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("")]
    [Description(@"Distribution of intermediate securities that gives the holder the right to take part in a future event.")]
    IntermediateSecuritiesDistribution = CorporateActionEventTypeV7Code.IntermediateSecuritiesDistribution, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Offer to holders of a security to subscribe for additional securities via the distribution of an intermediate security. Both processes are included in the same event.
    /// Encoded/decoded by serializers as &quot;RHTS&quot;.
    /// </summary>
    [EnumMember(Value = "RHTS")]
    [IsoId("")]
    [Description(@"Offer to holders of a security to subscribe for additional securities via the distribution of an intermediate security. Both processes are included in the same event.")]
    RightsIssue = CorporateActionEventTypeV7Code.RightsIssue, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Corporate event pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications.
    /// Encoded/decoded by serializers as &quot;SHPR&quot;.
    /// </summary>
    [EnumMember(Value = "SHPR")]
    [IsoId("")]
    [Description(@"Corporate event pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications.")]
    SharesPremiumDividend = CorporateActionEventTypeV7Code.SharesPremiumDividend, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("")]
    [Description(@"Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.")]
    SmallestNegotiableUnit = CorporateActionEventTypeV7Code.SmallestNegotiableUnit, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Distribution of securities issued by another company. The distributed securities may either be of a newly created or of an existing company. For example, spin-off, demerger, unbundling, divestment.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("")]
    [Description(@"Distribution of securities issued by another company. The distributed securities may either be of a newly created or of an existing company. For example, spin-off, demerger, unbundling, divestment.")]
    SpinOff = CorporateActionEventTypeV7Code.SpinOff, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Increase in a corporation's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("")]
    [Description(@"Increase in a corporation's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.")]
    StockSplit = CorporateActionEventTypeV7Code.StockSplit, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Decrease in a company's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are increased accordingly.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("")]
    [Description(@"Decrease in a company's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are increased accordingly.")]
    ReverseStockSplit = CorporateActionEventTypeV7Code.ReverseStockSplit, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Trading in the security has been suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("")]
    [Description(@"Trading in the security has been suspended.")]
    TradingStatusSuspended = CorporateActionEventTypeV7Code.TradingStatusSuspended, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Offer made to holders by a third party, requesting them to sell (tender) or exchange their securities.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("")]
    [Description(@"Offer made to holders by a third party, requesting them to sell (tender) or exchange their securities.")]
    Tender = CorporateActionEventTypeV7Code.Tender, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Event related to tax reclaim activities.
    /// Encoded/decoded by serializers as &quot;TREC&quot;.
    /// </summary>
    [EnumMember(Value = "TREC")]
    [IsoId("")]
    [Description(@"Event related to tax reclaim activities.")]
    TaxReclaim = CorporateActionEventTypeV7Code.TaxReclaim, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Booking out of valueless securities.
    /// Encoded/decoded by serializers as &quot;WRTH&quot;.
    /// </summary>
    [EnumMember(Value = "WRTH")]
    [IsoId("")]
    [Description(@"Booking out of valueless securities.")]
    Worthless = CorporateActionEventTypeV7Code.Worthless, // same ordinal as derivation source for type conversions


    /// <summary>
    /// Certification process for withholding tax reduction or exemption based on the tax status of the holder.
    /// Encoded/decoded by serializers as &quot;WTRC&quot;.
    /// </summary>
    [EnumMember(Value = "WTRC")]
    [IsoId("")]
    [Description(@"Certification process for withholding tax reduction or exemption based on the tax status of the holder.")]
    WithholdingTaxReliefCertification = CorporateActionEventTypeV7Code.WithholdingTaxReliefCertification, // same ordinal as derivation source for type conversions

}
