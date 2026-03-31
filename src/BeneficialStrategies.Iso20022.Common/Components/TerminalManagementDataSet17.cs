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
[IsoId("_GNEqoY3gEeW32YMP0mBeyw")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet17
{
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_GYGO4Y3gEeW32YMP0mBeyw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification6 Identification { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_GYGO443gEeW32YMP0mBeyw")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_GYGO5Y3gEeW32YMP0mBeyw")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Temporary encryption key that the host will use for protecting keys to download.
    /// </summary>
    [IsoId("_GYGO543gEeW32YMP0mBeyw")]
    [DisplayName("Session Key")]
    [IsoXmlTag("SsnKey")]
    public CryptographicKey5? SessionKey { get; init; }

    /// <summary>
    /// Proof of delegation to be validated by the terminal manager receiving a status report from a new POI.
    /// </summary>
    [IsoId("_SaGoMI3gEeW32YMP0mBeyw")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_WeiuAI3gEeW32YMP0mBeyw")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType12? ProtectedDelegationProof { get; init; }
}
