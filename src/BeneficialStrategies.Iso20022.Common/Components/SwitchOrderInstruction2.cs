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
/// Information about a switch order.
/// </summary>
[IsoId("_RNhhFtp-Ed-ak6NoX_4Aeg_-925024145")]
[DisplayName("Switch Order Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchOrderInstruction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the switch order.
    /// </summary>
    [IsoId("_RNhhF9p-Ed-ak6NoX_4Aeg_-925023776")]
    [DisplayName("Switch Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchOrdrDtls")]
    #endif
    [IsoXmlTag("SwtchOrdrDtls")]
    public ValueList<SwitchOrder3> SwitchOrderDetails { get; init; } = new ValueList<SwitchOrder3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RNhhF9p-Ed-ak6NoX_4Aeg_-925023776
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RNhhGNp-Ed-ak6NoX_4Aeg_-925024109")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
