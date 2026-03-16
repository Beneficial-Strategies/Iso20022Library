// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a drawdown.
/// </summary>
[IsoId("_68-ZgXzoEeuEHsEB8Johfw")]
[DisplayName("Drawdown")]
public record Drawdown3
{
    /// <summary>
    /// Previous employment information.
    /// </summary>
    [IsoId("_7U2G83zoEeuEHsEB8Johfw")]
    [DisplayName("Employment Details")]
    [IsoXmlTag("MplymntDtls")]
    public EmploymentDetails1? EmploymentDetails { get; init; }

    /// <summary>
    /// Additional information about the drawdown.
    /// </summary>
    [IsoId("_7U2HEXzoEeuEHsEB8Johfw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
