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
namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice1Choice
{
    /// <summary>
    /// Proprietary price specification of the underlying transaction.
    /// </summary>
    [IsoId("_RUrR9tp-Ed-ak6NoX_4Aeg_969960515")]
    [DisplayName("Proprietary")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Proprietary : TransactionPrice1Choice_
    #else
    public partial class Proprietary : TransactionPrice1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Proprietary instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Proprietary( System.String reqType,CurrencyAndAmount reqPrice )
        {
            Type = reqType;
            Price = reqPrice;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the type of price reported.
        /// </summary>
        [IsoId("_RUhg9Np-Ed-ak6NoX_4Aeg_1603762562")]
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
        [IsoId("_RUhg9dp-Ed-ak6NoX_4Aeg_426005158")]
        [DisplayName("Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pric")]
        #endif
        [IsoXmlTag("Pric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CurrencyAndAmount Price { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CurrencyAndAmount Price { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CurrencyAndAmount Price { get; init; } 
        #else
        public CurrencyAndAmount Price { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
