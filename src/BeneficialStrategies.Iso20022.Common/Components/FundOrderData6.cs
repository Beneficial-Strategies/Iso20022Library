// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extract of trade data for an investment fund switch order.
/// </summary>
[IsoId("_ENP28UgnEea9YuSvQGoi-w")]
[DisplayName("Fund Order Data")]
public record FundOrderData6
{
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_EmYvt0gnEea9YuSvQGoi-w")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_EmYvuUgnEea9YuSvQGoi-w")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Choice between additional cash in or resulting cash out.
    /// </summary>
    [IsoId("_vRD7cUgnEea9YuSvQGoi-w")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public AdditionalAmount1Choice_? AdditionalAmount { get; init; }

    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_EmYvv0gnEea9YuSvQGoi-w")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveCurrencyCode? UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_EmYvwUgnEea9YuSvQGoi-w")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public ActiveCurrencyCode? QuotedCurrency { get; init; }
}
