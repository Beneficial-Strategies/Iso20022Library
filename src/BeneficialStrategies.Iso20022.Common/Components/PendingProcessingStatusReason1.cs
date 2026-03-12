// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a pending status.
/// </summary>
[IsoId("_1vE9Klj2EeOnqqBHs8Gasw")]
[DisplayName("Pending Processing Status Reason")]
public partial record PendingProcessingStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_1vFkNFj2EeOnqqBHs8Gasw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required PendingProcessingReason9Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the processed instruction.
    /// </summary>
    [IsoId("_1vE9K1j2EeOnqqBHs8Gasw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
