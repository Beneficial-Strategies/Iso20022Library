// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.Direction4Choice
{
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker).
    /// Usage:
    /// DirectionOfTheFirstLeg should be used for most swaps and swap-like contracts including interest rate swaps, credit total return swaps, and equity swaps (except for credit default swaps, variance, volatility, and correlation swaps) as well as for the foreign exchange swaps, forwards and non-deliverable forwards.
    /// </summary>
    [IsoId("_HmpucC0YEe2ZUuvBHegNNg")]
    [DisplayName("Direction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Direction : Direction4Choice_
    #else
    public partial class Direction : Direction4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Direction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Direction( OptionParty3Code reqDirectionOfTheFirstLeg )
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
}
