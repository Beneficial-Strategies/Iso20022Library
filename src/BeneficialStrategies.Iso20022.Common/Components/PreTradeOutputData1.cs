// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pre-trade output related data.
/// </summary>
[IsoId("_EoadoGIWEfCeoPFCHQnhvA")]
[DisplayName("Pre Trade Output Data1")]
public record PreTradeOutputData1
{
    /// <summary>
    /// Code used to identify the financial instrument.
    /// </summary>
    [IsoId("_QmZSkGIWEfCeoPFCHQnhvA")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public required IsoISINOct2015Identifier ISIN { get; init; }

    /// <summary>
    /// The most relevant market in terms of liquidity shall be the trading venue where that financial instrument is first admitted to trading or first traded.
    /// </summary>
    [IsoId("_bhJI4GIWEfCeoPFCHQnhvA")]
    [DisplayName("Most Relevant Market")]
    [IsoXmlTag("MostRlvntMkt")]
    public required IsoMICIdentifier MostRelevantMarket { get; init; }

    /// <summary>
    /// Output data covering both the continuous order book and auction trading system.
    /// </summary>
    [IsoId("_94BAgGIYEfCeoPFCHQnhvA")]
    [DisplayName("Output Data")]
    [IsoXmlTag("OutptData")]
    public required OutputData1Choice_ OutputData { get; init; }

    /// <summary>
    /// Date and time when the transaction was published by the data contributors.
    /// </summary>
    [IsoId("_jKop0GIWEfCeoPFCHQnhvA")]
    [DisplayName("Publication Date Time")]
    [IsoXmlTag("PblctnDtTm")]
    public IsoISODateTime? PublicationDateTime { get; init; }

    /// <summary>
    /// Date and time when the output data were disseminated by the CTP.
    /// </summary>
    [IsoId("_CyOtgKUREfCmoeslmyBN5Q")]
    [DisplayName("Dissemination Date Time")]
    [IsoXmlTag("DssmntnDtTm")]
    public required IsoISODateTime DisseminationDateTime { get; init; }
}
