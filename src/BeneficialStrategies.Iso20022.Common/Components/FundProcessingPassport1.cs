// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fund Processing Passsport (FPP) is a fully harmonised document with all key operational information that fund promoters should provide on their investment funds in order to facilitate their trading.
/// </summary>
[IsoId("_Q5ZrMtp-Ed-ak6NoX_4Aeg_1497334338")]
[DisplayName("Fund Processing Passport")]
public record FundProcessingPassport1
{
    /// <summary>
    /// Date of last revision.
    /// </summary>
    [IsoId("_Q5ZrM9p-Ed-ak6NoX_4Aeg_781465456")]
    [DisplayName("Updated Date")]
    [IsoXmlTag("UpdtdDt")]
    public required UpdatedDate UpdatedDate { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_Q5ZrNNp-Ed-ak6NoX_4Aeg_-501321207")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification1 SecurityIdentification { get; init; }

    /// <summary>
    /// Principal entity appointed by the fund, to which orders should be submitted. Usually located in the country of domicile.
    /// </summary>
    [IsoId("_Q5ZrNdp-Ed-ak6NoX_4Aeg_-628195757")]
    [DisplayName("Main Fund Order Desk")]
    [IsoXmlTag("MainFndOrdrDsk")]
    public required ContactAttributes1 MainFundOrderDesk { get; init; }

    /// <summary>
    /// Company that is responsible for the management and operation of the fund, eg, determines the investment strategy, appoints
    /// the service providers, and makes major decisions for the fund. It is usually responsible for the distribution and marketing
    /// of the fund. For self-managed funds, this wlll often be a separate promoter or sponsor of the fund.
    /// </summary>
    [IsoId("_Q5ZrNtp-Ed-ak6NoX_4Aeg_-1464343138")]
    [DisplayName("Fund Management Company")]
    [IsoXmlTag("FndMgmtCpny")]
    public required ContactAttributes1 FundManagementCompany { get; init; }

    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    [IsoId("_Q5ZrN9p-Ed-ak6NoX_4Aeg_547053647")]
    [DisplayName("Fund Details")]
    [IsoXmlTag("FndDtls")]
    public required FinancialInstrument20 FundDetails { get; init; }

    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5ZrONp-Ed-ak6NoX_4Aeg_1029129650")]
    [DisplayName("Valuation Dealing Characteristics")]
    [IsoXmlTag("ValtnDealgChrtcs")]
    public required ValuationDealingProcessingCharacteristics2 ValuationDealingCharacteristics { get; init; }

    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5ZrOdp-Ed-ak6NoX_4Aeg_-477353454")]
    [DisplayName("Investment Restrictions")]
    [IsoXmlTag("InvstmtRstrctns")]
    public required InvestmentRestrictions2 InvestmentRestrictions { get; init; }

    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5jcMNp-Ed-ak6NoX_4Aeg_269854257")]
    [DisplayName("Subscription Processing Characteristics")]
    [IsoXmlTag("SbcptPrcgChrtcs")]
    public required ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; }

    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5jcMdp-Ed-ak6NoX_4Aeg_2027637475")]
    [DisplayName("Redemption Processing Characteristics")]
    [IsoXmlTag("RedPrcgChrtcs")]
    public required ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_Q5jcMtp-Ed-ak6NoX_4Aeg_-1685996653")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public ValueList<CashAccount22> SettlementDetails { get; init; } = [];

    // ID for the above is _Q5jcMtp-Ed-ak6NoX_4Aeg_-1685996653

    /// <summary>
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    [IsoId("_Q5jcM9p-Ed-ak6NoX_4Aeg_4177264")]
    [DisplayName("Local Market Annex")]
    [IsoXmlTag("LclMktAnx")]
    public LocalMarketAnnex2? LocalMarketAnnex { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Q5jcNNp-Ed-ak6NoX_4Aeg_113830738")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
