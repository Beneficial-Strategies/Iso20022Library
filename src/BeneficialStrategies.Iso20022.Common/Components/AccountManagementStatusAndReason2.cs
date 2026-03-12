// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of an account opening instruction or account modification instruction that was previously received.
/// </summary>
[IsoId("_xpyPYRc5EeK5g-3oYI0_9Q")]
[DisplayName("Account Management Status And Reason")]
public partial record AccountManagementStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Status of the account opening instruction or account modification instruction.
    /// </summary>
    [IsoId("_ab1YsBdSEeK5g-3oYI0_9Q")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status12Choice_ Status { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_x-f7MRc5EeK5g-3oYI0_9Q")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    
    #nullable disable
    
}
