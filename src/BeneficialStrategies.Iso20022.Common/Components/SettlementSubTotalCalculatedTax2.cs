// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the subtotal calculated tax applicable for this settlement.
/// </summary>
[IsoId("_sGUvgKtnEeSPCbFcs9Ilyw")]
[DisplayName("Settlement Sub Total Calculated Tax")]
public record SettlementSubTotalCalculatedTax2
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_A84usKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Type Code")]
    [IsoXmlTag("TpCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? TypeCode { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of this tax, levy or duty.
    /// </summary>
    [IsoId("_S-CnAKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Calculated Rate")]
    [IsoXmlTag("ClctdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CalculatedRate { get; init; }

    /// <summary>
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    [IsoId("_PI8kwKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Basis Amount")]
    [IsoXmlTag("BsisAmt")]
    public CurrencyAndAmount? BasisAmount { get; init; }

    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    [IsoId("_Khf4gKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Calculated Amount")]
    [IsoXmlTag("ClctdAmt")]
    public CurrencyAndAmount? CalculatedAmount { get; init; }

    /// <summary>
    /// Reason for tax exemption expressed as a code, if invoice or card transaction is out of tax processing.
    /// </summary>
    [IsoId("_ZH9yoKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Exemption Reason Code")]
    [IsoXmlTag("XmptnRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? ExemptionReasonCode { get; init; }

    /// <summary>
    /// Reason for a tax exemption, if invoice or card transaction is out of tax processing.
    /// </summary>
    [IsoId("_-mMusKtoEeSPCbFcs9Ilyw")]
    [DisplayName("Exemption Reason Text")]
    [IsoXmlTag("XmptnRsnTxt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? ExemptionReasonText { get; init; }

    /// <summary>
    /// If tax currency in tax calculation is different from invoice currency, then applied exchange rate is given in this message structure.
    /// </summary>
    [IsoId("_WOKf4KuoEeSmE8_WfXaYYg")]
    [DisplayName("Tax Currency Exchange")]
    [IsoXmlTag("TaxCcyXchg")]
    public CurrencyReference3? TaxCurrencyExchange { get; init; }
}
