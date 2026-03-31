// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing Batch Data3.
/// </summary>
[IsoId("_2snkEY1IEe6S0_1AaJzQCA")]
[DisplayName("Clearing Batch Data3")]
public record ClearingBatchData3
{
    /// <summary>
    /// Agent Fee Amount.
    /// </summary>
    [DisplayName("Agent Fee Amount")]
    [IsoXmlTag("AgtFeeAmt")]
    public ImpliedCurrencyAndAmount? AgentFeeAmount { get; init; }

    /// <summary>
    /// Agent Fee Credit Debit.
    /// </summary>
    [DisplayName("Agent Fee Credit Debit")]
    [IsoXmlTag("AgtFeeCdtDbt")]
    public CreditDebit3Code? AgentFeeCreditDebit { get; init; }

    /// <summary>
    /// Agent Fee Currency.
    /// </summary>
    [DisplayName("Agent Fee Currency")]
    [IsoXmlTag("AgtFeeCcy")]
    public ISO3NumericCurrencyCode? AgentFeeCurrency { get; init; }

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Interchange Fee Amount.
    /// </summary>
    [DisplayName("Interchange Fee Amount")]
    [IsoXmlTag("IntrchngFeeAmt")]
    public ImpliedCurrencyAndAmount? InterchangeFeeAmount { get; init; }

    /// <summary>
    /// Interchange Fee Credit Debit.
    /// </summary>
    [DisplayName("Interchange Fee Credit Debit")]
    [IsoXmlTag("IntrchngFeeCdtDbt")]
    public CreditDebit3Code? InterchangeFeeCreditDebit { get; init; }

    /// <summary>
    /// Interchange Fee Currency.
    /// </summary>
    [DisplayName("Interchange Fee Currency")]
    [IsoXmlTag("IntrchngFeeCcy")]
    public ISO3NumericCurrencyCode? InterchangeFeeCurrency { get; init; }

    /// <summary>
    /// Method.
    /// </summary>
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required ClearingMethod2Code Method { get; init; }

    /// <summary>
    /// Other Method.
    /// </summary>
    [DisplayName("Other Method")]
    [IsoXmlTag("OthrMtd")]
    public IsoMax35Text? OtherMethod { get; init; }

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public IsoMax35Text? Priority { get; init; }

    /// <summary>
    /// Totals Amount.
    /// </summary>
    [DisplayName("Totals Amount")]
    [IsoXmlTag("TtlsAmt")]
    public ImpliedCurrencyAndAmount? TotalsAmount { get; init; }

    /// <summary>
    /// Totals Count.
    /// </summary>
    [DisplayName("Totals Count")]
    [IsoXmlTag("TtlsCnt")]
    public IsoNumber? TotalsCount { get; init; }

    /// <summary>
    /// Totals Credit Debit.
    /// </summary>
    [DisplayName("Totals Credit Debit")]
    [IsoXmlTag("TtlsCdtDbt")]
    public CreditDebit3Code? TotalsCreditDebit { get; init; }

    /// <summary>
    /// Totals Currency.
    /// </summary>
    [DisplayName("Totals Currency")]
    [IsoXmlTag("TtlsCcy")]
    public ISO3NumericCurrencyCode? TotalsCurrency { get; init; }
}
