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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity14Choice
{
    /// <summary>
    /// Quantity expressed as a number, for example, a number of shares.
    /// </summary>
    [IsoId("_Wr_78dp-Ed-ak6NoX_4Aeg_-21246181")]
    [DisplayName("Unit")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Unit : FinancialInstrumentQuantity14Choice_
    #else
    public partial class Unit : FinancialInstrumentQuantity14Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Unit instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Unit( System.UInt64 reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example, 0.75 or 45.6.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Unit")]
        #endif
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoRestrictedFINDecimalNumber Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Value { get; init; } 
        #else
        public System.UInt64 Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
