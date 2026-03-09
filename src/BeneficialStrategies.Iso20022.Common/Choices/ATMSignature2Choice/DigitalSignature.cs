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
namespace BeneficialStrategies.Iso20022.Choices.ATMSignature2Choice
{
    /// <summary>
    /// Digital signature of implicit data depending on the security scheme download procedure.
    /// </summary>
    [IsoId("_iFHDYbTwEeeQy4o2AayYHg")]
    [DisplayName("Digital Signature")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DigitalSignature : ATMSignature2Choice_
    #else
    public partial class DigitalSignature : ATMSignature2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DigitalSignature instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DigitalSignature( ContentType2Code reqContentType,SignedData4 reqSignedData )
        {
            ContentType = reqContentType;
            SignedData = reqSignedData;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of data protection.
        /// </summary>
        [IsoId("_NjOT0YtNEeSxlKlAGYErFg")]
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
        /// Data protected by a digital signatures.
        /// </summary>
        [IsoId("_NjOT14tNEeSxlKlAGYErFg")]
        [DisplayName("Signed Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SgndData")]
        #endif
        [IsoXmlTag("SgndData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SignedData4 SignedData { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SignedData4 SignedData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SignedData4 SignedData { get; init; } 
        #else
        public SignedData4 SignedData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
