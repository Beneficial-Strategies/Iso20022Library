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
namespace BeneficialStrategies.Iso20022.Choices.InterestRate1Choice
{
    /// <summary>
    /// Provides details about the variable rate.
    /// </summary>
    [IsoId("_Qk1wdNp-Ed-ak6NoX_4Aeg_1389639465")]
    [DisplayName("Variable Interest Rate")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record VariableInterestRate : InterestRate1Choice_
    #else
    public partial class VariableInterestRate : InterestRate1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a VariableInterestRate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public VariableInterestRate( System.String reqIndex )
        {
            Index = reqIndex;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the index taken into account to calculate the variable interest rate.
        /// </summary>
        [IsoId("_Qk1wcNp-Ed-ak6NoX_4Aeg_-276733537")]
        [DisplayName("Index")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Indx")]
        #endif
        [IsoXmlTag("Indx")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Index { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Index { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Index { get; init; } 
        #else
        public System.String Index { get; set; } 
        #endif
        
        /// <summary>
        /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
        /// </summary>
        [IsoId("_Qk1wcdp-Ed-ak6NoX_4Aeg_-1323070567")]
        [DisplayName("Basis Point Spread")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BsisPtSprd")]
        #endif
        [IsoXmlTag("BsisPtSprd")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? BasisPointSpread { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? BasisPointSpread { get; init; } 
        #else
        public System.UInt64? BasisPointSpread { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
