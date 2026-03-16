// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data Set Request6.
/// </summary>
[IsoId("_41AgwZ9kEe-nbM0aSPcoiQ")]
[DisplayName("Data Set Request6")]
public record DataSetRequest6
{
    /// <summary>
    /// Delegation Proof.
    /// </summary>
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification11 Identification { get; init; }

    /// <summary>
    /// POI Challenge.
    /// </summary>
    [DisplayName("POI Challenge")]
    [IsoXmlTag("POIChllng")]
    public IsoMax140Binary? POIChallenge { get; init; }

    /// <summary>
    /// Protected Delegation Proof.
    /// </summary>
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType39? ProtectedDelegationProof { get; init; }

    /// <summary>
    /// Session Key.
    /// </summary>
    [DisplayName("Session Key")]
    [IsoXmlTag("SsnKey")]
    public CryptographicKey18? SessionKey { get; init; }

    /// <summary>
    /// TM Challenge.
    /// </summary>
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    public IsoMax140Binary? TMChallenge { get; init; }
}
