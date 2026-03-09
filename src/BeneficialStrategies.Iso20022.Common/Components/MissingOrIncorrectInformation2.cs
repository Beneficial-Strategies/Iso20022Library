// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further information on the reason for the unable to apply investigation.
/// </summary>
[IsoId("_T-i3N9p-Ed-ak6NoX_4Aeg_-689240837")]
[DisplayName("Missing Or Incorrect Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MissingOrIncorrectInformation2
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
