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
    /// Identification of the account expressed with an account number and a code.
    /// </summary>
    [IsoId("_RB5f4Np-Ed-ak6NoX_4Aeg_842152344")]
    [DisplayName("Identification And Purpose")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IdentificationAndPurpose : AccountIdentificationFormatChoice_
    #else
    public partial class IdentificationAndPurpose : AccountIdentificationFormatChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IdentificationAndPurpose instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IdentificationAndPurpose( AccountIdentification1 reqIdentification,SecuritiesAccountPurposeType1Code reqPurpose )
        {
            Identification = reqIdentification;
            Purpose = reqPurpose;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_PoVr99p-Ed-ak6NoX_4Aeg_1457217360")]
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
        /// Specifies the purpose of the account.
        /// </summary>
        [IsoId("_PoVr-Np-Ed-ak6NoX_4Aeg_1496004828")]
        [DisplayName("Purpose")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Purp")]
        #endif
        [IsoXmlTag("Purp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesAccountPurposeType1Code Purpose { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecuritiesAccountPurposeType1Code Purpose { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesAccountPurposeType1Code Purpose { get; init; } 
        #else
        public SecuritiesAccountPurposeType1Code Purpose { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
