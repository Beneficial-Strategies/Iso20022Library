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
namespace BeneficialStrategies.Iso20022.Choices.InterestRateDerivative2Choice
{
    /// <summary>
    /// Where contract type is different from swaps, swaptions, futures on swaps and forwards on a swap, this field is used.
    /// </summary>
    [IsoId("_xbbEc2lIEeaLAKoEUNsD9g")]
    [DisplayName("Other")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Other : InterestRateDerivative2Choice_
    #else
    public partial class Other : InterestRateDerivative2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Other instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Other( UnderlyingInterestRateType3Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of an underlying contract for interest rate derivatives.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Othr")]
        #endif
        [IsoXmlTag("Othr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required UnderlyingInterestRateType3Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required UnderlyingInterestRateType3Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnderlyingInterestRateType3Code Value { get; init; } 
        #else
        public UnderlyingInterestRateType3Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
