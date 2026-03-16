// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_fTDVQfssEeCUd_EZYqZ_Uw")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument26
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_fTNGSfssEeCUd_EZYqZ_Uw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_fTNGTfssEeCUd_EZYqZ_Uw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_ga4gFfssEeCUd_EZYqZ_Uw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity12Choice_? Quantity { get; init; }

    /// <summary>
    /// Average cost per share of a security, including all charges and commissions.
    /// </summary>
    [IsoId("_UUPmhfu9EeC3VvXpH76gow")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Net asset on balance sheet - total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_W7ShMPu9EeC3VvXpH76gow")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_JSCfxfstEeCUd_EZYqZ_Uw")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account6? TransfereeAccount { get; init; }
}
