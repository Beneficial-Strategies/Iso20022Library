// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the cash posted as collateral.
/// </summary>
[IsoId("_3yXwUWNwEeSIWbZ6by9dnA")]
[DisplayName("Cash Collateral")]
public record CashCollateral3
{
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_TzbnkG8HEeSo8eobdW7kLw")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; }

    /// <summary>
    /// Provides the identification of the clearing member &apos;s cash account.
    /// </summary>
    [IsoId("_pst84GNzEeSIWbZ6by9dnA")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Amount of the deposit.
    /// </summary>
    [IsoId("_4QYiAWNwEeSIWbZ6by9dnA")]
    [DisplayName("Deposit Amount")]
    [IsoXmlTag("DpstAmt")]
    public ActiveCurrencyAndAmount? DepositAmount { get; init; }

    /// <summary>
    /// Specifies whether the deposit is fixed term or call/notice.
    /// </summary>
    [IsoId("_4QYiA2NwEeSIWbZ6by9dnA")]
    [DisplayName("Deposit Type")]
    [IsoXmlTag("DpstTp")]
    public DepositType1Code? DepositType { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_4QYiBWNwEeSIWbZ6by9dnA")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Valuation date of the cash taken as collateral.
    /// </summary>
    [IsoId("_4QYiB2NwEeSIWbZ6by9dnA")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_4QYiCWNwEeSIWbZ6by9dnA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_4QYiC2NwEeSIWbZ6by9dnA")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_4QYiDWNwEeSIWbZ6by9dnA")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; }
}
