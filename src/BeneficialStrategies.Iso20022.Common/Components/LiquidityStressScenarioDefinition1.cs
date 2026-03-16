// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes and information that describe a scenario used to test whether a legal entity or other financial construct has sufficient liquid resources to meet its obligations as they arise.
/// </summary>
[IsoId("_ERnlwLDDEeaSl6vJk5Bd8w")]
[DisplayName("Liquidity Stress Scenario Definition")]
public record LiquidityStressScenarioDefinition1
{
    /// <summary>
    /// CCP’s internal unique identifier of the stress scenario that generates the reported liquidity need.
    /// </summary>
    [IsoId("_NlwDkLDDEeaSl6vJk5Bd8w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification168 Identification { get; init; }

    /// <summary>
    /// Details of the method and assumptions used for estimating operational outflows.
    /// </summary>
    [IsoId("_RlWFoLDDEeaSl6vJk5Bd8w")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000, MinimumLength = 1)]
    public required IsoMax2000Text Description { get; init; }

    /// <summary>
    /// CCP’s internal classification of stress scenario type.
    /// </summary>
    [IsoId("_duPKELDDEeaSl6vJk5Bd8w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Stress currency, or if aggregate, report ‘XLL’.
    /// </summary>
    [IsoId("_WXiXYLDFEeaSl6vJk5Bd8w")]
    [DisplayName("Stress Currency")]
    [IsoXmlTag("StrssCcy")]
    public required ActiveCurrencyCode StressCurrency { get; init; }
}
