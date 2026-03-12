// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status reason of the debtor activation request.
/// </summary>
[IsoId("_P4LStOIKEeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Status Reason")]
public partial record DebtorActivationStatusReason2
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_P4LSt-IKEeqbls7Gk4-ckA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public RTPPartyIdentification1? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the status reason for the debtor activation request.
    /// </summary>
    [IsoId("_P4LSteIKEeqbls7Gk4-ckA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required DebtorActivationStatusReason1Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_P4LStuIKEeqbls7Gk4-ckA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
