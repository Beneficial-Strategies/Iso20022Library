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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAggregateBalance1Choice
{
    /// <summary>
    /// Balance of holdings.
    /// </summary>
    [IsoId("_oI2KMaCCEeOEyO7fCl8lLA")]
    [DisplayName("Holding Balance")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record HoldingBalance : FinancialInstrumentAggregateBalance1Choice_
    #else
    public partial class HoldingBalance : FinancialInstrumentAggregateBalance1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Balance of settled transactions.
        /// </summary>
        [IsoId("_aA5_KqCCEeOEyO7fCl8lLA")]
        [DisplayName("Settled Balance")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttldBal")]
        #endif
        [IsoXmlTag("SttldBal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrumentQuantity1Choice_? SettledBalance { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity1Choice_? SettledBalance { get; init; } 
        #else
        public FinancialInstrumentQuantity1Choice_? SettledBalance { get; set; } 
        #endif
        
        /// <summary>
        /// Balance of settled transactions and transactions pending settlement.
        /// </summary>
        [IsoId("_aA5_KaCCEeOEyO7fCl8lLA")]
        [DisplayName("Traded Balance")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TraddBal")]
        #endif
        [IsoXmlTag("TraddBal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrumentQuantity1Choice_? TradedBalance { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity1Choice_? TradedBalance { get; init; } 
        #else
        public FinancialInstrumentQuantity1Choice_? TradedBalance { get; set; } 
        #endif
        
        /// <summary>
        /// Breakdown of the balances of holdings into sub-balances.
        /// </summary>
        [IsoId("_aA5_K6CCEeOEyO7fCl8lLA")]
        [DisplayName("Balance Breakdown")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BalBrkdwn")]
        #endif
        [IsoXmlTag("BalBrkdwn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SubBalanceBreakdown1? BalanceBreakdown { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SubBalanceBreakdown1? BalanceBreakdown { get; init; } 
        #else
        public SubBalanceBreakdown1? BalanceBreakdown { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
