// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information provided to claim funds
/// </summary>
[IsoId("_jh2RQBcTEeit0dtP9bTmEg")]
[DisplayName("Claim Information")]
public partial record ClaimInformation1
{
    #nullable enable
    
    /// <summary>
    /// Code presented by the customer to claim funds.
    /// </summary>
    [IsoId("_yZs2UBcTEeit0dtP9bTmEg")]
    [DisplayName("Claim Credentials")]
    [IsoXmlTag("ClmCrdntls")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? ClaimCredentials { get; init; } 
    
    /// <summary>
    /// Entity issuing the claim credential.
    /// </summary>
    [IsoId("_65wy4BcTEeit0dtP9bTmEg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; } 
    
    
    #nullable disable
    
}
