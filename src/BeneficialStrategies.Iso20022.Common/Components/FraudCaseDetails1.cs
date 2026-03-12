// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of fraudulent case.
/// </summary>
[IsoId("_08BmYcZdEeiCDcGzDHI_9Q")]
[DisplayName("Fraud Case Details")]
public partial record FraudCaseDetails1
{
    #nullable enable
    
    /// <summary>
    /// Type of market segment of confirmed fraud.
    /// </summary>
    [IsoId("_EVHQQsZeEeiCDcGzDHI_9Q")]
    [DisplayName("Market Segment")]
    [IsoXmlTag("MktSgmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MarketSegment { get; init; } 
    
    /// <summary>
    /// Locator reference.
    /// </summary>
    [IsoId("_EVHQQ8ZeEeiCDcGzDHI_9Q")]
    [DisplayName("Locator Number")]
    [IsoXmlTag("LctrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LocatorNumber { get; init; } 
    
    /// <summary>
    /// Reference to fraudulent case.
    /// </summary>
    [IsoId("_EVHQRMZeEeiCDcGzDHI_9Q")]
    [DisplayName("Case Reference")]
    [IsoXmlTag("CaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CaseReference { get; init; } 
    
    /// <summary>
    /// Indicates whether the party that committed fraud was arrested or not.
    /// False: the party was not arrested
    /// True: the party was arrested
    /// Default: False
    /// </summary>
    [IsoId("_EVHQRcZeEeiCDcGzDHI_9Q")]
    [DisplayName("Arrest Indicator")]
    [IsoXmlTag("ArrstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ArrestIndicator { get; init; } 
    
    
    #nullable disable
    
}
