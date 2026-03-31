// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of requested data set.
/// </summary>
[IsoId("_vpp_MXI2Ee299ZbWCkdR_w")]
[DisplayName("Data Set Request")]
public record DataSetRequest4
{
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_vxCZkXI2Ee299ZbWCkdR_w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification10 Identification { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_vxCZk3I2Ee299ZbWCkdR_w")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_vxCZlXI2Ee299ZbWCkdR_w")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Temporary encryption key that the host will use for protecting keys to download.
    /// </summary>
    [IsoId("_vxCZl3I2Ee299ZbWCkdR_w")]
    [DisplayName("Session Key")]
    [IsoXmlTag("SsnKey")]
    public CryptographicKey17? SessionKey { get; init; }

    /// <summary>
    /// Proof of delegation to be validated by the terminal manager receiving a status report from a new POI.
    /// </summary>
    [IsoId("_vxCZmXI2Ee299ZbWCkdR_w")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_vxCZm3I2Ee299ZbWCkdR_w")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType34? ProtectedDelegationProof { get; init; }
}
