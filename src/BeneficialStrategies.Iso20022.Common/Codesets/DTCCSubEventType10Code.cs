// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rxLUETDqEey2N-DB7H7A5A")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types."
)]
[DerivedFrom(typeof(DTCCSubEventTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCCSubEventType10Code>))]
#endif
public enum DTCCSubEventType10Code
{
    /// <summary>
    /// Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option).
    /// Encoded/decoded by serializers as &quot;OPTO&quot;.
    /// </summary>
    [EnumMember(Value = "OPTO")]
    [IsoId("_sGomsTDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option)."
    )]
    OptOut = DTCCSubEventTypeCode.OptOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation).
    /// Encoded/decoded by serializers as &quot;DRPD&quot;.
    /// </summary>
    [EnumMember(Value = "DRPD")]
    [IsoId("_sGomszDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation)."
    )]
    DividendReinvestmentByDTC = DTCCSubEventTypeCode.DividendReinvestmentByDTC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a change in the place where the security is listed.
    /// Encoded/decoded by serializers as &quot;PLCL&quot;.
    /// </summary>
    [EnumMember(Value = "PLCL")]
    [IsoId("_sGomtTDqEey2N-DB7H7A5A")]
    [Description(@"Identifies a change in the place where the security is listed.")]
    PlaceOfListing = DTCCSubEventTypeCode.PlaceOfListing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a change in Board Lot size.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_sGomtzDqEey2N-DB7H7A5A")]
    [Description(@"Identifies a change in Board Lot size.")]
    BoardLot = DTCCSubEventTypeCode.BoardLot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract&apos;s expiration.
    /// Encoded/decoded by serializers as &quot;RMRK&quot;.
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_sGomuTDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration."
    )]
    Remarketing = DTCCSubEventTypeCode.Remarketing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where &quot;unwinding&quot; of the basket of securities occurs.
    /// Encoded/decoded by serializers as &quot;UNWD&quot;.
    /// </summary>
    [EnumMember(Value = "UNWD")]
    [IsoId("_sGomuzDqEey2N-DB7H7A5A")]
    [Description(@"Identifies an event where ""unwinding"" of the basket of securities occurs.")]
    Unwind = DTCCSubEventTypeCode.Unwind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;SHEX&quot;.
    /// </summary>
    [EnumMember(Value = "SHEX")]
    [IsoId("_sGomvTDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets."
    )]
    ShareExchange = DTCCSubEventTypeCode.ShareExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;STDT&quot;.
    /// </summary>
    [EnumMember(Value = "STDT")]
    [IsoId("_sGomvzDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets."
    )]
    Standard = DTCCSubEventTypeCode.Standard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;XFER&quot;.
    /// </summary>
    [EnumMember(Value = "XFER")]
    [IsoId("_sGomwTDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets."
    )]
    Transfer = DTCCSubEventTypeCode.Transfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.
    /// Encoded/decoded by serializers as &quot;SOPT&quot;.
    /// </summary>
    [EnumMember(Value = "SOPT")]
    [IsoId("_sGomwzDqEey2N-DB7H7A5A")]
    [Description(
        @"Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities."
    )]
    SurvivorOptions = DTCCSubEventTypeCode.SurvivorOptions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.
    /// Encoded/decoded by serializers as &quot;MBCK&quot;.
    /// </summary>
    [EnumMember(Value = "MBCK")]
    [IsoId("_sGomxTDqEey2N-DB7H7A5A")]
    [Description(
        @"Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions."
    )]
    MortgageBacked = DTCCSubEventTypeCode.MortgageBacked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the distribution is from the proceeds of the sale of assets.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_sGomxzDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where the distribution is from the proceeds of the sale of assets."
    )]
    SaleOfAssets = DTCCSubEventTypeCode.SaleOfAssets, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.
    /// Encoded/decoded by serializers as &quot;PRNI&quot;.
    /// </summary>
    [EnumMember(Value = "PRNI")]
    [IsoId("_sGomyTDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues."
    )]
    PhysicalRightsNotIssued = DTCCSubEventTypeCode.PhysicalRightsNotIssued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies sale of rights event where issuers redeem poison pill rights.
    /// Encoded/decoded by serializers as &quot;POPI&quot;.
    /// </summary>
    [EnumMember(Value = "POPI")]
    [IsoId("_sGomyzDqEey2N-DB7H7A5A")]
    [Description(@"Identifies sale of rights event where issuers redeem poison pill rights.")]
    PoisonPill = DTCCSubEventTypeCode.PoisonPill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).
    /// Encoded/decoded by serializers as &quot;DRPI&quot;.
    /// </summary>
    [EnumMember(Value = "DRPI")]
    [IsoId("_sGomzTDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company)."
    )]
    DividendReinvestmentByIssuer = DTCCSubEventTypeCode.DividendReinvestmentByIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.
    /// Encoded/decoded by serializers as &quot;MROS&quot;.
    /// </summary>
    [EnumMember(Value = "MROS")]
    [IsoId("_sGomzzDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name."
    )]
    MandatoryRedemptionOfShares = DTCCSubEventTypeCode.MandatoryRedemptionOfShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).
    /// Encoded/decoded by serializers as &quot;SHPP&quot;.
    /// </summary>
    [EnumMember(Value = "SHPP")]
    [IsoId("_sGom0TDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS)."
    )]
    SharePurchasePlan = DTCCSubEventTypeCode.SharePurchasePlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event in certain markets where underlying rights are not issued.
    /// Encoded/decoded by serializers as &quot;OPOF&quot;.
    /// </summary>
    [EnumMember(Value = "OPOF")]
    [IsoId("_sGom0zDqEey2N-DB7H7A5A")]
    [Description(@"Identifies an event in certain markets where underlying rights are not issued.")]
    OpenOffer = DTCCSubEventTypeCode.OpenOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.
    /// Encoded/decoded by serializers as &quot;TWRI&quot;.
    /// </summary>
    [EnumMember(Value = "TWRI")]
    [IsoId("_sGom1TDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer."
    )]
    TenderWithRights = DTCCSubEventTypeCode.TenderWithRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to &quot;sell&quot; whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.
    /// Encoded/decoded by serializers as &quot;CILI&quot;.
    /// </summary>
    [EnumMember(Value = "CILI")]
    [IsoId("_sGom1zDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to ""sell"" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level."
    )]
    CashinLieu = DTCCSubEventTypeCode.CashinLieu, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.
    /// Encoded/decoded by serializers as &quot;BTST&quot;.
    /// </summary>
    [EnumMember(Value = "BTST")]
    [IsoId("_sGom2TDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror."
    )]
    BidTenderSealedTender = DTCCSubEventTypeCode.BidTenderSealedTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.
    /// Encoded/decoded by serializers as &quot;FTPR&quot;.
    /// </summary>
    [EnumMember(Value = "FTPR")]
    [IsoId("_sGom2zDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares."
    )]
    OfferToPurchase = DTCCSubEventTypeCode.OfferToPurchase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.
    /// Encoded/decoded by serializers as &quot;ADRS&quot;.
    /// </summary>
    [EnumMember(Value = "ADRS")]
    [IsoId("_sGom3TDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies when the event security is an ADR. The underlying security is American Depositary Receipt."
    )]
    ADR = DTCCSubEventTypeCode.ADR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a consent event with payout.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_sGom3zDqEey2N-DB7H7A5A")]
    [Description(@"Identifies a consent event with payout.")]
    WithPayout = DTCCSubEventTypeCode.WithPayout, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a consent event without payout.
    /// Encoded/decoded by serializers as &quot;WITO&quot;.
    /// </summary>
    [EnumMember(Value = "WITO")]
    [IsoId("_sGom4TDqEey2N-DB7H7A5A")]
    [Description(@"Identifies a consent event without payout.")]
    WithoutPayout = DTCCSubEventTypeCode.WithoutPayout, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where a tax credit relating to the Build America Bonds will occur.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_sGom4zDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event where a tax credit relating to the Build America Bonds will occur."
    )]
    TaxCredit = DTCCSubEventTypeCode.TaxCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an exchange offer on securities that are subject to Securities Rule 144A.
    /// Encoded/decoded by serializers as &quot;A144&quot;.
    /// </summary>
    [EnumMember(Value = "A144")]
    [IsoId("_sGom5TDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an exchange offer on securities that are subject to Securities Rule 144A."
    )]
    USLegal144A = DTCCSubEventTypeCode.USLegal144A, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the payout will be both cash and securities.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_sGom5zDqEey2N-DB7H7A5A")]
    [Description(@"Identifies an event where the payout will be both cash and securities.")]
    CashAndSecurities = DTCCSubEventTypeCode.CashAndSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an exchange offer on securities that are subject to securities rule Reg S.
    /// Encoded/decoded by serializers as &quot;REGS&quot;.
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_sGom6TDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an exchange offer on securities that are subject to securities rule Reg S."
    )]
    RegulationS = DTCCSubEventTypeCode.RegulationS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a MMI Important Notice.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_sGom6zDqEey2N-DB7H7A5A")]
    [Description(@"Identifies a MMI Important Notice.")]
    ImportantNotice = DTCCSubEventTypeCode.ImportantNotice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event which will be based on record date holdings.
    /// Encoded/decoded by serializers as &quot;RDTH&quot;.
    /// </summary>
    [EnumMember(Value = "RDTH")]
    [IsoId("_sGom7TDqEey2N-DB7H7A5A")]
    [Description(@"Identifies an event which will be based on record date holdings.")]
    BasedOnRecordDateHoldings = DTCCSubEventTypeCode.BasedOnRecordDateHoldings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the payout will be cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_sGom7zDqEey2N-DB7H7A5A")]
    [Description(@"Identifies an event where the payout will be cash.")]
    Cash = DTCCSubEventTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the presentation of securities will be required.
    /// Encoded/decoded by serializers as &quot;PREQ&quot;.
    /// </summary>
    [EnumMember(Value = "PREQ")]
    [IsoId("_sGom8TDqEey2N-DB7H7A5A")]
    [Description(@"Identifies an event where the presentation of securities will be required.")]
    PresentationRequired = DTCCSubEventTypeCode.PresentationRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the payout will be securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_sGom8zDqEey2N-DB7H7A5A")]
    [Description(@"Identifies an event where the payout will be securities.")]
    Securities = DTCCSubEventTypeCode.Securities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a tender offer with a convert feature.
    /// Encoded/decoded by serializers as &quot;COTE&quot;.
    /// </summary>
    [EnumMember(Value = "COTE")]
    [IsoId("_sGom9TDqEey2N-DB7H7A5A")]
    [Description(@"Identifies a tender offer with a convert feature.")]
    ConvertAndTender = DTCCSubEventTypeCode.ConvertAndTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies when a tender offer is a mini tender.
    /// Encoded/decoded by serializers as &quot;MITE&quot;.
    /// </summary>
    [EnumMember(Value = "MITE")]
    [IsoId("_sGom9zDqEey2N-DB7H7A5A")]
    [Description(@"Identifies when a tender offer is a mini tender.")]
    MiniTender = DTCCSubEventTypeCode.MiniTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies when a tender offer is a self tender.
    /// Encoded/decoded by serializers as &quot;SETE&quot;.
    /// </summary>
    [EnumMember(Value = "SETE")]
    [IsoId("_sGom-TDqEey2N-DB7H7A5A")]
    [Description(@"Identifies when a tender offer is a self tender.")]
    SelfTender = DTCCSubEventTypeCode.SelfTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies when the event security is a GDR. The underlying security is a global depositary receipt.
    /// Encoded/decoded by serializers as &quot;GDRS&quot;.
    /// </summary>
    [EnumMember(Value = "GDRS")]
    [IsoId("_sGom-zDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies when the event security is a GDR. The underlying security is a global depositary receipt."
    )]
    GDR = DTCCSubEventTypeCode.GDR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event which has been considered a dividend equivalent payment under Section 871(m) of the United States Internal Revenue Code.
    /// Encoded/decoded by serializers as &quot;M871&quot;.
    /// </summary>
    [EnumMember(Value = "M871")]
    [IsoId("_sGom_TDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event which has been considered a dividend equivalent payment under Section 871(m) of the United States Internal Revenue Code."
    )]
    DividendEquivalentPayment871M = DTCCSubEventTypeCode.DividendEquivalentPayment871M, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States  Internal Revenue Code.
    /// Encoded/decoded by serializers as &quot;C305&quot;.
    /// </summary>
    [EnumMember(Value = "C305")]
    [IsoId("_sGom_zDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States  Internal Revenue Code."
    )]
    DeemedDividend305C = DTCCSubEventTypeCode.DeemedDividend305C, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event which is a full call or a maturity with conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_sGonATDqEey2N-DB7H7A5A")]
    [Description(@"Identifies an event which is a full call or a maturity with conversion.")]
    Conversion = DTCCSubEventTypeCode.Conversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies distributions that have multiple components for tax withholding and 1042-S reporting purposes.
    /// Encoded/decoded by serializers as &quot;RCLA&quot;.
    /// </summary>
    [EnumMember(Value = "RCLA")]
    [IsoId("_vV5_ETDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies distributions that have multiple components for tax withholding and 1042-S reporting purposes."
    )]
    Classification1042S = DTCCSubEventTypeCode.Classification1042S, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a qualified notice issued by a publicly traded partnership that states applicability of the 10 percent exception under IRS regulation 1.1446(f)-4(b)(3).
    /// Encoded/decoded by serializers as &quot;QN92&quot;.
    /// </summary>
    [EnumMember(Value = "QN92")]
    [IsoId("_veG40TDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies a qualified notice issued by a publicly traded partnership that states applicability of the 10 percent exception under IRS regulation 1.1446(f)-4(b)(3)."
    )]
    ExemptionQualifiedNotice92Days = DTCCSubEventTypeCode.ExemptionQualifiedNotice92Days, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies when a publicly traded partnership identifies the amount realised on such portion of the distribution as an amount in excess of cumulative net income under IRS regulation 1.1446(f)-4(c)(2)(iii).
    /// Encoded/decoded by serializers as &quot;ECNI&quot;.
    /// </summary>
    [EnumMember(Value = "ECNI")]
    [IsoId("_v8NKETDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies when a publicly traded partnership identifies the amount realised on such portion of the distribution as an amount in excess of cumulative net income under IRS regulation 1.1446(f)-4(c)(2)(iii)."
    )]
    AmountsInExcessOfCumulativeNetIncome =
        DTCCSubEventTypeCode.AmountsInExcessOfCumulativeNetIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specified purpose acquisition companies (SPACs) are public companies comprised of cash available to investors in financial markets. The sole purpose of SPACs is to use the proceeds to finance a future acquisition. SPACs generally commit to identify a target operating company and complete a business combination transaction within a specified timeframe. SPACS have a feature where funds are put into a trust account and when the target investment is identified the investor can have their proceeds returned or participate in the business combination.
    /// Encoded/decoded by serializers as &quot;SPAC&quot;.
    /// </summary>
    [EnumMember(Value = "SPAC")]
    [IsoId("_xINDITDqEey2N-DB7H7A5A")]
    [Description(
        @"Specified purpose acquisition companies (SPACs) are public companies comprised of cash available to investors in financial markets. The sole purpose of SPACs is to use the proceeds to finance a future acquisition. SPACs generally commit to identify a target operating company and complete a business combination transaction within a specified timeframe. SPACS have a feature where funds are put into a trust account and when the target investment is identified the investor can have their proceeds returned or participate in the business combination."
    )]
    SpecialPurposeAcquisitionCompany = DTCCSubEventTypeCode.SpecialPurposeAcquisitionCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a combination of assets or types of assets packaged together and sold as one. For example, a shareholder buying one unit of company stock may get preferred shares, ordinary shares and even warrants in the unit.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_xmJjYTDqEey2N-DB7H7A5A")]
    [Description(
        @"Identifies a combination of assets or types of assets packaged together and sold as one. For example, a shareholder buying one unit of company stock may get preferred shares, ordinary shares and even warrants in the unit."
    )]
    UnitCombination = DTCCSubEventTypeCode.UnitCombination, // same ordinal as derivation source for type conversions
}
