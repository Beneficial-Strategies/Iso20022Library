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
[IsoId("_fOjPARNXEfC1ZfCQz0xB3g")]
[DisplayName("Processing Result28")]
public record ProcessingResult28
{
    /// <summary>
    /// Identification of response source.
    /// </summary>
    [IsoId("_fV7CURNXEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Identification")]
    [IsoXmlTag("RspnSrcId")]
    public IsoMax35Text? ResponseSourceIdentification { get; init; }

    /// <summary>
    /// Type of response source.
    /// </summary>
    [IsoId("_fV7CWRNXEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Type")]
    [IsoXmlTag("RspnSrcTp")]
    public ATICAPartyType1Code? ResponseSourceType { get; init; }

    /// <summary>
    /// Country of the response source.
    /// </summary>
    [IsoId("_fV7CXxNXEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Country")]
    [IsoXmlTag("RspnSrcCtry")]
    public ISOMax3ACountryCode? ResponseSourceCountry { get; init; }

    /// <summary>
    /// Name of the response source.
    /// </summary>
    [IsoId("_fV7CZxNXEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Name")]
    [IsoXmlTag("RspnSrcNm")]
    public IsoMax35Text? ResponseSourceName { get; init; }

    /// <summary>
    /// Detailed results of the processing, conforming to ISO 8583 Response codes list.
    /// </summary>
    [IsoId("_fV7CaRNXEfC1ZfCQz0xB3g")]
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public ISO8583ResponseCode? ResponseCode { get; init; }

    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    [IsoId("_fV7CcRNXEfC1ZfCQz0xB3g")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; }

    /// <summary>
    /// Contains the reason of the response.
    /// </summary>
    [IsoId("_2FKVsEL_EfCQAqQ9lolFUg")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public IsoMax35Text? ResponseReason { get; init; }

    /// <summary>
    /// Issuer permits reuse of temporary secure stored card data.
    /// </summary>
    [IsoId("_fV7CeRNXEfC1ZfCQz0xB3g")]
    [DisplayName("Temporary Secure Card Data Reuse Permitted")]
    [IsoXmlTag("TempScrCardDataReusePrtd")]
    public IsoTrueFalseIndicator? TemporarySecureCardDataReusePermitted { get; init; }

    /// <summary>
    /// Action to be performed based on ISO8583 Action Code.
    /// </summary>
    [IsoId("_fV7CfRNXEfC1ZfCQz0xB3g")]
    [DisplayName("Action Code")]
    [IsoXmlTag("ActnCd")]
    public ISO8583ActionCode? ActionCode { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_IxX_MkVbEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_IxX_M0VbEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
