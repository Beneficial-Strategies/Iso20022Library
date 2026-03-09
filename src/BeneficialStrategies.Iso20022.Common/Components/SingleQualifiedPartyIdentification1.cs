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
/// Defines an identifier for a party relative to another party using an identifier of another party followed by a local identifier issued by the other party.
/// It is assumed that customers of an identifiable party can be referenced by an identifier relative to that party. The identification of the party together with the relative identifier identifies the customer.
/// Such references can occur in sequence. The last occurrence of RelativeIdentifier is the local identifier at the party recursively defined by the PrefixParty and all preceding occurrences of RelativeIdentifier.
/// Technical note: The sequence of relative identifiers is used to avoid a recursive definition in the catalogue.
/// </summary>
[IsoId("_OTgzMjUx-AOSNFX-8224494")]
[DisplayName("Single Qualified Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SingleQualifiedPartyIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SingleQualifiedPartyIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SingleQualifiedPartyIdentification1( TradeParty1 reqBaseParty )
    {
        BaseParty = reqBaseParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party identification recognisable by parties in the trade.
    /// </summary>
    [IsoId("_OTgzMjUy-AOSNFX-8224494")]
    [DisplayName("Base Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BasePty")]
    #endif
    [IsoXmlTag("BasePty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeParty1 BaseParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeParty1 BaseParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1 BaseParty { get; init; } 
    #else
    public TradeParty1 BaseParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a party, each identifier is recursively defined relative to the party identified by the base party and the preceding part of the list.
    /// </summary>
    [IsoId("_OTgzMjUz-AOSNFX-8224494")]
    [DisplayName("Relative Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltvIdr")]
    #endif
    [IsoXmlTag("RltvIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> RelativeIdentifier { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
