// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reversal Request6.
/// </summary>
[IsoId("_cwaxoZL3Ee6GkefOR4Wjuw")]
[DisplayName("Reversal Request6")]
public partial record ReversalRequest6
{
    #nullable enable

    /// <summary>
    /// Customer Order.
    /// </summary>
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 

    /// <summary>
    /// Loyalty Data.
    /// </summary>
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public ValueList<LoyaltyRequestData3> LoyaltyData { get; init; } = [];

    /// <summary>
    /// Reversal Reason.
    /// </summary>
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public required ReversalReason1Code ReversalReason { get; init; } 

    /// <summary>
    /// Reversal Transaction.
    /// </summary>
    [DisplayName("Reversal Transaction")]
    [IsoXmlTag("RvslTx")]
    public CardPaymentTransaction136? ReversalTransaction { get; init; } 

    /// <summary>
    /// Reversed Amount.
    /// </summary>
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 

    
    #nullable disable
    
}
