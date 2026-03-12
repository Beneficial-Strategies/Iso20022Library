// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Start or end of service.
/// </summary>
[IsoId("_QOD4UcW1EeuhguwJmlgagQ")]
[DisplayName("Service Start End")]
public partial record ServiceStartEnd2
{
    #nullable enable
    
    /// <summary>
    /// Location of service (for example, Paris CDG, Paris Gare du Nord, etc.). 
    /// </summary>
    [IsoId("_QStHwcW1EeuhguwJmlgagQ")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Location { get; init; } 
    
    /// <summary>
    /// Location code assigned to an airport or to a service location (for example, CDG, YUL, etc.).
    /// </summary>
    [IsoId("_QStHw8W1EeuhguwJmlgagQ")]
    [DisplayName("Location Code")]
    [IsoXmlTag("LctnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LocationCode { get; init; } 
    
    /// <summary>
    /// Address of service.
    /// </summary>
    [IsoId("_QStHxcW1EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 
    
    /// <summary>
    /// Contact details at location.
    /// </summary>
    [IsoId("_QStHx8W1EeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact2? Contact { get; init; } 
    
    /// <summary>
    /// Date and time of service.
    /// </summary>
    [IsoId("_QStHycW1EeuhguwJmlgagQ")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateAndTime { get; init; } 
    
    /// <summary>
    /// Period of day pertaining to the service location.
    /// </summary>
    [IsoId("_QStHy8W1EeuhguwJmlgagQ")]
    [DisplayName("Time Segment")]
    [IsoXmlTag("TmSgmt")]
    public TimeSegment1Code? TimeSegment { get; init; } 
    
    /// <summary>
    /// Journey information related to the vehicle rental.
    /// </summary>
    [IsoId("_QStHzcW1EeuhguwJmlgagQ")]
    [DisplayName("Journey Information")]
    [IsoXmlTag("JrnyInf")]
    public JourneyInformation1? JourneyInformation { get; init; } 
    
    
    #nullable disable
    
}
