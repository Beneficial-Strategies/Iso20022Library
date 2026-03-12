// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the reason of the rejection.
/// </summary>
[IsoId("_UsSuA9p-Ed-ak6NoX_4Aeg_-521235445")]
[DisplayName("Rejection Reason")]
public partial record RejectionReason2
{
    #nullable enable
    
    /// <summary>
    /// Reason of the rejection provided by the rejecting party.
    /// </summary>
    [IsoId("_UsSuBNp-Ed-ak6NoX_4Aeg_-153673413")]
    [DisplayName("Rejecting Party Reason")]
    [IsoXmlTag("RjctgPtyRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RejectingPartyReason { get; init; } 
    
    /// <summary>
    /// Date and time at which the rejection was generated.
    /// </summary>
    [IsoId("_UsSuBdp-Ed-ak6NoX_4Aeg_-897575826")]
    [DisplayName("Rejection Date Time")]
    [IsoXmlTag("RjctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RejectionDateTime { get; init; } 
    
    /// <summary>
    /// Description of the precise location of the potential error in a message.
    /// </summary>
    [IsoId("_UsSuBtp-Ed-ak6NoX_4Aeg_-147208766")]
    [DisplayName("Error Location")]
    [IsoXmlTag("ErrLctn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? ErrorLocation { get; init; } 
    
    /// <summary>
    /// Detailed description of the rejection reason.
    /// </summary>
    [IsoId("_UsSuB9p-Ed-ak6NoX_4Aeg_-90876576")]
    [DisplayName("Reason Description")]
    [IsoXmlTag("RsnDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? ReasonDescription { get; init; } 
    
    /// <summary>
    /// Additional information related to the rejection and meant to allow for the precise identification of the rejection reason. This could include a copy of the rejected message in part or in full.
    /// </summary>
    [IsoId("_UsSuCNp-Ed-ak6NoX_4Aeg_-53011612")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public IsoMax20000Text? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
