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
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio9Choice
{
    /// <summary>
    /// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt &apos;wrappers&apos; in which equities, bonds and funds can be held to shelter them from various types of tax.
    /// In the UK, a typical tax wrapper product is known as an &apos;ISA&apos; (Individual Savings Account).
    /// </summary>
    [IsoId("_ZYn_welqEeuvhrZwLF0fDg")]
    [DisplayName("Tax Efficient Product")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TaxEfficientProduct : FundPortfolio9Choice_
    #else
    public partial class TaxEfficientProduct : FundPortfolio9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TaxEfficientProduct instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TaxEfficientProduct( TaxEfficientProductType2Choice_ reqTaxEfficientProductType )
        {
            TaxEfficientProductType = reqTaxEfficientProductType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
        /// </summary>
        [IsoId("_PogP4ZNNEemQB_8XA98K0Q")]
        [DisplayName("Tax Efficient Product Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxEffcntPdctTp")]
        #endif
        [IsoXmlTag("TaxEffcntPdctTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
        #else
        public TaxEfficientProductType2Choice_ TaxEfficientProductType { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates that all the current fiscal year’s products are to be included.
        /// </summary>
        [IsoId("_PogP5ZNNEemQB_8XA98K0Q")]
        [DisplayName("Current Year")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurYr")]
        #endif
        [IsoXmlTag("CurYr")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? CurrentYear { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CurrentYear { get; init; } 
        #else
        public System.String? CurrentYear { get; set; } 
        #endif
        
        /// <summary>
        /// Investment plans issued during previous years.
        /// </summary>
        [IsoId("_PogP45NNEemQB_8XA98K0Q")]
        [DisplayName("Previous Years")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrvsYrs")]
        #endif
        [IsoXmlTag("PrvsYrs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PreviousYear2Choice_? PreviousYears { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PreviousYear2Choice_? PreviousYears { get; init; } 
        #else
        public PreviousYear2Choice_? PreviousYears { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the tax efficient product.
        /// </summary>
        [IsoId("_PogP55NNEemQB_8XA98K0Q")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #else
        public AdditionalInformation15? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
