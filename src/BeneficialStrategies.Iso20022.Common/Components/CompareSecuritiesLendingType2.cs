// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a which classifies the type of the security.
/// </summary>
[IsoId("_ekC-AdR7EemZdYGWu384Zw")]
[DisplayName("Compare Securities Lending Type")]
public record CompareSecuritiesLendingType2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_eoA4AdR7EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public SecuritiesLendingType3Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_eoA4A9R7EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public SecuritiesLendingType3Choice_? Value2 { get; init; }
}
