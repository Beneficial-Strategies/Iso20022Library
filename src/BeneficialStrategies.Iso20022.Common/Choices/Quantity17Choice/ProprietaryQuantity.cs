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
namespace BeneficialStrategies.Iso20022.Choices.Quantity17Choice
{
    /// <summary>
    /// Proprietary quantity of security format.
    /// </summary>
    [IsoId("_LyFLJTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Proprietary Quantity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProprietaryQuantity : Quantity17Choice_
    #else
    public partial class ProprietaryQuantity : Quantity17Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProprietaryQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProprietaryQuantity( System.UInt64 reqQuantity,System.String reqQuantityType,System.String reqIssuer )
        {
            Quantity = reqQuantity;
            QuantityType = reqQuantityType;
            Issuer = reqIssuer;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_3jqUlTq5EeWQ1Y7f8kds2A")]
        [DisplayName("Short Long Position")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrtLngPos")]
        #endif
        [IsoXmlTag("ShrtLngPos")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ShortLong1Code? ShortLongPosition { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ShortLong1Code? ShortLongPosition { get; init; } 
        #else
        public ShortLong1Code? ShortLongPosition { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the proprietary quantity with a decimal number.
        /// </summary>
        [IsoId("_3jqUlzq5EeWQ1Y7f8kds2A")]
        [DisplayName("Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qty")]
        #endif
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoDecimalNumber Quantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Quantity { get; init; } 
        #else
        public System.UInt64 Quantity { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the type of proprietary quantity reported.
        /// </summary>
        [IsoId("_3jqUmTq5EeWQ1Y7f8kds2A")]
        [DisplayName("Quantity Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtyTp")]
        #endif
        [IsoXmlTag("QtyTp")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExact4AlphaNumericText QuantityType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String QuantityType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String QuantityType { get; init; } 
        #else
        public System.String QuantityType { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information related to issuer in free format.
        /// </summary>
        [IsoId("_3jqUmzq5EeWQ1Y7f8kds2A")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Issuer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Issuer { get; init; } 
        #else
        public System.String Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_3jqUozq5EeWQ1Y7f8kds2A")]
        [DisplayName("Scheme Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SchmeNm")]
        #endif
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SchemeName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SchemeName { get; init; } 
        #else
        public System.String? SchemeName { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
