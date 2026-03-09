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
namespace BeneficialStrategies.Iso20022.Choices.InterestRate8Choice
{
    /// <summary>
    /// Interest rate is a variable / floating rate, based on an index.
    /// </summary>
    [IsoId("_IEREA35aEea2k7EBUopqxw")]
    [DisplayName("Floating")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Floating : InterestRate8Choice_
    #else
    public partial class Floating : InterestRate8Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Floating instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Floating( BenchmarkCurveName5Choice_ reqReferenceRate )
        {
            ReferenceRate = reqReferenceRate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the reference index for the instrument. 
        /// Usage:
        /// Index or name if the reference rate is not included in the index list.
        /// </summary>
        [IsoId("_Hq0pQX5aEea2k7EBUopqxw")]
        [DisplayName("Reference Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RefRate")]
        #endif
        [IsoXmlTag("RefRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BenchmarkCurveName5Choice_ ReferenceRate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BenchmarkCurveName5Choice_ ReferenceRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BenchmarkCurveName5Choice_ ReferenceRate { get; init; } 
        #else
        public BenchmarkCurveName5Choice_ ReferenceRate { get; set; } 
        #endif
        
        /// <summary>
        /// Term of the reference rate.
        /// </summary>
        [IsoId("_Hq0pQ35aEea2k7EBUopqxw")]
        [DisplayName("Term")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Term")]
        #endif
        [IsoXmlTag("Term")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRateContractTerm2? Term { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateContractTerm2? Term { get; init; } 
        #else
        public InterestRateContractTerm2? Term { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
