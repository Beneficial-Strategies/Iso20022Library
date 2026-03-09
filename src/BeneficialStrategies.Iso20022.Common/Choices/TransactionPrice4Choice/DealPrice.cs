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
namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice4Choice
{
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_-XasI7TUEee_k7HqaUKERA")]
    [DisplayName("Deal Price")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DealPrice : TransactionPrice4Choice_
    #else
    public partial class DealPrice : TransactionPrice4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DealPrice instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DealPrice( YieldedOrValueType1Choice_ reqType,PriceRateOrAmount3Choice_ reqValue )
        {
            Type = reqType;
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specification of the price type.
        /// </summary>
        [IsoId("_yehJYbQBEee1Ke-6rZgsrA")]
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
        [IsoId("_yehJY7QBEee1Ke-6rZgsrA")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PriceRateOrAmount3Choice_ Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PriceRateOrAmount3Choice_ Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PriceRateOrAmount3Choice_ Value { get; init; } 
        #else
        public PriceRateOrAmount3Choice_ Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
