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
namespace BeneficialStrategies.Iso20022.Choices.Recipient3Choice
{
    /// <summary>
    /// Identification of a cryptographic symetric key, previously exchanged between the initiator and the recipient.
    /// </summary>
    [IsoId("_c8uDQFc0EeOi-M6GtW0vCQ")]
    [DisplayName("Key Identifier")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record KeyIdentifier : Recipient3Choice_
    #else
    public partial class KeyIdentifier : Recipient3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a KeyIdentifier instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public KeyIdentifier( System.String reqKeyIdentification,System.String reqKeyVersion )
        {
            KeyIdentification = reqKeyIdentification;
            KeyVersion = reqKeyVersion;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the cryptographic key.
        /// </summary>
        [IsoId("_Sw1NvAEcEeCQm6a_G2yO_w_-1402944648")]
        [DisplayName("Key Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="KeyId")]
        #endif
        [IsoXmlTag("KeyId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Text KeyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String KeyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String KeyIdentification { get; init; } 
        #else
        public System.String KeyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_Sw1NvQEcEeCQm6a_G2yO_w_-792542720")]
        [DisplayName("Key Version")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="KeyVrsn")]
        #endif
        [IsoXmlTag("KeyVrsn")]
        [IsoSimpleType(IsoSimpleType.Exact10Text)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExact10Text KeyVersion { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String KeyVersion { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String KeyVersion { get; init; } 
        #else
        public System.String KeyVersion { get; set; } 
        #endif
        
        /// <summary>
        /// Identification used for derivation of a unique key from a master key provided for the data protection.
        /// </summary>
        [IsoId("_Sw1NvgEcEeCQm6a_G2yO_w_-1001700130")]
        [DisplayName("Derivation Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DerivtnId")]
        #endif
        [IsoXmlTag("DerivtnId")]
        [IsoSimpleType(IsoSimpleType.Min5Max16Binary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMin5Max16Binary? DerivationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[]? DerivationIdentification { get; init; } 
        #else
        public System.Byte[]? DerivationIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
