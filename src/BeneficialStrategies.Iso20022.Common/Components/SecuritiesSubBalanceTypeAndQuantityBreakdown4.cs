// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity breakdown information for a specific securities balance.
/// </summary>
[IsoId("_5NeNC5NLEeWGlc8L7oPDIg")]
[DisplayName("Securities Sub Balance Type And Quantity Breakdown")]
public partial record SecuritiesSubBalanceTypeAndQuantityBreakdown4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_5NeNDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SecuritiesBalanceType8Choice_ Type { get; init; } 
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_5NeND5NLEeWGlc8L7oPDIg")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public QuantityBreakdown34? QuantityBreakdown { get; init; } 
    
    
    #nullable disable
    
}
