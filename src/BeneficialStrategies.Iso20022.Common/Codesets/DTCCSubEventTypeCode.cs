// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1mvcADL3EeKU9IrkkToqcw_-128626871")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types."
)]
[Derivations(
    typeof(DTCCSubEventType2Code),
    typeof(DTCCSubEventType8Code),
    typeof(DTCCSubEventType9Code),
    typeof(DTCCSubEventType7Code),
    typeof(DTCCSubEventType3Code),
    typeof(DTCCSubEventType1Code),
    typeof(DTCCSubEventType10Code),
    typeof(DTCCSubEventType4Code),
    typeof(DTCCSubEventType6Code)
)]
public enum DTCCSubEventTypeCode
{
    /// <summary>
    /// Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option).
    /// Encoded/decoded by serializers as &quot;OPTO&quot;.
    /// </summary>
    [EnumMember(Value = "OPTO")]
    [IsoId("_1mvcATL3EeKU9IrkkToqcw_1357486370")]
    [Description(
        @"Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option)."
    )]
    OptOut,

    /// <summary>
    /// Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation).
    /// Encoded/decoded by serializers as &quot;DRPD&quot;.
    /// </summary>
    [EnumMember(Value = "DRPD")]
    [IsoId("_1mvcAjL3EeKU9IrkkToqcw_-1195523464")]
    [Description(
        @"Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation)."
    )]
    DividendReinvestmentByDTC,

    /// <summary>
    /// Identifies a change in the place where the security is listed.
    /// Encoded/decoded by serializers as &quot;PLCL&quot;.
    /// </summary>
    [EnumMember(Value = "PLCL")]
    [IsoId("_1mvcAzL3EeKU9IrkkToqcw_-1727617849")]
    [Description(@"Identifies a change in the place where the security is listed.")]
    PlaceOfListing,

    /// <summary>
    /// Identifies a change in Board Lot size.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_1mvcBDL3EeKU9IrkkToqcw_-924028270")]
    [Description(@"Identifies a change in Board Lot size.")]
    BoardLot,

    /// <summary>
    /// Identifies an event that include notification of an interim payment in lieu of the original commitment.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_1mvcBTL3EeKU9IrkkToqcw_417492870")]
    [Description(
        @"Identifies an event that include notification of an interim payment in lieu of the original commitment."
    )]
    InterimPayment,

    /// <summary>
    /// Identifies an event that include notification of a final payment in lieu of the original commitment.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_1mvcBjL3EeKU9IrkkToqcw_-1599540079")]
    [Description(
        @"Identifies an event that include notification of a final payment in lieu of the original commitment."
    )]
    FinalPayment,

    /// <summary>
    /// Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract&apos;s expiration.
    /// Encoded/decoded by serializers as &quot;RMRK&quot;.
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_1m5NADL3EeKU9IrkkToqcw_2064685482")]
    [Description(
        @"Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration."
    )]
    Remarketing,

    /// <summary>
    /// Identifies an event where &quot;unwinding&quot; of the basket of securities occurs.
    /// Encoded/decoded by serializers as &quot;UNWD&quot;.
    /// </summary>
    [EnumMember(Value = "UNWD")]
    [IsoId("_1m5NATL3EeKU9IrkkToqcw_-1046332200")]
    [Description(@"Identifies an event where ""unwinding"" of the basket of securities occurs.")]
    Unwind,

    /// <summary>
    /// Identifies a meeting event called by the company on behalf of security holders at which the company can present corporate resolutions that may require a vote by the holders.
    /// Encoded/decoded by serializers as &quot;AMET&quot;.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_1m5NAjL3EeKU9IrkkToqcw_-472385839")]
    [Description(
        @"Identifies a meeting event called by the company on behalf of security holders at which the company can present corporate resolutions that may require a vote by the holders."
    )]
    AnnualGeneral,

    /// <summary>
    /// Identifies a meeting event called by the company when urgent matters need to be addressed before the next General Meeting.
    /// Encoded/decoded by serializers as &quot;EXOM&quot;.
    /// </summary>
    [EnumMember(Value = "EXOM")]
    [IsoId("_1m5NAzL3EeKU9IrkkToqcw_-343380369")]
    [Description(
        @"Identifies a meeting event called by the company when urgent matters need to be addressed before the next General Meeting."
    )]
    Extraordinary,

    /// <summary>
    /// Identifies a meeting event called by the company. Usually held annually.
    /// Encoded/decoded by serializers as &quot;ORDM&quot;.
    /// </summary>
    [EnumMember(Value = "ORDM")]
    [IsoId("_1m5NBDL3EeKU9IrkkToqcw_-505464302")]
    [Description(@"Identifies a meeting event called by the company. Usually held annually.")]
    Ordinary,

    /// <summary>
    /// Identifies a meeting event called by the company that cannot be categorized as Ordinary, Annual General, or Extraordinary.
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_1m5NBTL3EeKU9IrkkToqcw_1379855330")]
    [Description(
        @"Identifies a meeting event called by the company that cannot be categorized as Ordinary, Annual General, or Extraordinary."
    )]
    Special,

    /// <summary>
    /// Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;SHEX&quot;.
    /// </summary>
    [EnumMember(Value = "SHEX")]
    [IsoId("_1m5NBjL3EeKU9IrkkToqcw_1301321849")]
    [Description(
        @"Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets."
    )]
    ShareExchange,

    /// <summary>
    /// Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;STDT&quot;.
    /// </summary>
    [EnumMember(Value = "STDT")]
    [IsoId("_1nCW8DL3EeKU9IrkkToqcw_-534330324")]
    [Description(
        @"Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets."
    )]
    Standard,

    /// <summary>
    /// Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;XFER&quot;.
    /// </summary>
    [EnumMember(Value = "XFER")]
    [IsoId("_1nCW8TL3EeKU9IrkkToqcw_872239083")]
    [Description(
        @"Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets."
    )]
    Transfer,

    /// <summary>
    /// Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.
    /// Encoded/decoded by serializers as &quot;SOPT&quot;.
    /// </summary>
    [EnumMember(Value = "SOPT")]
    [IsoId("_1nCW8jL3EeKU9IrkkToqcw_-1725154596")]
    [Description(
        @"Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities."
    )]
    SurvivorOptions,

    /// <summary>
    /// Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.
    /// Encoded/decoded by serializers as &quot;MBCK&quot;.
    /// </summary>
    [EnumMember(Value = "MBCK")]
    [IsoId("_1nCW8zL3EeKU9IrkkToqcw_547681075")]
    [Description(
        @"Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions."
    )]
    MortgageBacked,

    /// <summary>
    /// Identifies an event where the distribution is from the proceeds of the sale of assets.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_1nCW9DL3EeKU9IrkkToqcw_781194712")]
    [Description(
        @"Identifies an event where the distribution is from the proceeds of the sale of assets."
    )]
    SaleOfAssets,

    /// <summary>
    /// Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.
    /// Encoded/decoded by serializers as &quot;PRNI&quot;.
    /// </summary>
    [EnumMember(Value = "PRNI")]
    [IsoId("_1nCW9TL3EeKU9IrkkToqcw_-1850483840")]
    [Description(
        @"Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues."
    )]
    PhysicalRightsNotIssued,

    /// <summary>
    /// Identifies sale of rights event where issuers redeem poison pill rights.
    /// Encoded/decoded by serializers as &quot;POPI&quot;.
    /// </summary>
    [EnumMember(Value = "POPI")]
    [IsoId("_1nMH8DL3EeKU9IrkkToqcw_2076931286")]
    [Description(@"Identifies sale of rights event where issuers redeem poison pill rights.")]
    PoisonPill,

    /// <summary>
    /// Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).
    /// Encoded/decoded by serializers as &quot;DRPI&quot;.
    /// </summary>
    [EnumMember(Value = "DRPI")]
    [IsoId("_1nMH8TL3EeKU9IrkkToqcw_-123370614")]
    [Description(
        @"Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company)."
    )]
    DividendReinvestmentByIssuer,

    /// <summary>
    /// Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.
    /// Encoded/decoded by serializers as &quot;MROS&quot;.
    /// </summary>
    [EnumMember(Value = "MROS")]
    [IsoId("_1nMH8jL3EeKU9IrkkToqcw_896355461")]
    [Description(
        @"Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name."
    )]
    MandatoryRedemptionOfShares,

    /// <summary>
    /// Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).
    /// Encoded/decoded by serializers as &quot;SHPP&quot;.
    /// </summary>
    [EnumMember(Value = "SHPP")]
    [IsoId("_1nMH8zL3EeKU9IrkkToqcw_1229322343")]
    [Description(
        @"Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS)."
    )]
    SharePurchasePlan,

    /// <summary>
    /// Identifies an event in certain markets where underlying rights are not issued.
    /// Encoded/decoded by serializers as &quot;OPOF&quot;.
    /// </summary>
    [EnumMember(Value = "OPOF")]
    [IsoId("_1nMH9DL3EeKU9IrkkToqcw_450752445")]
    [Description(@"Identifies an event in certain markets where underlying rights are not issued.")]
    OpenOffer,

    /// <summary>
    /// Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.
    /// Encoded/decoded by serializers as &quot;TWRI&quot;.
    /// </summary>
    [EnumMember(Value = "TWRI")]
    [IsoId("_1nMH9TL3EeKU9IrkkToqcw_-55077922")]
    [Description(
        @"Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer."
    )]
    TenderWithRights,

    /// <summary>
    /// Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to &quot;sell&quot; whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.
    /// Encoded/decoded by serializers as &quot;CILI&quot;.
    /// </summary>
    [EnumMember(Value = "CILI")]
    [IsoId("_1nMH9jL3EeKU9IrkkToqcw_-1673397831")]
    [Description(
        @"Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to ""sell"" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level."
    )]
    CashinLieu,

    /// <summary>
    /// Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.
    /// Encoded/decoded by serializers as &quot;BTST&quot;.
    /// </summary>
    [EnumMember(Value = "BTST")]
    [IsoId("_1nV48DL3EeKU9IrkkToqcw_1189026651")]
    [Description(
        @"Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror."
    )]
    BidTenderSealedTender,

    /// <summary>
    /// Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.
    /// Encoded/decoded by serializers as &quot;FTPR&quot;.
    /// </summary>
    [EnumMember(Value = "FTPR")]
    [IsoId("_1nV48TL3EeKU9IrkkToqcw_2099869732")]
    [Description(
        @"Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares."
    )]
    OfferToPurchase,

    /// <summary>
    /// Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.
    /// Encoded/decoded by serializers as &quot;ADRS&quot;.
    /// </summary>
    [EnumMember(Value = "ADRS")]
    [IsoId("_1nV48jL3EeKU9IrkkToqcw_-224380369")]
    [Description(
        @"Identifies when the event security is an ADR. The underlying security is American Depositary Receipt."
    )]
    ADR,

    /// <summary>
    /// Identifies a consent event with payout.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_pLZBQJ2PEeW-bsa36JFb9A")]
    [Description(@"Identifies a consent event with payout.")]
    WithPayout,

    /// <summary>
    /// Identifies a consent event without payout.
    /// Encoded/decoded by serializers as &quot;WITO&quot;.
    /// </summary>
    [EnumMember(Value = "WITO")]
    [IsoId("_0xe6oJ2PEeW-bsa36JFb9A")]
    [Description(@"Identifies a consent event without payout.")]
    WithoutPayout,

    /// <summary>
    /// Identifies an event where a tax credit relating to the Build America Bonds will occur.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_9b-lkJ2PEeW-bsa36JFb9A")]
    [Description(
        @"Identifies an event where a tax credit relating to the Build America Bonds will occur."
    )]
    TaxCredit,

    /// <summary>
    /// Identifies an exchange offer on securities that are subject to Securities Rule 144A.
    /// Encoded/decoded by serializers as &quot;A144&quot;.
    /// </summary>
    [EnumMember(Value = "A144")]
    [IsoId("_GYw6YJ2QEeW-bsa36JFb9A")]
    [Description(
        @"Identifies an exchange offer on securities that are subject to Securities Rule 144A."
    )]
    USLegal144A,

    /// <summary>
    /// Identifies an event where the payout will be both cash and securities.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_LXI44J2QEeW-bsa36JFb9A")]
    [Description(@"Identifies an event where the payout will be both cash and securities.")]
    CashAndSecurities,

    /// <summary>
    /// Identifies an exchange offer on securities that are subject to securities rule Reg S.
    /// Encoded/decoded by serializers as &quot;REGS&quot;.
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_O7g-kJ2QEeW-bsa36JFb9A")]
    [Description(
        @"Identifies an exchange offer on securities that are subject to securities rule Reg S."
    )]
    RegulationS,

    /// <summary>
    /// Identifies a MMI Important Notice.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_hIIgAJ2QEeW-bsa36JFb9A")]
    [Description(@"Identifies a MMI Important Notice.")]
    ImportantNotice,

    /// <summary>
    /// Identifies an event which will be based on record date holdings.
    /// Encoded/decoded by serializers as &quot;RDTH&quot;.
    /// </summary>
    [EnumMember(Value = "RDTH")]
    [IsoId("_sYpyAJ2QEeW-bsa36JFb9A")]
    [Description(@"Identifies an event which will be based on record date holdings.")]
    BasedOnRecordDateHoldings,

    /// <summary>
    /// Identifies an event where the presentation of securities will be required.
    /// Encoded/decoded by serializers as &quot;PREQ&quot;.
    /// </summary>
    [EnumMember(Value = "PREQ")]
    [IsoId("_zNdtsJ2QEeW-bsa36JFb9A")]
    [Description(@"Identifies an event where the presentation of securities will be required.")]
    PresentationRequired,

    /// <summary>
    /// Identifies an event where the payout will be cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_4k1bAJ2QEeW-bsa36JFb9A")]
    [Description(@"Identifies an event where the payout will be cash.")]
    Cash,

    /// <summary>
    /// Identifies an event where the payout will be securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_8n2kgJ2QEeW-bsa36JFb9A")]
    [Description(@"Identifies an event where the payout will be securities.")]
    Securities,

    /// <summary>
    /// Identifies a tender offer with a convert feature.
    /// Encoded/decoded by serializers as &quot;COTE&quot;.
    /// </summary>
    [EnumMember(Value = "COTE")]
    [IsoId("_BQXnwJ2REeW-bsa36JFb9A")]
    [Description(@"Identifies a tender offer with a convert feature.")]
    ConvertAndTender,

    /// <summary>
    /// Identifies when a tender offer is a mini tender.
    /// Encoded/decoded by serializers as &quot;MITE&quot;.
    /// </summary>
    [EnumMember(Value = "MITE")]
    [IsoId("_RUaTIJ2REeW-bsa36JFb9A")]
    [Description(@"Identifies when a tender offer is a mini tender.")]
    MiniTender,

    /// <summary>
    /// Identifies when a tender offer is a self tender.
    /// Encoded/decoded by serializers as &quot;SETE&quot;.
    /// </summary>
    [EnumMember(Value = "SETE")]
    [IsoId("_T-KjoJ2REeW-bsa36JFb9A")]
    [Description(@"Identifies when a tender offer is a self tender.")]
    SelfTender,

    /// <summary>
    /// Identifies when the event security is a GDR. The underlying security is a global depositary receipt.
    /// Encoded/decoded by serializers as &quot;GDRS&quot;.
    /// </summary>
    [EnumMember(Value = "GDRS")]
    [IsoId("_WZL0kJ2REeW-bsa36JFb9A")]
    [Description(
        @"Identifies when the event security is a GDR. The underlying security is a global depositary receipt."
    )]
    GDR,

    /// <summary>
    /// Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States  Internal Revenue Code.
    /// Encoded/decoded by serializers as &quot;C305&quot;.
    /// </summary>
    [EnumMember(Value = "C305")]
    [IsoId("_zY2x8JCOEeaSk9d1hvTrHg")]
    [Description(
        @"Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States  Internal Revenue Code."
    )]
    DeemedDividend305C,

    /// <summary>
    /// Identifies an event which has been considered a dividend equivalent payment under Section 871(m) of the United States Internal Revenue Code.
    /// Encoded/decoded by serializers as &quot;M871&quot;.
    /// </summary>
    [EnumMember(Value = "M871")]
    [IsoId("_FDQXIJCPEeaSk9d1hvTrHg")]
    [Description(
        @"Identifies an event which has been considered a dividend equivalent payment under Section 871(m) of the United States Internal Revenue Code."
    )]
    DividendEquivalentPayment871M,

    /// <summary>
    /// Identifies an event which is a full call or a maturity with conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_5xUagL_nEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event which is a full call or a maturity with conversion.")]
    Conversion,

    /// <summary>
    /// Name change with both CUSIP change and presentation required.
    /// Encoded/decoded by serializers as &quot;CUPR&quot;.
    /// </summary>
    [EnumMember(Value = "CUPR")]
    [IsoId("_0BxXEO2NEeiWtrflKsFqHg")]
    [Description(@"Name change with both CUSIP change and presentation required.")]
    NameAndCUSIPChangeAndPresentationRequired,

    /// <summary>
    /// Name change with CUSIP change.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("_QXRNAO2OEeiWtrflKsFqHg")]
    [Description(@"Name change with CUSIP change.")]
    NameAndCUSIPChange,

    /// <summary>
    /// Name change with presentation required without new CUSIP.
    /// Encoded/decoded by serializers as &quot;NCPR&quot;.
    /// </summary>
    [EnumMember(Value = "NCPR")]
    [IsoId("_h8nTEO2OEeiWtrflKsFqHg")]
    [Description(@"Name change with presentation required without new CUSIP.")]
    NameChangeAndPresentationRequired,

    /// <summary>
    /// Specified purpose acquisition companies (SPACs) are public companies comprised of cash available to investors in financial markets. The sole purpose of SPACs is to use the proceeds to finance a future acquisition. SPACs generally commit to identify a target operating company and complete a business combination transaction within a specified timeframe. SPACS have a feature where funds are put into a trust account and when the target investment is identified the investor can have their proceeds returned or participate in the business combination.
    /// Encoded/decoded by serializers as &quot;SPAC&quot;.
    /// </summary>
    [EnumMember(Value = "SPAC")]
    [IsoId("_44BgcDDoEey2N-DB7H7A5A")]
    [Description(
        @"Specified purpose acquisition companies (SPACs) are public companies comprised of cash available to investors in financial markets. The sole purpose of SPACs is to use the proceeds to finance a future acquisition. SPACs generally commit to identify a target operating company and complete a business combination transaction within a specified timeframe. SPACS have a feature where funds are put into a trust account and when the target investment is identified the investor can have their proceeds returned or participate in the business combination."
    )]
    SpecialPurposeAcquisitionCompany,

    /// <summary>
    /// Identifies a qualified notice issued by a publicly traded partnership that states applicability of the 10 percent exception under IRS regulation 1.1446(f)-4(b)(3).
    /// Encoded/decoded by serializers as &quot;QN92&quot;.
    /// </summary>
    [EnumMember(Value = "QN92")]
    [IsoId("_KINO0DDpEey2N-DB7H7A5A")]
    [Description(
        @"Identifies a qualified notice issued by a publicly traded partnership that states applicability of the 10 percent exception under IRS regulation 1.1446(f)-4(b)(3)."
    )]
    ExemptionQualifiedNotice92Days,

    /// <summary>
    /// Identifies when a publicly traded partnership identifies the amount realised on such portion of the distribution as an amount in excess of cumulative net income under IRS regulation 1.1446(f)-4(c)(2)(iii).
    /// Encoded/decoded by serializers as &quot;ECNI&quot;.
    /// </summary>
    [EnumMember(Value = "ECNI")]
    [IsoId("_icpDEDDpEey2N-DB7H7A5A")]
    [Description(
        @"Identifies when a publicly traded partnership identifies the amount realised on such portion of the distribution as an amount in excess of cumulative net income under IRS regulation 1.1446(f)-4(c)(2)(iii)."
    )]
    AmountsInExcessOfCumulativeNetIncome,

    /// <summary>
    /// Identifies distributions that have multiple components for tax withholding and 1042-S reporting purposes.
    /// Encoded/decoded by serializers as &quot;RCLA&quot;.
    /// </summary>
    [EnumMember(Value = "RCLA")]
    [IsoId("_wzl6gDDpEey2N-DB7H7A5A")]
    [Description(
        @"Identifies distributions that have multiple components for tax withholding and 1042-S reporting purposes."
    )]
    Classification1042S,

    /// <summary>
    /// Identifies a combination of assets or types of assets packaged together and sold as one. For example, a shareholder buying one unit of company stock may get preferred shares, ordinary shares and even warrants in the unit.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_GyHnUDDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies a combination of assets or types of assets packaged together and sold as one. For example, a shareholder buying one unit of company stock may get preferred shares, ordinary shares and even warrants in the unit."
    )]
    UnitCombination,
}
