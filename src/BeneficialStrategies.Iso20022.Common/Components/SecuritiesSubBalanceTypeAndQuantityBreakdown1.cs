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
[IsoId("_vZcQEP8IEeCKBMQETXEXKQ")]
[DisplayName("Securities Sub Balance Type And Quantity Breakdown")]
public partial record SecuritiesSubBalanceTypeAndQuantityBreakdown1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_3kV08P8IEeCKBMQETXEXKQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SecuritiesBalanceType3Choice_ Type { get; init; } 
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_4JvoMP8IEeCKBMQETXEXKQ")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public QuantityBreakdown12? QuantityBreakdown { get; init; } 
    
    
    #nullable disable
    
}
