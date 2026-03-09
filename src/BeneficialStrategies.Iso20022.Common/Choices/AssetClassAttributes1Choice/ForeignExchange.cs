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
namespace BeneficialStrategies.Iso20022.Choices.AssetClassAttributes1Choice
{
    /// <summary>
    /// Asset class is a non-financial instrument of type foreign exchange.
    /// </summary>
    [IsoId("_id4oJu94EeW7gabYEJmWIA")]
    [DisplayName("Foreign Exchange")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ForeignExchange : AssetClassAttributes1Choice_
    #else
    public partial class ForeignExchange : AssetClassAttributes1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ForeignExchange instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ForeignExchange( string reqOtherNotionalCurrency )
        {
            OtherNotionalCurrency = reqOtherNotionalCurrency;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Underlying currency 2 of the currency pair (the currency 1 will be populated in the notional currency).
        /// </summary>
        [IsoId("_BDX3g8nZEeWpf-ImB_F2gQ")]
        [DisplayName("Other Notional Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrNtnlCcy")]
        #endif
        [IsoXmlTag("OthrNtnlCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyCode OtherNotionalCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string OtherNotionalCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string OtherNotionalCurrency { get; init; } 
        #else
        public string OtherNotionalCurrency { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
