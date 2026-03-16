// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an exposure type.
/// </summary>
[IsoId("_cqZj4a5hEeuo-IflVgGqiA")]
[DisplayName("Compare Exposure Type")]
public record CompareExposureType3
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_c6DJca5hEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ExposureType10Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_c6DJc65hEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ExposureType10Code? Value2 { get; init; }
}
