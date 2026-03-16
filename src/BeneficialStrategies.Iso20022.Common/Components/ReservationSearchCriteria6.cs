// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reservation Search Criteria6.
/// </summary>
[IsoId("_zxJBeTEyEe6g-ffJsqGiSA")]
[DisplayName("Reservation Search Criteria6")]
public record ReservationSearchCriteria6
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Current Reservation Type.
    /// </summary>
    [DisplayName("Current Reservation Type")]
    [IsoXmlTag("CurRsvatnTp")]
    public ValueList<ReservationType2Choice_> CurrentReservationType { get; init; } = [];

    /// <summary>
    /// Date Time.
    /// </summary>
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public DateTimeSearch2Choice_? DateTime { get; init; }

    /// <summary>
    /// Default Reservation Type.
    /// </summary>
    [DisplayName("Default Reservation Type")]
    [IsoXmlTag("DfltRsvatnTp")]
    public ValueList<ReservationType2Choice_> DefaultReservationType { get; init; } = [];

    /// <summary>
    /// System Identification.
    /// </summary>
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }
}
