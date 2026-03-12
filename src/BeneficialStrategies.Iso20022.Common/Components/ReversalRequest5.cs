// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a reversal.
/// </summary>
[IsoId("_W8b1wXGtEe2TbaNWBpRZpQ")]
[DisplayName("Reversal Request")]
public partial record ReversalRequest5
{
    #nullable enable
    
    /// <summary>
    /// Transaction to reverse.
    /// </summary>
    [IsoId("_XC8GYXGtEe2TbaNWBpRZpQ")]
    [DisplayName("Reversal Transaction")]
    [IsoXmlTag("RvslTx")]
    public CardPaymentTransaction127? ReversalTransaction { get; init; } 
    
    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_XC8GY3GtEe2TbaNWBpRZpQ")]
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public LoyaltyRequestData3? LoyaltyData { get; init; } 
    
    /// <summary>
    /// Reason for this reversal.
    /// </summary>
    [IsoId("_XC8GZXGtEe2TbaNWBpRZpQ")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public required ReversalReason1Code ReversalReason { get; init; } 
    
    /// <summary>
    /// Amount to reverse (total or partial).
    /// </summary>
    [IsoId("_XC8GZ3GtEe2TbaNWBpRZpQ")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    
    /// <summary>
    /// Specific Customer Order linked with the reversal.
    /// </summary>
    [IsoId("_XC8GaXGtEe2TbaNWBpRZpQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    
    #nullable disable
    
}
