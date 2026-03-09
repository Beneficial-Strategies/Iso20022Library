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
/// Indicates the reason for which the contract has not been cleared.
/// </summary>
[IsoId("_Ak0bdZPuEey0rJ3Gl6WZVA")]
[DisplayName("Non Clearing Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonClearingReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for a clearing exemption or exception.
    /// </summary>
    [IsoId("_AmE_sZPuEey0rJ3Gl6WZVA")]
    [DisplayName("Clearing Exemption Exception")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrXmptnXcptn")]
    #endif
    [IsoXmlTag("ClrXmptnXcptn")]
    public SimpleValueList<ClearingExemptionException1Code> ClearingExemptionException { get; init; } = new SimpleValueList<ClearingExemptionException1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _AmE_sZPuEey0rJ3Gl6WZVA
    
    /// <summary>
    /// Indicates the reason for which the contract has not been cleared.
    /// </summary>
    [IsoId("_AmE_s5PuEey0rJ3Gl6WZVA")]
    [DisplayName("Non Clearing Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonClrRsnInf")]
    #endif
    [IsoXmlTag("NonClrRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? NonClearingReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonClearingReasonInformation { get; init; } 
    #else
    public System.String? NonClearingReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
