// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BH5UUA8EEeKhfswDSmpBfA")]
[Description(@"Specifies the type of a corporate action event.")]
[DerivedFrom(typeof(CorporateActionEventTypeV4Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionEventType13Code>))]
#endif
public enum CorporateActionEventType13Code
{
    /// <summary>
    /// Funds related event in which the income (for example accumulation units) that accrues during an accounting period is retained within the fund instead of being paid away to investors. The retained income is nonetheless deemed to have been distributed to investors for tax purposes.
    /// Encoded/decoded by serializers as &quot;ACCU&quot;.
    /// </summary>
    [EnumMember(Value = "ACCU")]
    [IsoId("_IBu58Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Funds related event in which the income (for example accumulation units) that accrues during an accounting period is retained within the fund instead of being paid away to investors. The retained income is nonetheless deemed to have been distributed to investors for tax purposes."
    )]
    Accumulation = CorporateActionEventTypeV4Code.Accumulation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading in security has commenced or security has been re-activated after a suspension in trading.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_IoeJ0Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Trading in security has commenced or security has been re-activated after a suspension in trading."
    )]
    ActiveTradingStatus = CorporateActionEventTypeV4Code.ActiveTradingStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of different security types to create a unit. Units are usually comprised of warrants and bonds or warrants and equities. Securities may be combined at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;ATTI&quot;.
    /// </summary>
    [EnumMember(Value = "ATTI")]
    [IsoId("_JBNZ8Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Combination of different security types to create a unit. Units are usually comprised of warrants and bonds or warrants and equities. Securities may be combined at the request of the security holder or based on market convention."
    )]
    Attachment = CorporateActionEventTypeV4Code.Attachment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.
    /// Encoded/decoded by serializers as &quot;BRUP&quot;.
    /// </summary>
    [EnumMember(Value = "BRUP")]
    [IsoId("_JYdcUQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless."
    )]
    Bankruptcy = CorporateActionEventTypeV4Code.Bankruptcy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_JfKhQQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Failure by the company to perform obligations defined as default events under the bond agreement and that have not been remedied."
    )]
    BondDefault = CorporateActionEventTypeV4Code.BondDefault, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn&apos;t change. Holder may be offered choice of form.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_Jl3mMQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn't change. Holder may be offered choice of form."
    )]
    BonusIssue = CorporateActionEventTypeV4Code.BonusIssue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities&apos; issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_JoGa0Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities' issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities."
    )]
    CallOnIntermediateSecurities = CorporateActionEventTypeV4Code.CallOnIntermediateSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Corporate event pays shareholders an amount in cash issued from the Capital account. There is no reduction to the face value of a single share (or the share has no par value). The number of circulating shares remains unchanged.
    /// Encoded/decoded by serializers as &quot;CAPD&quot;.
    /// </summary>
    [EnumMember(Value = "CAPD")]
    [IsoId("_J2HBoQ8EEeKhfswDSmpBfA")]
    [Description(
        @"The Corporate event pays shareholders an amount in cash issued from the Capital account. There is no reduction to the face value of a single share (or the share has no par value). The number of circulating shares remains unchanged."
    )]
    CapitalDistribution = CorporateActionEventTypeV4Code.CapitalDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_KA1q8Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund."
    )]
    CapitalGainsDistribution = CorporateActionEventTypeV4Code.CapitalGainsDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, for example, capitalisation, and negative amortisation.
    /// Encoded/decoded by serializers as &quot;CAPI&quot;.
    /// </summary>
    [EnumMember(Value = "CAPI")]
    [IsoId("_KHZl8Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Increase of the current principal of a debt instrument without increasing the nominal value. It normally arises from the incorporation of due but unpaid interest into the principal. This is commonly done by increasing the pool factor value, for example, capitalisation, and negative amortisation."
    )]
    Capitalisation = CorporateActionEventTypeV4Code.Capitalisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution to shareholders of cash resulting from the selling of non-eligible securities, for example, in the frame of a depositary receipt program.
    /// Encoded/decoded by serializers as &quot;DRCA&quot;.
    /// </summary>
    [EnumMember(Value = "DRCA")]
    [IsoId("_KN854Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Distribution to shareholders of cash resulting from the selling of non-eligible securities, for example, in the frame of a depositary receipt program."
    )]
    CashDistributionFromNonEligibleSecuritiesSales =
        CorporateActionEventTypeV4Code.CashDistributionFromNonEligibleSecuritiesSales, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_KUp-0Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency."
    )]
    CashDividend = CorporateActionEventTypeV4Code.CashDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information regarding a change further described in the corporate action details.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_Kb9gsQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Information regarding a change further described in the corporate action details."
    )]
    Change = CorporateActionEventTypeV4Code.Change, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.
    /// Encoded/decoded by serializers as &quot;CLSA&quot;.
    /// </summary>
    [EnumMember(Value = "CLSA")]
    [IsoId("_KjtugQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Situation where interested parties seek restitution for financial loss. The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction."
    )]
    ClassActionProposedSettlement = CorporateActionEventTypeV4Code.ClassActionProposedSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A Company Option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.
    /// Encoded/decoded by serializers as &quot;COOP&quot;.
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("_KwFWkQ8EEeKhfswDSmpBfA")]
    [Description(
        @"A Company Option may be granted by the company, allowing the holder to take up shares at some future date(s) at a pre arranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date."
    )]
    CompanyOption = CorporateActionEventTypeV4Code.CompanyOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting. For example, consent to change the terms of a bond.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_K_4GEQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting. For example, consent to change the terms of a bond."
    )]
    Consent = CorporateActionEventTypeV4Code.Consent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conversion of securities ( generally convertible bonds or preferred shares) into another form of securities ( usually common shares) at a pre-stated price/ratio.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_LGu8AQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Conversion of securities ( generally convertible bonds or preferred shares) into another form of securities ( usually common shares) at a pre-stated price/ratio."
    )]
    Conversion = CorporateActionEventTypeV4Code.Conversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations (as defined in terms and conditions).
    /// Encoded/decoded by serializers as &quot;CREV&quot;.
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("_L6cQ4Q8EEeKhfswDSmpBfA")]
    [Description(
        @"An occurrence of credit derivative for which the issuer of one or several underlying securities is unable to fulfill its financial obligations (as defined in terms and conditions)."
    )]
    CreditEvent = CorporateActionEventTypeV4Code.CreditEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reduction of face value of a single share or the value of fund assets. The number of circulating shares/units remains unchanged. This event may include a cash payout to holders.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_MCVooQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Reduction of face value of a single share or the value of fund assets. The number of circulating shares/units remains unchanged. This event may include a cash payout to holders."
    )]
    DecreaseInValue = CorporateActionEventTypeV4Code.DecreaseInValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Separation of components that comprise a security, for example, usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as &quot;DETI&quot;.
    /// </summary>
    [EnumMember(Value = "DETI")]
    [IsoId("_MI48kQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Separation of components that comprise a security, for example, usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention."
    )]
    Detachment = CorporateActionEventTypeV4Code.Detachment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer.
    /// Encoded/decoded by serializers as &quot;DSCL&quot;.
    /// </summary>
    [EnumMember(Value = "DSCL")]
    [IsoId("_MPTGkQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Requirement for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer."
    )]
    Disclosure = CorporateActionEventTypeV4Code.Disclosure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_MWALgQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both."
    )]
    DividendOption = CorporateActionEventTypeV4Code.DividendOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_MckGgQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company."
    )]
    DividendReinvestment = CorporateActionEventTypeV4Code.DividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_MkwZMQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value."
    )]
    Drawing = CorporateActionEventTypeV4Code.Drawing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_MrnPIQ8EEeKhfswDSmpBfA")]
    [Description(
        @"An action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer."
    )]
    DutchAuction = CorporateActionEventTypeV4Code.DutchAuction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example &quot;exchange offer&quot;, &quot;capital reorganisation&quot; or &quot;funds separation&quot;.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_NNcJ0Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation""."
    )]
    Exchange = CorporateActionEventTypeV4Code.Exchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager, at final maturity.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_Nx8lEQ8EEeKhfswDSmpBfA")]
    [Description(
        @"The redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager, at final maturity."
    )]
    FinalMaturity = CorporateActionEventTypeV4Code.FinalMaturity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager,before final maturity.
    /// Encoded/decoded by serializers as &quot;MCAL&quot;.
    /// </summary>
    [EnumMember(Value = "MCAL")]
    [IsoId("_OPAUgQ8EEeKhfswDSmpBfA")]
    [Description(
        @"The redemption of an entire issue outstanding of securities, eg, bonds, preferred equity, funds, by the issuer or its agent, for example, asset manager,before final maturity."
    )]
    FullCall = CorporateActionEventTypeV4Code.FullCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Increase in the face value of a single security. The number of circulating securities remains unchanged.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_OVaegQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Increase in the face value of a single security. The number of circulating securities remains unchanged."
    )]
    IncreaseInValue = CorporateActionEventTypeV4Code.IncreaseInValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.
    /// Encoded/decoded by serializers as &quot;PPMT&quot;.
    /// </summary>
    [EnumMember(Value = "PPMT")]
    [IsoId("_PfBx8Q8EEeKhfswDSmpBfA")]
    [Description(
        @"An instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser."
    )]
    InstalmentCall = CorporateActionEventTypeV4Code.InstalmentCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_PnhmoQ8EEeKhfswDSmpBfA")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment = CorporateActionEventTypeV4Code.InterestPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An event which consists of two components, the decrease of the amortized value of a pool factor security and an interest payment.
    /// Encoded/decoded by serializers as &quot;PRII&quot;.
    /// </summary>
    [EnumMember(Value = "PRII")]
    [IsoId("_SlX30Q8EEeKhfswDSmpBfA")]
    [Description(
        @"An event which consists of two components, the decrease of the amortized value of a pool factor security and an interest payment."
    )]
    InterestPaymentWithPrincipal = CorporateActionEventTypeV4Code.InterestPaymentWithPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The distribution of intermediate securities that gives the holder the right to take part in a future event.
    /// Encoded/decoded by serializers as &quot;RHDI&quot;.
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("_SryB0Q8EEeKhfswDSmpBfA")]
    [Description(
        @"The distribution of intermediate securities that gives the holder the right to take part in a future event."
    )]
    IntermediateSecuritiesDistribution =
        CorporateActionEventTypeV4Code.IntermediateSecuritiesDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_SyML0Q8EEeKhfswDSmpBfA")]
    [Description(
        @"A distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security."
    )]
    LiquidationDividend = CorporateActionEventTypeV4Code.LiquidationDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As stipulated in a bond&apos;s Terms and Conditions, the issuer or the bond-holder may prolong the maturity date of a bond. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder&apos;s approval.
    /// Encoded/decoded by serializers as &quot;EXTM&quot;.
    /// </summary>
    [EnumMember(Value = "EXTM")]
    [IsoId("_S0bAcQ8EEeKhfswDSmpBfA")]
    [Description(
        @"As stipulated in a bond's Terms and Conditions, the issuer or the bond-holder may prolong the maturity date of a bond. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder's approval."
    )]
    MaturityExtension = CorporateActionEventTypeV4Code.MaturityExtension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_S61KcQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange."
    )]
    Merger = CorporateActionEventTypeV4Code.Merger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offers that are not supervised or regulated by an official entity and being offered by a party, for example a broker, usually at a discount price, for example broker offer, mini-tender, mini odd lot offer or third party offer.
    /// Encoded/decoded by serializers as &quot;NOOF&quot;.
    /// </summary>
    [EnumMember(Value = "NOOF")]
    [IsoId("_Tp7FEQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Offers that are not supervised or regulated by an official entity and being offered by a party, for example a broker, usually at a discount price, for example broker offer, mini-tender, mini odd lot offer or third party offer."
    )]
    NonOfficialOffer = CorporateActionEventTypeV4Code.NonOfficialOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non-US beneficial owner certification requirement for exchange of temporary to permanent notes.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_UvqlIQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Non-US beneficial owner certification requirement for exchange of temporary to permanent notes."
    )]
    NonUSTEFRADCertification = CorporateActionEventTypeV4Code.NonUSTEFRADCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Odd Lot Sale/Purchase. Sale or purchase of odd-lots to/from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_U2EvIQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Odd Lot Sale/Purchase. Sale or purchase of odd-lots to/from the issuing company, initiated either by the holder of the security or through an offer made by the issuer."
    )]
    OddLotSalePurchase = CorporateActionEventTypeV4Code.OddLotSalePurchase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other event, use only when no other event type applies, for example, a new event type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VS08kQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Other event, use only when no other event type applies, for example, a new event type."
    )]
    OtherEvent = CorporateActionEventTypeV4Code.OtherEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Occurs when securities with different characteristics, for example, shares with different entitlements to dividend or voting rights, become identical in all respects, for example, pari-passu or assimilation. May be scheduled in advance, for example, shares resulting from a bonus may become fungible after a pre-set period of time, or may result from outside events, for example, merger, reorganisation, issue of supplementary tranches.
    /// Encoded/decoded by serializers as &quot;PARI&quot;.
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_VZY3kQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Occurs when securities with different characteristics, for example, shares with different entitlements to dividend or voting rights, become identical in all respects, for example, pari-passu or assimilation. May be scheduled in advance, for example, shares resulting from a bonus may become fungible after a pre-set period of time, or may result from outside events, for example, merger, reorganisation, issue of supplementary tranches."
    )]
    PariPassu = CorporateActionEventTypeV4Code.PariPassu, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally.
    /// Encoded/decoded by serializers as &quot;PCAL&quot;.
    /// </summary>
    [EnumMember(Value = "PCAL")]
    [IsoId("_Vf8LgQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally."
    )]
    PartialRedemptionWithNominalValueReduction =
        CorporateActionEventTypeV4Code.PartialRedemptionWithNominalValueReduction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date without reduction of the nominal value of the shares. This is commonly done by pool factor reduction.
    /// Encoded/decoded by serializers as &quot;PRED&quot;.
    /// </summary>
    [EnumMember(Value = "PRED")]
    [IsoId("_VmWVgQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Securities are redeemed in part before their scheduled final maturity date without reduction of the nominal value of the shares. This is commonly done by pool factor reduction."
    )]
    PartialRedemptionWithoutNominalValueReduction =
        CorporateActionEventTypeV4Code.PartialRedemptionWithoutNominalValueReduction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("_Vv4sAQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Interest payment, in any kind except cash, distributed to holders of an interest bearing asset."
    )]
    PayInKind = CorporateActionEventTypeV4Code.PayInKind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_V3Cc4Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar."
    )]
    PlaceOfIncorporation = CorporateActionEventTypeV4Code.PlaceOfIncorporation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_V9mX4Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity."
    )]
    Prefunding = CorporateActionEventTypeV4Code.Prefunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_WEAh4Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders."
    )]
    PriorityIssue = CorporateActionEventTypeV4Code.PriorityIssue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value.
    /// Encoded/decoded by serializers as &quot;BPUT&quot;.
    /// </summary>
    [EnumMember(Value = "BPUT")]
    [IsoId("_WKj10Q8EEeKhfswDSmpBfA")]
    [Description(
        @"Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and with no reduction in nominal value."
    )]
    PutRedemption = CorporateActionEventTypeV4Code.PutRedemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("_WSBIsQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency."
    )]
    Redenomination = CorporateActionEventTypeV4Code.Redenomination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as &quot;REMK&quot;.
    /// </summary>
    [EnumMember(Value = "REMK")]
    [IsoId("_XaInUQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders."
    )]
    RemarketingAgreement = CorporateActionEventTypeV4Code.RemarketingAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase offer/Issuer bid/ Reverse rights. Offer to existing holders by the issuing company to repurchase its own securities. The objective of the offer is to reduce the number of outstanding securities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_YY4HgQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Repurchase offer/Issuer bid/ Reverse rights. Offer to existing holders by the issuing company to repurchase its own securities. The objective of the offer is to reduce the number of outstanding securities."
    )]
    RepurchaseOffer = CorporateActionEventTypeV4Code.RepurchaseOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("_YgnuQQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly."
    )]
    ReverseStockSplit = CorporateActionEventTypeV4Code.ReverseStockSplit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights Issue/ Subscription Rights/ Rights Offer. Offer to holders of a security to subscribe for additional securities via the distribution of an intermediate security. Both processes are included in the same event.
    /// Encoded/decoded by serializers as &quot;RHTS&quot;.
    /// </summary>
    [EnumMember(Value = "RHTS")]
    [IsoId("_YnUzMQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Rights Issue/ Subscription Rights/ Rights Offer. Offer to holders of a security to subscribe for additional securities via the distribution of an intermediate security. Both processes are included in the same event."
    )]
    RightsIssue = CorporateActionEventTypeV4Code.RightsIssue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scrip Dividend/Payment. Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_Ytu9MQ8EEeKhfswDSmpBfA")]
    [Description(@"Scrip Dividend/Payment. Dividend or interest paid in the form of scrip.")]
    ScripDividend = CorporateActionEventTypeV4Code.ScripDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This corporate event pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications.
    /// Encoded/decoded by serializers as &quot;SHPR&quot;.
    /// </summary>
    [EnumMember(Value = "SHPR")]
    [IsoId("_Z9TusQ8EEeKhfswDSmpBfA")]
    [Description(
        @"This corporate event pays shareholders an amount in cash issued from the shares premium reserve. It is similar to a dividend but with different tax implications."
    )]
    SharesPremiumDividend = CorporateActionEventTypeV4Code.SharesPremiumDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_aEdfkQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit."
    )]
    SmallestNegotiableUnit = CorporateActionEventTypeV4Code.SmallestNegotiableUnit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_aK3pkQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder."
    )]
    SpinOff = CorporateActionEventTypeV4Code.SpinOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_aRRzkQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution."
    )]
    StockDividend = CorporateActionEventTypeV4Code.StockDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a change in nominal value, a subdivision. It is an increase in a corporation&apos;s number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_aYSagQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is a change in nominal value, a subdivision. It is an increase in a corporation's number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly."
    )]
    StockSplit = CorporateActionEventTypeV4Code.StockSplit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event related to tax reclaim activities.
    /// Encoded/decoded by serializers as &quot;TREC&quot;.
    /// </summary>
    [EnumMember(Value = "TREC")]
    [IsoId("_bHEzIQ8EEeKhfswDSmpBfA")]
    [Description(@"Event related to tax reclaim activities.")]
    TaxReclaim = CorporateActionEventTypeV4Code.TaxReclaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer. It is an offer made to holders by a third party, requesting them to sell (tender) or exchange their securities.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_bNx4EQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer. It is an offer made to holders by a third party, requesting them to sell (tender) or exchange their securities."
    )]
    Tender = CorporateActionEventTypeV4Code.Tender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.
    /// Encoded/decoded by serializers as &quot;DLST&quot;.
    /// </summary>
    [EnumMember(Value = "DLST")]
    [IsoId("_bUe9AQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation."
    )]
    TradingStatusDelisted = CorporateActionEventTypeV4Code.TradingStatusDelisted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading in the security has been suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_bbC4AQ8EEeKhfswDSmpBfA")]
    [Description(@"Trading in the security has been suspended.")]
    TradingStatusSuspended = CorporateActionEventTypeV4Code.TradingStatusSuspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).
    /// Encoded/decoded by serializers as &quot;EXWA&quot;.
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("_b6yIAQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Option offered to holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue)."
    )]
    WarrantExercise = CorporateActionEventTypeV4Code.WarrantExercise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certification process for withholding tax reduction or exemption based on the tax status of the holder.
    /// Encoded/decoded by serializers as &quot;WTRC&quot;.
    /// </summary>
    [EnumMember(Value = "WTRC")]
    [IsoId("_cBMSAQ8EEeKhfswDSmpBfA")]
    [Description(
        @"Certification process for withholding tax reduction or exemption based on the tax status of the holder."
    )]
    WithholdingTaxReliefCertification =
        CorporateActionEventTypeV4Code.WithholdingTaxReliefCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Booking out of valueless securities.
    /// Encoded/decoded by serializers as &quot;WRTH&quot;.
    /// </summary>
    [EnumMember(Value = "WRTH")]
    [IsoId("_cJPawQ8EEeKhfswDSmpBfA")]
    [Description(@"Booking out of valueless securities.")]
    Worthless = CorporateActionEventTypeV4Code.Worthless, // same ordinal as derivation source for type conversions
}
