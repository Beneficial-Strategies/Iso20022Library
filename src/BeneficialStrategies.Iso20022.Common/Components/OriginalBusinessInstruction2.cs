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
/// Unique identification, as assigned by the original requestor, to unambiguously identify the business instruction message.
/// </summary>
[IsoId("_XaC4U_WfEemtd4wHZYvFUQ")]
[DisplayName("Original Business Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalBusinessInstruction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original instruction message.
    /// </summary>
    [IsoId("_XaC4V_WfEemtd4wHZYvFUQ")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax35Text? MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageIdentification { get; init; } 
    #else
    public System.String? MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the instruction message name identifier to which the message refers.
    /// </summary>
    [IsoId("_XaC4WfWfEemtd4wHZYvFUQ")]
    [DisplayName("Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNmId")]
    #endif
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax35Text? MessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageNameIdentification { get; init; } 
    #else
    public System.String? MessageNameIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
