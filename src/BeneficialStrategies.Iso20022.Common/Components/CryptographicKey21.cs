// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic key.
/// </summary>
[IsoId("_xufmcbZ5EfCUZfsQO4rYeA")]
[DisplayName("Cryptographic Key21")]
public record CryptographicKey21
{
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [IsoId("_xvj9cbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_xvj9c7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax140Text? Identification { get; init; }

    /// <summary>
    /// Identification of the security domain.
    /// </summary>
    [IsoId("_xvj9dbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Security Domain Identification")]
    [IsoXmlTag("SctyDomnId")]
    public IsoMax35Text? SecurityDomainIdentification { get; init; }

    /// <summary>
    /// Additional identification of the key, for instance to derive the key.
    /// </summary>
    [IsoId("_xvj9d7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public IsoMax35Binary? AdditionalIdentification { get; init; }

    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_xvj9ebZ5EfCUZfsQO4rYeA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Sequence counter of the cryptographic key.
    /// </summary>
    [IsoId("_xvj9e7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public IsoNumber? SequenceCounter { get; init; }

    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_xvj9fbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CryptographicKeyType5Code? Type { get; init; }

    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_xvj9f7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = [];

    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_xvj9gbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    public IsoISODateTime? ActivationDate { get; init; }

    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_xvj9g7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    public IsoISODateTime? DeactivationDate { get; init; }

    /// <summary>
    /// Value for checking a cryptographic key.
    /// </summary>
    [IsoId("_xvj9hbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    public IsoMax35Binary? KeyCheckValue { get; init; }

    /// <summary>
    /// Value of the public component of a RSA key.
    /// </summary>
    [IsoId("_xvj9h7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Public Key Value")]
    [IsoXmlTag("PblcKeyVal")]
    public PublicRSAKey1? PublicKeyValue { get; init; }

    /// <summary>
    /// Element containing the key information.
    /// </summary>
    [IsoId("_xvj9ibZ5EfCUZfsQO4rYeA")]
    [DisplayName("Key Choice Value")]
    [IsoXmlTag("KeyChcVal")]
    public KeyValue3Choice_? KeyChoiceValue { get; init; }
}
