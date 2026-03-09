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
/// Specifies the relationship record between two parties.
/// </summary>
[IsoId("_XVpN0CR7Ee2VuKUpJ7HXPg")]
[DisplayName("Trade Counterparty Relationship Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeCounterpartyRelationshipRecord1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeCounterpartyRelationshipRecord1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeCounterpartyRelationshipRecord1( TradeCounterpartyType1Code reqStartRelationshipParty,TradeCounterpartyType1Code reqEndRelationshipParty,TradeCounterpartyRelationship1Choice_ reqRelationshipType )
    {
        StartRelationshipParty = reqStartRelationshipParty;
        EndRelationshipParty = reqEndRelationshipParty;
        RelationshipType = reqRelationshipType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies type of counterparty at the start of a directional relationship.
    /// </summary>
    [IsoId("_iEevECR7Ee2VuKUpJ7HXPg")]
    [DisplayName("Start Relationship Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartRltshPty")]
    #endif
    [IsoXmlTag("StartRltshPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCounterpartyType1Code StartRelationshipParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeCounterpartyType1Code StartRelationshipParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyType1Code StartRelationshipParty { get; init; } 
    #else
    public TradeCounterpartyType1Code StartRelationshipParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies type of counterparty at the end of a directional relationship.
    /// </summary>
    [IsoId("_ixzIECR7Ee2VuKUpJ7HXPg")]
    [DisplayName("End Relationship Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndRltshPty")]
    #endif
    [IsoXmlTag("EndRltshPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCounterpartyType1Code EndRelationshipParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeCounterpartyType1Code EndRelationshipParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyType1Code EndRelationshipParty { get; init; } 
    #else
    public TradeCounterpartyType1Code EndRelationshipParty { get; set; } 
    #endif
    
    /// <summary>
    /// Type of relationship between two parties.
    /// Usage: RelationshipType is always in the direction of the StartRelationshipParty to EndRelationshipParty.
    /// </summary>
    [IsoId("_jcbZcCR7Ee2VuKUpJ7HXPg")]
    [DisplayName("Relationship Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltshTp")]
    #endif
    [IsoXmlTag("RltshTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCounterpartyRelationship1Choice_ RelationshipType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeCounterpartyRelationship1Choice_ RelationshipType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyRelationship1Choice_ RelationshipType { get; init; } 
    #else
    public TradeCounterpartyRelationship1Choice_ RelationshipType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides description of other type of relationship between two parties.
    /// Usage: Description is to be used only when RelationshipType is not precisely indicating the type of relationship between parties to the transaction.
    /// </summary>
    [IsoId("_tdQlMCR7Ee2VuKUpJ7HXPg")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
