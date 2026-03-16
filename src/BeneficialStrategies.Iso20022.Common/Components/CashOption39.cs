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
[IsoId("_OeDJYVkxEeSiQOnYSp7BZg")]
[DisplayName("Cash Option")]
public record CashOption39
{
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_O7WwdVkxEeSiQOnYSp7BZg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    [IsoId("_O7WwfVkxEeSiQOnYSp7BZg")]
    [DisplayName("Contractual Payment Indicator")]
    [IsoXmlTag("CtrctlPmtInd")]
    public Payment1Code? ContractualPaymentIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_O7WwhVkxEeSiQOnYSp7BZg")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification20? IncomeType { get; init; }

    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_O7WwjVkxEeSiQOnYSp7BZg")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification20> ExemptionType { get; init; } = [];

    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_O7Wwj1kxEeSiQOnYSp7BZg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account8Choice_? Account { get; init; }

    /// <summary>
    /// Provides information about cash parties.
    /// </summary>
    [IsoId("_O7Wwl1kxEeSiQOnYSp7BZg")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties21? CashParties { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_O7Wwn1kxEeSiQOnYSp7BZg")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public required CorporateActionAmounts29 AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_O7Wwp1kxEeSiQOnYSp7BZg")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate24 DateDetails { get; init; }

    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_O7Wwr1kxEeSiQOnYSp7BZg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms11? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Provides information about the tax voucher related to a cash movement.
    /// </summary>
    [IsoId("_O7Wwt1kxEeSiQOnYSp7BZg")]
    [DisplayName("Tax Voucher Details")]
    [IsoXmlTag("TaxVchrDtls")]
    public TaxVoucher2? TaxVoucherDetails { get; init; }

    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_O7Wwv1kxEeSiQOnYSp7BZg")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public RateDetails15? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_O7WwwVkxEeSiQOnYSp7BZg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails14? PriceDetails { get; init; }
}
