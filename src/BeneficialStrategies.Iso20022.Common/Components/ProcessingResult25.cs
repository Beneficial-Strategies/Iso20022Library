// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing Result25.
/// </summary>
[IsoId("_XX7ewYVpEe6odei_lsRKtw")]
[DisplayName("Processing Result25")]
public record ProcessingResult25
{
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
}
