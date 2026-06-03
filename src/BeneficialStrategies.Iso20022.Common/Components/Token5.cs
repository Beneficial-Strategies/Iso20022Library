// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unencrypted sensitive data of a token.
/// </summary>
[IsoId("_t0ehQRRBEfC_aaedwHHlmw")]
[DisplayName("Token5")]
public record Token5
{
    [IsoId("_t7ehIRRBEfC_aaedwHHlmw")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public IsoMax19NumericText? PaymentToken { get; init; }

    [IsoId("_N5idwC9gEfCD0_iZ8tw-zA")]
    [DisplayName("Token Type")]
    [IsoXmlTag("TknTp")]
    public IsoMax3Text? TokenType { get; init; }

    [IsoId("_t7ehIxRBEfC_aaedwHHlmw")]
    [DisplayName("Token Expiry Date")]
    [IsoXmlTag("TknXpryDt")]
    public IsoISOYearMonth? TokenExpiryDate { get; init; }

    [IsoId("_t7ehJRRBEfC_aaedwHHlmw")]
    [DisplayName("Token Requestor Identification")]
    [IsoXmlTag("TknRqstrId")]
    public IsoMax11NumericText? TokenRequestorIdentification { get; init; }

    [IsoId("_t7ehJxRBEfC_aaedwHHlmw")]
    [DisplayName("Token Assurance Data")]
    [IsoXmlTag("TknAssrncData")]
    public IsoMax140Text? TokenAssuranceData { get; init; }

    [IsoId("_t7ehKRRBEfC_aaedwHHlmw")]
    [DisplayName("Token Assurance Method")]
    [IsoXmlTag("TknAssrncMtd")]
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; }

    [IsoId("_2H71AXn2EfCmC4yYaU27Kg")]
    [DisplayName("Token Reference Identification")]
    [IsoXmlTag("TknRefId")]
    public IsoMax35Text? TokenReferenceIdentification { get; init; }

    [IsoId("_t7ehKxRBEfC_aaedwHHlmw")]
    [DisplayName("Token Initiated Indicator")]
    [IsoXmlTag("TknInittdInd")]
    public IsoTrueFalseIndicator? TokenInitiatedIndicator { get; init; }

    [IsoId("_t7ehLRRBEfC_aaedwHHlmw")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public StorageLocation2Code? StorageLocation { get; init; }

    [IsoId("_t7ehMRRBEfC_aaedwHHlmw")]
    [DisplayName("Protection Method")]
    [IsoXmlTag("PrtcnMtd")]
    public ProtectionMethod2Code? ProtectionMethod { get; init; }

    [IsoId("_S--_gC9eEfCD0_iZ8tw-zA")]
    [DisplayName("Non Payment")]
    [IsoXmlTag("NonPmt")]
    public IsoTrueFalseIndicator? NonPayment { get; init; }

    [IsoId("_9NYe8C9eEfCD0_iZ8tw-zA")]
    [DisplayName("Token Requestor Name")]
    [IsoXmlTag("TknRqstrNm")]
    public IsoMax70Text? TokenRequestorName { get; init; }

    [IsoId("_WiUG4C9fEfCD0_iZ8tw-zA")]
    [DisplayName("Updated Channel")]
    [IsoXmlTag("UpdtdChanl")]
    public IsoMax35Text? UpdatedChannel { get; init; }

    [IsoId("_hyy8oC9fEfCD0_iZ8tw-zA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public IsoMax35Text? Status { get; init; }

    [IsoId("_8V5ZEK8dEfCnL-2fAG0ssA")]
    [DisplayName("Token Activation Date Time")]
    [IsoXmlTag("TknActvtnDtTm")]
    public IsoISODateTime? TokenActivationDateTime { get; init; }

    [IsoId("_w7D04S9iEfCD0_iZ8tw-zA")]
    [DisplayName("Original Token")]
    [IsoXmlTag("OrgnlTkn")]
    public Token4? OriginalToken { get; init; }

    [IsoId("_AiY2ckVZEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_AiY2c0VZEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
