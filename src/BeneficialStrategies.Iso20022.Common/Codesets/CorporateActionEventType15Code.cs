// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U_mfIGOAEeW4z96Yfj3Wng")]
[Description(@"Specifies the corporate action event type.")]
[DerivedFrom(typeof(CorporateActionEventTypeV5Code))]
public enum CorporateActionEventType15Code
{
    /// <summary>
    /// Trading in security has commenced or security has been re-activated after a suspension in trading.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_iYtOQWOAEeW4z96Yfj3Wng")]
    [Description(@"Trading in security has commenced or security has been re-activated after a suspension in trading.")]
    ActiveTradingStatus = CorporateActionEventTypeV5Code.ActiveTradingStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of different security types to create a unit. Units are usually comprised of warrants and bonds or warrants and equities. Securities may be combined at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;ATTI&quot;.
    /// </summary>
    [EnumMember(Value = "ATTI")]
    [IsoId("_ilH5oWOAEeW4z96Yfj3Wng")]
    [Description(@"Combination of different security types to create a unit. Units are usually comprised of warrants and bonds or warrants and equities. Securities may be combined at the request of the security holder or based on market convention.")]
    Attachment = CorporateActionEventTypeV5Code.Attachment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.
    /// Encoded/decoded by serializers as &quot;BRUP&quot;.
    /// </summary>
    [EnumMember(Value = "BRUP")]
    [IsoId("_irDigWOAEeW4z96Yfj3Wng")]
    [Description(@"Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.")]
    Bankruptcy = CorporateActionEventTypeV5Code.Bankruptcy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_is9nAWOAEeW4z96Yfj3Wng")]
    [Description(@"Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.")]
    BondDefault = CorporateActionEventTypeV5Code.BondDefault, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bonus or capitalisation issue. Security holders receive additional assets free of payment from the issuer, in proportion to their holding.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_i1QnYWOAEeW4z96Yfj3Wng")]
    [Description(@"Bonus or capitalisation issue. Security holders receive additional assets free of payment from the issuer, in proportion to their holding.")]
    BonusIssue = CorporateActionEventTypeV5Code.BonusIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities&apos; issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_i3MhEWOAEeW4z96Yfj3Wng")]
    [Description(@"Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities' issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.")]
    CallOnIntermediateSecurities = CorporateActionEventTypeV5Code.CallOnIntermediateSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate event pays shareholders an amount in cash issued from the Capital account. There is no reduction to the face value of a single share (or the share has no par value). The number of circulating shares remains unchanged.
    /// Encoded/decoded by serializers as &quot;CAPD&quot;.
    /// </summary>
    [EnumMember(Value = "CAPD")]
    [IsoId("_jCRvsWOAEeW4z96Yfj3Wng")]
    [Description(@"Corporate event pays shareholders an amount in cash issued from the Capital account. There is no reduction to the face value of a single share (or the share has no par value). The number of circulating shares remains unchanged.")]
    CapitalDistribution = CorporateActionEventTypeV5Code.CapitalDistribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_jEL0MWOAEeW4z96Yfj3Wng")]
    [Description(@"Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.")]
    CapitalGainsDistribution = CorporateActionEventTypeV5Code.CapitalGainsDistribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, for example, capitalisation, and negative amortisation.
    /// Encoded/decoded by serializers as &quot;CAPI&quot;.
    /// </summary>
    [EnumMember(Value = "CAPI")]
    [IsoId("_jKCkkWOAEeW4z96Yfj3Wng")]
    [Description(@"Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, for example, capitalisation, and negative amortisation.")]
    Capitalisation = CorporateActionEventTypeV5Code.Capitalisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution to shareholders of cash resulting from the selling of non-eligible securities, for example, in the frame of a depositary receipt program.
    /// Encoded/decoded by serializers as &quot;DRCA&quot;.
    /// </summary>
    [EnumMember(Value = "DRCA")]
    [IsoId("_jOnikWOAEeW4z96Yfj3Wng")]
    [Description(@"Distribution to shareholders of cash resulting from the selling of non-eligible securities, for example, in the frame of a depositary receipt program.")]
    CashDistributionFromNonEligibleSecuritiesSales = CorporateActionEventTypeV5Code.CashDistributionFromNonEligibleSecuritiesSales, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_jVYR4WOAEeW4z96Yfj3Wng")]
    [Description(@"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.")]
    CashDividend = CorporateActionEventTypeV5Code.CashDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information regarding a change further described in the corporate action details.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_jXVZsGOAEeW4z96Yfj3Wng")]
    [Description(@"Information regarding a change further described in the corporate action details.")]
    Change = CorporateActionEventTypeV5Code.Change, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.
    /// Encoded/decoded by serializers as &quot;CLSA&quot;.
    /// </summary>
    [EnumMember(Value = "CLSA")]
    [IsoId("_jdIfsWOAEeW4z96Yfj3Wng")]
    [Description(@"Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.")]
    ClassActionProposedSettlement = CorporateActionEventTypeV5Code.ClassActionProposedSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Company Option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("_jqkewWOAEeW4z96Yfj3Wng")]
    [Description(@"Company Option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.")]
    CompanyOption = CorporateActionEventTypeV5Code.CompanyOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting. For example, consent to change the terms of a bond.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_jvYGQWOAEeW4z96Yfj3Wng")]
    [Description(@"Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting. For example, consent to change the terms of a bond.")]
    Consent = CorporateActionEventTypeV5Code.Consent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conversion of securities ( generally convertible bonds or preferred shares) into another form of securities ( usually common shares) at a pre-stated price/ratio.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_j1J-IWOAEeW4z96Yfj3Wng")]
    [Description(@"Conversion of securities ( generally convertible bonds or preferred shares) into another form of securities ( usually common shares) at a pre-stated price/ratio.")]
    Conversion = CorporateActionEventTypeV5Code.Conversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations (as defined in terms and conditions).
    /// Encoded/decoded by serializers as &quot;CREV&quot;.
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("_k6OIwWOAEeW4z96Yfj3Wng")]
    [Description(@"Occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations (as defined in terms and conditions).")]
    CreditEvent = CorporateActionEventTypeV5Code.CreditEvent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reduction of face value of a single share or the value of fund assets. The number of circulating shares/units remains unchanged. This event may include a cash payout to holders.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_k-lrYWOAEeW4z96Yfj3Wng")]
    [Description(@"Reduction of face value of a single share or the value of fund assets. The number of circulating shares/units remains unchanged. This event may include a cash payout to holders.")]
    DecreaseInValue = CorporateActionEventTypeV5Code.DecreaseInValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Separation of components that comprise a security, for example, usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;DETI&quot;.
    /// </summary>
    [EnumMember(Value = "DETI")]
    [IsoId("_mKBjwWOAEeW4z96Yfj3Wng")]
    [Description(@"Separation of components that comprise a security, for example, usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.")]
    Detachment = CorporateActionEventTypeV5Code.Detachment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.
    /// Encoded/decoded by serializers as &quot;DSCL&quot;.
    /// </summary>
    [EnumMember(Value = "DSCL")]
    [IsoId("_mSMoUWOAEeW4z96Yfj3Wng")]
    [Description(@"Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.")]
    Disclosure = CorporateActionEventTypeV5Code.Disclosure, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of a dividend to shareholders with a choice of benefit to receive. Shareholders may choose to receive shares or cash. To be distinguished from DRIP as the company creates new share capital in exchange for the dividend rather than investing the dividend in the market.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_mW0poWOAEeW4z96Yfj3Wng")]
    [Description(@"Distribution of a dividend to shareholders with a choice of benefit to receive. Shareholders may choose to receive shares or cash. To be distinguished from DRIP as the company creates new share capital in exchange for the dividend rather than investing the dividend in the market.")]
    DividendOption = CorporateActionEventTypeV5Code.DividendOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares in the issuing company. To be distinguished from DVOP as the company invests the dividend in the market rather than creating new share capital in exchange for the dividend.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_mct2QWOAEeW4z96Yfj3Wng")]
    [Description(@"Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares in the issuing company. To be distinguished from DVOP as the company invests the dividend in the market rather than creating new share capital in exchange for the dividend.")]
    DividendReinvestment = CorporateActionEventTypeV5Code.DividendReinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_mk9zUWOAEeW4z96Yfj3Wng")]
    [Description(@"Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value.")]
    Drawing = CorporateActionEventTypeV5Code.Drawing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_mqpkkWOAEeW4z96Yfj3Wng")]
    [Description(@"Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.")]
    DutchAuction = CorporateActionEventTypeV5Code.DutchAuction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example &quot;exchange offer&quot;, &quot;capital reorganisation&quot; or &quot;funds separation&quot;.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_n-OFQWOAEeW4z96Yfj3Wng")]
    [Description(@"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation"".")]
    Exchange = CorporateActionEventTypeV5Code.Exchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager, at final maturity.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_qBkdEWOAEeW4z96Yfj3Wng")]
    [Description(@"Redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager, at final maturity.")]
    FinalMaturity = CorporateActionEventTypeV5Code.FinalMaturity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager,before final maturity.
    /// Encoded/decoded by serializers as &quot;MCAL&quot;.
    /// </summary>
    [EnumMember(Value = "MCAL")]
    [IsoId("_qJ1BMWOAEeW4z96Yfj3Wng")]
    [Description(@"Redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager,before final maturity.")]
    FullCall = CorporateActionEventTypeV5Code.FullCall, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Increase in the face value of a single security. The number of circulating securities remains unchanged.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_qLvFsWOAEeW4z96Yfj3Wng")]
    [Description(@"Increase in the face value of a single security. The number of circulating securities remains unchanged.")]
    IncreaseInValue = CorporateActionEventTypeV5Code.IncreaseInValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.
    /// Encoded/decoded by serializers as &quot;PPMT&quot;.
    /// </summary>
    [EnumMember(Value = "PPMT")]
    [IsoId("_qZ1MEWOAEeW4z96Yfj3Wng")]
    [Description(@"Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.")]
    InstalmentCall = CorporateActionEventTypeV5Code.InstalmentCall, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_qbv3oWOAEeW4z96Yfj3Wng")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment = CorporateActionEventTypeV5Code.InterestPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event which consists of two components, the decrease of the amortized value of a pool factor security and an interest payment.
    /// Encoded/decoded by serializers as &quot;PRII&quot;.
    /// </summary>
    [EnumMember(Value = "PRII")]
    [IsoId("_qgmicWOAEeW4z96Yfj3Wng")]
    [Description(@"Event which consists of two components, the decrease of the amortized value of a pool factor security and an interest payment.")]
    InterestPaymentWithPrincipal = CorporateActionEventTypeV5Code.InterestPaymentWithPrincipal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of intermediate securities that gives the holder the right to take part in a future event.
    /// Encoded/decoded by serializers as &quot;RHDI&quot;.
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("_qmUI4WOAEeW4z96Yfj3Wng")]
    [Description(@"Distribution of intermediate securities that gives the holder the right to take part in a future event.")]
    IntermediateSecuritiesDistribution = CorporateActionEventTypeV5Code.IntermediateSecuritiesDistribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_qycgYWOAEeW4z96Yfj3Wng")]
    [Description(@"Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.")]
    LiquidationDividend = CorporateActionEventTypeV5Code.LiquidationDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// As stipulated in a bond&apos;s Terms and Conditions, the issuer or the bond-holder may prolong the maturity date of a bond. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder&apos;s approval.
    /// Encoded/decoded by serializers as &quot;EXTM&quot;.
    /// </summary>
    [EnumMember(Value = "EXTM")]
    [IsoId("_q4L8AWOAEeW4z96Yfj3Wng")]
    [Description(@"As stipulated in a bond's Terms and Conditions, the issuer or the bond-holder may prolong the maturity date of a bond. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder's approval.")]
    MaturityExtension = CorporateActionEventTypeV5Code.MaturityExtension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_q-BeQWOAEeW4z96Yfj3Wng")]
    [Description(@"Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.")]
    Merger = CorporateActionEventTypeV5Code.Merger, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offers that are not supervised or regulated by an official entity and being offered by a party, for example a broker, usually at a discount price, for example broker offer, mini-tender, mini odd lot offer or third party offer.
    /// Encoded/decoded by serializers as &quot;NOOF&quot;.
    /// </summary>
    [EnumMember(Value = "NOOF")]
    [IsoId("_rITboWOAEeW4z96Yfj3Wng")]
    [Description(@"Offers that are not supervised or regulated by an official entity and being offered by a party, for example a broker, usually at a discount price, for example broker offer, mini-tender, mini odd lot offer or third party offer.")]
    NonOfficialOffer = CorporateActionEventTypeV5Code.NonOfficialOffer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non-US beneficial owner certification requirement for exchange of temporary to permanent notes.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_ry9iMWOAEeW4z96Yfj3Wng")]
    [Description(@"Non-US beneficial owner certification requirement for exchange of temporary to permanent notes.")]
    NonUSTEFRADCertification = CorporateActionEventTypeV5Code.NonUSTEFRADCertification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sale or purchase of odd-lots to/from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_r3ZWQWOAEeW4z96Yfj3Wng")]
    [Description(@"Sale or purchase of odd-lots to/from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.")]
    OddLotSalePurchase = CorporateActionEventTypeV5Code.OddLotSalePurchase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other event, use only when no other event type applies, for example, a new event type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_r_PqsWOAEeW4z96Yfj3Wng")]
    [Description(@"Other event, use only when no other event type applies, for example, a new event type.")]
    OtherEvent = CorporateActionEventTypeV5Code.OtherEvent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Occurs when securities with different characteristics, for example, shares with different entitlements to dividend or voting rights, become identical in all respects, for example, pari-passu or assimilation. May be scheduled in advance, for example, shares resulting from a bonus may become fungible after a pre-set period of time, or may result from outside events, for example, merger, reorganisation, issue of supplementary tranches.
    /// Encoded/decoded by serializers as &quot;PARI&quot;.
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_sDxlYWOAEeW4z96Yfj3Wng")]
    [Description(@"Occurs when securities with different characteristics, for example, shares with different entitlements to dividend or voting rights, become identical in all respects, for example, pari-passu or assimilation. May be scheduled in advance, for example, shares resulting from a bonus may become fungible after a pre-set period of time, or may result from outside events, for example, merger, reorganisation, issue of supplementary tranches.")]
    PariPassu = CorporateActionEventTypeV5Code.PariPassu, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally.
    /// Encoded/decoded by serializers as &quot;PCAL&quot;.
    /// </summary>
    [EnumMember(Value = "PCAL")]
    [IsoId("_sJtOQWOAEeW4z96Yfj3Wng")]
    [Description(@"Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally.")]
    PartialRedemptionWithNominalValueReduction = CorporateActionEventTypeV5Code.PartialRedemptionWithNominalValueReduction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date without reduction of the nominal value of the shares. This is commonly done by pool factor reduction.
    /// Encoded/decoded by serializers as &quot;PRED&quot;.
    /// </summary>
    [EnumMember(Value = "PRED")]
    [IsoId("_sPoQEWOAEeW4z96Yfj3Wng")]
    [Description(@"Securities are redeemed in part before their scheduled final maturity date without reduction of the nominal value of the shares. This is commonly done by pool factor reduction.")]
    PartialRedemptionWithoutNominalValueReduction = CorporateActionEventTypeV5Code.PartialRedemptionWithoutNominalValueReduction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("_sRkw0WOAEeW4z96Yfj3Wng")]
    [Description(@"Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.")]
    PayInKind = CorporateActionEventTypeV5Code.PayInKind, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_sXcIQWOAEeW4z96Yfj3Wng")]
    [Description(@"Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.")]
    PlaceOfIncorporation = CorporateActionEventTypeV5Code.PlaceOfIncorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_skHSUWOAEeW4z96Yfj3Wng")]
    [Description(@"Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.")]
    Prefunding = CorporateActionEventTypeV5Code.Prefunding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_sxmUsWOAEeW4z96Yfj3Wng")]
    [Description(@"Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.")]
    PriorityIssue = CorporateActionEventTypeV5Code.PriorityIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Early redemption of a security at the election of the holder subject to the terms and condition of the issue with no reduction in nominal value.
    /// Encoded/decoded by serializers as &quot;BPUT&quot;.
    /// </summary>
    [EnumMember(Value = "BPUT")]
    [IsoId("_s5yAUWOAEeW4z96Yfj3Wng")]
    [Description(@"Early redemption of a security at the election of the holder subject to the terms and condition of the issue with no reduction in nominal value.")]
    PutRedemption = CorporateActionEventTypeV5Code.PutRedemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("_s_m7gWOAEeW4z96Yfj3Wng")]
    [Description(@"Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency.")]
    Redenomination = CorporateActionEventTypeV5Code.Redenomination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;REMK&quot;.
    /// </summary>
    [EnumMember(Value = "REMK")]
    [IsoId("_tF0RMWOAEeW4z96Yfj3Wng")]
    [Description(@"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.")]
    RemarketingAgreement = CorporateActionEventTypeV5Code.RemarketingAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repurchase offer/Issuer bid/ Reverse rights. Offer to existing holders by the issuing company to repurchase its own securities. The objective of the offer is to reduce the number of outstanding securities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_tLkT4WOAEeW4z96Yfj3Wng")]
    [Description(@"Repurchase offer/Issuer bid/ Reverse rights. Offer to existing holders by the issuing company to repurchase its own securities. The objective of the offer is to reduce the number of outstanding securities.")]
    RepurchaseOffer = CorporateActionEventTypeV5Code.RepurchaseOffer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Decrease in a company&apos;s number of outstanding equities without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Equity price and nominal value are increased accordingly.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("_tsUQgWOAEeW4z96Yfj3Wng")]
    [Description(@"Decrease in a company's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are increased accordingly.")]
    ReverseStockSplit = CorporateActionEventTypeV5Code.ReverseStockSplit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer to holders of a security to subscribe for additional securities via the distribution of an intermediate security. Both processes are included in the same event.
    /// Encoded/decoded by serializers as &quot;RHTS&quot;.
    /// </summary>
    [EnumMember(Value = "RHTS")]
    [IsoId("_twrMEWOAEeW4z96Yfj3Wng")]
    [Description(@"Offer to holders of a security to subscribe for additional securities via the distribution of an intermediate security. Both processes are included in the same event.")]
    RightsIssue = CorporateActionEventTypeV5Code.RightsIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_t2YygWOAEeW4z96Yfj3Wng")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividend = CorporateActionEventTypeV5Code.ScripDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate event pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications.
    /// Encoded/decoded by serializers as &quot;SHPR&quot;.
    /// </summary>
    [EnumMember(Value = "SHPR")]
    [IsoId("_t8s14WOAEeW4z96Yfj3Wng")]
    [Description(@"Corporate event pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications.")]
    SharesPremiumDividend = CorporateActionEventTypeV5Code.SharesPremiumDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_uCmpkWOAEeW4z96Yfj3Wng")]
    [Description(@"Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.")]
    SmallestNegotiableUnit = CorporateActionEventTypeV5Code.SmallestNegotiableUnit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of securities issued by another company. The distributed securities may either be of a newly created or of an existing company. For example, spin-off, demerger, unbundling, divestment.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_uMNRgWOAEeW4z96Yfj3Wng")]
    [Description(@"Distribution of securities issued by another company. The distributed securities may either be of a newly created or of an existing company. For example, spin-off, demerger, unbundling, divestment.")]
    SpinOff = CorporateActionEventTypeV5Code.SpinOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend paid to shareholders in the form of equities of the issuing corporation.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_uOHWAWOAEeW4z96Yfj3Wng")]
    [Description(@"Dividend paid to shareholders in the form of equities of the issuing corporation.")]
    StockDividend = CorporateActionEventTypeV5Code.StockDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Increase in a corporation&apos;s number of outstanding equities without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_uSffsWOAEeW4z96Yfj3Wng")]
    [Description(@"Increase in a corporation's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.")]
    StockSplit = CorporateActionEventTypeV5Code.StockSplit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event related to tax reclaim activities.
    /// Encoded/decoded by serializers as &quot;TREC&quot;.
    /// </summary>
    [EnumMember(Value = "TREC")]
    [IsoId("_ueU8QWOAEeW4z96Yfj3Wng")]
    [Description(@"Event related to tax reclaim activities.")]
    TaxReclaim = CorporateActionEventTypeV5Code.TaxReclaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer made to holders by a third party, requesting them to sell (tender) or exchange their securities.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_ukGNEWOAEeW4z96Yfj3Wng")]
    [Description(@"Offer made to holders by a third party, requesting them to sell (tender) or exchange their securities.")]
    Tender = CorporateActionEventTypeV5Code.Tender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.
    /// Encoded/decoded by serializers as &quot;DLST&quot;.
    /// </summary>
    [EnumMember(Value = "DLST")]
    [IsoId("_usabkWOAEeW4z96Yfj3Wng")]
    [Description(@"Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.")]
    TradingStatusDelisted = CorporateActionEventTypeV5Code.TradingStatusDelisted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading in the security has been suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_uyJ3MWOAEeW4z96Yfj3Wng")]
    [Description(@"Trading in the security has been suspended.")]
    TradingStatusSuspended = CorporateActionEventTypeV5Code.TradingStatusSuspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).
    /// Encoded/decoded by serializers as &quot;EXWA&quot;.
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("_vSN3UWOAEeW4z96Yfj3Wng")]
    [Description(@"Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).")]
    WarrantExercise = CorporateActionEventTypeV5Code.WarrantExercise, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certification process for withholding tax reduction or exemption based on the tax status of the holder.
    /// Encoded/decoded by serializers as &quot;WTRC&quot;.
    /// </summary>
    [EnumMember(Value = "WTRC")]
    [IsoId("_vaaKAWOAEeW4z96Yfj3Wng")]
    [Description(@"Certification process for withholding tax reduction or exemption based on the tax status of the holder.")]
    WithholdingTaxReliefCertification = CorporateActionEventTypeV5Code.WithholdingTaxReliefCertification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Booking out of valueless securities.
    /// Encoded/decoded by serializers as &quot;WRTH&quot;.
    /// </summary>
    [EnumMember(Value = "WRTH")]
    [IsoId("_vcWDsWOAEeW4z96Yfj3Wng")]
    [Description(@"Booking out of valueless securities.")]
    Worthless = CorporateActionEventTypeV5Code.Worthless, // same ordinal as derivation source for type conversions
    
}
