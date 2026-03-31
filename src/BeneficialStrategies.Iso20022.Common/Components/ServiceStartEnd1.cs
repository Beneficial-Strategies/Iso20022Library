// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Start or end of service.
/// </summary>
[IsoId("_rqeg4V1pEeeu75xdwwAXQw")]
[DisplayName("Service Start End")]
public record ServiceStartEnd1
{
    /// <summary>
    /// Location of service (for example, Paris CDG, Paris Gare du Nord, etc.).
    /// </summary>
    [IsoId("_r1ooAV1pEeeu75xdwwAXQw")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Location { get; init; }

    /// <summary>
    /// Location code assigned to an airport or to a service location (for example, CDG, YUL, etc.).
    /// </summary>
    [IsoId("_r1ooA11pEeeu75xdwwAXQw")]
    [DisplayName("Location Code")]
    [IsoXmlTag("LctnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LocationCode { get; init; }

    /// <summary>
    /// Address of service.
    /// </summary>
    [IsoId("_r1ooBV1pEeeu75xdwwAXQw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }

    /// <summary>
    /// Contact details at location.
    /// </summary>
    [IsoId("_r1ooB11pEeeu75xdwwAXQw")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact2? Contact { get; init; }

    /// <summary>
    /// Date and time of service.
    /// </summary>
    [IsoId("_r1ooCV1pEeeu75xdwwAXQw")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateAndTime { get; init; }

    /// <summary>
    /// Period of day pertaining to the service location.
    /// </summary>
    [IsoId("_r1ooC11pEeeu75xdwwAXQw")]
    [DisplayName("Time Segment")]
    [IsoXmlTag("TmSgmt")]
    public TimeSegment1Code? TimeSegment { get; init; }

    /// <summary>
    /// Journey information related to the vehicle rental.
    /// </summary>
    [IsoId("_r1ooDV1pEeeu75xdwwAXQw")]
    [DisplayName("Journey Information")]
    [IsoXmlTag("JrnyInf")]
    public JourneyInformation1? JourneyInformation { get; init; }
}
