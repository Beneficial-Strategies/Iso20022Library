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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentIdentification9Choice
{
    /// <summary>
    /// Index on which the financial instrument is based.
    /// </summary>
    [IsoId("_3V6ZQ53DEeuwmdq0KtnICg")]
    [DisplayName("Index")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Index : FinancialInstrumentIdentification9Choice_
    #else
    public partial class Index : FinancialInstrumentIdentification9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Index instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Index( FloatingInterestRate8 reqName )
        {
            Name = reqName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the index on which the financial instrument is based.
        /// </summary>
        [IsoId("_GHFukZ3EEeuwmdq0KtnICg")]
        [DisplayName("ISIN")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ISIN")]
        #endif
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISIN2021Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISIN2021Identifier? ISIN { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ISIN { get; init; } 
        #else
        public System.String? ISIN { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the index on which the financial instrument is based.
        /// </summary>
        [IsoId("_GHFuk53EEeuwmdq0KtnICg")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FloatingInterestRate8 Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FloatingInterestRate8 Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FloatingInterestRate8 Name { get; init; } 
        #else
        public FloatingInterestRate8 Name { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
