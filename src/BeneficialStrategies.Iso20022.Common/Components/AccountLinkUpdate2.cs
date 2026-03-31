// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Link Update2.
/// </summary>
[IsoId("_K8BEsWcxEemvNLufWGIVOQ")]
[DisplayName("Account Link Update2")]
public record AccountLinkUpdate2
{
    /// <summary>
    /// Valid To.
    /// </summary>
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    public required DateAndDateTime2Choice_ ValidTo { get; init; }
}
