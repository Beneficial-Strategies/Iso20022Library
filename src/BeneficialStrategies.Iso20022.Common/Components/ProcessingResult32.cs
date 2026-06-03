// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the transaction.
/// </summary>
[IsoId("_89D68ROGEfC1ZfCQz0xB3g")]
[DisplayName("Processing Result32")]
public record ProcessingResult32
{
    /// <summary>
    /// Identification of response source.
    /// </summary>
    [IsoId("_9ELPkROGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Identification")]
    [IsoXmlTag("RspnSrcId")]
    public IsoMax35Text? ResponseSourceIdentification { get; init; }

    /// <summary>
    /// Type of response source.
    /// </summary>
    [IsoId("_9ELPmROGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Type")]
    [IsoXmlTag("RspnSrcTp")]
    public ATICAPartyType1Code? ResponseSourceType { get; init; }

    /// <summary>
    /// Country of the response source.
    /// </summary>
    [IsoId("_9ELPnxOGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Country")]
    [IsoXmlTag("RspnSrcCtry")]
    public ISOMax3ACountryCode? ResponseSourceCountry { get; init; }

    /// <summary>
    /// Name of the response source.
    /// </summary>
    [IsoId("_9ELPpxOGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Name")]
    [IsoXmlTag("RspnSrcNm")]
    public IsoMax35Text? ResponseSourceName { get; init; }

    /// <summary>
    /// Response code defined in ISO 8583.
    /// </summary>
    [IsoId("_9ELPqROGEfC1ZfCQz0xB3g")]
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public ISO8583ResponseCode? ResponseCode { get; init; }

    /// <summary>
    /// Contains the reason of the response.
    /// </summary>
    [IsoId("__iG3okMHEfCQAqQ9lolFUg")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public IsoMax35Text? ResponseReason { get; init; }

    /// <summary>
    /// Action to be performed based on ISO8583 Action Code.
    /// </summary>
    [IsoId("__iG3o0MHEfCQAqQ9lolFUg")]
    [DisplayName("Action Code")]
    [IsoXmlTag("ActnCd")]
    public ISO8583ActionCode? ActionCode { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_tPxO4kVbEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_tPxO40VbEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
