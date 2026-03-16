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
[IsoId("_d5k5U65MEeuo-IflVgGqiA")]
[DisplayName("Volume Metrics")]
public record VolumeMetrics5
{
    /// <summary>
    /// Count of the number of Unique Trade Identifiers.
    /// </summary>
    [IsoId("_eIL9Ea5MEeuo-IflVgGqiA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Sum for each exposure variable and currency.
    /// </summary>
    [IsoId("_eIL9E65MEeuo-IflVgGqiA")]
    [DisplayName("Exposure")]
    [IsoXmlTag("Xpsr")]
    public ExposureMetrics4? Exposure { get; init; }
}
