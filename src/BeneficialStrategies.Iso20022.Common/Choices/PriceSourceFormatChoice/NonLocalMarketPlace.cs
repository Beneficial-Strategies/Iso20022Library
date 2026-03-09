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
namespace BeneficialStrategies.Iso20022.Choices.PriceSourceFormatChoice
{
    /// <summary>
    /// Source of a price quotation when it is not the local market.
    /// </summary>
    [IsoId("_RCDQ5dp-Ed-ak6NoX_4Aeg_1149070716")]
    [DisplayName("Non Local Market Place")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NonLocalMarketPlace : PriceSourceFormatChoice_
    #else
    public partial class NonLocalMarketPlace : PriceSourceFormatChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NonLocalMarketPlace instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NonLocalMarketPlace( PriceSource1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Source of the price.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PricSrc")]
        #endif
        [IsoXmlTag("PricSrc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PriceSource1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PriceSource1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PriceSource1Code Value { get; init; } 
        #else
        public PriceSource1Code Value { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the source of a price.
        /// </summary>
        [IsoId("_QelXcdp-Ed-ak6NoX_4Aeg_404714109")]
        [DisplayName("Narrative")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nrrtv")]
        #endif
        [IsoXmlTag("Nrrtv")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Narrative { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Narrative { get; init; } 
        #else
        public System.String? Narrative { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
