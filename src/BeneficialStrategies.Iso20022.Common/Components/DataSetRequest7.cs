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
[IsoId("_cRUh8bZzEfCUZfsQO4rYeA")]
[DisplayName("Data Set Request7")]
public record DataSetRequest7
{
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_cSPH9bZzEfCUZfsQO4rYeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification11 Identification { get; init; }

    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_cSPH-7ZzEfCUZfsQO4rYeA")]
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_cSPIAbZzEfCUZfsQO4rYeA")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Temporary encryption key that the host will use for protecting keys to download.
    /// </summary>
    [IsoId("_cSPIB7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Session Key")]
    [IsoXmlTag("SsnKey")]
    public CryptographicKey19? SessionKey { get; init; }

    /// <summary>
    /// Proof of delegation to be validated by the terminal manager receiving a status report from a new POI.
    /// </summary>
    [IsoId("_cSPIDbZzEfCUZfsQO4rYeA")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_cSPIE7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType39? ProtectedDelegationProof { get; init; }
}
