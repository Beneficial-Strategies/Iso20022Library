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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice22Choice
{
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument, when the price is available in both monetary value and digital token amount.
    /// </summary>
    [IsoId("_fc2HMKOrEe2UDKy7o9_HIg")]
    [DisplayName("Digital Token Price")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DigitalTokenPrice : SecuritiesTransactionPrice22Choice_
    #else
    public partial class DigitalTokenPrice : SecuritiesTransactionPrice22Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DigitalTokenPrice instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DigitalTokenPrice( AmountAndDirection61 reqMonetaryValue,DigitalTokenAmount2 reqDigitalTokenQuantity )
        {
            MonetaryValue = reqMonetaryValue;
            DigitalTokenQuantity = reqDigitalTokenQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Price expressed as a monetary value.
        /// </summary>
        [IsoId("_i9PTAZiuEe2f7NHvXATP5g")]
        [DisplayName("Monetary Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MntryVal")]
        #endif
        [IsoXmlTag("MntryVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AmountAndDirection61 MonetaryValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AmountAndDirection61 MonetaryValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection61 MonetaryValue { get; init; } 
        #else
        public AmountAndDirection61 MonetaryValue { get; set; } 
        #endif
        
        /// <summary>
        /// Price expressed as a number of digital tokens.
        /// </summary>
        [IsoId("_o26cIJiuEe2f7NHvXATP5g")]
        [DisplayName("Digital Token Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DgtlTknQty")]
        #endif
        [IsoXmlTag("DgtlTknQty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DigitalTokenAmount2 DigitalTokenQuantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DigitalTokenAmount2 DigitalTokenQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DigitalTokenAmount2 DigitalTokenQuantity { get; init; } 
        #else
        public DigitalTokenAmount2 DigitalTokenQuantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
