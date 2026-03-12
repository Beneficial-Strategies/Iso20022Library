// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_WoYoQdzkEd-tnM7aRm4nqg")]
[DisplayName("Linkages")]
public partial record Linkages7
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_WoiZQdzkEd-tnM7aRm4nqg")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition1Choice_? ProcessingPosition { get; init; } 
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_WoiZQ9zkEd-tnM7aRm4nqg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_WoiZRdzkEd-tnM7aRm4nqg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References14Choice_ Reference { get; init; } 
    
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    [IsoId("_WoiZR9zkEd-tnM7aRm4nqg")]
    [DisplayName("Linked Quantity")]
    [IsoXmlTag("LkdQty")]
    public PairedOrTurnedQuantity1Choice_? LinkedQuantity { get; init; } 
    
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_Z0-gENzkEd-tnM7aRm4nqg")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification36Choice_? ReferenceOwner { get; init; } 
    
    
    #nullable disable
    
}
