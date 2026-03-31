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
[IsoId("_Ju3igeGiEd-1Ktb5rVaajw")]
[DisplayName("Cash Option")]
public record CashOption10
{
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_Ju3ig-GiEd-1Ktb5rVaajw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_Ju3iheGiEd-1Ktb5rVaajw")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_Ju3ih-GiEd-1Ktb5rVaajw")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification20? IncomeType { get; init; }

    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    [IsoId("_Ju3iieGiEd-1Ktb5rVaajw")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_Ju3ii-GiEd-1Ktb5rVaajw")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts10? AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_Ju3ijeGiEd-1Ktb5rVaajw")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate17 DateDetails { get; init; }

    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_Ju3ij-GiEd-1Ktb5rVaajw")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms13? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_R72N0OsgEd-b_I-JAnHTUQ")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public RateDetails3? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_5aLIzOzaEd-Z2q4-Bbm3ZA")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails3? PriceDetails { get; init; }
}
