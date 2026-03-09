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
namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice3Choice
{
    /// <summary>
    /// Proprietary price specification related to the underlying transaction.
    /// </summary>
    [IsoId("_tqJEMFkyEeGeoaLUQk__nA_1612231068")]
    [DisplayName("Proprietary")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Proprietary : TransactionPrice3Choice_
    #else
    public partial class Proprietary : TransactionPrice3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Proprietary instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Proprietary( System.String reqType,ActiveOrHistoricCurrencyAndAmount reqPrice )
        {
            Type = reqType;
            Price = reqPrice;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the type of price.
        /// </summary>
        [IsoId("_Rpr4pdp-Ed-ak6NoX_4Aeg_1562404617")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Type { get; init; } 
        #else
        public System.String Type { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary price specification related to the underlying transaction.
        /// </summary>
        [IsoId("_Rpr4ptp-Ed-ak6NoX_4Aeg_1562404671")]
        [DisplayName("Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pric")]
        #endif
        [IsoXmlTag("Pric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyAndAmount Price { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveOrHistoricCurrencyAndAmount Price { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount Price { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount Price { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
