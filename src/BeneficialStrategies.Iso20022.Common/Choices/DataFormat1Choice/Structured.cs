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
namespace BeneficialStrategies.Iso20022.Choices.DataFormat1Choice
{
    /// <summary>
    /// Specification of data in structured form.
    /// </summary>
    [IsoId("_Uys4Btp-Ed-ak6NoX_4Aeg_1723007680")]
    [DisplayName("Structured")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Structured : DataFormat1Choice_
    #else
    public partial class Structured : DataFormat1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Structured instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Structured( System.String reqSchemeName )
        {
            SchemeName = reqSchemeName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_VC8TdNp-Ed-ak6NoX_4Aeg_704057909")]
        [DisplayName("Scheme Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SchmeNm")]
        #endif
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text SchemeName { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String SchemeName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SchemeName { get; init; } 
        #else
        public System.String SchemeName { get; set; } 
        #endif
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_VC8Tddp-Ed-ak6NoX_4Aeg_704057910")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Issuer { get; init; } 
        #else
        public System.String? Issuer { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
