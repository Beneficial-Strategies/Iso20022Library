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
/// Defines the criteria used to search for a reservation.
/// </summary>
[IsoId("_1HrfsQzAEe2Wmf2RrXviyA")]
[DisplayName("Reservation Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReservationSearchCriteria5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Patterns to search a date time.
    /// </summary>
    [IsoId("_NOy4gQ2kEe2Se4rqNVVW-A")]
    [DisplayName("Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtTm")]
    #endif
    [IsoXmlTag("DtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimeSearch2Choice_? DateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimeSearch2Choice_? DateTime { get; init; } 
    #else
    public DateTimeSearch2Choice_? DateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_1RgxIQzAEe2Wmf2RrXviyA")]
    [DisplayName("System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysId")]
    #endif
    [IsoXmlTag("SysId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    #else
    public SystemIdentification2Choice_? SystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of reservation as set by default in the system. The default reservation is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_1RgxIwzAEe2Wmf2RrXviyA")]
    [DisplayName("Default Reservation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltRsvatnTp")]
    #endif
    [IsoXmlTag("DfltRsvatnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReservationType2Choice_? DefaultReservationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationType2Choice_? DefaultReservationType { get; init; } 
    #else
    public ReservationType2Choice_? DefaultReservationType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of reservation applied by the system at the present time.
    /// </summary>
    [IsoId("_1RgxJQzAEe2Wmf2RrXviyA")]
    [DisplayName("Current Reservation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurRsvatnTp")]
    #endif
    [IsoXmlTag("CurRsvatnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReservationType2Choice_? CurrentReservationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationType2Choice_? CurrentReservationType { get; init; } 
    #else
    public ReservationType2Choice_? CurrentReservationType { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_1RgxJwzAEe2Wmf2RrXviyA")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_1RgxKQzAEe2Wmf2RrXviyA")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #else
    public AccountIdentification4Choice_? AccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
