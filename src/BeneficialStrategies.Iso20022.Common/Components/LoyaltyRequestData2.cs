// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data linked to card loyalty during payment.
/// </summary>
[IsoId("_K09FUQ0zEeqUVL7sB4m7NA")]
[DisplayName("Loyalty Request Data")]
public partial record LoyaltyRequestData2
{
    #nullable enable
    
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_LAltkQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    /// <summary>
    /// Identification of a Loyalty account.
    /// </summary>
    [IsoId("_LAltkw0zEeqUVL7sB4m7NA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public LoyaltyAccount2? Account { get; init; } 
    
    /// <summary>
    /// Amount of a loyalty account.
    /// </summary>
    [IsoId("_LAltlQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public LoyaltyAmount1? Amount { get; init; } 
    
    
    #nullable disable
    
}
