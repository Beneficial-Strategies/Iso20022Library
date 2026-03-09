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
namespace BeneficialStrategies.Iso20022.Choices.InterestRate6Choice
{
    /// <summary>
    /// Provides details about the variable rate.
    /// </summary>
    [IsoId("_nf6kwyc1EeaCIe3n1Gx9ug")]
    [DisplayName("Floating")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Floating : InterestRate6Choice_
    #else
    public partial class Floating : InterestRate6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Floating instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Floating( BenchmarkCurveName6Choice_ reqReferenceRate,InterestRateContractTerm2 reqTerm,System.UInt64 reqBasisPointSpread )
        {
            ReferenceRate = reqReferenceRate;
            Term = reqTerm;
            BasisPointSpread = reqBasisPointSpread;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the reference index for the debt instrument.
        /// </summary>
        [IsoId("_XhGXoSc1EeaCIe3n1Gx9ug")]
        [DisplayName("Reference Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RefRate")]
        #endif
        [IsoXmlTag("RefRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BenchmarkCurveName6Choice_ ReferenceRate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BenchmarkCurveName6Choice_ ReferenceRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BenchmarkCurveName6Choice_ ReferenceRate { get; init; } 
        #else
        public BenchmarkCurveName6Choice_ ReferenceRate { get; set; } 
        #endif
        
        /// <summary>
        /// Term of the index/benchmark of a floating rate bond. The term shall be expressed in days, weeks, months or years.
        /// </summary>
        [IsoId("_XhGXoyc1EeaCIe3n1Gx9ug")]
        [DisplayName("Term")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Term")]
        #endif
        [IsoXmlTag("Term")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InterestRateContractTerm2 Term { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InterestRateContractTerm2 Term { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateContractTerm2 Term { get; init; } 
        #else
        public InterestRateContractTerm2 Term { get; set; } 
        #endif
        
        /// <summary>
        /// Number of basis points above (if positive) or below (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
        /// Usage:
        /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
        /// </summary>
        [IsoId("_XhGXpSc1EeaCIe3n1Gx9ug")]
        [DisplayName("Basis Point Spread")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BsisPtSprd")]
        #endif
        [IsoXmlTag("BsisPtSprd")]
        [IsoSimpleType(IsoSimpleType.Max5Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax5Number BasisPointSpread { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 BasisPointSpread { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 BasisPointSpread { get; init; } 
        #else
        public System.UInt64 BasisPointSpread { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
