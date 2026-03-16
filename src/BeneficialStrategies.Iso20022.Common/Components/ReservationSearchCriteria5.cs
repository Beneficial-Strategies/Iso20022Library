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
[IsoId("_1HrfsQzAEe2Wmf2RrXviyA")]
[DisplayName("Reservation Search Criteria")]
public record ReservationSearchCriteria5
{
    /// <summary>
    /// Patterns to search a date time.
    /// </summary>
    [IsoId("_NOy4gQ2kEe2Se4rqNVVW-A")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public DateTimeSearch2Choice_? DateTime { get; init; }

    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_1RgxIQzAEe2Wmf2RrXviyA")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Type of reservation as set by default in the system. The default reservation is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_1RgxIwzAEe2Wmf2RrXviyA")]
    [DisplayName("Default Reservation Type")]
    [IsoXmlTag("DfltRsvatnTp")]
    public ReservationType2Choice_? DefaultReservationType { get; init; }

    /// <summary>
    /// Type of reservation applied by the system at the present time.
    /// </summary>
    [IsoId("_1RgxJQzAEe2Wmf2RrXviyA")]
    [DisplayName("Current Reservation Type")]
    [IsoXmlTag("CurRsvatnTp")]
    public ReservationType2Choice_? CurrentReservationType { get; init; }

    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_1RgxJwzAEe2Wmf2RrXviyA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_1RgxKQzAEe2Wmf2RrXviyA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }
}
