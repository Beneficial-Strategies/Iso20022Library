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
/// Specifies the details on the settlement fails per participant.
/// </summary>
[IsoId("_dhkbUI0UEemUAO64Q252gQ")]
[DisplayName("Settlement Fails Participant")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsParticipant1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsParticipant1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsParticipant1( System.String reqLEI,System.String reqRank,SettlementTotalData1 reqAggregate )
    {
        LEI = reqLEI;
        Rank = reqRank;
        Aggregate = reqAggregate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Legal entity identification of the participant in the securities settlement system.
    /// </summary>
    [IsoId("_pLGqQY0UEemUAO64Q252gQ")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier LEI { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LEI { get; init; } 
    #else
    public System.String LEI { get; set; } 
    #endif
    
    /// <summary>
    /// Ranking of the top participants with the highest rate of settlement fails.
    /// </summary>
    [IsoId("_qNCoYY0UEemUAO64Q252gQ")]
    [DisplayName("Rank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rank")]
    #endif
    [IsoXmlTag("Rank")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2NumericText Rank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Rank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Rank { get; init; } 
    #else
    public System.String Rank { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregated data of the settlement instructions.
    /// </summary>
    [IsoId("_4yoYwI0UEemUAO64Q252gQ")]
    [DisplayName("Aggregate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Aggt")]
    #endif
    [IsoXmlTag("Aggt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1 Aggregate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1 Aggregate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1 Aggregate { get; init; } 
    #else
    public SettlementTotalData1 Aggregate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
