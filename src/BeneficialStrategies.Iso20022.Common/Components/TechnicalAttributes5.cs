// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies technical attributes of the message.
/// </summary>
[IsoId("_-UBWoRaIEe27wrM4RUjLog")]
[DisplayName("Technical Attributes")]
public record TechnicalAttributes5
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_DH2BkDAdEe2Ne600gC45nw")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_-VogMRaIEe27wrM4RUjLog")]
    [DisplayName("Reconciliation Flag")]
    [IsoXmlTag("RcncltnFlg")]
    public Reconciliation3Code? ReconciliationFlag { get; init; }

    /// <summary>
    /// Indicates the date and time of the receipt of the submission of the report to the trade repository as recorded by the trade repository. This item should only be present in a message from the trade repository to an authority and/or other recipients of the message.
    /// </summary>
    [IsoId("_9ATPgBaJEe27wrM4RUjLog")]
    [DisplayName("Report Receipt Time Stamp")]
    [IsoXmlTag("RptRctTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ReportReceiptTimeStamp { get; init; }
}
