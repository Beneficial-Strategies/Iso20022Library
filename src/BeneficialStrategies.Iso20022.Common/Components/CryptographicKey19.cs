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
[IsoId("_FLVBwaABEfC4Q_xhaK1hdQ")]
[DisplayName("Cryptographic Key19")]
public record CryptographicKey19
{
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_FMs6xaABEfC4Q_xhaK1hdQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax350Text? Identification { get; init; }

    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_zZ7jo7ZwEfCUZfsQO4rYeA")]
    [DisplayName("Key Identification")]
    [IsoXmlTag("KeyId")]
    public IsoMax350Text? KeyIdentification { get; init; }

    /// <summary>
    /// Additional identification of the key.
    /// </summary>
    [IsoId("_FMs6y6ABEfC4Q_xhaK1hdQ")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public IsoMax35Binary? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name of the Cryptographic Element.
    /// </summary>
    [IsoId("_FMs60aABEfC4Q_xhaK1hdQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax256Text? Name { get; init; }

    /// <summary>
    /// Identification of the set of security elements to which this element belongs.
    /// </summary>
    [IsoId("_FMs616ABEfC4Q_xhaK1hdQ")]
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    public IsoMax35Text? SecurityProfile { get; init; }

    /// <summary>
    /// Hierarchical identification of a key inside all the key system.
    /// </summary>
    [IsoId("_FMs63aABEfC4Q_xhaK1hdQ")]
    [DisplayName("Item Number")]
    [IsoXmlTag("ItmNb")]
    public IsoMax35Text? ItemNumber { get; init; }

    /// <summary>
    /// Sequence number of the cryptographic key.
    /// </summary>
    [IsoId("_apcJIKABEfC4Q_xhaK1hdQ")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_FMs646ABEfC4Q_xhaK1hdQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_8byls7ZwEfCUZfsQO4rYeA")]
    [DisplayName("Key Version")]
    [IsoXmlTag("KeyVrsn")]
    public IsoMax256Text? KeyVersion { get; init; }

    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_FMs66aABEfC4Q_xhaK1hdQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CryptographicKeyType5Code? Type { get; init; }

    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_FMs676ABEfC4Q_xhaK1hdQ")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = [];

    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_FMs69aABEfC4Q_xhaK1hdQ")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    public IsoISODateTime? ActivationDate { get; init; }

    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_FMs6-6ABEfC4Q_xhaK1hdQ")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    public IsoISODateTime? DeactivationDate { get; init; }

    /// <summary>
    /// Encrypted cryptographic key.
    /// </summary>
    [IsoId("_FMs7AaABEfC4Q_xhaK1hdQ")]
    [DisplayName("Key Value")]
    [IsoXmlTag("KeyVal")]
    public ContentInformationType39? KeyValue { get; init; }

    /// <summary>
    /// Identification of components which are allowed to access this cryptographic key.
    /// </summary>
    [IsoId("_FMs7B6ABEfC4Q_xhaK1hdQ")]
    [DisplayName("Component With Authorised Access")]
    [IsoXmlTag("CmpntWthAuthrsdAccs")]
    public ValueList<GenericIdentification186> ComponentWithAuthorisedAccess { get; init; } = [];

    /// <summary>
    /// Protection of identification of components which are allowed to access this cryptographic key.
    /// </summary>
    [IsoId("_FMs7CaABEfC4Q_xhaK1hdQ")]
    [DisplayName("Protected Component With Authorised Access")]
    [IsoXmlTag("PrtctdCmpntWthAuthrsdAccs")]
    public ValueList<ContentInformationType39> ProtectedComponentWithAuthorisedAccess { get; init; } = [];

    /// <summary>
    /// Value for checking a cryptographic key security parameter.
    /// </summary>
    [IsoId("_FMs7C6ABEfC4Q_xhaK1hdQ")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    public IsoMax35Binary? KeyCheckValue { get; init; }

    /// <summary>
    /// Additional Information needed by the receiver to securely process the management of the security element.
    /// </summary>
    [IsoId("_FMs7EaABEfC4Q_xhaK1hdQ")]
    [DisplayName("Additional Management Information")]
    [IsoXmlTag("AddtlMgmtInf")]
    public ValueList<GenericInformation1> AdditionalManagementInformation { get; init; } = [];

    /// <summary>
    /// Identification of the derivation algorithm that must be used.
    /// </summary>
    [IsoId("_FiAm8KACEfC4Q_xhaK1hdQ")]
    [DisplayName("Derivation Algorithm Identifier")]
    [IsoXmlTag("DerivtnAlgoIdr")]
    public IsoMax140Text? DerivationAlgorithmIdentifier { get; init; }

    /// <summary>
    /// Identification of the algorithm and mode that must be used.
    /// </summary>
    [IsoId("_LgEg0KACEfC4Q_xhaK1hdQ")]
    [DisplayName("Algorithm Identifier")]
    [IsoXmlTag("AlgoIdr")]
    public IsoMax140Text? AlgorithmIdentifier { get; init; }
}
