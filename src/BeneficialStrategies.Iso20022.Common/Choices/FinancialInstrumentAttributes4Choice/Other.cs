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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAttributes4Choice
{
    /// <summary>
    /// Description of the financial instrument, such as a a derivative, when the instrument is not admitted to trading on a trading venue.
    /// </summary>
    [IsoId("_GMbzg53CEeuwmdq0KtnICg")]
    [DisplayName("Other")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Other : FinancialInstrumentAttributes4Choice_
    #else
    public partial class Other : FinancialInstrumentAttributes4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Other instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Other( SecurityInstrumentDescription20 reqFinancialInstrumentGeneralAttributes,DerivativeInstrument9 reqDerivativeInstrumentAttributes )
        {
            FinancialInstrumentGeneralAttributes = reqFinancialInstrumentGeneralAttributes;
            DerivativeInstrumentAttributes = reqDerivativeInstrumentAttributes;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_sAOv4Z3CEeuwmdq0KtnICg")]
        [DisplayName("Financial Instrument General Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmGnlAttrbts")]
        #endif
        [IsoXmlTag("FinInstrmGnlAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecurityInstrumentDescription20 FinancialInstrumentGeneralAttributes { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecurityInstrumentDescription20 FinancialInstrumentGeneralAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityInstrumentDescription20 FinancialInstrumentGeneralAttributes { get; init; } 
        #else
        public SecurityInstrumentDescription20 FinancialInstrumentGeneralAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_sAOv453CEeuwmdq0KtnICg")]
        [DisplayName("Debt Instrument Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DebtInstrmAttrbts")]
        #endif
        [IsoXmlTag("DebtInstrmAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
        #else
        public DebtInstrument4? DebtInstrumentAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_sAOv5Z3CEeuwmdq0KtnICg")]
        [DisplayName("Derivative Instrument Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DerivInstrmAttrbts")]
        #endif
        [IsoXmlTag("DerivInstrmAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DerivativeInstrument9 DerivativeInstrumentAttributes { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DerivativeInstrument9 DerivativeInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DerivativeInstrument9 DerivativeInstrumentAttributes { get; init; } 
        #else
        public DerivativeInstrument9 DerivativeInstrumentAttributes { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
