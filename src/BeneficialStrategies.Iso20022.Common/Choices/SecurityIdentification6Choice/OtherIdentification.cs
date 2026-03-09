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
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification6Choice
{
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_TBKB8dp-Ed-ak6NoX_4Aeg_-1421894967")]
    [DisplayName("Other Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherIdentification : SecurityIdentification6Choice_
    #else
    public partial class OtherIdentification : SecurityIdentification6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OtherIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OtherIdentification( System.String reqIdentification,string reqDomesticIdentificationSource,System.String reqProprietaryIdentificationSource )
        {
            Identification = reqIdentification;
            DomesticIdentificationSource = reqDomesticIdentificationSource;
            ProprietaryIdentificationSource = reqProprietaryIdentificationSource;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier of a security.
        /// </summary>
        [IsoId("_Sk_qYNp-Ed-ak6NoX_4Aeg_-815168262")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Country of the proprietary identification scheme.
        /// </summary>
        [IsoId("_Sk_qYdp-Ed-ak6NoX_4Aeg_-815168264")]
        [DisplayName("Domestic Identification Source")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DmstIdSrc")]
        #endif
        [IsoXmlTag("DmstIdSrc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CountryCode DomesticIdentificationSource { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string DomesticIdentificationSource { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string DomesticIdentificationSource { get; init; } 
        #else
        public string DomesticIdentificationSource { get; set; } 
        #endif
        
        /// <summary>
        /// Entity that issues the proprietary identification.
        /// </summary>
        [IsoId("_Sk_qYtp-Ed-ak6NoX_4Aeg_-815168263")]
        [DisplayName("Proprietary Identification Source")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryIdSrc")]
        #endif
        [IsoXmlTag("PrtryIdSrc")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text ProprietaryIdentificationSource { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ProprietaryIdentificationSource { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ProprietaryIdentificationSource { get; init; } 
        #else
        public System.String ProprietaryIdentificationSource { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
