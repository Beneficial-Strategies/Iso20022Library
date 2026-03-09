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
namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice
{
    /// <summary>
    /// Details specific for Contract for difference (CFDs).
    /// </summary>
    [IsoId("_JXb7AWkwEeaLAKoEUNsD9g")]
    [DisplayName("Contract For Difference")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ContractForDifference : Derivative2Choice_
    #else
    public partial class ContractForDifference : Derivative2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ContractForDifference instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ContractForDifference( UnderlyingContractForDifferenceType3Code reqUnderlyingType )
        {
            UnderlyingType = reqUnderlyingType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Underlying type of the contract for difference.
        /// </summary>
        [IsoId("_Mb3u0WlQEeaLAKoEUNsD9g")]
        [DisplayName("Underlying Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygTp")]
        #endif
        [IsoXmlTag("UndrlygTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required UnderlyingContractForDifferenceType3Code UnderlyingType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required UnderlyingContractForDifferenceType3Code UnderlyingType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnderlyingContractForDifferenceType3Code UnderlyingType { get; init; } 
        #else
        public UnderlyingContractForDifferenceType3Code UnderlyingType { get; set; } 
        #endif
        
        /// <summary>
        /// Currency 1 of the underlying currency pair.
        /// </summary>
        [IsoId("_Mb3u02lQEeaLAKoEUNsD9g")]
        [DisplayName("Notional Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NtnlCcy1")]
        #endif
        [IsoXmlTag("NtnlCcy1")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyCode? NotionalCurrency1 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? NotionalCurrency1 { get; init; } 
        #else
        public string? NotionalCurrency1 { get; set; } 
        #endif
        
        /// <summary>
        /// Currency 2 of the underlying currency pair.
        /// </summary>
        [IsoId("_Mb3u1WlQEeaLAKoEUNsD9g")]
        [DisplayName("Notional Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NtnlCcy2")]
        #endif
        [IsoXmlTag("NtnlCcy2")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyCode? NotionalCurrency2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? NotionalCurrency2 { get; init; } 
        #else
        public string? NotionalCurrency2 { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
