// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the accepted status.
/// </summary>
[IsoId("_QyjcWtp-Ed-ak6NoX_4Aeg_-598894903")]
[DisplayName("Accepted Status Reason")]
public partial record AcceptedStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been accepted.
    /// </summary>
    [IsoId("_QysmQNp-Ed-ak6NoX_4Aeg_-1791627574")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required AcceptedReason1Choice_ ReasonCode { get; init; } 
    
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_QysmQdp-Ed-ak6NoX_4Aeg_-598894849")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
