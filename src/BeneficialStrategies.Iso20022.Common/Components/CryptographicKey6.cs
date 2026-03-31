// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic Key.
/// </summary>
[IsoId("_t5utsXvOEeSCJdwgzb6SFw")]
[DisplayName("Cryptographic Key")]
public record CryptographicKey6
{
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [IsoId("__juqQHvOEeSCJdwgzb6SFw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_uGPfsXvOEeSCJdwgzb6SFw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Identification { get; init; }

    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_uGPftXvOEeSCJdwgzb6SFw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_uGPft3vOEeSCJdwgzb6SFw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CryptographicKeyType3Code Type { get; init; }

    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_uGPfuXvOEeSCJdwgzb6SFw")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = [];

    // ID for the above is _uGPfuXvOEeSCJdwgzb6SFw

    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_uGPfu3vOEeSCJdwgzb6SFw")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActivationDate { get; init; }

    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_uGPfvXvOEeSCJdwgzb6SFw")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeactivationDate { get; init; }

    /// <summary>
    /// Encrypted value of the key present as CMS structure EnvelopedData.
    /// </summary>
    [IsoId("_NbHQ0HvPEeSCJdwgzb6SFw")]
    [DisplayName("Encrypted Key Value")]
    [IsoXmlTag("NcrptdKeyVal")]
    public ContentInformationType10? EncryptedKeyValue { get; init; }

    /// <summary>
    /// Certificate to protect the key.
    /// </summary>
    [IsoId("_VzAv4HvPEeSCJdwgzb6SFw")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax5000Binary> Certificate { get; init; } = [];

    /// <summary>
    /// Chip card protection of the key.
    /// </summary>
    [IsoId("_Ykxs4HvPEeSCJdwgzb6SFw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? ICCRelatedData { get; init; }
}
