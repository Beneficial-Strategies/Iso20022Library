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
    /// Underlying interest rate type is a swap, swaption, a future on a swap or a forward on a swap with regard to the underlying swap.
    /// </summary>
    [IsoId("_xbbEcWlIEeaLAKoEUNsD9g")]
    [DisplayName("Swap Related")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SwapRelated : InterestRateDerivative2Choice_
    #else
    public partial class SwapRelated : InterestRateDerivative2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SwapRelated instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SwapRelated( SwapType1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SwpRltd")]
        #endif
        [IsoXmlTag("SwpRltd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SwapType1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SwapType1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SwapType1Code Value { get; init; } 
        #else
        public SwapType1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
