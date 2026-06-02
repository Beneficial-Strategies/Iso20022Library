// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further detailed information on the exchange rate that has been used in or is related to the transaction.
/// </summary>
[IsoId("_fbVncSH1EfCkq6-p7S3J1Q")]
[DisplayName("Card Exchange Rate1")]
public record CardExchangeRate1
{
    /// <summary>
    /// Identifies the source of the rate information.
    /// </summary>
    [IsoId("_feWfMSH1EfCkq6-p7S3J1Q")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public IsoMax70Text? Provider { get; init; }

    /// <summary>
    /// Identification of the specific rate, table or file that contains the rate information.
    /// </summary>
    [IsoId("_feWfMyH1EfCkq6-p7S3J1Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax70Text? Identification { get; init; }

    /// <summary>
    /// The date the exchange rate data is effective.
    /// </summary>
    [IsoId("_feWfNSH1EfCkq6-p7S3J1Q")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// The time the exchange rate data is effective.
    /// </summary>
    [IsoId("_feWfNyH1EfCkq6-p7S3J1Q")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; }

    /// <summary>
    /// Identifies the party to which this detail applies.
    /// </summary>
    [IsoId("_feWfOSH1EfCkq6-p7S3J1Q")]
    [DisplayName("End Point")]
    [IsoXmlTag("EndPt")]
    public Endpoint2Code? EndPoint { get; init; }

    /// <summary>
    /// Identifies the counter currency used for currency conversion for the transaction party.
    /// </summary>
    [IsoId("_feWfPSH1EfCkq6-p7S3J1Q")]
    [DisplayName("Counter Currency Code")]
    [IsoXmlTag("CntrCcyCd")]
    public ISO3NumericCurrencyCode? CounterCurrencyCode { get; init; }

    /// <summary>
    /// Identifies the base currency used for currency conversion for the transaction party.
    /// </summary>
    [IsoId("_feWfPyH1EfCkq6-p7S3J1Q")]
    [DisplayName("Base Currency Code")]
    [IsoXmlTag("BaseCcyCd")]
    public ISO3NumericCurrencyCode? BaseCurrencyCode { get; init; }

    /// <summary>
    /// Contains the exchange rate.
    /// </summary>
    [IsoId("_feWfQSH1EfCkq6-p7S3J1Q")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoBaseOne25Rate? Rate { get; init; }

    /// <summary>
    /// Identifies the type of rate.
    /// </summary>
    [IsoId("_feWfQyH1EfCkq6-p7S3J1Q")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public ExchangeRateType3Code? RateType { get; init; }

    /// <summary>
    /// Type of exchange rate agreement.
    /// </summary>
    [IsoId("_feWfRyH1EfCkq6-p7S3J1Q")]
    [DisplayName("Agreement Type")]
    [IsoXmlTag("AgrmtTp")]
    public ExchangeRateAgreementType2Code? AgreementType { get; init; }

    /// <summary>
    /// Indicates if a rate lock is or was requested.
    /// </summary>
    [IsoId("_feWfSyH1EfCkq6-p7S3J1Q")]
    [DisplayName("Rate Lock Requested")]
    [IsoXmlTag("RateLckReqd")]
    public IsoTrueFalseIndicator? RateLockRequested { get; init; }

    /// <summary>
    /// Indicates if the transaction is rate lock eligible.
    /// </summary>
    [IsoId("_feWfTSH1EfCkq6-p7S3J1Q")]
    [DisplayName("Rate Lock Eligible")]
    [IsoXmlTag("RateLckElgbl")]
    public IsoTrueFalseIndicator? RateLockEligible { get; init; }

    /// <summary>
    /// Indicates if a rate lock was applied.
    /// </summary>
    [IsoId("_feWfTyH1EfCkq6-p7S3J1Q")]
    [DisplayName("Rate Lock Applied")]
    [IsoXmlTag("RateLckApld")]
    public IsoTrueFalseIndicator? RateLockApplied { get; init; }
}
