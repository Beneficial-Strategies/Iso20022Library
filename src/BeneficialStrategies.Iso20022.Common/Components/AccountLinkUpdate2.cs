// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Link Update2.
/// </summary>
[IsoId("_K8BEsWcxEemvNLufWGIVOQ")]
[DisplayName("Account Link Update2")]
public partial record AccountLinkUpdate2
{
    #nullable enable

    /// <summary>
    /// Valid To.
    /// </summary>
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    public required DateAndDateTime2Choice_ ValidTo { get; init; } 

    
    #nullable disable
    
}
