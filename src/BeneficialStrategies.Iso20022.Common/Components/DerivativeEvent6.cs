// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to derivative details.
/// </summary>
[IsoId("_lk8TIfbeEeyInphUKJZxtQ")]
[DisplayName("Derivative Event")]
public partial record DerivativeEvent6
{
    #nullable enable
    
    /// <summary>
    /// Classification of derivative event type.
    /// </summary>
    [IsoId("_llrS8fbeEeyInphUKJZxtQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DerivativeEventType3Code? Type { get; init; } 
    
    /// <summary>
    /// Indicates means of identification of a derivative event.
    /// </summary>
    [IsoId("_jf75APbfEeyInphUKJZxtQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public EventIdentifier1Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Indicates the time stamp of a derivative event.
    /// </summary>
    [IsoId("_llrS9fbeEeyInphUKJZxtQ")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    public DateAndDateTime2Choice_? TimeStamp { get; init; } 
    
    /// <summary>
    /// Indicator of whether the modification of the swap transaction reflects newly agreed upon term(s) from the previously negotiated terms resulting in price forming event.
    /// Usage: When absent, meaning of AmendmentIndicator is False.
    /// </summary>
    [IsoId("_x7bUoTNYEe2Mjc1DeLmBZw")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; } 
    
    
    #nullable disable
    
}
