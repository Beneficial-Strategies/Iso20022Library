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
/// Provides details on the settlement obligation report.
/// </summary>
[IsoId("_7jLUES9dEeS94oXWDaBauA")]
[DisplayName("Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Report5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification for the non-clearing member. This is mandatory if the clearing member identification equals a general clearing member.
    /// </summary>
    [IsoId("_71U0AS9dEeS94oXWDaBauA")]
    [DisplayName("Non Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonClrMmb")]
    #endif
    [IsoXmlTag("NonClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #else
    public PartyIdentificationAndAccount31? NonClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the settlement obligation details.
    /// </summary>
    [IsoId("_71U0Ay9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Obligation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmOblgtnDtls")]
    #endif
    [IsoXmlTag("SttlmOblgtnDtls")]
    public ValueList<SettlementObligation8> SettlementObligationDetails { get; init; } = new ValueList<SettlementObligation8>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _71U0Ay9dEeS94oXWDaBauA
    
    
    #nullable disable
    
}
