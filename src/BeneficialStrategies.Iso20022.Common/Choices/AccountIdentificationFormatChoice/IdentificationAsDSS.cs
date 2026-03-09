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
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentificationFormatChoice
{
    /// <summary>
    /// Identification of the account expressed with a data source scheme, a code used within the data source scheme and the account identification.
    /// </summary>
    [IsoId("_RB5f4dp-Ed-ak6NoX_4Aeg_1770326434")]
    [DisplayName("Identification As DSS")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IdentificationAsDSS : AccountIdentificationFormatChoice_
    #else
    public partial class IdentificationAsDSS : AccountIdentificationFormatChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IdentificationAsDSS instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IdentificationAsDSS( AccountIdentification1 reqIdentification,System.String reqIssuer,System.String reqInformation )
        {
            Identification = reqIdentification;
            Issuer = reqIssuer;
            Information = reqInformation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_PoVr89p-Ed-ak6NoX_4Aeg_1372251027")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AccountIdentification1 Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AccountIdentification1 Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentification1 Identification { get; init; } 
        #else
        public AccountIdentification1 Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Entity that assigns the information.
        /// </summary>
        [IsoId("_PoVr9Np-Ed-ak6NoX_4Aeg_2100019973")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max8Text)]
        [StringLength(maximumLength: 8 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax8Text Issuer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Issuer { get; init; } 
        #else
        public System.String Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_PoVr9dp-Ed-ak6NoX_4Aeg_2100019938")]
        [DisplayName("Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Inf")]
        #endif
        [IsoXmlTag("Inf")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExact4AlphaNumericText Information { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Information { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Information { get; init; } 
        #else
        public System.String Information { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
