// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the result of a processed loyalty transaction.
/// </summary>
[IsoId("_UWZZANxLEeioifFt1dhnJA")]
[DisplayName("Loyalty Result")]
public partial record LoyaltyResult1
{
    #nullable enable
    
    /// <summary>
    /// Account managing the Loyalty.
    /// </summary>
    [IsoId("_jkTGkNxLEeioifFt1dhnJA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required LoyaltyAccount1 Account { get; init; } 
    
    /// <summary>
    /// Amount.
    /// </summary>
    [IsoId("_uuQdkNxLEeioifFt1dhnJA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public LoyaltyAmount1? Amount { get; init; } 
    
    /// <summary>
    /// Data sent by the Loyalty server.
    /// </summary>
    [IsoId("_x6aQgNxLEeioifFt1dhnJA")]
    [DisplayName("Server Data")]
    [IsoXmlTag("SvrData")]
    public LoyaltyServerData1? ServerData { get; init; } 
    
    /// <summary>
    /// Rebate information.
    /// </summary>
    [IsoId("_IBz6kNxOEeioifFt1dhnJA")]
    [DisplayName("Rebates")]
    [IsoXmlTag("Rbts")]
    public LoyaltyRebates1? Rebates { get; init; } 
    
    
    #nullable disable
    
}
