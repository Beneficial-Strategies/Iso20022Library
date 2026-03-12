// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a loyalty service. A Loyalty request contents : the loyalty transaction request and the loyalty data if any.
/// </summary>
[IsoId("_A9uhgQ0zEeqUVL7sB4m7NA")]
[DisplayName("Loyalty Request")]
public partial record LoyaltyRequest2
{
    #nullable enable
    
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_BJUGcQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_BJUGcw0zEeqUVL7sB4m7NA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required LoyaltyTransaction2 Transaction { get; init; } 
    
    /// <summary>
    /// Data related to a Loyalty program or account.
    /// </summary>
    [IsoId("_BJUGdQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public LoyaltyRequestData2? Data { get; init; } 
    
    
    #nullable disable
    
}
