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
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice
{
    /// <summary>
    /// Indicates the index upon which the financial instrument is based.
    /// </summary>
    [IsoId("_idD06Vo2Ee23K4GXSpBSeg")]
    [DisplayName("Index")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Index : SecurityIdentification41Choice_
    #else
    public partial class Index : SecurityIdentification41Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoId("_bs8aEDN1Ee2gE4h-lpiUxQ")]
        [DisplayName("ISIN")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ISIN")]
        #endif
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISINOct2015Identifier? ISIN { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ISIN { get; init; } 
        #else
        public System.String? ISIN { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary identification of the index on which the financial instrument is based.
        /// </summary>
        [IsoId("_bs7zATN1Ee2gE4h-lpiUxQ")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Index name where the underlying is an index.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Indx")]
        #endif
        [IsoXmlTag("Indx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExternalBenchmarkCurveName1Code? Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalBenchmarkCurveName1Code? Value { get; init; } 
        #else
        public ExternalBenchmarkCurveName1Code? Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
