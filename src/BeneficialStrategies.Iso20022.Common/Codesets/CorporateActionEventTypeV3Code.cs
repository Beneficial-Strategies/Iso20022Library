// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bI6MJdp-Ed-ak6NoX_4Aeg_-1371447915")]
[Description(@"Specifies the corporate action event type.")]
[Derivations(typeof(CorporateActionEventType7Code),typeof(CorporateActionEventType9Code),typeof(CorporateActionEventType8Code),typeof(CorporateActionEventType6Code),typeof(CorporateActionEventType2Code))]
public enum CorporateActionEventTypeV3Code
{
    /// <summary>
    /// Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_bI6MJtp-Ed-ak6NoX_4Aeg_-970639835")]
    [Description(@"Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.")]
    DividendReinvestment,
    
    /// <summary>
    /// Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_bI6MJ9p-Ed-ak6NoX_4Aeg_-970639800")]
    [Description(@"Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.")]
    CapitalGainsDistribution,
    
    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_bI6MKNp-Ed-ak6NoX_4Aeg_-970639740")]
    [Description(@"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.")]
    CashDividend,
    
    /// <summary>
    /// Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_bI6MKdp-Ed-ak6NoX_4Aeg_-970639463")]
    [Description(@"Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.")]
    DividendOption,
    
    /// <summary>
    /// Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_bJDWENp-Ed-ak6NoX_4Aeg_-970639386")]
    [Description(@"Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.")]
    StockDividend,
    
    /// <summary>
    /// A distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_bJDWEdp-Ed-ak6NoX_4Aeg_-970639326")]
    [Description(@"A distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.")]
    LiquidationDividend,
    
    /// <summary>
    /// Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_bJDWEtp-Ed-ak6NoX_4Aeg_-970639025")]
    [Description(@"Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.")]
    Merger,
    
    /// <summary>
    /// Event is a name change. The issuing company changes its name. The event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.
    /// Encoded/decoded by serializers as &quot;NAME&quot;.
    /// </summary>
    [EnumMember(Value = "NAME")]
    [IsoId("_bJDWE9p-Ed-ak6NoX_4Aeg_-970638940")]
    [Description(@"Event is a name change. The issuing company changes its name. The event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.")]
    NameChange,
    
    /// <summary>
    /// Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_bJDWFNp-Ed-ak6NoX_4Aeg_-970638888")]
    [Description(@"Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.")]
    SpinOff,
    
    /// <summary>
    /// Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_bJDWFdp-Ed-ak6NoX_4Aeg_-970638733")]
    [Description(@"Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.")]
    Tender,
    
    /// <summary>
    /// Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn&apos;t change. Holder may be offered choice of form.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_bJDWFtp-Ed-ak6NoX_4Aeg_-970638352")]
    [Description(@"Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn't change. Holder may be offered choice of form.")]
    BonusIssue,
    
    /// <summary>
    /// Information regarding a change further described in the corporate action details.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_bJDWF9p-Ed-ak6NoX_4Aeg_-970637777")]
    [Description(@"Information regarding a change further described in the corporate action details.")]
    Change,
    
    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a security is restated, eg, nominal/par value of security in a national currency is restated in another currency.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("_bJDWGNp-Ed-ak6NoX_4Aeg_-970637465")]
    [Description(@"Event by which the unit (currency and/or nominal) of a security is restated, eg, nominal/par value of security in a national currency is restated in another currency.")]
    Redenomination,
    
    /// <summary>
    /// Event is an option for the shareholders to exchange their securities for other securities and/or cash. Exchange options are mentioned in the terms and conditions of a security and are valid during the whole lifetime of a security.
    /// Encoded/decoded by serializers as &quot;EXOP&quot;.
    /// </summary>
    [EnumMember(Value = "EXOP")]
    [IsoId("_bJDWGdp-Ed-ak6NoX_4Aeg_-970637387")]
    [Description(@"Event is an option for the shareholders to exchange their securities for other securities and/or cash. Exchange options are mentioned in the terms and conditions of a security and are valid during the whole lifetime of a security.")]
    ExchangeOption,
    
    /// <summary>
    /// Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example &quot;exchange offer&quot;, &quot;capital reorganisation&quot; or &quot;funds separation&quot;.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_bJNHENp-Ed-ak6NoX_4Aeg_-970637044")]
    [Description(@"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation"".")]
    Exchange,
    
    /// <summary>
    /// Reduction of face value of a single share or the value of fund assets. The number of circulating shares/units remains unchanged. This event may include a cash payout to holders.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_bJNHEdp-Ed-ak6NoX_4Aeg_-970636949")]
    [Description(@"Reduction of face value of a single share or the value of fund assets. The number of circulating shares/units remains unchanged. This event may include a cash payout to holders.")]
    DecreaseInValue,
    
    /// <summary>
    /// This includes drawing, partial and full call, put.|Redemption in part or full before the scheduled final maturity date of a security, subject to the terms and conditions of the issue. |Drawing - Securities are redeemed in part by lottery.|Partial Call - Securities are redeemed in part by reducing proportionally the outstanding amount of securities.|Put - Early redemption of a bond at the election of the bondholder.|Full Call - The entire outstanding of a security is redeemed by the issuer.
    /// Encoded/decoded by serializers as &quot;ERED&quot;.
    /// </summary>
    [EnumMember(Value = "ERED")]
    [IsoId("_bJNHEtp-Ed-ak6NoX_4Aeg_-970636847")]
    [Description(@"This includes drawing, partial and full call, put.|Redemption in part or full before the scheduled final maturity date of a security, subject to the terms and conditions of the issue. |Drawing - Securities are redeemed in part by lottery.|Partial Call - Securities are redeemed in part by reducing proportionally the outstanding amount of securities.|Put - Early redemption of a bond at the election of the bondholder.|Full Call - The entire outstanding of a security is redeemed by the issuer.")]
    EarlyRedemption,
    
    /// <summary>
    /// The redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, eg, asset manager, at final maturity.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_bJNHE9p-Ed-ak6NoX_4Aeg_-969716426")]
    [Description(@"The redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, eg, asset manager, at final maturity.")]
    FinalMaturity,
    
    /// <summary>
    /// Regular interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_bJNHFNp-Ed-ak6NoX_4Aeg_-969716192")]
    [Description(@"Regular interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment,
    
    /// <summary>
    /// Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_bJNHFdp-Ed-ak6NoX_4Aeg_-969715880")]
    [Description(@"Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.")]
    Prefunding,
    
    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;RMRK&quot;.
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_bJNHFtp-Ed-ak6NoX_4Aeg_-969715417")]
    [Description(@"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.")]
    Remarketing,
    
    /// <summary>
    /// The ability for security holders to purchase (additional or new) securities at a certain price, in proportion to their holding.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_bJNHF9p-Ed-ak6NoX_4Aeg_-969715305")]
    [Description(@"The ability for security holders to purchase (additional or new) securities at a certain price, in proportion to their holding.")]
    Subscription,
    
    /// <summary>
    /// Combination of different security types to create a unit. Units are usually comprised of warrants and bonds or warrants and equities. Securities may be combined at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;ATTI&quot;.
    /// </summary>
    [EnumMember(Value = "ATTI")]
    [IsoId("_bJNHGNp-Ed-ak6NoX_4Aeg_-969714968")]
    [Description(@"Combination of different security types to create a unit. Units are usually comprised of warrants and bonds or warrants and equities. Securities may be combined at the request of the security holder or based on market convention.")]
    Attachment,
    
    /// <summary>
    /// Conversion of securities ( generally convertible bonds or preferred shares) into another form of securities ( usually common shares) at a pre-stated price/ratio.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_bJNHGdp-Ed-ak6NoX_4Aeg_-969714855")]
    [Description(@"Conversion of securities ( generally convertible bonds or preferred shares) into another form of securities ( usually common shares) at a pre-stated price/ratio.")]
    Conversion,
    
    /// <summary>
    /// Separation of components that comprise a security, eg, usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;DETI&quot;.
    /// </summary>
    [EnumMember(Value = "DETI")]
    [IsoId("_bJW4ENp-Ed-ak6NoX_4Aeg_-969714487")]
    [Description(@"Separation of components that comprise a security, eg, usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.")]
    Detachment,
    
    /// <summary>
    /// Trading in security has commenced or security has been re-activated after a suspension in trading.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_bJW4Edp-Ed-ak6NoX_4Aeg_-969713865")]
    [Description(@"Trading in security has commenced or security has been re-activated after a suspension in trading.")]
    ActiveTradingStatus,
    
    /// <summary>
    /// Meeting Annual general meeting.
    /// Encoded/decoded by serializers as &quot;MEET&quot;.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_bJW4Etp-Ed-ak6NoX_4Aeg_-969713012")]
    [Description(@"Meeting Annual general meeting.")]
    AnnualGeneralMeeting,
    
    /// <summary>
    /// Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.
    /// Encoded/decoded by serializers as &quot;BRUP&quot;.
    /// </summary>
    [EnumMember(Value = "BRUP")]
    [IsoId("_bJW4E9p-Ed-ak6NoX_4Aeg_-968791895")]
    [Description(@"Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.")]
    Bankruptcy,
    
    /// <summary>
    /// Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_bJW4FNp-Ed-ak6NoX_4Aeg_-968790964")]
    [Description(@"Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.")]
    BondDefault,
    
    /// <summary>
    /// Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities&apos; issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_bJW4Fdp-Ed-ak6NoX_4Aeg_-968790017")]
    [Description(@"Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities' issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.")]
    CallOnIntermediateSecurities,
    
    /// <summary>
    /// Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, eg, capitalisation, and negative amortisation.
    /// Encoded/decoded by serializers as &quot;CAPI&quot;.
    /// </summary>
    [EnumMember(Value = "CAPI")]
    [IsoId("_bJW4Ftp-Ed-ak6NoX_4Aeg_-967869338")]
    [Description(@"Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, eg, capitalisation, and negative amortisation.")]
    Capitalisation,
    
    /// <summary>
    /// Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party intended to progress an event to the next stage. This procedure is not required to be linked to the organisation of a formal meeting. For example, consent to approve a plan of reorganisation for a bankruptcy proceeding.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_bJW4F9p-Ed-ak6NoX_4Aeg_-967867442")]
    [Description(@"Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party intended to progress an event to the next stage. This procedure is not required to be linked to the organisation of a formal meeting. For example, consent to approve a plan of reorganisation for a bankruptcy proceeding.")]
    Consent,
    
    /// <summary>
    /// A Company Option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("_bJW4GNp-Ed-ak6NoX_4Aeg_-967868390")]
    [Description(@"A Company Option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.")]
    CompanyOption,
    
    /// <summary>
    /// Coupon stripping is the process whereby interest coupons for future payment dates are separated from the security corpus that entitles the holder to the principal repayment.
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_bJW4Gdp-Ed-ak6NoX_4Aeg_1283877892")]
    [Description(@"Coupon stripping is the process whereby interest coupons for future payment dates are separated from the security corpus that entitles the holder to the principal repayment.")]
    CouponStripping,
    
    /// <summary>
    /// Announcement of a meeting at a Court.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_bJW4Gtp-Ed-ak6NoX_4Aeg_-967866487")]
    [Description(@"Announcement of a meeting at a Court.")]
    CourtMeeting,
    
    /// <summary>
    /// Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.
    /// Encoded/decoded by serializers as &quot;DSCL&quot;.
    /// </summary>
    [EnumMember(Value = "DSCL")]
    [IsoId("_bJgCANp-Ed-ak6NoX_4Aeg_-966945366")]
    [Description(@"Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.")]
    Disclosure,
    
    /// <summary>
    /// Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_bJgCAdp-Ed-ak6NoX_4Aeg_-966944418")]
    [Description(@"Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value.")]
    Drawing,
    
    /// <summary>
    /// An action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_bJgCAtp-Ed-ak6NoX_4Aeg_-966943462")]
    [Description(@"An action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.")]
    DutchAuction,
    
    /// <summary>
    /// Extraordinary or Special General Meeting. Extraordinary or special general meeting.
    /// Encoded/decoded by serializers as &quot;XMET&quot;.
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_bJgCA9p-Ed-ak6NoX_4Aeg_-966942497")]
    [Description(@"Extraordinary or Special General Meeting. Extraordinary or special general meeting.")]
    ExtraordinaryGeneralMeeting,
    
    /// <summary>
    /// The redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, eg, asset manager,before final maturity.
    /// Encoded/decoded by serializers as &quot;MCAL&quot;.
    /// </summary>
    [EnumMember(Value = "MCAL")]
    [IsoId("_bJgCBNp-Ed-ak6NoX_4Aeg_-966021327")]
    [Description(@"The redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, eg, asset manager,before final maturity.")]
    FullCall,
    
    /// <summary>
    /// Increase in the face value of a single security. The number of circulating securities remains unchanged.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_bJgCBdp-Ed-ak6NoX_4Aeg_-966020355")]
    [Description(@"Increase in the face value of a single security. The number of circulating securities remains unchanged.")]
    IncreaseInValue,
    
    /// <summary>
    /// An instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.
    /// Encoded/decoded by serializers as &quot;PPMT&quot;.
    /// </summary>
    [EnumMember(Value = "PPMT")]
    [IsoId("_bJgCBtp-Ed-ak6NoX_4Aeg_-966018897")]
    [Description(@"An instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.")]
    InstalmentCall,
    
    /// <summary>
    /// An event which consists of two components, the decrease of the amortized value of a pool factor security and an interest payment.
    /// Encoded/decoded by serializers as &quot;PRII&quot;.
    /// </summary>
    [EnumMember(Value = "PRII")]
    [IsoId("_bJgCB9p-Ed-ak6NoX_4Aeg_-965098218")]
    [Description(@"An event which consists of two components, the decrease of the amortized value of a pool factor security and an interest payment.")]
    InterestPaymentWithPrincipal,
    
    /// <summary>
    /// The distribution of intermediate securities or privilege that gives the holder the right to take part in a future event.
    /// Encoded/decoded by serializers as &quot;RHDI&quot;.
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("_bJgCCNp-Ed-ak6NoX_4Aeg_-965097236")]
    [Description(@"The distribution of intermediate securities or privilege that gives the holder the right to take part in a future event.")]
    IntermediateSecuritiesDistribution,
    
    /// <summary>
    /// As stipulated in a bond&apos;s Terms and Conditions, the issuer or the bond-holder may prolong the maturity date of a bond. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder&apos;s approval.
    /// Encoded/decoded by serializers as &quot;EXTM&quot;.
    /// </summary>
    [EnumMember(Value = "EXTM")]
    [IsoId("_bJgCCdp-Ed-ak6NoX_4Aeg_-965096262")]
    [Description(@"As stipulated in a bond's Terms and Conditions, the issuer or the bond-holder may prolong the maturity date of a bond. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder's approval.")]
    MaturityExtension,
    
    /// <summary>
    /// Non-US beneficial owner certification requirement for exchange of temporary to permanent notes.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_bJpzANp-Ed-ak6NoX_4Aeg_-964174816")]
    [Description(@"Non-US beneficial owner certification requirement for exchange of temporary to permanent notes.")]
    NonUSTEFRADCertification,
    
    /// <summary>
    /// Odd Lot Sale/Purchase. Sale or purchase of odd-lots to/from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_bJpzAdp-Ed-ak6NoX_4Aeg_-964173843")]
    [Description(@"Odd Lot Sale/Purchase. Sale or purchase of odd-lots to/from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.")]
    OddLotSalePurchase,
    
    /// <summary>
    /// Ordinary general meeting.
    /// Encoded/decoded by serializers as &quot;OMET&quot;.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_bJpzAtp-Ed-ak6NoX_4Aeg_-964172860")]
    [Description(@"Ordinary general meeting.")]
    OrdinaryGeneralMeeting,
    
    /// <summary>
    /// Other event, use only when no other event type applies, eg, a new event type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bJpzA9p-Ed-ak6NoX_4Aeg_-964171869")]
    [Description(@"Other event, use only when no other event type applies, eg, a new event type.")]
    OtherEvent,
    
    /// <summary>
    /// Occurs when securities with different characteristics, eg, shares with different entitlements to dividend or voting rights, become identical in all respects, eg, pari-passu or assimilation. May be scheduled in advance, eg, shares resulting from a bonus may become fungible after a pre-set period of time, or may result from outside events, eg, merger, reorganisation, issue of supplementary tranches, etc.
    /// Encoded/decoded by serializers as &quot;PARI&quot;.
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_bJpzBNp-Ed-ak6NoX_4Aeg_-963250615")]
    [Description(@"Occurs when securities with different characteristics, eg, shares with different entitlements to dividend or voting rights, become identical in all respects, eg, pari-passu or assimilation. May be scheduled in advance, eg, shares resulting from a bonus may become fungible after a pre-set period of time, or may result from outside events, eg, merger, reorganisation, issue of supplementary tranches, etc.")]
    PariPassu,
    
    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally.
    /// Encoded/decoded by serializers as &quot;PCAL&quot;.
    /// </summary>
    [EnumMember(Value = "PCAL")]
    [IsoId("_bJpzBdp-Ed-ak6NoX_4Aeg_-963248347")]
    [Description(@"Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally.")]
    PartialRedemptionWithNominalValueReduction,
    
    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date without reduction of the nominal value of the shares. This is commonly done by pool factor reduction.
    /// Encoded/decoded by serializers as &quot;PRED&quot;.
    /// </summary>
    [EnumMember(Value = "PRED")]
    [IsoId("_bJpzBtp-Ed-ak6NoX_4Aeg_-955862987")]
    [Description(@"Securities are redeemed in part before their scheduled final maturity date without reduction of the nominal value of the shares. This is commonly done by pool factor reduction.")]
    PartialRedemptionWithoutNominalValueReduction,
    
    /// <summary>
    /// Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("_bJpzB9p-Ed-ak6NoX_4Aeg_-955861438")]
    [Description(@"Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.")]
    PayInKind,
    
    /// <summary>
    /// Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_bJpzCNp-Ed-ak6NoX_4Aeg_-955860196")]
    [Description(@"Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.")]
    PlaceOfIncorporation,
    
    /// <summary>
    /// Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_bJpzCdp-Ed-ak6NoX_4Aeg_-954939456")]
    [Description(@"Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.")]
    PriorityIssue,
    
    /// <summary>
    /// Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value.
    /// Encoded/decoded by serializers as &quot;BPUT&quot;.
    /// </summary>
    [EnumMember(Value = "BPUT")]
    [IsoId("_bJy88Np-Ed-ak6NoX_4Aeg_-954938208")]
    [Description(@"Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value.")]
    PutRedemption,
    
    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;REMK&quot;.
    /// </summary>
    [EnumMember(Value = "REMK")]
    [IsoId("_bJy88dp-Ed-ak6NoX_4Aeg_-954937175")]
    [Description(@"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.")]
    RemarketingAgreement,
    
    /// <summary>
    /// Repurchase offer/Issuer bid/ Reverse rights. Offer to existing shareholders by the issuing company to repurchase equity or other securities convertible into equity. The objective of the offer is to reduce the number of outstanding equities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_bJy88tp-Ed-ak6NoX_4Aeg_-954016426")]
    [Description(@"Repurchase offer/Issuer bid/ Reverse rights. Offer to existing shareholders by the issuing company to repurchase equity or other securities convertible into equity. The objective of the offer is to reduce the number of outstanding equities.")]
    RepurchaseOffer,
    
    /// <summary>
    /// Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("_bJy889p-Ed-ak6NoX_4Aeg_-954015400")]
    [Description(@"Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.")]
    ReverseStockSplit,
    
    /// <summary>
    /// Rights Issue/ Subscription Rights/ Rights Offer. Distribution of a security or privilege that gives the holder an entitlement or right to take part in a future event.
    /// Encoded/decoded by serializers as &quot;RHTS&quot;.
    /// </summary>
    [EnumMember(Value = "RHTS")]
    [IsoId("_bJy89Np-Ed-ak6NoX_4Aeg_-954014168")]
    [Description(@"Rights Issue/ Subscription Rights/ Rights Offer. Distribution of a security or privilege that gives the holder an entitlement or right to take part in a future event.")]
    RightsIssue,
    
    /// <summary>
    /// Scrip Dividend/Payment. Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_bJy89dp-Ed-ak6NoX_4Aeg_-953092826")]
    [Description(@"Scrip Dividend/Payment. Dividend or interest paid in the form of scrip.")]
    ScripDividend,
    
    /// <summary>
    /// This corporate event pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications.
    /// Encoded/decoded by serializers as &quot;SHPR&quot;.
    /// </summary>
    [EnumMember(Value = "SHPR")]
    [IsoId("_bJy89tp-Ed-ak6NoX_4Aeg_-953091576")]
    [Description(@"This corporate event pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications.")]
    SharesPremiumDividend,
    
    /// <summary>
    /// Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_bJy899p-Ed-ak6NoX_4Aeg_-953090533")]
    [Description(@"Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.")]
    SmallestNegotiableUnit,
    
    /// <summary>
    /// Event is a change in nominal value, a subdivision. It is an increase in a corporation&apos;s number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_bJy8-Np-Ed-ak6NoX_4Aeg_-952169536")]
    [Description(@"Event is a change in nominal value, a subdivision. It is an increase in a corporation's number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.")]
    StockSplit,
    
    /// <summary>
    /// Event related to tax reclaim activities.
    /// Encoded/decoded by serializers as &quot;TREC&quot;.
    /// </summary>
    [EnumMember(Value = "TREC")]
    [IsoId("_bJy8-dp-Ed-ak6NoX_4Aeg_-952167923")]
    [Description(@"Event related to tax reclaim activities.")]
    TaxReclaim,
    
    /// <summary>
    /// Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.
    /// Encoded/decoded by serializers as &quot;DLST&quot;.
    /// </summary>
    [EnumMember(Value = "DLST")]
    [IsoId("_bJy8-tp-Ed-ak6NoX_4Aeg_-952166625")]
    [Description(@"Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.")]
    TradingStatusDelisted,
    
    /// <summary>
    /// Trading in the security has been suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_bJ8t8Np-Ed-ak6NoX_4Aeg_-951245851")]
    [Description(@"Trading in the security has been suspended.")]
    TradingStatusSuspended,
    
    /// <summary>
    /// Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).
    /// Encoded/decoded by serializers as &quot;EXWA&quot;.
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("_bJ8t8dp-Ed-ak6NoX_4Aeg_-951244808")]
    [Description(@"Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).")]
    WarrantExercise,
    
    /// <summary>
    /// Certification process for withholding tax reduction or exemption based on the tax status of the holder.
    /// Encoded/decoded by serializers as &quot;WTRC&quot;.
    /// </summary>
    [EnumMember(Value = "WTRC")]
    [IsoId("_bJ8t8tp-Ed-ak6NoX_4Aeg_-951242922")]
    [Description(@"Certification process for withholding tax reduction or exemption based on the tax status of the holder.")]
    WithholdingTaxReliefCertification,
    
    /// <summary>
    /// Booking out of valueless securities.
    /// Encoded/decoded by serializers as &quot;WRTH&quot;.
    /// </summary>
    [EnumMember(Value = "WRTH")]
    [IsoId("_bJ8t89p-Ed-ak6NoX_4Aeg_-942933754")]
    [Description(@"Booking out of valueless securities.")]
    Worthless,
    
    /// <summary>
    /// Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.
    /// Encoded/decoded by serializers as &quot;CLSA&quot;.
    /// </summary>
    [EnumMember(Value = "CLSA")]
    [IsoId("_bJ8t9Np-Ed-ak6NoX_4Aeg_-1945812085")]
    [Description(@"Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.")]
    ClassActionProposedSettlement,
    
    /// <summary>
    /// The Corporate event pays shareholders an amount in cash issued from the Capital account. There is no reduction to the face value of a single share (or the share has no par value). The number of circulating shares remains unchanged.
    /// Encoded/decoded by serializers as &quot;CAPD&quot;.
    /// </summary>
    [EnumMember(Value = "CAPD")]
    [IsoId("_bJ8t9dp-Ed-ak6NoX_4Aeg_-1882422668")]
    [Description(@"The Corporate event pays shareholders an amount in cash issued from the Capital account. There is no reduction to the face value of a single share (or the share has no par value). The number of circulating shares remains unchanged.")]
    CapitalDistribution,
    
    /// <summary>
    /// An occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations (as defined in terms and conditions).
    /// Encoded/decoded by serializers as &quot;CREV&quot;.
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("_bJ8t9tp-Ed-ak6NoX_4Aeg_1631928104")]
    [Description(@"An occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations (as defined in terms and conditions).")]
    CreditEvent,
    
    /// <summary>
    /// Ordinary or annual or extraordinary or special general meeting.
    /// Encoded/decoded by serializers as &quot;MTNG&quot;.
    /// </summary>
    [EnumMember(Value = "MTNG")]
    [IsoId("_2tgg4PfbEd-5M-tMFgHEdw")]
    [Description(@"Ordinary or annual or extraordinary or special general meeting.")]
    SecuritiesHoldersMeeting,
    
    /// <summary>
    /// Distribution to shareholders of cash resulting from the selling of non-eligible securities, for example, in the frame of a depositary receipt program.
    /// Encoded/decoded by serializers as &quot;DRCA&quot;.
    /// </summary>
    [EnumMember(Value = "DRCA")]
    [IsoId("_umM_F_mTEeCcAY_zfcalaA")]
    [Description(@"Distribution to shareholders of cash resulting from the selling of non-eligible securities, for example, in the frame of a depositary receipt program.")]
    CashDistributionFromNonEligibleSecuritiesSales,
    
}
