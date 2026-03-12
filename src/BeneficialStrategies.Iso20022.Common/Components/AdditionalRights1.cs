// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
/// </summary>
[IsoId("_TkUZVdp-Ed-ak6NoX_4Aeg_-552052404")]
[DisplayName("Additional Rights")]
public partial record AdditionalRights1
{
    #nullable enable
    
    /// <summary>
    /// Specific rights granted to the shareholders that can be exercised at shareholders meetings (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
    /// </summary>
    [IsoId("_TkUZVtp-Ed-ak6NoX_4Aeg_1606874728")]
    [DisplayName("Additional Right")]
    [IsoXmlTag("AddtlRght")]
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    
    /// <summary>
    /// Address to use over the www (HTTP) service where addtional information on specific rights granted to the shareholders can be found.
    /// </summary>
    [IsoId("_TkUZV9p-Ed-ak6NoX_4Aeg_-990597867")]
    [DisplayName("Additional Right Information URL Address")]
    [IsoXmlTag("AddtlRghtInfURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AdditionalRightInformationURLAddress { get; init; } 
    
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_TkUZWNp-Ed-ak6NoX_4Aeg_417772718")]
    [DisplayName("Additional Right Deadline")]
    [IsoXmlTag("AddtlRghtDdln")]
    public DateFormat2Choice_? AdditionalRightDeadline { get; init; } 
    
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TkeKUNp-Ed-ak6NoX_4Aeg_417772749")]
    [DisplayName("Additional Right Market Deadline")]
    [IsoXmlTag("AddtlRghtMktDdln")]
    public DateFormat2Choice_? AdditionalRightMarketDeadline { get; init; } 
    
    /// <summary>
    /// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    [IsoId("_TkeKUdp-Ed-ak6NoX_4Aeg_-1317132181")]
    [DisplayName("Additional Right Threshold")]
    [IsoXmlTag("AddtlRghtThrshld")]
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; init; } 
    
    
    #nullable disable
    
}
