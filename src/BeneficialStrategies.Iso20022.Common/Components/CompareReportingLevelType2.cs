// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a reporting level type.
/// </summary>
[IsoId("_03zGYdSbEemZdYGWu384Zw")]
[DisplayName("Compare Reporting Level Type")]
public record CompareReportingLevelType2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_0-TXAdSbEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ModificationLevel1Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_0-TXA9SbEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ModificationLevel1Code? Value2 { get; init; }
}
