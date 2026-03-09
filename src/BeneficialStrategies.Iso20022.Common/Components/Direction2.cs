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
/// Elements indicating the direction of the derivative transaction.
/// </summary>
[IsoId("_9zN68C0WEe2ZUuvBHegNNg")]
[DisplayName("Direction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Direction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Direction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Direction2( OptionParty3Code reqDirectionOfTheFirstLeg )
    {
        DirectionOfTheFirstLeg = reqDirectionOfTheFirstLeg;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the first leg as determined at the time of transaction.
    /// </summary>
    [IsoId("_gC-v4C0XEe2ZUuvBHegNNg")]
    [DisplayName("Direction Of The First Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctnOfTheFrstLeg")]
    #endif
    [IsoXmlTag("DrctnOfTheFrstLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionParty3Code DirectionOfTheFirstLeg { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionParty3Code DirectionOfTheFirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionParty3Code DirectionOfTheFirstLeg { get; init; } 
    #else
    public OptionParty3Code DirectionOfTheFirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the second leg as determined at the time of transaction.
    /// </summary>
    [IsoId("_p5uykC0XEe2ZUuvBHegNNg")]
    [DisplayName("Direction Of The Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctnOfTheScndLeg")]
    #endif
    [IsoXmlTag("DrctnOfTheScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionParty3Code? DirectionOfTheSecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionParty3Code? DirectionOfTheSecondLeg { get; init; } 
    #else
    public OptionParty3Code? DirectionOfTheSecondLeg { get; set; } 
    #endif
    
    
    #nullable disable
    
}
