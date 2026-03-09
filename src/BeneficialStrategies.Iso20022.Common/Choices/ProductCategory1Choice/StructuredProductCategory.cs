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
namespace BeneficialStrategies.Iso20022.Choices.ProductCategory1Choice
{
    /// <summary>
    /// Specifies the type of product category.
    /// </summary>
    [IsoId("_RbrR19p-Ed-ak6NoX_4Aeg_1854520026")]
    [DisplayName("Structured Product Category")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StructuredProductCategory : ProductCategory1Choice_
    #else
    public partial class StructuredProductCategory : ProductCategory1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a StructuredProductCategory instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public StructuredProductCategory( ProductCategory1Code reqType,System.String reqCategory )
        {
            Type = reqType;
            Category = reqCategory;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the type of product category by means of a code.
        /// </summary>
        [IsoId("_T5CFHNp-Ed-ak6NoX_4Aeg_-1686636659")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ProductCategory1Code Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ProductCategory1Code Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProductCategory1Code Type { get; init; } 
        #else
        public ProductCategory1Code Type { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the category of a product.
        /// </summary>
        [IsoId("_T5L2ENp-Ed-ak6NoX_4Aeg_-1658931027")]
        [DisplayName("Category")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ctgy")]
        #endif
        [IsoXmlTag("Ctgy")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Category { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Category { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Category { get; init; } 
        #else
        public System.String Category { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
