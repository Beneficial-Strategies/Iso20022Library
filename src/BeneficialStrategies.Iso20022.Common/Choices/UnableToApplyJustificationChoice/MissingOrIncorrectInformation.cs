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
namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustificationChoice
{
    /// <summary>
    /// Missing or incorrect information.
    /// </summary>
    [IsoId("_VFn0ENp-Ed-ak6NoX_4Aeg_478745608")]
    [DisplayName("Missing Or Incorrect Information")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MissingOrIncorrectInformation : UnableToApplyJustificationChoice_
    #else
    public partial class MissingOrIncorrectInformation : UnableToApplyJustificationChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates the missing information.
        /// </summary>
        [IsoId("_VFn0DNp-Ed-ak6NoX_4Aeg_-2094358719")]
        [DisplayName("Missing Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MssngInf")]
        #endif
        [IsoXmlTag("MssngInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyMissingInfo1Code> MissingInformation { get; init; } = new SimpleValueList<UnableToApplyMissingInfo1Code>(){};
        
        /// <summary>
        /// Indicates the incorrect information.
        /// </summary>
        [IsoId("_VFn0Ddp-Ed-ak6NoX_4Aeg_1320808370")]
        [DisplayName("Incorrect Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IncrrctInf")]
        #endif
        [IsoXmlTag("IncrrctInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyIncorrectInfo1Code> IncorrectInformation { get; init; } = new SimpleValueList<UnableToApplyIncorrectInfo1Code>(){};
        
        
        #nullable disable
        
    }
}
