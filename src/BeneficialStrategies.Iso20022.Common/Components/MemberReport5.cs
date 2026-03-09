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
/// Reports either on a member or a business error.
/// </summary>
[IsoId("_jmCflXSbEeiH1ZOt2UD8vQ")]
[DisplayName("Member Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MemberReport5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MemberReport5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MemberReport5( MemberIdentification3Choice_ reqMemberIdentification,MemberReportOrError6Choice_ reqMemberOrError )
    {
        MemberIdentification = reqMemberIdentification;
        MemberOrError = reqMemberOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_j3hRIXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbId")]
    #endif
    [IsoXmlTag("MmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #else
    public MemberIdentification3Choice_ MemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reports either on a member or a business error.
    /// </summary>
    [IsoId("_j3hRI3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbOrErr")]
    #endif
    [IsoXmlTag("MmbOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MemberReportOrError6Choice_ MemberOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MemberReportOrError6Choice_ MemberOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberReportOrError6Choice_ MemberOrError { get; init; } 
    #else
    public MemberReportOrError6Choice_ MemberOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
