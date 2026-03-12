// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.
/// </summary>
[IsoId("__p1KALC8EeaSl6vJk5Bd8w")]
[DisplayName("End Of Day Requirement")]
public partial record EndOfDayRequirement1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the initial margin requirement for position.
    /// </summary>
    [IsoId("_TC3bQLC9EeaSl6vJk5Bd8w")]
    [DisplayName("Initial Margin Requirement")]
    [IsoXmlTag("InitlMrgnRqrmnt")]
    public ActiveCurrencyAndAmount? InitialMarginRequirement { get; init; } 
    
    /// <summary>
    /// Daily change in mark-to-market for the associated position. Indicates whether variation margin paid to clearing members (true) or received from clearing members (false).
    /// </summary>
    [IsoId("_VNaAMLC9EeaSl6vJk5Bd8w")]
    [DisplayName("Variation Margin Requirement")]
    [IsoXmlTag("VartnMrgnRqrmnt")]
    public AmountAndDirection102? VariationMarginRequirement { get; init; } 
    
    
    #nullable disable
    
}
