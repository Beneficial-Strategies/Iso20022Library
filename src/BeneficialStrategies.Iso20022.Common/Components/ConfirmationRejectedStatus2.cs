// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rejection of a confirmation.
/// </summary>
[IsoId("_EwdoAUhDEea8pJjypp-yMQ")]
[DisplayName("Confirmation Rejected Status")]
public partial record ConfirmationRejectedStatus2
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_FJAq40hDEea8pJjypp-yMQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ConfirmationRejectedReason1Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    [IsoId("__OYdI3ZxEeaN2c674jyTxQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
