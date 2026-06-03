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
[IsoId("_zTg8sRNYEfC1ZfCQz0xB3g")]
[DisplayName("Processing Result29")]
public record ProcessingResult29
{
    /// <summary>
    /// Identification of response source.
    /// </summary>
    [IsoId("_za9ogRNYEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Identification")]
    [IsoXmlTag("RspnSrcId")]
    public IsoMax35Text? ResponseSourceIdentification { get; init; }

    /// <summary>
    /// Type of response source.
    /// </summary>
    [IsoId("_za9oiRNYEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Type")]
    [IsoXmlTag("RspnSrcTp")]
    public ATICAPartyType1Code? ResponseSourceType { get; init; }

    /// <summary>
    /// Country of the response source.
    /// </summary>
    [IsoId("_za9ojxNYEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Country")]
    [IsoXmlTag("RspnSrcCtry")]
    public ISOMax3ACountryCode? ResponseSourceCountry { get; init; }

    /// <summary>
    /// Name of the response source.
    /// </summary>
    [IsoId("_za9olxNYEfC1ZfCQz0xB3g")]
    [DisplayName("Response Source Name")]
    [IsoXmlTag("RspnSrcNm")]
    public IsoMax35Text? ResponseSourceName { get; init; }

    /// <summary>
    /// Detailed results of the processing, conforming to ISO 8583 Response codes list.
    /// </summary>
    [IsoId("_za9omRNYEfC1ZfCQz0xB3g")]
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public required ISO8583ResponseCode ResponseCode { get; init; }

    /// <summary>
    /// Contains the reason of the response.
    /// </summary>
    [IsoId("_4ceyYUL_EfCQAqQ9lolFUg")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public IsoMax4Text? ResponseReason { get; init; }

    /// <summary>
    /// Action to be performed based on ISO8583 Action Code.
    /// </summary>
    [IsoId("_za9orRNYEfC1ZfCQz0xB3g")]
    [DisplayName("Action Code")]
    [IsoXmlTag("ActnCd")]
    public ISO8583ActionCode? ActionCode { get; init; }

    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    [IsoId("_za9ooRNYEfC1ZfCQz0xB3g")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; }

    /// <summary>
    /// Issuer permits reuse of temporary secure stored card data.
    /// </summary>
    [IsoId("_za9oqRNYEfC1ZfCQz0xB3g")]
    [DisplayName("Temporary Secure Card Data Reuse Permitted")]
    [IsoXmlTag("TempScrCardDataReusePrtd")]
    public IsoTrueFalseIndicator? TemporarySecureCardDataReusePermitted { get; init; }

    /// <summary>
    /// Error detail information.
    /// </summary>
    [IsoId("_za9orxNYEfC1ZfCQz0xB3g")]
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ValueList<ErrorDetails4> ErrorDetail { get; init; } = [];

    /// <summary>
    /// Contains information of the cardholder receipt.
    /// </summary>
    [IsoId("_SZsn9RQREfC1ZfCQz0xB3g")]
    [DisplayName("Cardholder Receipt Data")]
    [IsoXmlTag("CrdhldrRctData")]
    public IsoMax99Text? CardholderReceiptData { get; init; }

    /// <summary>
    /// Contains information of the card acceptor receipt.
    /// </summary>
    [IsoId("_SZsn9hQREfC1ZfCQz0xB3g")]
    [DisplayName("Card Acceptor Receipt Data")]
    [IsoXmlTag("CardAccptrRctData")]
    public IsoMax99Text? CardAcceptorReceiptData { get; init; }

    /// <summary>
    /// Contains information displayed to the cardholder.
    /// </summary>
    [IsoId("_SZsn9xQREfC1ZfCQz0xB3g")]
    [DisplayName("Cardholder Display Data")]
    [IsoXmlTag("CrdhldrDispData")]
    public IsoMax99Text? CardholderDisplayData { get; init; }

    /// <summary>
    /// Contains information displayed to the card acceptor.
    /// </summary>
    [IsoId("_SZsn-BQREfC1ZfCQz0xB3g")]
    [DisplayName("Card Acceptor Display Data")]
    [IsoXmlTag("CardAccptrDispData")]
    public IsoMax99Text? CardAcceptorDisplayData { get; init; }

    /// <summary>
    /// Contains the card issuer's contact telephone number.
    /// </summary>
    [IsoId("_SZsn-RQREfC1ZfCQz0xB3g")]
    [DisplayName("Card Issuer Telephone Number")]
    [IsoXmlTag("CardIssrTelNb")]
    public IsoPhoneNumber? CardIssuerTelephoneNumber { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_ekGEokVbEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_ekGEo0VbEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
