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
[IsoId("_2OKtwdzlEd-tnM7aRm4nqg")]
[DisplayName("Linkages")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Linkages8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Linkages8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Linkages8( References14Choice_ reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_2OKtw9zlEd-tnM7aRm4nqg")]
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
    [IsoId("_2OKtxdzlEd-tnM7aRm4nqg")]
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
    [IsoId("_2OKtx9zlEd-tnM7aRm4nqg")]
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
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_5Mdq4NzlEd-tnM7aRm4nqg")]
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
