// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service Start End3.
/// </summary>
[IsoId("_22SOsXTkEe6h-4AZRg9sVg")]
[DisplayName("Service Start End3")]
public record ServiceStartEnd3
{
    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Contact.
    /// </summary>
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactBusiness1? Contact { get; init; }

    /// <summary>
    /// Date And Time.
    /// </summary>
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    public IsoISODateTime? DateAndTime { get; init; }

    /// <summary>
    /// Journey Data.
    /// </summary>
    [DisplayName("Journey Data")]
    [IsoXmlTag("JrnyData")]
    public IsoMax35Text? JourneyData { get; init; }

    /// <summary>
    /// Journey Date And Time.
    /// </summary>
    [DisplayName("Journey Date And Time")]
    [IsoXmlTag("JrnyDtAndTm")]
    public IsoISODateTime? JourneyDateAndTime { get; init; }

    /// <summary>
    /// Journey Type.
    /// </summary>
    [DisplayName("Journey Type")]
    [IsoXmlTag("JrnyTp")]
    public JourneyType1Code? JourneyType { get; init; }

    /// <summary>
    /// Location.
    /// </summary>
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public IsoMax35Text? Location { get; init; }

    /// <summary>
    /// Location Code.
    /// </summary>
    [DisplayName("Location Code")]
    [IsoXmlTag("LctnCd")]
    public IsoMax35Text? LocationCode { get; init; }

    /// <summary>
    /// Time Segment.
    /// </summary>
    [DisplayName("Time Segment")]
    [IsoXmlTag("TmSgmt")]
    public TimeSegment1Code? TimeSegment { get; init; }
}
