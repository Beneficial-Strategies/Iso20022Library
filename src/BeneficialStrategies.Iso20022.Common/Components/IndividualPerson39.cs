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
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_fQtPUa-SEemJ1NnLPsTFaw")]
[DisplayName("Individual Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualPerson39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualPerson39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualPerson39( AttendanceCard2 reqAttendanceCardDetails )
    {
        AttendanceCardDetails = reqAttendanceCardDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the proxy.
    /// </summary>
    [IsoId("_fliP16-SEemJ1NnLPsTFaw")]
    [DisplayName("Preassigned Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrssgndPrxy")]
    #endif
    [IsoXmlTag("PrssgndPrxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification223Choice_? PreassignedProxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification223Choice_? PreassignedProxy { get; init; } 
    #else
    public PartyIdentification223Choice_? PreassignedProxy { get; set; } 
    #endif
    
    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    [IsoId("_fliP26-SEemJ1NnLPsTFaw")]
    [DisplayName("Employing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmplngPty")]
    #endif
    [IsoXmlTag("EmplngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification129Choice_? EmployingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_? EmployingParty { get; init; } 
    #else
    public PartyIdentification129Choice_? EmployingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the attendance card.
    /// </summary>
    [IsoId("_fliP3a-SEemJ1NnLPsTFaw")]
    [DisplayName("Attendance Card Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncCardDtls")]
    #endif
    [IsoXmlTag("AttndncCardDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AttendanceCard2 AttendanceCardDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AttendanceCard2 AttendanceCardDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttendanceCard2 AttendanceCardDetails { get; init; } 
    #else
    public AttendanceCard2 AttendanceCardDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
