// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies one or more agents involved in a transaction, with their role.
/// </summary>
[IsoId("_4zG7sKHHEeagRbKvRt3LnA")]
[DisplayName("Agent Type")]
public partial record AgentType1
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_Wf_bUaHIEeagRbKvRt3LnA")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public SimpleValueList<System.String> AnyBIC { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Wf_bUaHIEeagRbKvRt3LnA
    
    /// <summary>
    /// Specifies the role of the party in the payment chain.
    /// </summary>
    [IsoId("_pNVEMKHIEeagRbKvRt3LnA")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public required PaymentsPartyType1Code Role { get; init; } 
    
    
    #nullable disable
    
}
