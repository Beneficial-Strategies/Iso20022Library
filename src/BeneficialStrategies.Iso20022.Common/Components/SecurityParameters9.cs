// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security parameters of the ATM for the initiated key download.
/// </summary>
[IsoId("_dfs4IbToEeeQy4o2AayYHg")]
[DisplayName("Security Parameters")]
public record SecurityParameters9
{
    /// <summary>
    /// Cryptographic key used to protect the key download.
    /// </summary>
    [IsoId("_doTagbToEeeQy4o2AayYHg")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey12? Key { get; init; }

    /// <summary>
    /// Element containing the signature.
    /// </summary>
    [IsoId("_doTag7ToEeeQy4o2AayYHg")]
    [DisplayName("Signature Choice")]
    [IsoXmlTag("SgntrChc")]
    public ATMSignature2Choice_? SignatureChoice { get; init; }

    /// <summary>
    /// Ordered certificate chain of the asymmetric key encryption key, starting with the ATM certificate.
    /// </summary>
    [IsoId("_doTahbToEeeQy4o2AayYHg")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? Certificate { get; init; }

    /// <summary>
    /// Random value from the ATM to avoid message replay.
    /// </summary>
    [IsoId("_doTah7ToEeeQy4o2AayYHg")]
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ATMChallenge { get; init; }

    /// <summary>
    /// Requested key for downloading, depending on the key hierarchy used by the host.
    /// </summary>
    [IsoId("_doTaibToEeeQy4o2AayYHg")]
    [DisplayName("Requested Key")]
    [IsoXmlTag("ReqdKey")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RequestedKey { get; init; }
}
