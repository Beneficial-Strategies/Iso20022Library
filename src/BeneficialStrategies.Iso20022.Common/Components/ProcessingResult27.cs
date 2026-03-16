// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing Result27.
/// </summary>
[IsoId("_vDnbYZgJEe6OBt2eQPMPsQ")]
[DisplayName("Processing Result27")]
public partial record ProcessingResult27
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
    /// Response Code.
    /// </summary>
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public ISO8583ResponseCode? ResponseCode { get; init; } 

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
