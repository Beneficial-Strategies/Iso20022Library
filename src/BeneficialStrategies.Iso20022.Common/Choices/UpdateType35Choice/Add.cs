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
namespace BeneficialStrategies.Iso20022.Choices.UpdateType35Choice
{
    /// <summary>
    /// Set of data requested to enrich a security.
    /// </summary>
    [IsoId("_QOJ0MZJKEeuAlLVx8pyt3w")]
    [DisplayName("Add")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Add : UpdateType35Choice_
    #else
    public partial class Add : UpdateType35Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides additional details about the financial instrument.
        /// </summary>
        [IsoId("_QKNvYZJKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmTp")]
        #endif
        [IsoXmlTag("FinInstrmTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrument97? FinancialInstrumentType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrument97? FinancialInstrumentType { get; init; } 
        #else
        public FinancialInstrument97? FinancialInstrumentType { get; set; } 
        #endif
        
        /// <summary>
        /// Provides details about the financial instrument attributes of a particular leg.
        /// </summary>
        [IsoId("_QKNvY5JKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmAttrbts")]
        #endif
        [IsoXmlTag("FinInstrmAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CommonFinancialInstrumentAttributes12? FinancialInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommonFinancialInstrumentAttributes12? FinancialInstrumentAttributes { get; init; } 
        #else
        public CommonFinancialInstrumentAttributes12? FinancialInstrumentAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_QKNvZZJKEeuAlLVx8pyt3w")]
        [DisplayName("Supplementary Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SplmtryData")]
        #endif
        [IsoXmlTag("SplmtryData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SupplementaryData1? SupplementaryData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SupplementaryData1? SupplementaryData { get; init; } 
        #else
        public SupplementaryData1? SupplementaryData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
