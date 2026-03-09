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
namespace BeneficialStrategies.Iso20022.Choices.Recipient13Choice
{
    /// <summary>
    /// Specifies the recipient&apos;s certificate by a key identifier.
    /// </summary>
    [IsoId("_d9kLgHDDEe2MCaKO5AtGsA")]
    [DisplayName("Subject Key Identifier")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SubjectKeyIdentifier : Recipient13Choice_
    #else
    public partial class SubjectKeyIdentifier : Recipient13Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SubjectKeyIdentifier instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SubjectKeyIdentifier( System.Byte[] reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a binary string with a maximum length of 140 binary bytes.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SbjtKeyIdr")]
        #endif
        [IsoXmlTag("SbjtKeyIdr")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Binary Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Byte[] Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[] Value { get; init; } 
        #else
        public System.Byte[] Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
