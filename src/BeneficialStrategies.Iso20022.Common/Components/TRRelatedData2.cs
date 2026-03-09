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
/// Data block for a TR31 or TR34 key block which contains the key being transported.
/// </summary>
[IsoId("_PRFA0LTpEeeQy4o2AayYHg")]
[DisplayName("TR Related Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TRRelatedData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specific TR34 command where the TRBlock is a TR34 block.
    /// </summary>
    [IsoId("_PZ0GEbTpEeeQy4o2AayYHg")]
    [DisplayName("TR 34 Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TR34Cmd")]
    #endif
    [IsoXmlTag("TR34Cmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TR34Command1Code? TR34Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TR34Command1Code? TR34Command { get; init; } 
    #else
    public TR34Command1Code? TR34Command { get; set; } 
    #endif
    
    /// <summary>
    /// TR31 or TR34 data block.
    /// </summary>
    [IsoId("_PZ0GE7TpEeeQy4o2AayYHg")]
    [DisplayName("TR Block")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TRBlck")]
    #endif
    [IsoXmlTag("TRBlck")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? TRBlock { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TRBlock { get; init; } 
    #else
    public System.Byte[]? TRBlock { get; set; } 
    #endif
    
    
    #nullable disable
    
}
