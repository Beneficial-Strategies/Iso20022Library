// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason to reject the message.
/// </summary>
[IsoId("_U3LIX9p-Ed-ak6NoX_4Aeg_-2025393824")]
[DisplayName("Rejection Reason")]
public partial record RejectionReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_U3USQNp-Ed-ak6NoX_4Aeg_-282709820")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MessageRejectedReason1Code Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the rejection reason.
    /// </summary>
    [IsoId("_U3USQdp-Ed-ak6NoX_4Aeg_-282709803")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Linked previous reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_U3USQtp-Ed-ak6NoX_4Aeg_-425856419")]
    [DisplayName("Linked Message Previous Reference")]
    [IsoXmlTag("LkdMsgPrvsRef")]
    public AdditionalReference2? LinkedMessagePreviousReference { get; init; } 
    
    /// <summary>
    /// Linked other reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_U3USQ9p-Ed-ak6NoX_4Aeg_-71222051")]
    [DisplayName("Linked Message Other Reference")]
    [IsoXmlTag("LkdMsgOthrRef")]
    public AdditionalReference2? LinkedMessageOtherReference { get; init; } 
    
    /// <summary>
    /// Linked related reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_U3USRNp-Ed-ak6NoX_4Aeg_1139278303")]
    [DisplayName("Linked Message Related Reference")]
    [IsoXmlTag("LkdMsgRltdRef")]
    public AdditionalReference2? LinkedMessageRelatedReference { get; init; } 
    
    
    #nullable disable
    
}
