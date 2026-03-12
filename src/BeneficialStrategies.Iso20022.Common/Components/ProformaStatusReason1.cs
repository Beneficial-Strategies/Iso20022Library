// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for an proforma status.
/// </summary>
[IsoId("_GeducUzDEeafiMTDrtSnyw")]
[DisplayName("Proforma Status Reason")]
public partial record ProformaStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the proforma account status.
    /// </summary>
    [IsoId("_G4DTIUzDEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ProformaStatusReason2Choice_ Code { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the proforma account status.
    /// </summary>
    [IsoId("_G4DTI0zDEeafiMTDrtSnyw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
