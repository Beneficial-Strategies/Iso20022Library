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
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_RBvu5tp-Ed-ak6NoX_4Aeg_1757395821")]
    [DisplayName("Simple Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SimpleIdentification : AccountIdentificationFormatChoice_
    #else
    public partial class SimpleIdentification : AccountIdentificationFormatChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SimpleIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SimpleIdentification( SimpleIdentificationInformation reqProprietary )
        {
            Proprietary = reqProprietary;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier for an account. It is assigned by the account servicer using a proprietary identification scheme.
        /// </summary>
        [IsoId("_PdnCpNp-Ed-ak6NoX_4Aeg_-1749118142")]
        [DisplayName("Proprietary")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Prtry")]
        #endif
        [IsoXmlTag("Prtry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SimpleIdentificationInformation Proprietary { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SimpleIdentificationInformation Proprietary { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SimpleIdentificationInformation Proprietary { get; init; } 
        #else
        public SimpleIdentificationInformation Proprietary { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
