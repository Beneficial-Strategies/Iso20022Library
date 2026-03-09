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
/// Charge or commission of the original individual order details that have been repaired so that the order can be accepted.
/// </summary>
[IsoId("_U3USS9p-Ed-ak6NoX_4Aeg_-1187208577")]
[DisplayName("Repaired Conditions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RepairedConditions2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Charge from the original individual order details that has been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_U3USTNp-Ed-ak6NoX_4Aeg_-1187208550")]
    [DisplayName("Repaired Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdChrg")]
    #endif
    [IsoXmlTag("RprdChrg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Charge11> RepairedCharge { get; init; } = new ValueList<Charge11>(){};
    
    /// <summary>
    /// Commission from the original individual order details that has been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_U3eDQNp-Ed-ak6NoX_4Aeg_-1187208516")]
    [DisplayName("Repaired Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdComssn")]
    #endif
    [IsoXmlTag("RprdComssn")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Commission7> RepairedCommission { get; init; } = new ValueList<Commission7>(){};
    
    
    #nullable disable
    
}
