// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_u7dqL-DgEd-udr336SN7mQ")]
[DisplayName("Linkages")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Linkages9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Linkages9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Linkages9( References14Choice_ reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_u7dqMeDgEd-udr336SN7mQ")]
    [DisplayName("Processing Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgPos")]
    #endif
    [IsoXmlTag("PrcgPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingPosition1Choice_? ProcessingPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingPosition1Choice_? ProcessingPosition { get; init; } 
    #else
    public ProcessingPosition1Choice_? ProcessingPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_u7dqM-DgEd-udr336SN7mQ")]
    [DisplayName("Message Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNb")]
    #endif
    [IsoXmlTag("MsgNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    #else
    public DocumentNumber1Choice_? MessageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_u7dqNeDgEd-udr336SN7mQ")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References14Choice_ Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References14Choice_ Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References14Choice_ Reference { get; init; } 
    #else
    public References14Choice_ Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    [IsoId("_u7dqN-DgEd-udr336SN7mQ")]
    [DisplayName("Linked Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdQty")]
    #endif
    [IsoXmlTag("LkdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PairedOrTurnedQuantity1Choice_? LinkedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PairedOrTurnedQuantity1Choice_? LinkedQuantity { get; init; } 
    #else
    public PairedOrTurnedQuantity1Choice_? LinkedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_AgwKMPb4Ed-P34yQZlSZoQ")]
    [DisplayName("Reference Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefOwnr")]
    #endif
    [IsoXmlTag("RefOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification36Choice_? ReferenceOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification36Choice_? ReferenceOwner { get; init; } 
    #else
    public PartyIdentification36Choice_? ReferenceOwner { get; set; } 
    #endif
    
    
    #nullable disable
    
}
