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
namespace BeneficialStrategies.Iso20022.Choices.Direction2Choice
{
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the first leg as determined at the time of transaction.
    /// </summary>
    [IsoId("_oKFn0Xg-Eeu3kecHd7QKUQ")]
    [DisplayName("Direction Of The First Leg")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DirectionOfTheFirstLeg : Direction2Choice_
    #else
    public partial class DirectionOfTheFirstLeg : Direction2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DirectionOfTheFirstLeg instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DirectionOfTheFirstLeg( OptionParty3Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies if a trade party is a taker or a maker.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrctnOfTheFrstLeg")]
        #endif
        [IsoXmlTag("DrctnOfTheFrstLeg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OptionParty3Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OptionParty3Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OptionParty3Code Value { get; init; } 
        #else
        public OptionParty3Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
