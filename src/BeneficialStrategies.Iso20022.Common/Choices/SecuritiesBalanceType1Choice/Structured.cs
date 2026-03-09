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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType1Choice
{
    /// <summary>
    /// Balance reason in structured format.
    /// </summary>
    [IsoId("_U11Ehtp-Ed-ak6NoX_4Aeg_1393739597")]
    [DisplayName("Structured")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Structured : SecuritiesBalanceType1Choice_
    #else
    public partial class Structured : SecuritiesBalanceType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Structured instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Structured( SecuritiesBalanceType1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the securities or investment fund balance.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Strd")]
        #endif
        [IsoXmlTag("Strd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesBalanceType1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecuritiesBalanceType1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesBalanceType1Code Value { get; init; } 
        #else
        public SecuritiesBalanceType1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
