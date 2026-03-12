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
[IsoId("_dlhzYS9BEeu125Ip9zFcsQ")]
[DisplayName("Balance Inquiry Response")]
public partial record BalanceInquiryResponse3
{
    #nullable enable
    
    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_dx7QoS9BEeu125Ip9zFcsQ")]
    [DisplayName("Payment Account")]
    [IsoXmlTag("PmtAcct")]
    public PaymentAccount3? PaymentAccount { get; init; } 
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_dx7Qoy9BEeu125Ip9zFcsQ")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount2? LoyaltyAccount { get; init; } 
    
    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_dx7QpS9BEeu125Ip9zFcsQ")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public StoredValueAccount2? StoredValueAccount { get; init; } 
    
    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_dx7Qpy9BEeu125Ip9zFcsQ")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt3? Receipt { get; init; } 
    
    
    #nullable disable
    
}
