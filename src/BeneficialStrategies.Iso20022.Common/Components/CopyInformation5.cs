// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information provided when the message is a copy of a previous message.
/// </summary>
[IsoId("_y6HYAZELEem-9Y6mq5ZH3Q")]
[DisplayName("Copy Information")]
public partial record CopyInformation5
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the message is a copy.
    /// </summary>
    [IsoId("_zNKP05ELEem-9Y6mq5ZH3Q")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CopyIndicator { get; init; } 
    
    /// <summary>
    /// Original receiver of the message, if this message is a copy.
    /// </summary>
    [IsoId("_zNKP1ZELEem-9Y6mq5ZH3Q")]
    [DisplayName("Original Receiver")]
    [IsoXmlTag("OrgnlRcvr")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public IsoAnyBICDec2014Identifier? OriginalReceiver { get; init; } 
    
    
    #nullable disable
    
}
