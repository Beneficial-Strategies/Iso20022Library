// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a reservation.
/// </summary>
[IsoId("_gv7qwdcZEeqRFcf2R4bPBw")]
[DisplayName("Reservation Search Criteria")]
public partial record ReservationSearchCriteria4
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_gx0hIdcZEeqRFcf2R4bPBw")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    
    /// <summary>
    /// Type of reservation as set by default in the system. The default reservation is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_gx0hI9cZEeqRFcf2R4bPBw")]
    [DisplayName("Default Reservation Type")]
    [IsoXmlTag("DfltRsvatnTp")]
    public ReservationType2Choice_? DefaultReservationType { get; init; } 
    
    /// <summary>
    /// Type of reservation applied by the system at the present time.
    /// </summary>
    [IsoId("_gx0hJdcZEeqRFcf2R4bPBw")]
    [DisplayName("Current Reservation Type")]
    [IsoXmlTag("CurRsvatnTp")]
    public ReservationType2Choice_? CurrentReservationType { get; init; } 
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_gx0hJ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_gx0hKdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
