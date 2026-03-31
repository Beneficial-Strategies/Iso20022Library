// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
[IsoId("_FVhZ8fo0EeCfbIXrKCjG0g")]
[DisplayName("Cash Option")]
public record CashOption16
{
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_FVhZ__o0EeCfbIXrKCjG0g")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    [IsoId("_FVhaCfo0EeCfbIXrKCjG0g")]
    [DisplayName("Contractual Payment Indicator")]
    [IsoXmlTag("CtrctlPmtInd")]
    public Payment1Code? ContractualPaymentIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_FVhaE_o0EeCfbIXrKCjG0g")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_F7q0Bfo0EeCfbIXrKCjG0g")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public IssuerTaxability1Code? IssuerOfferorTaxabilityIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_FVhaHfo0EeCfbIXrKCjG0g")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification20? IncomeType { get; init; }

    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    [IsoId("_FVhaJ_o0EeCfbIXrKCjG0g")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_FVhaMfo0EeCfbIXrKCjG0g")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts16? AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_FVhaP_o0EeCfbIXrKCjG0g")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate23 DateDetails { get; init; }

    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_FVhaSfo0EeCfbIXrKCjG0g")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms13? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_FVhaU_o0EeCfbIXrKCjG0g")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public RateDetails3? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_FVhaV_o0EeCfbIXrKCjG0g")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails6? PriceDetails { get; init; }
}
