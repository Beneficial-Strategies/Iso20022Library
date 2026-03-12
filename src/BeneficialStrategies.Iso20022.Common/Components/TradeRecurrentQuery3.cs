// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Recurrent query criteria.
/// </summary>
[IsoId("_QH0wdYeAEei-Poi-FosJdw")]
[DisplayName("Trade Recurrent Query")]
public partial record TradeRecurrentQuery3
{
    #nullable enable
    
    /// <summary>
    /// Defines the type of recurrent query which is requested.
    /// </summary>
    [IsoId("_QV1XQYeAEei-Poi-FosJdw")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public required IsoMax1000Text QueryType { get; init; } 
    
    /// <summary>
    /// Defines the requested frequency of the recurrent query.
    /// </summary>
    [IsoId("_QV1XQ4eAEei-Poi-FosJdw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required TradeQueryExecutionFrequency1Choice_ Frequency { get; init; } 
    
    /// <summary>
    /// Defines the date until which the query will be executed.
    /// </summary>
    [IsoId("_QV1XRYeAEei-Poi-FosJdw")]
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValidUntil { get; init; } 
    
    
    #nullable disable
    
}
