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
namespace BeneficialStrategies.Iso20022.Choices.SecurityOrBusinessError4Choice
{
    /// <summary>
    /// Provides the business error details.
    /// </summary>
    [IsoId("_P7y445JKEeuAlLVx8pyt3w")]
    [DisplayName("Business Error")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BusinessError : SecurityOrBusinessError4Choice_
    #else
    public partial class BusinessError : SecurityOrBusinessError4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a BusinessError instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public BusinessError( SecurityIdentification39 reqFinancialInstrumentIdentification )
        {
            FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Way(s) of identifying the security.
        /// </summary>
        [IsoId("_P-BGcZJKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmId")]
        #endif
        [IsoXmlTag("FinInstrmId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
        #else
        public SecurityIdentification39 FinancialInstrumentIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the business error.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BizErr")]
        #endif
        [IsoXmlTag("BizErr")]
        public ValueList<ErrorHandling5> Value { get; init; } = new ValueList<ErrorHandling5>(){}; // Warning: Don't know multiplicity.
        
        
        #nullable disable
        
    }
}
