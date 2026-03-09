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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice10Choice
{
    /// <summary>
    /// Indicates that price is expressed as a monetary value.
    /// </summary>
    [IsoId("_QtL74f9iEea3W_f2lS_aiw")]
    [DisplayName("Monetary Value")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MonetaryValue : SecuritiesTransactionPrice10Choice_
    #else
    public partial class MonetaryValue : SecuritiesTransactionPrice10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MonetaryValue instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MonetaryValue( ActiveOrHistoricCurrencyAnd20Amount reqAmount )
        {
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
        /// </summary>
        [IsoId("_qosZ0UDWEeWOL-OsSq2h6w")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyAnd20Amount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveOrHistoricCurrencyAnd20Amount Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAnd20Amount Amount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAnd20Amount Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates that the amount value is positive or negative.
        /// Usage: When absent, the amount is positive.
        /// </summary>
        [IsoId("_qosZ00DWEeWOL-OsSq2h6w")]
        [DisplayName("Sign")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sgn")]
        #endif
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPlusOrMinusIndicator? Sign { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Sign { get; init; } 
        #else
        public System.String? Sign { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
