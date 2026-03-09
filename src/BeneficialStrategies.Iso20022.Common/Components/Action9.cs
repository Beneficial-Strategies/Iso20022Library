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
/// Set of actions to be performed.
/// </summary>
[IsoId("_B1YNAEXVEeegp_DADCe7HQ")]
[DisplayName("Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Action9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Destination of the action.
    /// </summary>
    [IsoId("_R3PHEEXVEeegp_DADCe7HQ")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType20Code? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType20Code? Destination { get; init; } 
    #else
    public PartyType20Code? Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Action type to be performed.
    /// </summary>
    [IsoId("_WxEj0EXVEeegp_DADCe7HQ")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionType11Code? ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionType11Code? ActionType { get; init; } 
    #else
    public ActionType11Code? ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Other action type to be performed.
    /// </summary>
    [IsoId("_ccz-oEXVEeegp_DADCe7HQ")]
    [DisplayName("Other Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrActnTp")]
    #endif
    [IsoXmlTag("OthrActnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherActionType { get; init; } 
    #else
    public System.String? OtherActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to the type of action to be performed (for example, channel to be used for additional verification or authentication).
    /// </summary>
    [IsoId("_nWyY4EXVEeegp_DADCe7HQ")]
    [DisplayName("Action Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnInf")]
    #endif
    [IsoXmlTag("ActnInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ActionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ActionInformation { get; init; } 
    #else
    public System.String? ActionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
