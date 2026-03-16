// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
[IsoId("_UFracZELEem-9Y6mq5ZH3Q")]
[DisplayName("Foreign Exchange Terms")]
public record ForeignExchangeTerms37
{
    /// <summary>
    /// Cash amount resulting from a foreign exchange trade.
    /// </summary>
    [IsoId("_UZK-M5ELEem-9Y6mq5ZH3Q")]
    [DisplayName("To Amount")]
    [IsoXmlTag("ToAmt")]
    public ActiveCurrencyAndAmount? ToAmount { get; init; }

    /// <summary>
    /// Cash amount for which a foreign exchange is required.
    /// </summary>
    [IsoId("_UZK-NZELEem-9Y6mq5ZH3Q")]
    [DisplayName("From Amount")]
    [IsoXmlTag("FrAmt")]
    public ActiveCurrencyAndAmount? FromAmount { get; init; }

    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_UZK-N5ELEem-9Y6mq5ZH3Q")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveCurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_UZK-OZELEem-9Y6mq5ZH3Q")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveCurrencyCode QuotedCurrency { get; init; }

    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects that amount of the quoted currency that can be purchased with one unit of the unit currency, as follows:
    /// 1 x CUR1 = nnn x CUR2,
    /// where:
    /// CUR1 is the unit currency
    /// CUR2 is the quoted currency
    /// nnn is the exchange rate.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_UZK-O5ELEem-9Y6mq5ZH3Q")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_UZK-Q5ELEem-9Y6mq5ZH3Q")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Party that proposes the foreign exchange rate.
    /// </summary>
    [IsoId("_UZK-RZELEem-9Y6mq5ZH3Q")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification139? QuotingInstitution { get; init; }
}
