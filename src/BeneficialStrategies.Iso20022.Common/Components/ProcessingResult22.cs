// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing Result22.
/// </summary>
[IsoId("_PXQTEXHEEe60F8I8TAMKmg")]
[DisplayName("Processing Result22")]
public partial record ProcessingResult22
{
    #nullable enable

    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action16> Action { get; init; } = [];

    /// <summary>
    /// Action Required.
    /// </summary>
    [DisplayName("Action Required")]
    [IsoXmlTag("ActnReqrd")]
    public IsoTrueFalseIndicator? ActionRequired { get; init; } 

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalData1> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Approval Code.
    /// </summary>
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; } 

    /// <summary>
    /// Error Detail.
    /// </summary>
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ValueList<ErrorDetails3> ErrorDetail { get; init; } = [];

    /// <summary>
    /// Response Code.
    /// </summary>
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public required ISO8583ResponseCode ResponseCode { get; init; } 

    /// <summary>
    /// Response Source Assigner.
    /// </summary>
    [DisplayName("Response Source Assigner")]
    [IsoXmlTag("RspnSrcAssgnr")]
    public PartyType9Code? ResponseSourceAssigner { get; init; } 

    /// <summary>
    /// Response Source Country.
    /// </summary>
    [DisplayName("Response Source Country")]
    [IsoXmlTag("RspnSrcCtry")]
    public ISOMax3ACountryCode? ResponseSourceCountry { get; init; } 

    /// <summary>
    /// Response Source Identification.
    /// </summary>
    [DisplayName("Response Source Identification")]
    [IsoXmlTag("RspnSrcId")]
    public IsoMax35Text? ResponseSourceIdentification { get; init; } 

    /// <summary>
    /// Response Source Other Type.
    /// </summary>
    [DisplayName("Response Source Other Type")]
    [IsoXmlTag("RspnSrcOthrTp")]
    public IsoMax35Text? ResponseSourceOtherType { get; init; } 

    /// <summary>
    /// Response Source Short Name.
    /// </summary>
    [DisplayName("Response Source Short Name")]
    [IsoXmlTag("RspnSrcShrtNm")]
    public IsoMax35Text? ResponseSourceShortName { get; init; } 

    /// <summary>
    /// Response Source Type.
    /// </summary>
    [DisplayName("Response Source Type")]
    [IsoXmlTag("RspnSrcTp")]
    public PartyType26Code? ResponseSourceType { get; init; } 

    /// <summary>
    /// Temporary Secure Card Data Reuse Permitted.
    /// </summary>
    [DisplayName("Temporary Secure Card Data Reuse Permitted")]
    [IsoXmlTag("TempScrCardDataReusePrtd")]
    public IsoTrueFalseIndicator? TemporarySecureCardDataReusePermitted { get; init; } 

    
    #nullable disable
    
}
