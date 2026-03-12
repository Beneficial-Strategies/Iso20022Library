// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the journey before or after the rental.
/// </summary>
[IsoId("_fEn7AF1mEeeu75xdwwAXQw")]
[DisplayName("Journey Information")]
public partial record JourneyInformation1
{
    #nullable enable
    
    /// <summary>
    /// Type of journey.
    /// </summary>
    [IsoId("_vnTDIF1mEeeu75xdwwAXQw")]
    [DisplayName("Journey Type")]
    [IsoXmlTag("JrnyTp")]
    public JourneyType1Code? JourneyType { get; init; } 
    
    /// <summary>
    /// Data related to the type of journey selected (for example, AF1234 when FlightNumber selected).
    /// </summary>
    [IsoId("_-v9rYF1mEeeu75xdwwAXQw")]
    [DisplayName("Journey Data")]
    [IsoXmlTag("JrnyData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? JourneyData { get; init; } 
    
    /// <summary>
    /// Date and time related to the journey type selected.
    /// </summary>
    [IsoId("_dQ-EsF1pEeeu75xdwwAXQw")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateAndTime { get; init; } 
    
    
    #nullable disable
    
}
