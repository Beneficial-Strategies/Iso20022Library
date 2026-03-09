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
namespace BeneficialStrategies.Iso20022.Choices.PriceType1Choice
{
    /// <summary>
    /// Last reported price of a financial instrument in a market, determined by supply and demand.
    /// </summary>
    [IsoId("_RdnLhtp-Ed-ak6NoX_4Aeg_-394309489")]
    [DisplayName("Market")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Market : PriceType1Choice_
    #else
    public partial class Market : PriceType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Market instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Market( YieldedOrValueType1Choice_ reqType,PriceRateOrAmountChoice_ reqValue )
        {
            Type = reqType;
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specification of the price type.
        /// </summary>
        [IsoId("_QfxqSNp-Ed-ak6NoX_4Aeg_-109280990")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required YieldedOrValueType1Choice_ Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required YieldedOrValueType1Choice_ Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public YieldedOrValueType1Choice_ Type { get; init; } 
        #else
        public YieldedOrValueType1Choice_ Type { get; set; } 
        #endif
        
        /// <summary>
        /// Value of the price, for example, as a currency and value.
        /// </summary>
        [IsoId("_QfxqSdp-Ed-ak6NoX_4Aeg_-371294350")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PriceRateOrAmountChoice_ Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PriceRateOrAmountChoice_ Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PriceRateOrAmountChoice_ Value { get; init; } 
        #else
        public PriceRateOrAmountChoice_ Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
