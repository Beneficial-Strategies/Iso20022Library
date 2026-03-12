// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The details of a specific trading session.
/// </summary>
[IsoId("_S0oo3dp-Ed-ak6NoX_4Aeg_-1794649600")]
[DisplayName("Trading Session")]
public partial record TradingSession1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a specific execution time bracket code through its trading session name or description.
    /// </summary>
    [IsoId("_S0oo3tp-Ed-ak6NoX_4Aeg_-1733697860")]
    [DisplayName("Trading Session Identification")]
    [IsoXmlTag("TradgSsnId")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    public IsoMax128Text? TradingSessionIdentification { get; init; } 
    
    /// <summary>
    /// Optional market assigned sub identifier for a trading session. Usage is determined by market or counterparties.
    /// </summary>
    [IsoId("_S0yZ0Np-Ed-ak6NoX_4Aeg_-365329415")]
    [DisplayName("Trading Session Sub Identification")]
    [IsoXmlTag("TradgSsnSubId")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    public IsoMax128Text? TradingSessionSubIdentification { get; init; } 
    
    
    #nullable disable
    
}
