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
/// Communication channel information.
/// </summary>
[IsoId("_9yCXl3ltEeG7BsjMvd1mEw_167324952")]
[DisplayName("Communication Channel")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommunicationChannel1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommunicationChannel1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommunicationChannel1( ExternalChannel1Code reqMethod,PartyType1Choice_ reqDeliverToPartyType )
    {
        Method = reqMethod;
        DeliverToPartyType = reqDeliverToPartyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method by which the original undertaking or proposed amendment is to be made available.
    /// </summary>
    [IsoId("_QEJog38KEeGvEbxvurqpIg")]
    [DisplayName("Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtd")]
    #endif
    [IsoXmlTag("Mtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChannel1Code Method { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalChannel1Code Method { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalChannel1Code Method { get; init; } 
    #else
    public ExternalChannel1Code Method { get; set; } 
    #endif
    
    /// <summary>
    /// Type of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    [IsoId("_9yCXmXltEeG7BsjMvd1mEw_-988253345")]
    [DisplayName("Deliver To Party Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrToPtyTp")]
    #endif
    [IsoXmlTag("DlvrToPtyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyType1Choice_ DeliverToPartyType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyType1Choice_ DeliverToPartyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType1Choice_ DeliverToPartyType { get; init; } 
    #else
    public PartyType1Choice_ DeliverToPartyType { get; set; } 
    #endif
    
    /// <summary>
    /// Name of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    [IsoId("_9yMIkHltEeG7BsjMvd1mEw_493546087")]
    [DisplayName("Deliver To Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrToNm")]
    #endif
    [IsoXmlTag("DlvrToNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? DeliverToName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliverToName { get; init; } 
    #else
    public System.String? DeliverToName { get; set; } 
    #endif
    
    /// <summary>
    /// Address of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    [IsoId("_9yMIkXltEeG7BsjMvd1mEw_-657472540")]
    [DisplayName("Deliver To Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrToAdr")]
    #endif
    [IsoXmlTag("DlvrToAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress6? DeliverToAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress6? DeliverToAddress { get; init; } 
    #else
    public PostalAddress6? DeliverToAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
