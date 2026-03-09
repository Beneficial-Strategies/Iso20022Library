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
namespace BeneficialStrategies.Iso20022.Choices.PartyAdditionalIdentification2Choice
{
    /// <summary>
    /// Official identification of an organisation in a specific register.
    /// </summary>
    [IsoId("_Qo3U09p-Ed-ak6NoX_4Aeg_136820808")]
    [DisplayName("Registration Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RegistrationIdentification : PartyAdditionalIdentification2Choice_
    #else
    public partial class RegistrationIdentification : PartyAdditionalIdentification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RegistrationIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RegistrationIdentification( System.String reqRegistrationNumber )
        {
            RegistrationNumber = reqRegistrationNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name of the register of legal entities.
        /// </summary>
        [IsoId("_QP1Jwdp-Ed-ak6NoX_4Aeg_-1308997280")]
        [DisplayName("Registration Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RegnNb")]
        #endif
        [IsoXmlTag("RegnNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text RegistrationNumber { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String RegistrationNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String RegistrationNumber { get; init; } 
        #else
        public System.String RegistrationNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the register managed by a registration authority.
        /// </summary>
        [IsoId("_QP1Jwtp-Ed-ak6NoX_4Aeg_-1209035067")]
        [DisplayName("Register Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RegrNm")]
        #endif
        [IsoXmlTag("RegrNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? RegisterName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? RegisterName { get; init; } 
        #else
        public System.String? RegisterName { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
