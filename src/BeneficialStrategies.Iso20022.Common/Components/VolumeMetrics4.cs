// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on the number of transactions or on market exposures.
/// </summary>
[IsoId("_T23LEIMGEeueDJg7fN5MDw")]
[DisplayName("Volume Metrics")]
public record VolumeMetrics4
{
    /// <summary>
    /// Indication whether reused value is actual or estimated.
    /// </summary>
    [IsoId("_XE-s4oMGEeueDJg7fN5MDw")]
    [DisplayName("Reuse Value")]
    [IsoXmlTag("ReuseVal")]
    public ReuseValue1Choice_? ReuseValue { get; init; }

    /// <summary>
    /// Provides details on the amount of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_XE-s44MGEeueDJg7fN5MDw")]
    [DisplayName("Reinvested Cash Amount")]
    [IsoXmlTag("RinvstdCshAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReinvestedCashAmount { get; init; }
}
