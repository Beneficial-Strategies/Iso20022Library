// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security CSD Link Update3.
/// </summary>
[IsoId("_DAcycZ2KEe6LRZBwAQprDA")]
[DisplayName("Security CSD Link Update3")]
public partial record SecurityCSDLinkUpdate3
{
    #nullable enable

    /// <summary>
    /// Default Link.
    /// </summary>
    [DisplayName("Default Link")]
    [IsoXmlTag("DfltLk")]
    public IsoTrueFalseIndicator? DefaultLink { get; init; } 

    /// <summary>
    /// Valid To.
    /// </summary>
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    public required DateAndDateTime2Choice_ ValidTo { get; init; } 

    
    #nullable disable
    
}
