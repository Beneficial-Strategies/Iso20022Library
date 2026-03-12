// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a requested Loyalty program or account.
/// </summary>
[IsoId("_0MHNEQxqEeqdx6buGpCCQw")]
[DisplayName("Loyalty Account Request")]
public partial record LoyaltyAccountRequest2
{
    #nullable enable
    
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_0YeOEQxqEeqdx6buGpCCQw")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_0YeOEwxqEeqdx6buGpCCQw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public LoyaltyAccount2? Account { get; init; } 
    
    
    #nullable disable
    
}
