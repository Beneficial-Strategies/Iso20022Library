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
/// Loyalty programme information
/// </summary>
[IsoId("_R1YN9PJpEeiJn9rM2Znz2w")]
[DisplayName("Loyalty Programme")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyProgramme2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of loyalty programme (for example, airline, lodging, vehicle and rail etc.).
    /// </summary>
    [IsoId("_R1YN9fJpEeiJn9rM2Znz2w")]
    [DisplayName("Programme Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrgrmmTp")]
    #endif
    [IsoXmlTag("PrgrmmTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProgrammeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProgrammeType { get; init; } 
    #else
    public System.String? ProgrammeType { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty programme identification value.
    /// </summary>
    [IsoId("_R1YN9vJpEeiJn9rM2Znz2w")]
    [DisplayName("Program Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrgmId")]
    #endif
    [IsoXmlTag("PrgmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ProgramIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProgramIdentification { get; init; } 
    #else
    public System.String? ProgramIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty programme participant identification value.
    /// </summary>
    [IsoId("_R1YN9_JpEeiJn9rM2Znz2w")]
    [DisplayName("Participant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptId")]
    #endif
    [IsoXmlTag("PtcptId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ParticipantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ParticipantIdentification { get; init; } 
    #else
    public System.String? ParticipantIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
