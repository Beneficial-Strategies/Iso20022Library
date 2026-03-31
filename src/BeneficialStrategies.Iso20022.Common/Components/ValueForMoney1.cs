// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value For Money1.
/// </summary>
[IsoId("_63iJ8CY9Ee6m8LTtAzU6hA")]
[DisplayName("Value For Money1")]
public record ValueForMoney1
{
    /// <summary>
    /// Assessment Of Value Required Under COLLUK.
    /// </summary>
    [DisplayName("Assessment Of Value Required Under COLLUK")]
    [IsoXmlTag("AssmntOfValReqrdUdrCOLLUK")]
    public AssessmentOfValueRequiredUnderCOLLUKType1Code? AssessmentOfValueRequiredUnderCOLLUK { get; init; }

    /// <summary>
    /// EMT Data Reporting VFMUK.
    /// </summary>
    [DisplayName("EMT Data Reporting VFMUK")]
    [IsoXmlTag("EMTDataRptgVFMUK")]
    public EMTDataReportingVFMUKType1Code? EMTDataReportingVFMUK { get; init; }

    /// <summary>
    /// Further Information UK.
    /// </summary>
    [DisplayName("Further Information UK")]
    [IsoXmlTag("FrthrInfUK")]
    public IsoMax350Text? FurtherInformationUK { get; init; }

    /// <summary>
    /// Other Review Related To Value And Or Charges UK.
    /// </summary>
    [DisplayName("Other Review Related To Value And Or Charges UK")]
    [IsoXmlTag("OthrRvwRltdToValAndOrChrgsUK")]
    public OtherReviewRelatedToValueAndOrChargesUKType1Code? OtherReviewRelatedToValueAndOrChargesUK { get; init; }

    /// <summary>
    /// Outcome Of COLL Assessment Of Value UK.
    /// </summary>
    [DisplayName("Outcome Of COLL Assessment Of Value UK")]
    [IsoXmlTag("OutcmOfCOLLAssmntOfValUK")]
    public OutcomeOfCOLLAssessmentOfValueUKType1Code? OutcomeOfCOLLAssessmentOfValueUK { get; init; }

    /// <summary>
    /// Outcome Of PRIN Value Assessment Or Review UK.
    /// </summary>
    [DisplayName("Outcome Of PRIN Value Assessment Or Review UK")]
    [IsoXmlTag("OutcmOfPRINValAssmntOrRvwUK")]
    public OutcomeOfPRINValueAssessmentOrReviewUKType1Code? OutcomeOfPRINValueAssessmentOrReviewUK { get; init; }

    /// <summary>
    /// Review Date UK.
    /// </summary>
    [DisplayName("Review Date UK")]
    [IsoXmlTag("RvwDtUK")]
    public IsoISODate? ReviewDateUK { get; init; }

    /// <summary>
    /// Review Next Due UK.
    /// </summary>
    [DisplayName("Review Next Due UK")]
    [IsoXmlTag("RvwNxtDueUK")]
    public IsoISODate? ReviewNextDueUK { get; init; }
}
