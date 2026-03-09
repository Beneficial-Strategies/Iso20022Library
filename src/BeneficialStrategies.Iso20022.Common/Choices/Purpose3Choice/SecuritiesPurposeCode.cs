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
namespace BeneficialStrategies.Iso20022.Choices.Purpose3Choice
{
    /// <summary>
    /// Underlying reason for the SSI instruction, expressed as a code.
    /// </summary>
    [IsoId("_KU6yQyUOEeOgKIHGINc2Uw")]
    [DisplayName("Securities Purpose Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesPurposeCode : Purpose3Choice_
    #else
    public partial class SecuritiesPurposeCode : Purpose3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesPurposeCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesPurposeCode( ExternalSecuritiesPurpose1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason code for an SSI instruction, in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SctiesPurpCd")]
        #endif
        [IsoXmlTag("SctiesPurpCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExternalSecuritiesPurpose1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExternalSecuritiesPurpose1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalSecuritiesPurpose1Code Value { get; init; } 
        #else
        public ExternalSecuritiesPurpose1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
