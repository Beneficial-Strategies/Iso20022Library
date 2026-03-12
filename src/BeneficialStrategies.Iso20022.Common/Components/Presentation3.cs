// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Electronic presentation information.
/// </summary>
[IsoId("_97IpNHltEeG7BsjMvd1mEw_776064240")]
[DisplayName("Presentation")]
public partial record Presentation3
{
    #nullable enable
    
    /// <summary>
    /// Format for presentation documents that are submitted electronically.
    /// </summary>
    [IsoId("_97RzIHltEeG7BsjMvd1mEw_1774083101")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public DocumentFormat1Choice_? Format { get; init; } 
    
    /// <summary>
    /// Channel through which presentation documents are submitted electronically, such as SWIFT, Web upload, or secure email.
    /// </summary>
    [IsoId("_97RzIXltEeG7BsjMvd1mEw_-403292535")]
    [DisplayName("Channel")]
    [IsoXmlTag("Chanl")]
    public Channel1Choice_? Channel { get; init; } 
    
    /// <summary>
    /// Uniform Resource Identifier (URI), such as a web or an email address, specifying where the presentation can be addressed.
    /// </summary>
    [IsoId("_97RzInltEeG7BsjMvd1mEw_837339061")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Address { get; init; } 
    
    
    #nullable disable
    
}
