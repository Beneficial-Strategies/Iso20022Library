// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on a payment transaction.
/// </summary>
[IsoId("_hKQTse0gEeWGZ8O9Moj6Zw")]
[DisplayName("Transaction Return Criteria")]
public partial record TransactionReturnCriteria4
{
    #nullable enable
    
    /// <summary>
    /// Destination of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_hUXR8-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Payment To Return Criteria")]
    [IsoXmlTag("PmtToRtrCrit")]
    public SystemReturnCriteria2? PaymentToReturnCriteria { get; init; } 
    
    /// <summary>
    /// Origin of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_hUXR9e0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Payment From Return Criteria")]
    [IsoXmlTag("PmtFrRtrCrit")]
    public SystemReturnCriteria2? PaymentFromReturnCriteria { get; init; } 
    
    /// <summary>
    /// Defines the criteria used to report on the cash entry.
    /// </summary>
    [IsoId("_hUXR9-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Cash Entry Return Criteria")]
    [IsoXmlTag("AcctCshNtryRtrCrit")]
    public AccountCashEntryReturnCriteria3? AccountCashEntryReturnCriteria { get; init; } 
    
    /// <summary>
    /// Defines the criteria used to report on the payment.
    /// </summary>
    [IsoId("_hUXR-e0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Payment Return Criteria")]
    [IsoXmlTag("PmtRtrCrit")]
    public PaymentReturnCriteria3? PaymentReturnCriteria { get; init; } 
    
    
    #nullable disable
    
}
