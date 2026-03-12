// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the rejection of the instruction or cancellation request.
/// </summary>
[IsoId("_RCfVwtp-Ed-ak6NoX_4Aeg_-1755939750")]
[DisplayName("Additional Status")]
public partial record AdditionalStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason advising the rejection of the instruction.
    /// </summary>
    [IsoId("_RCfVw9p-Ed-ak6NoX_4Aeg_-1090217196")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required InstructionRejectionStatus1Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the reason.
    /// </summary>
    [IsoId("_RCfVxNp-Ed-ak6NoX_4Aeg_-1755939689")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
