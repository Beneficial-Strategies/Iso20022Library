// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security CSD Link Update3.
/// </summary>
[IsoId("_DAcycZ2KEe6LRZBwAQprDA")]
[DisplayName("Security CSD Link Update3")]
public record SecurityCSDLinkUpdate3
{
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
}
