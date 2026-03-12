// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicators about rate lock.
/// </summary>
[IsoId("_vL6cgIZ7EeuSbct6WWD-Ng")]
[DisplayName("Rate Lock")]
public partial record RateLock1
{
    #nullable enable
    
    /// <summary>
    /// Indicates if a rate lock is or was requested.
    /// </summary>
    [IsoId("_Gd4uMIZ8EeuSbct6WWD-Ng")]
    [DisplayName("Requested Indicator")]
    [IsoXmlTag("ReqdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates if the transaction is rate lock eligible.
    /// </summary>
    [IsoId("_epXawIZ8EeuSbct6WWD-Ng")]
    [DisplayName("Eligible Indicator")]
    [IsoXmlTag("ElgblInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? EligibleIndicator { get; init; } 
    
    /// <summary>
    /// Indicates if a rate lock was applied.
    /// </summary>
    [IsoId("_ja7FQIZ8EeuSbct6WWD-Ng")]
    [DisplayName("Applied Indicator")]
    [IsoXmlTag("ApldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AppliedIndicator { get; init; } 
    
    
    #nullable disable
    
}
