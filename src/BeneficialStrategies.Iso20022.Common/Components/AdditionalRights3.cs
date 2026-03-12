// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about additional rights that can be granted for a meeting.
/// </summary>
[IsoId("_k8fcwa09EemDtrWpq90Ckg")]
[DisplayName("Additional Rights")]
public partial record AdditionalRights3
{
    #nullable enable
    
    /// <summary>
    /// Specific rights granted to the shareholders that can be exercised at shareholders meetings, for example, the right to ask questions, the right to add items to the agenda or table draft resolutions.
    /// </summary>
    [IsoId("_lReOMa09EemDtrWpq90Ckg")]
    [DisplayName("Additional Right")]
    [IsoXmlTag("AddtlRght")]
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    
    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on specific rights granted to the shareholders can be found.
    /// </summary>
    [IsoId("_lReOM609EemDtrWpq90Ckg")]
    [DisplayName("Additional Right Information URL Address")]
    [IsoXmlTag("AddtlRghtInfURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? AdditionalRightInformationURLAddress { get; init; } 
    
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_lReONa09EemDtrWpq90Ckg")]
    [DisplayName("Additional Right Deadline")]
    [IsoXmlTag("AddtlRghtDdln")]
    public DateFormat58Choice_? AdditionalRightDeadline { get; init; } 
    
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_lReON609EemDtrWpq90Ckg")]
    [DisplayName("Additional Right Market Deadline")]
    [IsoXmlTag("AddtlRghtMktDdln")]
    public DateFormat58Choice_? AdditionalRightMarketDeadline { get; init; } 
    
    /// <summary>
    /// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    [IsoId("_lReOOa09EemDtrWpq90Ckg")]
    [DisplayName("Additional Right Threshold")]
    [IsoXmlTag("AddtlRghtThrshld")]
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; init; } 
    
    
    #nullable disable
    
}
