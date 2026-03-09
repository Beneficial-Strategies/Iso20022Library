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
namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification2Choice
{
    /// <summary>
    /// Set of elements used to indicate which information is missing or incorrect.
    /// </summary>
    [IsoId("_T-i3Ndp-Ed-ak6NoX_4Aeg_-1089125167")]
    [DisplayName("Missing Or Incorrect Information")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MissingOrIncorrectInformation : UnableToApplyJustification2Choice_
    #else
    public partial class MissingOrIncorrectInformation : UnableToApplyJustification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
        /// </summary>
        [IsoId("_T-soMNp-Ed-ak6NoX_4Aeg_257368960")]
        [DisplayName("Anti Money Laundering Request")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AMLReq")]
        #endif
        [IsoXmlTag("AMLReq")]
        [IsoSimpleType(IsoSimpleType.AMLIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AntiMoneyLaunderingRequest { get; init; } 
        #else
        public System.String? AntiMoneyLaunderingRequest { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the missing information.
        /// </summary>
        [IsoId("_T-soMdp-Ed-ak6NoX_4Aeg_-689240580")]
        [DisplayName("Missing Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MssngInf")]
        #endif
        [IsoXmlTag("MssngInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyMissingInformation2Code> MissingInformation { get; init; } = new SimpleValueList<UnableToApplyMissingInformation2Code>(){};
        
        /// <summary>
        /// Indicates, in a coded form, the incorrect information.
        /// </summary>
        [IsoId("_T-soMtp-Ed-ak6NoX_4Aeg_-689240558")]
        [DisplayName("Incorrect Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IncrrctInf")]
        #endif
        [IsoXmlTag("IncrrctInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyIncorrectInformation3Code> IncorrectInformation { get; init; } = new SimpleValueList<UnableToApplyIncorrectInformation3Code>(){};
        
        
        #nullable disable
        
    }
}
