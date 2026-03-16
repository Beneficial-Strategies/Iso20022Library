// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
/// </summary>
[IsoId("_oe0xMVuCEeSmO6RkXg92Lg")]
[DisplayName("Additional Rights")]
public record AdditionalRights2
{
    /// <summary>
    /// Specific rights granted to the shareholders that can be exercised at shareholders meetings, for example, the right to ask questions, the right to add items to the agenda or table draft resolutions.
    /// </summary>
    [IsoId("_o7GdgVuCEeSmO6RkXg92Lg")]
    [DisplayName("Additional Right")]
    [IsoXmlTag("AddtlRght")]
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; }

    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on specific rights granted to the shareholders can be found.
    /// </summary>
    [IsoId("_o7Gdg1uCEeSmO6RkXg92Lg")]
    [DisplayName("Additional Right Information URL Address")]
    [IsoXmlTag("AddtlRghtInfURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalRightInformationURLAddress { get; init; }

    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_o7GdhVuCEeSmO6RkXg92Lg")]
    [DisplayName("Additional Right Deadline")]
    [IsoXmlTag("AddtlRghtDdln")]
    public DateFormat29Choice_? AdditionalRightDeadline { get; init; }

    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_o7Gdh1uCEeSmO6RkXg92Lg")]
    [DisplayName("Additional Right Market Deadline")]
    [IsoXmlTag("AddtlRghtMktDdln")]
    public DateFormat29Choice_? AdditionalRightMarketDeadline { get; init; }

    /// <summary>
    /// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    [IsoId("_o7GdiVuCEeSmO6RkXg92Lg")]
    [DisplayName("Additional Right Threshold")]
    [IsoXmlTag("AddtlRghtThrshld")]
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; init; }
}
