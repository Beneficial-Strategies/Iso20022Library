// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the cheque presentment cancellation request.
/// </summary>
[IsoId("_kwwc97tvEeq_cfXrH83Rcw")]
[DisplayName("Cheque Cancellation Reason")]
public partial record ChequeCancellationReason1
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_kwwc-btvEeq_cfXrH83Rcw")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public ChequePartyRole1Code? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_kwwc-LtvEeq_cfXrH83Rcw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required ChequeCancellationReason1Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_kwwc-rtvEeq_cfXrH83Rcw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
