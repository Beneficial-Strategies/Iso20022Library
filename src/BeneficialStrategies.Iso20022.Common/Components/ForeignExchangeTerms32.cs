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
[IsoId("_zkLg1zbsEead9bDRE_1DAQ")]
[DisplayName("Foreign Exchange Terms")]
public record ForeignExchangeTerms32
{
    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_z8lZwzbsEead9bDRE_1DAQ")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveCurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_z8lZxTbsEead9bDRE_1DAQ")]
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
    [IsoId("_z8lZxzbsEead9bDRE_1DAQ")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_z8lZzzbsEead9bDRE_1DAQ")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("_z8lZ0TbsEead9bDRE_1DAQ")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification113? QuotingInstitution { get; init; }
}
