// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a securities identification.
/// </summary>
[IsoId("_DmnrQdScEemZdYGWu384Zw")]
[DisplayName("Compare Security Identification")]
public record CompareSecurityIdentification2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_DrF7kdScEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public SecurityIdentification26Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second of the transaction.
    /// </summary>
    [IsoId("_DrF7k9ScEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public SecurityIdentification26Choice_? Value2 { get; init; }
}
