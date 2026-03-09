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
/// Information related to the clearing of the contract.
/// </summary>
[IsoId("_BIv4sexYEemioJdkOVFBdw")]
[DisplayName("Trade Clearing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeClearing5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates, whether the reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation and both counterparties to the contract are subject to the clearing obligation, as of the time of execution of the contract.
    /// </summary>
    [IsoId("_BT5_0exYEemioJdkOVFBdw")]
    [DisplayName("Clearing Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrOblgtn")]
    #endif
    [IsoXmlTag("ClrOblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingObligationType1Code? ClearingObligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingObligationType1Code? ClearingObligation { get; init; } 
    #else
    public ClearingObligationType1Code? ClearingObligation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of whether the transaction has been cleared, or is intended to be cleared, by a central counterparty.
    /// </summary>
    [IsoId("_BT5_0-xYEemioJdkOVFBdw")]
    [DisplayName("Clearing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSts")]
    #endif
    [IsoXmlTag("ClrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cleared12Choice_? ClearingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cleared12Choice_? ClearingStatus { get; init; } 
    #else
    public Cleared12Choice_? ClearingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the contract was entered into as an intragroup transaction.
    /// Usage: When absent, default value is false.
    /// </summary>
    [IsoId("_BT5_1exYEemioJdkOVFBdw")]
    [DisplayName("Intra Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraGrp")]
    #endif
    [IsoXmlTag("IntraGrp")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? IntraGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IntraGroup { get; init; } 
    #else
    public System.String? IntraGroup { get; set; } 
    #endif
    
    
    #nullable disable
    
}
