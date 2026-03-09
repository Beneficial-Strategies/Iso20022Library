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
namespace BeneficialStrategies.Iso20022.Choices.AmountPrice1Choice
{
    /// <summary>
    /// Amount expressed as a unit price.
    /// </summary>
    [IsoId("_VMB-Ctp-Ed-ak6NoX_4Aeg_1790266847")]
    [DisplayName("Unit Price")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record UnitPrice : AmountPrice1Choice_
    #else
    public partial class UnitPrice : AmountPrice1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a UnitPrice instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public UnitPrice( TypeOfPrice8Code reqType,PriceValue1 reqValue )
        {
            Type = reqType;
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type and information about a price.
        /// </summary>
        [IsoId("_U4glFdp-Ed-ak6NoX_4Aeg_-1484209806")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TypeOfPrice8Code Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TypeOfPrice8Code Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TypeOfPrice8Code Type { get; init; } 
        #else
        public TypeOfPrice8Code Type { get; set; } 
        #endif
        
        /// <summary>
        /// Value of the price, eg, as a currency and value.
        /// </summary>
        [IsoId("_U4glFtp-Ed-ak6NoX_4Aeg_-1484209805")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PriceValue1 Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PriceValue1 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PriceValue1 Value { get; init; } 
        #else
        public PriceValue1 Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
