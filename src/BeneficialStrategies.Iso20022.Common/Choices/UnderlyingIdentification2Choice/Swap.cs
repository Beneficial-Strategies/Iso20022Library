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
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingIdentification2Choice
{
    /// <summary>
    /// Underlying of a swap transaction.
    /// </summary>
    [IsoId("_Ky7eQYG-EeaalK9UbuVGFw")]
    [DisplayName("Swap")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Swap : UnderlyingIdentification2Choice_
    #else
    public partial class Swap : UnderlyingIdentification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Instrument received by the buyer.
        /// </summary>
        [IsoId("_K9fvgYG-EeaalK9UbuVGFw")]
        [DisplayName("Swap In")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SwpIn")]
        #endif
        [IsoXmlTag("SwpIn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrumentIdentification7Choice_? SwapIn { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentIdentification7Choice_? SwapIn { get; init; } 
        #else
        public FinancialInstrumentIdentification7Choice_? SwapIn { get; set; } 
        #endif
        
        /// <summary>
        /// Instrument paid by the buyer.
        /// </summary>
        [IsoId("_K9fvg4G-EeaalK9UbuVGFw")]
        [DisplayName("Swap Out")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SwpOut")]
        #endif
        [IsoXmlTag("SwpOut")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrumentIdentification7Choice_? SwapOut { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentIdentification7Choice_? SwapOut { get; init; } 
        #else
        public FinancialInstrumentIdentification7Choice_? SwapOut { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
