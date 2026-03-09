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
/// Conditions to be met by the holder.
/// </summary>
[IsoId("_Y41SoA7zEeuZI5Sr_GAcuA")]
[DisplayName("Option Conditions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionConditions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OptionConditions1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OptionConditions1( System.UInt64 reqConditionNumber,System.String reqConditionText,System.String reqConditionRequiredFlag )
    {
        ConditionNumber = reqConditionNumber;
        ConditionText = reqConditionText;
        ConditionRequiredFlag = reqConditionRequiredFlag;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of the condition.
    /// </summary>
    [IsoId("_ogHwkA7zEeuZI5Sr_GAcuA")]
    [DisplayName("Condition Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondNb")]
    #endif
    [IsoXmlTag("CondNb")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax1Number ConditionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ConditionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ConditionNumber { get; init; } 
    #else
    public System.UInt64 ConditionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the condition.
    /// </summary>
    [IsoId("_Dj-YcA70EeuZI5Sr_GAcuA")]
    [DisplayName("Condition Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondTxt")]
    #endif
    [IsoXmlTag("CondTxt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax520Text)]
    [StringLength(maximumLength: 520 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax520Text ConditionText { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ConditionText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ConditionText { get; init; } 
    #else
    public System.String ConditionText { get; set; } 
    #endif
    
    /// <summary>
    /// States whether the condition must be acknowledged. Conditions with a No (&quot;false&quot; or &quot;0&quot;) do not need acknowledgement.
    /// </summary>
    [IsoId("_NpNjEA70EeuZI5Sr_GAcuA")]
    [DisplayName("Condition Required Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondReqrdFlg")]
    #endif
    [IsoXmlTag("CondReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ConditionRequiredFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ConditionRequiredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ConditionRequiredFlag { get; init; } 
    #else
    public System.String ConditionRequiredFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
