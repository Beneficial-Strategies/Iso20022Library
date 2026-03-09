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
/// Indicates derivative contract was tranched.
/// </summary>
[IsoId("_Ocsf0byOEeaUov4jN5X9Qw")]
[DisplayName("Tranche")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Tranche2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the point at which losses in the pool will attach to a particular tranche.
    /// </summary>
    [IsoId("_OpEH4byOEeaUov4jN5X9Qw")]
    [DisplayName("Attachment Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttchmntPt")]
    #endif
    [IsoXmlTag("AttchmntPt")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? AttachmentPoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AttachmentPoint { get; init; } 
    #else
    public System.Decimal? AttachmentPoint { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the point beyond which losses do not affect the particular tranche.
    /// </summary>
    [IsoId("_OpEH47yOEeaUov4jN5X9Qw")]
    [DisplayName("Detachment Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtchmntPt")]
    #endif
    [IsoXmlTag("DtchmntPt")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? DetachmentPoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DetachmentPoint { get; init; } 
    #else
    public System.Decimal? DetachmentPoint { get; set; } 
    #endif
    
    
    #nullable disable
    
}
