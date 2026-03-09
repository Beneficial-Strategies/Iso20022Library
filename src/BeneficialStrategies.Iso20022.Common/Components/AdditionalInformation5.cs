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
/// Contains additional information related to the message.
/// </summary>
[IsoId("_Qoao5dp-Ed-ak6NoX_4Aeg_478592239")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains additional information related to the message.
    /// </summary>
    [IsoId("_Qoao5tp-Ed-ak6NoX_4Aeg_1159536818")]
    [DisplayName("Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Inf")]
    #endif
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    public SimpleValueList<System.String> Information { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Qoao5tp-Ed-ak6NoX_4Aeg_1159536818
    
    
    #nullable disable
    
}
