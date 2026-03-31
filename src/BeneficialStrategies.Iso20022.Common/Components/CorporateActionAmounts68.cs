// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Amounts68.
/// </summary>
[IsoId("_U1ardXSdEe6VWZz2tTgENw")]
[DisplayName("Corporate Action Amounts68")]
public record CorporateActionAmounts68
{
    /// <summary>
    /// Accrued Interest Amount.
    /// </summary>
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Additional Tax Amount.
    /// </summary>
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Back Up Withholding Tax Amount.
    /// </summary>
    [DisplayName("Back Up Withholding Tax Amount")]
    [IsoXmlTag("BckUpWhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; }

    /// <summary>
    /// Buy Up Amount.
    /// </summary>
    [DisplayName("Buy Up Amount")]
    [IsoXmlTag("BuyUpAmt")]
    public RestrictedFINActiveCurrencyAndAmount? BuyUpAmount { get; init; }

    /// <summary>
    /// Capital Gain.
    /// </summary>
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public RestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Cash In Lieu Of Share.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Charges Amount.
    /// </summary>
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Deemed Amount.
    /// </summary>
    [DisplayName("Deemed Amount")]
    [IsoXmlTag("DmdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedAmount { get; init; }

    /// <summary>
    /// Deemed Dividend Amount.
    /// </summary>
    [DisplayName("Deemed Dividend Amount")]
    [IsoXmlTag("DmdDvddAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedDividendAmount { get; init; }

    /// <summary>
    /// Deemed Fund Amount.
    /// </summary>
    [DisplayName("Deemed Fund Amount")]
    [IsoXmlTag("DmdFndAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedFundAmount { get; init; }

    /// <summary>
    /// Deemed Interest Amount.
    /// </summary>
    [DisplayName("Deemed Interest Amount")]
    [IsoXmlTag("DmdIntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedInterestAmount { get; init; }

    /// <summary>
    /// Deemed Royalties Amount.
    /// </summary>
    [DisplayName("Deemed Royalties Amount")]
    [IsoXmlTag("DmdRyltsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedRoyaltiesAmount { get; init; }

    /// <summary>
    /// Entitled Amount.
    /// </summary>
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Equalisation Amount.
    /// </summary>
    [DisplayName("Equalisation Amount")]
    [IsoXmlTag("EqulstnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; }

    /// <summary>
    /// Executing Broker Amount.
    /// </summary>
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// FATCA Tax Amount.
    /// </summary>
    [DisplayName("FATCA Tax Amount")]
    [IsoXmlTag("FATCATaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; }

    /// <summary>
    /// Fiscal Stamp Amount.
    /// </summary>
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Foreign Income Amount.
    /// </summary>
    [DisplayName("Foreign Income Amount")]
    [IsoXmlTag("FrgnIncmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ForeignIncomeAmount { get; init; }

    /// <summary>
    /// Fully Franked Amount.
    /// </summary>
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Gross Cash Amount.
    /// </summary>
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Income Portion.
    /// </summary>
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public RestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; }

    /// <summary>
    /// Indemnity Amount.
    /// </summary>
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Interest Amount.
    /// </summary>
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// Local Broker Commission Amount.
    /// </summary>
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Manufactured Dividend Payment Amount.
    /// </summary>
    [DisplayName("Manufactured Dividend Payment Amount")]
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; }

    /// <summary>
    /// Market Claim Amount.
    /// </summary>
    [DisplayName("Market Claim Amount")]
    [IsoXmlTag("MktClmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; }

    /// <summary>
    /// Net Cash Amount.
    /// </summary>
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// NRA Tax Amount.
    /// </summary>
    [DisplayName("NRA Tax Amount")]
    [IsoXmlTag("NRATaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; }

    /// <summary>
    /// Original Amount.
    /// </summary>
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public RestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Paying Agent Commission Amount.
    /// </summary>
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Regulatory Fees Amount.
    /// </summary>
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// Reinvestment Amount.
    /// </summary>
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Second Level Tax Amount.
    /// </summary>
    [DisplayName("Second Level Tax Amount")]
    [IsoXmlTag("ScndLvlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; }

    /// <summary>
    /// Shipping Fees Amount.
    /// </summary>
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Solicitation Fees.
    /// </summary>
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public RestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Stamp Duty Amount.
    /// </summary>
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Sundry Or Other Amount.
    /// </summary>
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Tax Credit Amount.
    /// </summary>
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Tax Deferred Amount.
    /// </summary>
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Tax Free Amount.
    /// </summary>
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Tax On Income Amount.
    /// </summary>
    [DisplayName("Tax On Income Amount")]
    [IsoXmlTag("TaxOnIncmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; }

    /// <summary>
    /// Tax Reclaim Amount.
    /// </summary>
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Transaction Tax.
    /// </summary>
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; }

    /// <summary>
    /// Unfranked Amount.
    /// </summary>
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Value Added Tax Amount.
    /// </summary>
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Withholding Tax Amount.
    /// </summary>
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }
}
