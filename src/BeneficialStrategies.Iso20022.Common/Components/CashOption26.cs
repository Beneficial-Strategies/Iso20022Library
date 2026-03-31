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
[IsoId("_oiSXsRFMEeKp2ZN13DI_pA")]
[DisplayName("Cash Option")]
public record CashOption26
{
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_o22SeRFMEeKp2ZN13DI_pA")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    [IsoId("_o22SgxFMEeKp2ZN13DI_pA")]
    [DisplayName("Contractual Payment Indicator")]
    [IsoXmlTag("CtrctlPmtInd")]
    public Payment1Code? ContractualPaymentIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_o22SjRFMEeKp2ZN13DI_pA")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification20? IncomeType { get; init; }

    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_o22SlxFMEeKp2ZN13DI_pA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account8Choice_? Account { get; init; }

    /// <summary>
    /// Provides information about cash parties.
    /// </summary>
    [IsoId("_o22SoRFMEeKp2ZN13DI_pA")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties10? CashParties { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_o22SqxFMEeKp2ZN13DI_pA")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public required CorporateActionAmounts23 AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_o22StRFMEeKp2ZN13DI_pA")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate24 DateDetails { get; init; }

    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_o22SvxFMEeKp2ZN13DI_pA")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms11? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Provides information about the tax voucher related to a cash movement.
    /// </summary>
    [IsoId("_o22SyRFMEeKp2ZN13DI_pA")]
    [DisplayName("Tax Voucher Details")]
    [IsoXmlTag("TaxVchrDtls")]
    public TaxVoucher2? TaxVoucherDetails { get; init; }

    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_o22S0xFMEeKp2ZN13DI_pA")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public RateDetails11? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_o22S1xFMEeKp2ZN13DI_pA")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails11? PriceDetails { get; init; }
}
