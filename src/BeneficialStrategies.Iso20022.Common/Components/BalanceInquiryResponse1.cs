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
[IsoId("_XCUYcO19Eei-V5h0ja04AA")]
[DisplayName("Balance Inquiry Response")]
public partial record BalanceInquiryResponse1
{
    #nullable enable
    
    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_layS0O19Eei-V5h0ja04AA")]
    [DisplayName("Payment Account")]
    [IsoXmlTag("PmtAcct")]
    public PaymentAccount2? PaymentAccount { get; init; } 
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_RYOG8e1-Eei-V5h0ja04AA")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount1? LoyaltyAccount { get; init; } 
    
    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_mjz68e1-Eei-V5h0ja04AA")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public StoredValueAccount1? StoredValueAccount { get; init; } 
    
    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_tVd08e1-Eei-V5h0ja04AA")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt1? Receipt { get; init; } 
    
    
    #nullable disable
    
}
