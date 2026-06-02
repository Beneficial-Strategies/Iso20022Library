// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing data at batch level. Allows clearing in different currencies.
/// </summary>
[IsoId("_SxDRYW79EfC68Y4jZPNEug")]
[DisplayName("Clearing Batch Data4")]
public record ClearingBatchData4
{
    /// <summary>
    /// Type of clearing method used.
    /// </summary>
    [IsoId("_SzfhYW79EfC68Y4jZPNEug")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required ClearingMethod3Code Method { get; init; }

    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    [IsoId("_SzfhZW79EfC68Y4jZPNEug")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public IsoMax35Text? Priority { get; init; }

    /// <summary>
    /// Date of clearing.
    /// </summary>
    [IsoId("_SzfhZ279EfC68Y4jZPNEug")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Number of transactions to clear.
    /// </summary>
    [IsoId("_SzfhaW79EfC68Y4jZPNEug")]
    [DisplayName("Totals Count")]
    [IsoXmlTag("TtlsCnt")]
    public IsoNumber? TotalsCount { get; init; }

    /// <summary>
    /// Gross clearing accumulated amount.
    /// </summary>
    [IsoId("_Szfha279EfC68Y4jZPNEug")]
    [DisplayName("Totals Amount")]
    [IsoXmlTag("TtlsAmt")]
    public ImpliedCurrencyAndAmount? TotalsAmount { get; init; }

    /// <summary>
    /// Currency code of gross clearing accumulated amount.
    /// </summary>
    [IsoId("_SzfhbW79EfC68Y4jZPNEug")]
    [DisplayName("Totals Currency")]
    [IsoXmlTag("TtlsCcy")]
    public ISO3NumericCurrencyCode? TotalsCurrency { get; init; }

    /// <summary>
    /// Sign of the gross clearing accumulated amount.
    /// </summary>
    [IsoId("_Szfhb279EfC68Y4jZPNEug")]
    [DisplayName("Totals Credit Debit")]
    [IsoXmlTag("TtlsCdtDbt")]
    public CreditDebit3Code? TotalsCreditDebit { get; init; }

    /// <summary>
    /// Interchange fee amount.
    /// </summary>
    [IsoId("_SzfhcW79EfC68Y4jZPNEug")]
    [DisplayName("Interchange Fee Amount")]
    [IsoXmlTag("IntrchngFeeAmt")]
    public ImpliedCurrencyAndAmount? InterchangeFeeAmount { get; init; }

    /// <summary>
    /// Currency code of interchange fee amount.
    /// </summary>
    [IsoId("_Szfhc279EfC68Y4jZPNEug")]
    [DisplayName("Interchange Fee Currency")]
    [IsoXmlTag("IntrchngFeeCcy")]
    public ISO3NumericCurrencyCode? InterchangeFeeCurrency { get; init; }

    /// <summary>
    /// Sign of the interchange fee amount.
    /// </summary>
    [IsoId("_SzfhdW79EfC68Y4jZPNEug")]
    [DisplayName("Interchange Fee Credit Debit")]
    [IsoXmlTag("IntrchngFeeCdtDbt")]
    public CreditDebit3Code? InterchangeFeeCreditDebit { get; init; }

    /// <summary>
    /// Agent fee amount.
    /// </summary>
    [IsoId("_Szfhd279EfC68Y4jZPNEug")]
    [DisplayName("Agent Fee Amount")]
    [IsoXmlTag("AgtFeeAmt")]
    public ImpliedCurrencyAndAmount? AgentFeeAmount { get; init; }

    /// <summary>
    /// Currency code of agent fee amount.
    /// </summary>
    [IsoId("_SzfheW79EfC68Y4jZPNEug")]
    [DisplayName("Agent Fee Currency")]
    [IsoXmlTag("AgtFeeCcy")]
    public ISO3NumericCurrencyCode? AgentFeeCurrency { get; init; }

    /// <summary>
    /// Sign of agent fee amount.
    /// </summary>
    [IsoId("_Szfhe279EfC68Y4jZPNEug")]
    [DisplayName("Agent Fee Credit Debit")]
    [IsoXmlTag("AgtFeeCdtDbt")]
    public CreditDebit3Code? AgentFeeCreditDebit { get; init; }
}
