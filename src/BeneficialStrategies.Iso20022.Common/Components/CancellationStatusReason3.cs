// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status of the cancellation request.
/// </summary>
[IsoId("_sUtWfYlrEeePr-EGJjGYzQ")]
[DisplayName("Cancellation Status Reason")]
public partial record CancellationStatusReason3
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation status.
    /// </summary>
    [IsoId("_skGdQ4lrEeePr-EGJjGYzQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification125? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_skGdRYlrEeePr-EGJjGYzQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancellationStatusReason3Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation status reason.
    /// </summary>
    [IsoId("_skGdR4lrEeePr-EGJjGYzQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
