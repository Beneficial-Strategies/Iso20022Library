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
namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat6Choice
{
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_lHIu4Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Balance")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Balance : BalanceFormat6Choice_
    #else
    public partial class Balance : BalanceFormat6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Balance instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Balance( ShortLong1Code reqShortLongPosition,Quantity19Choice_ reqQuantityChoice )
        {
            ShortLongPosition = reqShortLongPosition;
            QuantityChoice = reqQuantityChoice;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_LbsO8zq6EeWQ1Y7f8kds2A")]
        [DisplayName("Short Long Position")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrtLngPos")]
        #endif
        [IsoXmlTag("ShrtLngPos")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ShortLong1Code ShortLongPosition { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ShortLong1Code ShortLongPosition { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ShortLong1Code ShortLongPosition { get; init; } 
        #else
        public ShortLong1Code ShortLongPosition { get; set; } 
        #endif
        
        /// <summary>
        /// Choice between different quantity of security formats.
        /// </summary>
        [IsoId("_LbsO9Tq6EeWQ1Y7f8kds2A")]
        [DisplayName("Quantity Choice")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtyChc")]
        #endif
        [IsoXmlTag("QtyChc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Quantity19Choice_ QuantityChoice { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Quantity19Choice_ QuantityChoice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Quantity19Choice_ QuantityChoice { get; init; } 
        #else
        public Quantity19Choice_ QuantityChoice { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
