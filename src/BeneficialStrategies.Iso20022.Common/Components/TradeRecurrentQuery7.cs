// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Recurrent Query7.
/// </summary>
[IsoId("_-zhqwZjCEe6BApM7bIoABA")]
[DisplayName("Trade Recurrent Query7")]
public partial record TradeRecurrentQuery7
{
    #nullable enable

    /// <summary>
    /// Frequency.
    /// </summary>
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public ValueList<TradeQueryExecutionFrequency3> Frequency { get; init; } = [];

    /// <summary>
    /// Query Type.
    /// </summary>
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required IsoMax1000Text QueryType { get; init; } 

    /// <summary>
    /// Valid Until.
    /// </summary>
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    public required IsoISODate ValidUntil { get; init; } 

    
    #nullable disable
    
}
