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
namespace BeneficialStrategies.Iso20022.Choices.PriceType5Choice
{
    /// <summary>
    /// Estimated price, for valuation purposes.
    /// </summary>
    [IsoId("_SKL8D83yEee5nJBZsW8MFQ")]
    [DisplayName("Indicative")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Indicative : PriceType5Choice_
    #else
    public partial class Indicative : PriceType5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Indicative instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Indicative( YieldedOrValueType1Choice_ reqType,PriceRateOrAmount1Choice_ reqValue )
        {
            Type = reqType;
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specification of the price type.
        /// </summary>
        [IsoId("_WimvZdp-Ed-ak6NoX_4Aeg_-1813914755")]
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
        [IsoId("_WimvZtp-Ed-ak6NoX_4Aeg_373068769")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PriceRateOrAmount1Choice_ Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PriceRateOrAmount1Choice_ Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PriceRateOrAmount1Choice_ Value { get; init; } 
        #else
        public PriceRateOrAmount1Choice_ Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
