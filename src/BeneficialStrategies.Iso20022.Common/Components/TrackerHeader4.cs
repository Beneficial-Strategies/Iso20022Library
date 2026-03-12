// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_k0GN8_Y0Eemf4dJxCjghNw")]
[DisplayName("Tracker Header")]
public partial record TrackerHeader4
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the tracker informing party and sent by the tracker to unambiguously identify the message.
    /// </summary>
    [IsoId("_k0GN9fY0Eemf4dJxCjghNw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_k0GN9_Y0Eemf4dJxCjghNw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Original reference, as assigned by the informer and sent to the tracker to unambiguously identify the tracker update message.
    /// Usage: this element may only be present when the alert notification is related to a payment status tracker update.
    /// </summary>
    [IsoId("_k0GN__Y0Eemf4dJxCjghNw")]
    [DisplayName("Original Tracker Update")]
    [IsoXmlTag("OrgnlTrckrUpd")]
    public OriginalBusinessInstruction3? OriginalTrackerUpdate { get; init; } 
    
    /// <summary>
    /// Agreement under which or rules under which the tracker update must be processed.
    /// </summary>
    [IsoId("_k0GOAfY0Eemf4dJxCjghNw")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public TransactionServiceLevel1? ServiceLevel { get; init; } 
    
    
    #nullable disable
    
}
