// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the notification of the termination of an undertaking.
/// </summary>
[IsoId("_98BaAHltEeG7BsjMvd1mEw_969313560")]
[DisplayName("Undertaking Termination")]
public partial record UndertakingTermination3
{
    #nullable enable
    
    /// <summary>
    /// Date on which the termination is effective.
    /// </summary>
    [IsoId("_98BaAXltEeG7BsjMvd1mEw_-27758793")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EffectiveDate { get; init; } 
    
    /// <summary>
    /// Reason for the termination.
    /// </summary>
    [IsoId("_98BaAnltEeG7BsjMvd1mEw_1275991444")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public TerminationReason1Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Additional information related to the termination.
    /// </summary>
    [IsoId("_98BaA3ltEeG7BsjMvd1mEw_-1993406674")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
