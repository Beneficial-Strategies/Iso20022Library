// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the authorisation.
/// </summary>
[IsoId("_zBmXYROGEfC1ZfCQz0xB3g")]
[DisplayName("Processing Result31")]
public record ProcessingResult31
{
    /// <summary>
    /// Identification of response source.
    /// </summary>
    [IsoId("_zIqosROGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Identification")]
    [IsoXmlTag("RspnSrcId")]
    public IsoMax35Text? ResponseSourceIdentification { get; init; }

    /// <summary>
    /// Type of response source.
    /// </summary>
    [IsoId("_zIqouROGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Type")]
    [IsoXmlTag("RspnSrcTp")]
    public ATICAPartyType1Code? ResponseSourceType { get; init; }

    /// <summary>
    /// Country of the response source.
    /// </summary>
    [IsoId("_zIqovxOGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Country")]
    [IsoXmlTag("RspnSrcCtry")]
    public ISOMax3ACountryCode? ResponseSourceCountry { get; init; }

    /// <summary>
    /// Name of the response source.
    /// </summary>
    [IsoId("_zIqoxxOGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Name")]
    [IsoXmlTag("RspnSrcNm")]
    public IsoMax35Text? ResponseSourceName { get; init; }

    /// <summary>
    /// Detailed results of the processing, conforming to ISO 8583 Response codes list.
    /// </summary>
    [IsoId("_zIqoyROGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public ISO8583ResponseCode? ResponseCode { get; init; }

    /// <summary>
    /// Action to be performed based on ISO8583 Action Code.
    /// </summary>
    [IsoId("_YOo4QUMHEfCQAqQ9lolFUg")]
    [DisplayName("Action Code")]
    [IsoXmlTag("ActnCd")]
    public ISO8583ActionCode? ActionCode { get; init; }

    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    [IsoId("_zIqo0ROGEfC1ZfCQz0xB3g")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; }

    /// <summary>
    /// Contains the reason of the response.
    /// </summary>
    [IsoId("_b_G5MUMHEfCQAqQ9lolFUg")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public IsoMax35Text? ResponseReason { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_ru__skVbEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_ru__s0VbEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
