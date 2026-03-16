// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DTCCSubEventType11Code")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.")]
[DerivedFrom(typeof(DTCCSubEventTypeCode))]
public enum DTCCSubEventType11Code
{
    /// <summary>
    /// Identifies an exchange offer on securities that are subject to Securities Rule 144A.
    /// Encoded/decoded by serializers as &quot;A144&quot;.
    /// </summary>
    [EnumMember(Value = "A144")]
    [IsoId("_DTCCSubEventType11Code_USLegal144A")]
    [Description(@"Identifies an exchange offer on securities that are subject to Securities Rule 144A.")]
    USLegal144A = DTCCSubEventTypeCode.USLegal144A,

    /// <summary>
    /// Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.
    /// Encoded/decoded by serializers as &quot;ADRS&quot;.
    /// </summary>
    [EnumMember(Value = "ADRS")]
    [IsoId("_DTCCSubEventType11Code_ADR")]
    [Description(@"Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.")]
    ADR = DTCCSubEventTypeCode.ADR,

    /// <summary>
    /// Identifies a change in Board Lot size.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_DTCCSubEventType11Code_BoardLot")]
    [Description(@"Identifies a change in Board Lot size.")]
    BoardLot = DTCCSubEventTypeCode.BoardLot,

    /// <summary>
    /// Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities.
    /// Encoded/decoded by serializers as &quot;BTST&quot;.
    /// </summary>
    [EnumMember(Value = "BTST")]
    [IsoId("_DTCCSubEventType11Code_BidTenderSealedTender")]
    [Description(@"Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities.")]
    BidTenderSealedTender = DTCCSubEventTypeCode.BidTenderSealedTender,

    /// <summary>
    /// Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States Internal Revenue Code.
    /// Encoded/decoded by serializers as &quot;C305&quot;.
    /// </summary>
    [EnumMember(Value = "C305")]
    [IsoId("_DTCCSubEventType11Code_DeemedDividend305C")]
    [Description(@"Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States Internal Revenue Code.")]
    DeemedDividend305C = DTCCSubEventTypeCode.DeemedDividend305C,

    /// <summary>
    /// Identifies an event where the payout will be both cash and securities.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_DTCCSubEventType11Code_CashAndSecurities")]
    [Description(@"Identifies an event where the payout will be both cash and securities.")]
    CashAndSecurities = DTCCSubEventTypeCode.CashAndSecurities,

    /// <summary>
    /// Identifies an event where the payout will be cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_DTCCSubEventType11Code_Cash")]
    [Description(@"Identifies an event where the payout will be cash.")]
    Cash = DTCCSubEventTypeCode.Cash,

    /// <summary>
    /// Identifies DTC specific sub-event where holders can elect to sell whole shares to satisfy fractional entitlements.
    /// Encoded/decoded by serializers as &quot;CILI&quot;.
    /// </summary>
    [EnumMember(Value = "CILI")]
    [IsoId("_DTCCSubEventType11Code_CashinLieu")]
    [Description(@"Identifies DTC specific sub-event where holders can elect to sell whole shares to satisfy fractional entitlements.")]
    CashinLieu = DTCCSubEventTypeCode.CashinLieu,

    /// <summary>
    /// Identifies an event which is a full call or a maturity with conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_DTCCSubEventType11Code_Conversion")]
    [Description(@"Identifies an event which is a full call or a maturity with conversion.")]
    Conversion = DTCCSubEventTypeCode.Conversion,

    /// <summary>
    /// Identifies a tender offer with a convert feature.
    /// Encoded/decoded by serializers as &quot;COTE&quot;.
    /// </summary>
    [EnumMember(Value = "COTE")]
    [IsoId("_DTCCSubEventType11Code_ConvertAndTender")]
    [Description(@"Identifies a tender offer with a convert feature.")]
    ConvertAndTender = DTCCSubEventTypeCode.ConvertAndTender,

    /// <summary>
    /// Identifies an event where a tax credit relating to the Build America Bonds will occur.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_DTCCSubEventType11Code_TaxCredit")]
    [Description(@"Identifies an event where a tax credit relating to the Build America Bonds will occur.")]
    TaxCredit = DTCCSubEventTypeCode.TaxCredit,

    /// <summary>
    /// Name change with both CUSIP change and presentation required.
    /// Encoded/decoded by serializers as &quot;CUPR&quot;.
    /// </summary>
    [EnumMember(Value = "CUPR")]
    [IsoId("_DTCCSubEventType11Code_NameAndCUSIPChangeAndPresentationRequired")]
    [Description(@"Name change with both CUSIP change and presentation required.")]
    NameAndCUSIPChangeAndPresentationRequired = DTCCSubEventTypeCode.NameAndCUSIPChangeAndPresentationRequired,

    /// <summary>
    /// Name change with CUSIP change.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("_DTCCSubEventType11Code_NameAndCUSIPChange")]
    [Description(@"Name change with CUSIP change.")]
    NameAndCUSIPChange = DTCCSubEventTypeCode.NameAndCUSIPChange,

    /// <summary>
    /// Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC.
    /// Encoded/decoded by serializers as &quot;DRPD&quot;.
    /// </summary>
    [EnumMember(Value = "DRPD")]
    [IsoId("_DTCCSubEventType11Code_DividendReinvestmentByDTC")]
    [Description(@"Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC.")]
    DividendReinvestmentByDTC = DTCCSubEventTypeCode.DividendReinvestmentByDTC,

    /// <summary>
    /// Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC.
    /// Encoded/decoded by serializers as &quot;DRPI&quot;.
    /// </summary>
    [EnumMember(Value = "DRPI")]
    [IsoId("_DTCCSubEventType11Code_DividendReinvestmentByIssuer")]
    [Description(@"Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC.")]
    DividendReinvestmentByIssuer = DTCCSubEventTypeCode.DividendReinvestmentByIssuer,

    /// <summary>
    /// Identifies when a publicly traded partnership identifies amounts in excess of cumulative net income.
    /// Encoded/decoded by serializers as &quot;ECNI&quot;.
    /// </summary>
    [EnumMember(Value = "ECNI")]
    [IsoId("_DTCCSubEventType11Code_AmountsInExcessOfCumulativeNetIncome")]
    [Description(@"Identifies when a publicly traded partnership identifies amounts in excess of cumulative net income.")]
    AmountsInExcessOfCumulativeNetIncome = DTCCSubEventTypeCode.AmountsInExcessOfCumulativeNetIncome,

    /// <summary>
    /// Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.
    /// Encoded/decoded by serializers as &quot;FTPR&quot;.
    /// </summary>
    [EnumMember(Value = "FTPR")]
    [IsoId("_DTCCSubEventType11Code_OfferToPurchase")]
    [Description(@"Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.")]
    OfferToPurchase = DTCCSubEventTypeCode.OfferToPurchase,

    /// <summary>
    /// Identifies when the event security is a GDR.
    /// Encoded/decoded by serializers as &quot;GDRS&quot;.
    /// </summary>
    [EnumMember(Value = "GDRS")]
    [IsoId("_DTCCSubEventType11Code_GDR")]
    [Description(@"Identifies when the event security is a GDR.")]
    GDR = DTCCSubEventTypeCode.GDR,

    /// <summary>
    /// Identifies an event which has been considered a dividend equivalent payment under Section 871(m).
    /// Encoded/decoded by serializers as &quot;M871&quot;.
    /// </summary>
    [EnumMember(Value = "M871")]
    [IsoId("_DTCCSubEventType11Code_DividendEquivalentPayment871M")]
    [Description(@"Identifies an event which has been considered a dividend equivalent payment under Section 871(m).")]
    DividendEquivalentPayment871M = DTCCSubEventTypeCode.DividendEquivalentPayment871M,

    /// <summary>
    /// Indicates an event where the issue has an early redemption feature allowing the holder to elect to sell bonds back to the issuer on a monthly basis.
    /// Encoded/decoded by serializers as &quot;MBCK&quot;.
    /// </summary>
    [EnumMember(Value = "MBCK")]
    [IsoId("_DTCCSubEventType11Code_MortgageBacked")]
    [Description(@"Indicates an event where the issue has an early redemption feature allowing the holder to elect to sell bonds back to the issuer on a monthly basis.")]
    MortgageBacked = DTCCSubEventTypeCode.MortgageBacked,

    /// <summary>
    /// Identifies when a tender offer is a mini tender.
    /// Encoded/decoded by serializers as &quot;MITE&quot;.
    /// </summary>
    [EnumMember(Value = "MITE")]
    [IsoId("_DTCCSubEventType11Code_MiniTender")]
    [Description(@"Identifies when a tender offer is a mini tender.")]
    MiniTender = DTCCSubEventTypeCode.MiniTender,

    /// <summary>
    /// Identifies an event where redemption shares are issued in addition to shares of the original security.
    /// Encoded/decoded by serializers as &quot;MROS&quot;.
    /// </summary>
    [EnumMember(Value = "MROS")]
    [IsoId("_DTCCSubEventType11Code_MandatoryRedemptionOfShares")]
    [Description(@"Identifies an event where redemption shares are issued in addition to shares of the original security.")]
    MandatoryRedemptionOfShares = DTCCSubEventTypeCode.MandatoryRedemptionOfShares,

    /// <summary>
    /// Identifies a MMI Important Notice.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_DTCCSubEventType11Code_ImportantNotice")]
    [Description(@"Identifies a MMI Important Notice.")]
    ImportantNotice = DTCCSubEventTypeCode.ImportantNotice,

    /// <summary>
    /// Identifies an event in certain markets where underlying rights are not issued.
    /// Encoded/decoded by serializers as &quot;OPOF&quot;.
    /// </summary>
    [EnumMember(Value = "OPOF")]
    [IsoId("_DTCCSubEventType11Code_OpenOffer")]
    [Description(@"Identifies an event in certain markets where underlying rights are not issued.")]
    OpenOffer = DTCCSubEventTypeCode.OpenOffer,

    /// <summary>
    /// Identifies an event where DTC offers a DRIP option as a default option (holder must opt out).
    /// Encoded/decoded by serializers as &quot;OPTO&quot;.
    /// </summary>
    [EnumMember(Value = "OPTO")]
    [IsoId("_DTCCSubEventType11Code_OptOut")]
    [Description(@"Identifies an event where DTC offers a DRIP option as a default option (holder must opt out).")]
    OptOut = DTCCSubEventTypeCode.OptOut,

    /// <summary>
    /// Identifies a change in the place where the security is listed.
    /// Encoded/decoded by serializers as &quot;PLCL&quot;.
    /// </summary>
    [EnumMember(Value = "PLCL")]
    [IsoId("_DTCCSubEventType11Code_PlaceOfListing")]
    [Description(@"Identifies a change in the place where the security is listed.")]
    PlaceOfListing = DTCCSubEventTypeCode.PlaceOfListing,

    /// <summary>
    /// Identifies sale of rights event where issuers redeem poison pill rights.
    /// Encoded/decoded by serializers as &quot;POPI&quot;.
    /// </summary>
    [EnumMember(Value = "POPI")]
    [IsoId("_DTCCSubEventType11Code_PoisonPill")]
    [Description(@"Identifies sale of rights event where issuers redeem poison pill rights.")]
    PoisonPill = DTCCSubEventTypeCode.PoisonPill,

    /// <summary>
    /// Identifies an event where the presentation of securities will be required.
    /// Encoded/decoded by serializers as &quot;PREQ&quot;.
    /// </summary>
    [EnumMember(Value = "PREQ")]
    [IsoId("_DTCCSubEventType11Code_PresentationRequired")]
    [Description(@"Identifies an event where the presentation of securities will be required.")]
    PresentationRequired = DTCCSubEventTypeCode.PresentationRequired,

    /// <summary>
    /// Identifies an event where the company is not issuing a security with the right to subscribe for additional shares.
    /// Encoded/decoded by serializers as &quot;PRNI&quot;.
    /// </summary>
    [EnumMember(Value = "PRNI")]
    [IsoId("_DTCCSubEventType11Code_PhysicalRightsNotIssued")]
    [Description(@"Identifies an event where the company is not issuing a security with the right to subscribe for additional shares.")]
    PhysicalRightsNotIssued = DTCCSubEventTypeCode.PhysicalRightsNotIssued,

    /// <summary>
    /// Identifies a qualified notice issued by a publicly traded partnership.
    /// Encoded/decoded by serializers as &quot;QN92&quot;.
    /// </summary>
    [EnumMember(Value = "QN92")]
    [IsoId("_DTCCSubEventType11Code_ExemptionQualifiedNotice92Days")]
    [Description(@"Identifies a qualified notice issued by a publicly traded partnership.")]
    ExemptionQualifiedNotice92Days = DTCCSubEventTypeCode.ExemptionQualifiedNotice92Days,

    /// <summary>
    /// Identifies distributions that have multiple components for tax withholding and 1042-S reporting purposes.
    /// Encoded/decoded by serializers as &quot;RCLA&quot;.
    /// </summary>
    [EnumMember(Value = "RCLA")]
    [IsoId("_DTCCSubEventType11Code_Classification1042S")]
    [Description(@"Identifies distributions that have multiple components for tax withholding and 1042-S reporting purposes.")]
    Classification1042S = DTCCSubEventTypeCode.Classification1042S,

    /// <summary>
    /// Identifies an event which will be based on record date holdings.
    /// Encoded/decoded by serializers as &quot;RDTH&quot;.
    /// </summary>
    [EnumMember(Value = "RDTH")]
    [IsoId("_DTCCSubEventType11Code_BasedOnRecordDateHoldings")]
    [Description(@"Identifies an event which will be based on record date holdings.")]
    BasedOnRecordDateHoldings = DTCCSubEventTypeCode.BasedOnRecordDateHoldings,

    /// <summary>
    /// Identifies an exchange offer on securities that are subject to securities rule Reg S.
    /// Encoded/decoded by serializers as &quot;REGS&quot;.
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_DTCCSubEventType11Code_RegulationS")]
    [Description(@"Identifies an exchange offer on securities that are subject to securities rule Reg S.")]
    RegulationS = DTCCSubEventTypeCode.RegulationS,

    /// <summary>
    /// Identifies an event that involves a Stock Purchase Contract product offering an early settlement or remarketing feature.
    /// Encoded/decoded by serializers as &quot;RMRK&quot;.
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_DTCCSubEventType11Code_Remarketing")]
    [Description(@"Identifies an event that involves a Stock Purchase Contract product offering an early settlement or remarketing feature.")]
    Remarketing = DTCCSubEventTypeCode.Remarketing,

    /// <summary>
    /// Identifies an event where the distribution is from the proceeds of the sale of assets.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_DTCCSubEventType11Code_SaleOfAssets")]
    [Description(@"Identifies an event where the distribution is from the proceeds of the sale of assets.")]
    SaleOfAssets = DTCCSubEventTypeCode.SaleOfAssets,

    /// <summary>
    /// Identifies an event where the payout will be securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_DTCCSubEventType11Code_Securities")]
    [Description(@"Identifies an event where the payout will be securities.")]
    Securities = DTCCSubEventTypeCode.Securities,

    /// <summary>
    /// Identifies when a tender offer is a self tender.
    /// Encoded/decoded by serializers as &quot;SETE&quot;.
    /// </summary>
    [EnumMember(Value = "SETE")]
    [IsoId("_DTCCSubEventType11Code_SelfTender")]
    [Description(@"Identifies when a tender offer is a self tender.")]
    SelfTender = DTCCSubEventTypeCode.SelfTender,

    /// <summary>
    /// Identifies an event where two companies exchange their shares during a merger.
    /// Encoded/decoded by serializers as &quot;SHEX&quot;.
    /// </summary>
    [EnumMember(Value = "SHEX")]
    [IsoId("_DTCCSubEventType11Code_ShareExchange")]
    [Description(@"Identifies an event where two companies exchange their shares during a merger.")]
    ShareExchange = DTCCSubEventTypeCode.ShareExchange,

    /// <summary>
    /// Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange.
    /// Encoded/decoded by serializers as &quot;SHPP&quot;.
    /// </summary>
    [EnumMember(Value = "SHPP")]
    [IsoId("_DTCCSubEventType11Code_SharePurchasePlan")]
    [Description(@"Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange.")]
    SharePurchasePlan = DTCCSubEventTypeCode.SharePurchasePlan,

    /// <summary>
    /// Indicates an event where the Issue has an early redemption feature allowing the holder to elect to sell bonds back to the issuer.
    /// Encoded/decoded by serializers as &quot;SOPT&quot;.
    /// </summary>
    [EnumMember(Value = "SOPT")]
    [IsoId("_DTCCSubEventType11Code_SurvivorOptions")]
    [Description(@"Indicates an event where the Issue has an early redemption feature allowing the holder to elect to sell bonds back to the issuer.")]
    SurvivorOptions = DTCCSubEventTypeCode.SurvivorOptions,

    /// <summary>
    /// Specified purpose acquisition companies (SPACs) are public companies comprised of cash available to investors in financial markets.
    /// Encoded/decoded by serializers as &quot;SPAC&quot;.
    /// </summary>
    [EnumMember(Value = "SPAC")]
    [IsoId("_DTCCSubEventType11Code_SpecialPurposeAcquisitionCompany")]
    [Description(@"Specified purpose acquisition companies (SPACs) are public companies comprised of cash available to investors in financial markets.")]
    SpecialPurposeAcquisitionCompany = DTCCSubEventTypeCode.SpecialPurposeAcquisitionCompany,

    /// <summary>
    /// Identifies an event where one company merges with the other and assumes the name of the surviving company.
    /// Encoded/decoded by serializers as &quot;STDT&quot;.
    /// </summary>
    [EnumMember(Value = "STDT")]
    [IsoId("_DTCCSubEventType11Code_Standard")]
    [Description(@"Identifies an event where one company merges with the other and assumes the name of the surviving company.")]
    Standard = DTCCSubEventTypeCode.Standard,

    /// <summary>
    /// Identifies a tender offer event on a Rights security.
    /// Encoded/decoded by serializers as &quot;TWRI&quot;.
    /// </summary>
    [EnumMember(Value = "TWRI")]
    [IsoId("_DTCCSubEventType11Code_TenderWithRights")]
    [Description(@"Identifies a tender offer event on a Rights security.")]
    TenderWithRights = DTCCSubEventTypeCode.TenderWithRights,

    /// <summary>
    /// Identifies a combination of assets or types of assets packaged together and sold as one.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_DTCCSubEventType11Code_UnitCombination")]
    [Description(@"Identifies a combination of assets or types of assets packaged together and sold as one.")]
    UnitCombination = DTCCSubEventTypeCode.UnitCombination,

    /// <summary>
    /// Identifies an event where unwinding of the basket of securities occurs.
    /// Encoded/decoded by serializers as &quot;UNWD&quot;.
    /// </summary>
    [EnumMember(Value = "UNWD")]
    [IsoId("_DTCCSubEventType11Code_Unwind")]
    [Description(@"Identifies an event where unwinding of the basket of securities occurs.")]
    Unwind = DTCCSubEventTypeCode.Unwind,

    /// <summary>
    /// Event where creditors whose claims are impaired are entitled to vote.
    /// Encoded/decoded by serializers as &quot;VOTE&quot;.
    /// </summary>
    [EnumMember(Value = "VOTE")]
    [IsoId("_DTCCSubEventType11Code_Vote")]
    [Description(@"Event where creditors whose claims are impaired are entitled to vote.")]
    Vote,

    /// <summary>
    /// Identifies a consent event with payout.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_DTCCSubEventType11Code_WithPayout")]
    [Description(@"Identifies a consent event with payout.")]
    WithPayout = DTCCSubEventTypeCode.WithPayout,

    /// <summary>
    /// Identifies a consent event without payout.
    /// Encoded/decoded by serializers as &quot;WITO&quot;.
    /// </summary>
    [EnumMember(Value = "WITO")]
    [IsoId("_DTCCSubEventType11Code_WithoutPayout")]
    [Description(@"Identifies a consent event without payout.")]
    WithoutPayout = DTCCSubEventTypeCode.WithoutPayout,

    /// <summary>
    /// Identifies an event where one company transfers all of its shares to a newly created company.
    /// Encoded/decoded by serializers as &quot;XFER&quot;.
    /// </summary>
    [EnumMember(Value = "XFER")]
    [IsoId("_DTCCSubEventType11Code_Transfer")]
    [Description(@"Identifies an event where one company transfers all of its shares to a newly created company.")]
    Transfer = DTCCSubEventTypeCode.Transfer,

}
