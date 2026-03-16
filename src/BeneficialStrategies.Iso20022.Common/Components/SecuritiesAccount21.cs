// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unambiguous identification for the account between the account owner and the account servicer.
/// </summary>
[IsoId("_m-Itu_NBEeCuA5Tr22BnwA_1737617622")]
[DisplayName("Securities Account")]
public record SecuritiesAccount21
{
    /// <summary>
    /// Account identification.
    /// </summary>
    [IsoId("_m-SesPNBEeCuA5Tr22BnwA_1237780923")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required AccountIdentification5 Account { get; init; }

    /// <summary>
    /// Sub-account identification.
    /// </summary>
    [IsoId("_m-SesfNBEeCuA5Tr22BnwA_607511995")]
    [DisplayName("Sub Account")]
    [IsoXmlTag("SubAcct")]
    public AccountIdentification5? SubAccount { get; init; }

    /// <summary>
    /// Base currency for the account.
    /// </summary>
    [IsoId("_m-SesvNBEeCuA5Tr22BnwA_1306004853")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public ActiveOrHistoricCurrencyCode? BaseCurrency { get; init; }

    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_m-Ses_NBEeCuA5Tr22BnwA_1419598212")]
    [DisplayName("Reporting Currency")]
    [IsoXmlTag("RptgCcy")]
    public ActiveOrHistoricCurrencyCode? ReportingCurrency { get; init; }

    /// <summary>
    /// Foreign exchange rate applied between the reporting and base currencies. It is assumed the valuation date is the same as the report date.
    /// </summary>
    [IsoId("_m-SetPNBEeCuA5Tr22BnwA_-2029423443")]
    [DisplayName("Foreign Exchange Rate")]
    [IsoXmlTag("FXRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ForeignExchangeRate { get; init; }
}
