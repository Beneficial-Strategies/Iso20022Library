// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fund reference data.
/// </summary>
[IsoId("_bbb7sTQbEeifw8iDiyZLmQ")]
[DisplayName("Fund Reference Data Report")]
public record FundReferenceDataReport1
{
    /// <summary>
    /// Unique technical identifier for an instance of a report within a fund reference data report, as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_sG7E0V9NEeicg40_9gK9vQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Version Number. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00001 and is the version of the template for which the EMT data is provided. In EMT v1, this element is not supported.
    /// </summary>
    [IsoId("_sMKzIIvtEeicrr-UkGlMQA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public MarketPracticeVersion1? Version { get; init; }

    /// <summary>
    /// Date to which the data refers. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00050. In EMT v1, this is known as the Reporting Date.
    /// </summary>
    [IsoId("_467fkDQbEeifw8iDiyZLmQ")]
    [DisplayName("General Reference Date")]
    [IsoXmlTag("GnlRefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate GeneralReferenceDate { get; init; }

    /// <summary>
    /// Identification of the security.
    /// </summary>
    [IsoId("_buLRgzQbEeifw8iDiyZLmQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification36 SecurityIdentification { get; init; }

    /// <summary>
    /// Parties related to the investment fund.
    /// </summary>
    [IsoId("__lb_0F_5EeiNMJ262H2pWg")]
    [DisplayName("Fund Parties")]
    [IsoXmlTag("FndPties")]
    public FundParties1? FundParties { get; init; }

    /// <summary>
    /// Principal entity appointed by the fund, to which orders should be submitted. Usually located in the country of domicile.
    /// </summary>
    [IsoId("_buLRhTQbEeifw8iDiyZLmQ")]
    [DisplayName("Main Fund Order Desk")]
    [IsoXmlTag("MainFndOrdrDsk")]
    public OrderDesk1? MainFundOrderDesk { get; init; }

    /// <summary>
    /// Company that is responsible for the management and operation of the fund, for example, determines the investment strategy, appoints the service providers, and makes major decisions for the fund. It is usually responsible for the distribution and marketing of the fund. For self-managed funds, this will often be a separate promoter or sponsor of the fund.
    /// </summary>
    [IsoId("_buLRhzQbEeifw8iDiyZLmQ")]
    [DisplayName("Fund Management Company")]
    [IsoXmlTag("FndMgmtCpny")]
    public ContactAttributes5? FundManagementCompany { get; init; }

    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
    /// </summary>
    [IsoId("_buLRiTQbEeifw8iDiyZLmQ")]
    [DisplayName("Fund Details")]
    [IsoXmlTag("FndDtls")]
    public FinancialInstrument66? FundDetails { get; init; }

    /// <summary>
    /// Processing characteristics linked to the instrument, that is, not to the market.
    /// </summary>
    [IsoId("_buLRizQbEeifw8iDiyZLmQ")]
    [DisplayName("Valuation Dealing Characteristics")]
    [IsoXmlTag("ValtnDealgChrtcs")]
    public ValuationDealingProcessingCharacteristics3? ValuationDealingCharacteristics { get; init; }

    /// <summary>
    /// Investment restrictions linked to the trading of the investment fund or an alternative/hedge fund.
    /// </summary>
    [IsoId("_buLRjTQbEeifw8iDiyZLmQ")]
    [DisplayName("Investment Restrictions")]
    [IsoXmlTag("InvstmtRstrctns")]
    public InvestmentRestrictions3? InvestmentRestrictions { get; init; }

    /// <summary>
    /// Processing characteristics linked to a subscription to the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_buLRjzQbEeifw8iDiyZLmQ")]
    [DisplayName("Subscription Processing Characteristics")]
    [IsoXmlTag("SbcptPrcgChrtcs")]
    public ProcessingCharacteristics4? SubscriptionProcessingCharacteristics { get; init; }

    /// <summary>
    /// Processing characteristics linked to a redemption to the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_buLRkTQbEeifw8iDiyZLmQ")]
    [DisplayName("Redemption Processing Characteristics")]
    [IsoXmlTag("RedPrcgChrtcs")]
    public ProcessingCharacteristics5? RedemptionProcessingCharacteristics { get; init; }

    /// <summary>
    /// Processing characteristics linked to a switch of the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_XM02AF84Eeicg40_9gK9vQ")]
    [DisplayName("Switch Processing Characteristics")]
    [IsoXmlTag("SwtchPrcgChrtcs")]
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; }

    /// <summary>
    /// Characteristics of the investment plan.
    /// </summary>
    [IsoId("_bmKmEF8-Eeicg40_9gK9vQ")]
    [DisplayName("Plan Characteristics")]
    [IsoXmlTag("PlanChrtcs")]
    public ValueList<InvestmentPlanCharacteristics1> PlanCharacteristics { get; init; } = [];

    /// <summary>
    /// Specifies, for a specific type of transaction, how amounts are to be paid in or paid out.
    /// </summary>
    [IsoId("_3_MBMF8qEeicg40_9gK9vQ")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public ValueList<PaymentInstrument16> PaymentInstrument { get; init; } = [];

    /// <summary>
    /// Account to be used for cash settlement.
    /// </summary>
    [IsoId("_buLRkzQbEeifw8iDiyZLmQ")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public ValueList<CashAccount202> CashSettlementDetails { get; init; } = [];

    /// <summary>
    /// Processing characteristics specific to a local fund order desk.
    /// </summary>
    [IsoId("_buLRlTQbEeifw8iDiyZLmQ")]
    [DisplayName("Local Market Annex")]
    [IsoXmlTag("LclMktAnx")]
    public ValueList<LocalMarketAnnex3> LocalMarketAnnex { get; init; } = [];

    /// <summary>
    /// Target market criteria.
    /// </summary>
    [IsoId("_u69HEDQpEeifw8iDiyZLmQ")]
    [DisplayName("Target Market")]
    [IsoXmlTag("TrgtMkt")]
    public TargetMarket1? TargetMarket { get; init; }

    /// <summary>
    /// Distribution strategy criteria.
    /// </summary>
    [IsoId("_Voos0DcfEeidBoT_PugKiA")]
    [DisplayName("Distribution Strategy")]
    [IsoXmlTag("DstrbtnStrtgy")]
    public DistributionStrategy1? DistributionStrategy { get; init; }

    /// <summary>
    /// Costs and charges associated with the distribution of selling of the financial instrument. These may be one-off or recurring. These may be ex ante (intended) or post ante (actual).
    /// </summary>
    [IsoId("_jSDBcDciEeidBoT_PugKiA")]
    [DisplayName("Costs And Charges")]
    [IsoXmlTag("CostsAndChrgs")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<CostsAndCharges1> CostsAndCharges { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_buLRlzQbEeifw8iDiyZLmQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
