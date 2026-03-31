// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument specific technical data to support identification.
/// </summary>
[IsoId("_OwQysSX7EeigZbhgJcrASA")]
[DisplayName("Record Technical Data")]
public record RecordTechnicalData4
{
    /// <summary>
    /// Flag to say if there is an inconsistency across all submitting entities records.
    /// </summary>
    [IsoId("_O7vp8yX7EeigZbhgJcrASA")]
    [DisplayName("Inconsistency Indicator")]
    [IsoXmlTag("IncnsstncyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InconsistencyIndicator { get; init; }

    /// <summary>
    /// Last date for which data was received for this instrument.
    /// </summary>
    [IsoId("_O7vp9SX7EeigZbhgJcrASA")]
    [DisplayName("Last Update")]
    [IsoXmlTag("LastUpd")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? LastUpdate { get; init; }

    /// <summary>
    /// Defines the date and time when this instrument was originally received at the submission destination.
    /// </summary>
    [IsoId("_O7vp9yX7EeigZbhgJcrASA")]
    [DisplayName("Submission Date Time")]
    [IsoXmlTag("SubmissnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? SubmissionDateTime { get; init; }

    /// <summary>
    /// Country code of the relevant competent authority of the instrument.
    /// </summary>
    [IsoId("_O7vp-SX7EeigZbhgJcrASA")]
    [DisplayName("Relevant Competent Authority")]
    [IsoXmlTag("RlvntCmptntAuthrty")]
    public CountryCode? RelevantCompetentAuthority { get; init; }

    /// <summary>
    /// Period for which the associated instrument has been publically available.
    /// </summary>
    [IsoId("_O7vp-yX7EeigZbhgJcrASA")]
    [DisplayName("Publication Period")]
    [IsoXmlTag("PblctnPrd")]
    public Period4Choice_? PublicationPeriod { get; init; }

    /// <summary>
    /// Flag to say if the record has ever been published.
    /// </summary>
    [IsoId("_O7vp_SX7EeigZbhgJcrASA")]
    [DisplayName("Never Published")]
    [IsoXmlTag("NvrPblshd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NeverPublished { get; init; }

    /// <summary>
    /// Trading venue of the record used by the relevant competent authority to determine the reference data for the instrument.
    /// </summary>
    [IsoId("_qDbo8CX7EeigZbhgJcrASA")]
    [DisplayName("Relevant Trading Venue")]
    [IsoXmlTag("RlvntTradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? RelevantTradingVenue { get; init; }
}
