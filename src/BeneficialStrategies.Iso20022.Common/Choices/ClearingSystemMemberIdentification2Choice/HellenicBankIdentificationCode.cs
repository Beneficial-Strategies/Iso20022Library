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
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Hellenic Bank Identification Code - identifies Hellenic financial institutions on the Hellenic national clearing system.
    /// </summary>
    [IsoId("_TDPFg9p-Ed-ak6NoX_4Aeg_-1906990554")]
    [DisplayName("Hellenic Bank Identification Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record HellenicBankIdentificationCode : ClearingSystemMemberIdentification2Choice_
    #else
    public partial class HellenicBankIdentificationCode : ClearingSystemMemberIdentification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a HellenicBankIdentificationCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public HellenicBankIdentificationCode( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Hellenic Bank Identification Code Identifier. Identifies Greek financial institutions on the Greek national clearing system.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="GRHEBIC")]
        #endif
        [IsoXmlTag("GRHEBIC")]
        [IsoSimpleType(IsoSimpleType.HellenicBankIdentificationCodeIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoHellenicBankIdentificationCodeIdentifier Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
