// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the payment transaction status and optionally the reason for that status. 
/// </summary>
[IsoId("_VkglBEJHEeinU6Cqu8f2Ow")]
[DisplayName("Payment Status")]
public partial record PaymentStatus4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a single payment transaction.
    /// </summary>
    [IsoId("_VkglBUJHEeinU6Cqu8f2Ow")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransactionIndividualStatus5Code Status { get; init; } 
    
    /// <summary>
    /// Provides the reason for a specific payment status.
    /// </summary>
    [IsoId("_VkglBkJHEeinU6Cqu8f2Ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public PaymentStatusReason1Code? Reason { get; init; } 
    
    
    #nullable disable
    
}
