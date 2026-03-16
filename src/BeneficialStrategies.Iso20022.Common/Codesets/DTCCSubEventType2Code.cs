// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_16Q08DL3EeKU9IrkkToqcw_-527716700")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types."
)]
[DerivedFrom(typeof(DTCCSubEventTypeCode))]
public enum DTCCSubEventType2Code
{
    /// <summary>
    /// Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option).
    /// Encoded/decoded by serializers as &quot;OPTO&quot;.
    /// </summary>
    [EnumMember(Value = "OPTO")]
    [IsoId("_16Q08TL3EeKU9IrkkToqcw_1817541425")]
    [Description(
        @"Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option)."
    )]
    OptOut = DTCCSubEventTypeCode.OptOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation).
    /// Encoded/decoded by serializers as &quot;DRPD&quot;.
    /// </summary>
    [EnumMember(Value = "DRPD")]
    [IsoId("_16Q08jL3EeKU9IrkkToqcw_1703702359")]
    [Description(
        @"Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation)."
    )]
    DividendReinvestmentByDTC = DTCCSubEventTypeCode.DividendReinvestmentByDTC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a change in the place where the security is listed.
    /// Encoded/decoded by serializers as &quot;PLCL&quot;.
    /// </summary>
    [EnumMember(Value = "PLCL")]
    [IsoId("_16Q08zL3EeKU9IrkkToqcw_1935412410")]
    [Description(@"Identifies a change in the place where the security is listed.")]
    PlaceOfListing = DTCCSubEventTypeCode.PlaceOfListing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a change in Board Lot size.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_16Q09DL3EeKU9IrkkToqcw_1821573344")]
    [Description(@"Identifies a change in Board Lot size.")]
    BoardLot = DTCCSubEventTypeCode.BoardLot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract&apos;s expiration.
    /// Encoded/decoded by serializers as &quot;RMRK&quot;.
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_16Q09TL3EeKU9IrkkToqcw_-469948703")]
    [Description(
        @"Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration."
    )]
    Remarketing = DTCCSubEventTypeCode.Remarketing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where &quot;unwinding&quot; of the basket of securities occurs.
    /// Encoded/decoded by serializers as &quot;UNWD&quot;.
    /// </summary>
    [EnumMember(Value = "UNWD")]
    [IsoId("_16Q09jL3EeKU9IrkkToqcw_-659166152")]
    [Description(@"Identifies an event where ""unwinding"" of the basket of securities occurs.")]
    Unwind = DTCCSubEventTypeCode.Unwind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;SHEX&quot;.
    /// </summary>
    [EnumMember(Value = "SHEX")]
    [IsoId("_16al8DL3EeKU9IrkkToqcw_-1844078251")]
    [Description(
        @"Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets."
    )]
    ShareExchange = DTCCSubEventTypeCode.ShareExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;STDT&quot;.
    /// </summary>
    [EnumMember(Value = "STDT")]
    [IsoId("_16al8TL3EeKU9IrkkToqcw_258714424")]
    [Description(
        @"Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets."
    )]
    Standard = DTCCSubEventTypeCode.Standard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as &quot;XFER&quot;.
    /// </summary>
    [EnumMember(Value = "XFER")]
    [IsoId("_16al8jL3EeKU9IrkkToqcw_844661450")]
    [Description(
        @"Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets."
    )]
    Transfer = DTCCSubEventTypeCode.Transfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.
    /// Encoded/decoded by serializers as &quot;SOPT&quot;.
    /// </summary>
    [EnumMember(Value = "SOPT")]
    [IsoId("_16al8zL3EeKU9IrkkToqcw_730822384")]
    [Description(
        @"Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities."
    )]
    SurvivorOptions = DTCCSubEventTypeCode.SurvivorOptions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.
    /// Encoded/decoded by serializers as &quot;MBCK&quot;.
    /// </summary>
    [EnumMember(Value = "MBCK")]
    [IsoId("_16al9DL3EeKU9IrkkToqcw_-534021493")]
    [Description(
        @"Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions."
    )]
    MortgageBacked = DTCCSubEventTypeCode.MortgageBacked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the distribution is from the proceeds of the sale of assets.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_16al9TL3EeKU9IrkkToqcw_-647860559")]
    [Description(
        @"Identifies an event where the distribution is from the proceeds of the sale of assets."
    )]
    SaleOfAssets = DTCCSubEventTypeCode.SaleOfAssets, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.
    /// Encoded/decoded by serializers as &quot;PRNI&quot;.
    /// </summary>
    [EnumMember(Value = "PRNI")]
    [IsoId("_16al9jL3EeKU9IrkkToqcw_-545120270")]
    [Description(
        @"Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues."
    )]
    PhysicalRightsNotIssued = DTCCSubEventTypeCode.PhysicalRightsNotIssued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies sale of rights event where issuers redeem poison pill rights.
    /// Encoded/decoded by serializers as &quot;POPI&quot;.
    /// </summary>
    [EnumMember(Value = "POPI")]
    [IsoId("_16al9zL3EeKU9IrkkToqcw_-220002763")]
    [Description(@"Identifies sale of rights event where issuers redeem poison pill rights.")]
    PoisonPill = DTCCSubEventTypeCode.PoisonPill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).
    /// Encoded/decoded by serializers as &quot;DRPI&quot;.
    /// </summary>
    [EnumMember(Value = "DRPI")]
    [IsoId("_16jv4DL3EeKU9IrkkToqcw_-333841829")]
    [Description(
        @"Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company)."
    )]
    DividendReinvestmentByIssuer = DTCCSubEventTypeCode.DividendReinvestmentByIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.
    /// Encoded/decoded by serializers as &quot;MROS&quot;.
    /// </summary>
    [EnumMember(Value = "MROS")]
    [IsoId("_16jv4TL3EeKU9IrkkToqcw_1739890168")]
    [Description(
        @"Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name."
    )]
    MandatoryRedemptionOfShares = DTCCSubEventTypeCode.MandatoryRedemptionOfShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).
    /// Encoded/decoded by serializers as &quot;SHPP&quot;.
    /// </summary>
    [EnumMember(Value = "SHPP")]
    [IsoId("_16jv4jL3EeKU9IrkkToqcw_1626051102")]
    [Description(
        @"Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS)."
    )]
    SharePurchasePlan = DTCCSubEventTypeCode.SharePurchasePlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an event in certain markets where underlying rights are not issued.
    /// Encoded/decoded by serializers as &quot;OPOF&quot;.
    /// </summary>
    [EnumMember(Value = "OPOF")]
    [IsoId("_16jv4zL3EeKU9IrkkToqcw_-1140840506")]
    [Description(@"Identifies an event in certain markets where underlying rights are not issued.")]
    OpenOffer = DTCCSubEventTypeCode.OpenOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.
    /// Encoded/decoded by serializers as &quot;TWRI&quot;.
    /// </summary>
    [EnumMember(Value = "TWRI")]
    [IsoId("_16jv5DL3EeKU9IrkkToqcw_-1254679572")]
    [Description(
        @"Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer."
    )]
    TenderWithRights = DTCCSubEventTypeCode.TenderWithRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to &quot;sell&quot; whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.
    /// Encoded/decoded by serializers as &quot;CILI&quot;.
    /// </summary>
    [EnumMember(Value = "CILI")]
    [IsoId("_16jv5TL3EeKU9IrkkToqcw_-554893480")]
    [Description(
        @"Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to ""sell"" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level."
    )]
    CashinLieu = DTCCSubEventTypeCode.CashinLieu, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.
    /// Encoded/decoded by serializers as &quot;BTST&quot;.
    /// </summary>
    [EnumMember(Value = "BTST")]
    [IsoId("_16jv5jL3EeKU9IrkkToqcw_595408430")]
    [Description(
        @"Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror."
    )]
    BidTenderSealedTender = DTCCSubEventTypeCode.BidTenderSealedTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.
    /// Encoded/decoded by serializers as &quot;FTPR&quot;.
    /// </summary>
    [EnumMember(Value = "FTPR")]
    [IsoId("_16tg4DL3EeKU9IrkkToqcw_481569364")]
    [Description(
        @"Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares."
    )]
    OfferToPurchase = DTCCSubEventTypeCode.OfferToPurchase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.
    /// Encoded/decoded by serializers as &quot;ADRS&quot;.
    /// </summary>
    [EnumMember(Value = "ADRS")]
    [IsoId("_16tg4TL3EeKU9IrkkToqcw_584309653")]
    [Description(
        @"Identifies when the event security is an ADR. The underlying security is American Depositary Receipt."
    )]
    ADR = DTCCSubEventTypeCode.ADR, // same ordinal as derivation source for type conversions
}
