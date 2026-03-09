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
/// Content of the Display Response message.
/// </summary>
[IsoId("_qaFZAN7EEeiwsev40qZGEQ")]
[DisplayName("Device Display Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceDisplayResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Give result for display request.
    /// </summary>
    [IsoId("_2U-dsN7EEeiwsev40qZGEQ")]
    [DisplayName("Output Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutptRslt")]
    #endif
    [IsoXmlTag("OutptRslt")]
    public ValueList<OutputResult1> OutputResult { get; init; } = new ValueList<OutputResult1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _2U-dsN7EEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
