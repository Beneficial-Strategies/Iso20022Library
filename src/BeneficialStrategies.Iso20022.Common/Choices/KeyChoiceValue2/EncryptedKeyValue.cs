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
namespace BeneficialStrategies.Iso20022.Choices.KeyChoiceValue2
{
    /// <summary>
    /// Encrypted value of the cryptographic key.
    /// </summary>
    [IsoId("_FjgS0bTqEeeQy4o2AayYHg")]
    [DisplayName("Encrypted Key Value")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record EncryptedKeyValue : KeyChoiceValue2_
    #else
    public partial class EncryptedKeyValue : KeyChoiceValue2_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a EncryptedKeyValue instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public EncryptedKeyValue( ContentType2Code reqContentType,EnvelopedData4 reqEnvelopedData )
        {
            ContentType = reqContentType;
            EnvelopedData = reqEnvelopedData;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of data protection.
        /// </summary>
        [IsoId("_Us-c0WizEeS87LmvcA55sg")]
        [DisplayName("Content Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CnttTp")]
        #endif
        [IsoXmlTag("CnttTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ContentType2Code ContentType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ContentType2Code ContentType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContentType2Code ContentType { get; init; } 
        #else
        public ContentType2Code ContentType { get; set; } 
        #endif
        
        /// <summary>
        /// Data protection by encryption or by a digital envelope, with an encryption key.
        /// </summary>
        [IsoId("_Us-c02izEeS87LmvcA55sg")]
        [DisplayName("Enveloped Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EnvlpdData")]
        #endif
        [IsoXmlTag("EnvlpdData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required EnvelopedData4 EnvelopedData { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required EnvelopedData4 EnvelopedData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public EnvelopedData4 EnvelopedData { get; init; } 
        #else
        public EnvelopedData4 EnvelopedData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
