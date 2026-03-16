// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Audit Trail Report4.
/// </summary>
[IsoId("_Yn4CMTE_Ee62xuUQ2zyZww")]
[DisplayName("Party Audit Trail Report4")]
public record PartyAuditTrailReport4
{
    /// <summary>
    /// Date Period.
    /// </summary>
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DatePeriod3Choice_? DatePeriod { get; init; }

    /// <summary>
    /// Party Audit Trail Or Error.
    /// </summary>
    [DisplayName("Party Audit Trail Or Error")]
    [IsoXmlTag("PtyAudtTrlOrErr")]
    public required PartyAuditTrailOrError4Choice_ PartyAuditTrailOrError { get; init; }

    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification8 PartyIdentification { get; init; }
}
