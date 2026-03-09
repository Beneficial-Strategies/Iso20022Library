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
/// Indicates the reason for the UnableToApply. It can be missing and/or incorrect information.
/// </summary>
[IsoId("_T-ZtStp-Ed-ak6NoX_4Aeg_-1840697394")]
[DisplayName("Missing Or Incorrect Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MissingOrIncorrectInformation1
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
    [IsoId("_T-ZtS9p-Ed-ak6NoX_4Aeg_-1840697101")]
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
    [IsoId("_T-ZtTNp-Ed-ak6NoX_4Aeg_-1839776740")]
    [DisplayName("Incorrect Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncrrctInf")]
    #endif
    [IsoXmlTag("IncrrctInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<UnableToApplyIncorrectInfo2Code> IncorrectInformation { get; init; } = new SimpleValueList<UnableToApplyIncorrectInfo2Code>(){};
    
    
    #nullable disable
    
}
