// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a reservation.
/// </summary>
[IsoId("_8IaeM6MgEeCJ6YNENx4h-w_-54648369")]
[DisplayName("Reservation Search Criteria")]
public record ReservationSearchCriteria2
{
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_8IaeNKMgEeCJ6YNENx4h-w_-344148107")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Type of reservation as set by default in the system. The default reservation is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_8IaeNaMgEeCJ6YNENx4h-w_-1264985850")]
    [DisplayName("Default Reservation Type")]
    [IsoXmlTag("DfltRsvatnTp")]
    public ReservationType1Code? DefaultReservationType { get; init; }

    /// <summary>
    /// Type of reservation applied by the system at the present time.
    /// </summary>
    [IsoId("_8IaeNqMgEeCJ6YNENx4h-w_-821997358")]
    [DisplayName("Current Reservation Type")]
    [IsoXmlTag("CurRsvatnTp")]
    public ReservationType1Code? CurrentReservationType { get; init; }

    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_8IaeN6MgEeCJ6YNENx4h-w_-853968122")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_8IjoIKMgEeCJ6YNENx4h-w_-1621016378")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }
}
