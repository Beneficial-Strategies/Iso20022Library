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
[IsoId("_lmO2MSXxEeO4bIO_HtGo9Q")]
[DisplayName("Cash Option")]
public record CashOption30
{
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_l9lmRSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    [IsoId("_l9lmTSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Contractual Payment Indicator")]
    [IsoXmlTag("CtrctlPmtInd")]
    public Payment1Code? ContractualPaymentIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_l9lmVSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification20? IncomeType { get; init; }

    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_okWDoSeSEeOXAt_43VmZGw")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public GenericIdentification20? ExemptionType { get; init; }

    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_l9lmXSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account8Choice_? Account { get; init; }

    /// <summary>
    /// Provides information about cash parties.
    /// </summary>
    [IsoId("_l9lmZSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties10? CashParties { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_l9lmbSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public required CorporateActionAmounts29 AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_l9lmdSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate24 DateDetails { get; init; }

    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_l9lmfSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms11? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Provides information about the tax voucher related to a cash movement.
    /// </summary>
    [IsoId("_l9lmhSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Tax Voucher Details")]
    [IsoXmlTag("TaxVchrDtls")]
    public TaxVoucher2? TaxVoucherDetails { get; init; }

    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_l9lmjSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public RateDetails15? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_l9lmjyXxEeO4bIO_HtGo9Q")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails14? PriceDetails { get; init; }
}
