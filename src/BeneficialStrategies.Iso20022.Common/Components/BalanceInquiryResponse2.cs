// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Balance Inquiry Response message.
/// </summary>
[IsoId("_FM7pwQxrEeqdx6buGpCCQw")]
[DisplayName("Balance Inquiry Response")]
public partial record BalanceInquiryResponse2
{
    #nullable enable
    
    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_FYARUQxrEeqdx6buGpCCQw")]
    [DisplayName("Payment Account")]
    [IsoXmlTag("PmtAcct")]
    public PaymentAccount3? PaymentAccount { get; init; } 
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_FYARUwxrEeqdx6buGpCCQw")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount2? LoyaltyAccount { get; init; } 
    
    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_FYARVQxrEeqdx6buGpCCQw")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public StoredValueAccount2? StoredValueAccount { get; init; } 
    
    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_FYARVwxrEeqdx6buGpCCQw")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt2? Receipt { get; init; } 
    
    
    #nullable disable
    
}
