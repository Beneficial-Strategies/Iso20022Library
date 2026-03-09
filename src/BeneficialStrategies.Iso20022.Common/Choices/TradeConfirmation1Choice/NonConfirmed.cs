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
namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation1Choice
{
    /// <summary>
    /// Indicates that contract was not confirmed.
    /// </summary>
    [IsoId("_SDySEA28EeWmAKKPnqYEVQ")]
    [DisplayName("Non Confirmed")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NonConfirmed : TradeConfirmation1Choice_
    #else
    public partial class NonConfirmed : TradeConfirmation1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NonConfirmed instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NonConfirmed( TradeConfirmationType2Code reqType )
        {
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies that the contract remains unconfirmed.
        /// </summary>
        [IsoId("_8sHJ5w27EeWmAKKPnqYEVQ")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TradeConfirmationType2Code Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TradeConfirmationType2Code Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeConfirmationType2Code Type { get; init; } 
        #else
        public TradeConfirmationType2Code Type { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
