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
[IsoId("_FVa2kS8iEeu125Ip9zFcsQ")]
[DisplayName("Data Set Request")]
public record DataSetRequest2
{
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_FkGLwS8iEeu125Ip9zFcsQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification8 Identification { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_FkGLwy8iEeu125Ip9zFcsQ")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_FkGLxS8iEeu125Ip9zFcsQ")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Temporary encryption key that the host will use for protecting keys to download.
    /// </summary>
    [IsoId("_FkGLxy8iEeu125Ip9zFcsQ")]
    [DisplayName("Session Key")]
    [IsoXmlTag("SsnKey")]
    public CryptographicKey15? SessionKey { get; init; }

    /// <summary>
    /// Proof of delegation to be validated by the terminal manager receiving a status report from a new POI.
    /// </summary>
    [IsoId("_FkGLyS8iEeu125Ip9zFcsQ")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_FkGLyy8iEeu125Ip9zFcsQ")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType26? ProtectedDelegationProof { get; init; }
}
