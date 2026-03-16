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
[IsoId("_ELOLu24-EeiU9cctagi5ow")]
[DisplayName("Reservation Search Criteria")]
public record ReservationSearchCriteria3
{
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_EVDdI24-EeiU9cctagi5ow")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Type of reservation as set by default in the system. The default reservation is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_EVDdJW4-EeiU9cctagi5ow")]
    [DisplayName("Default Reservation Type")]
    [IsoXmlTag("DfltRsvatnTp")]
    public ReservationType1Code? DefaultReservationType { get; init; }

    /// <summary>
    /// Type of reservation applied by the system at the present time.
    /// </summary>
    [IsoId("_EVDdJ24-EeiU9cctagi5ow")]
    [DisplayName("Current Reservation Type")]
    [IsoXmlTag("CurRsvatnTp")]
    public ReservationType1Code? CurrentReservationType { get; init; }

    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_EVDdKW4-EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_EVDdK24-EeiU9cctagi5ow")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }
}
