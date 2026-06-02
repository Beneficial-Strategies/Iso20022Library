// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic Key component.
/// </summary>
[IsoId("_SLAxkbZ5EfCUZfsQO4rYeA")]
[DisplayName("Cryptographic Key20")]
public record CryptographicKey20
{
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [IsoId("_SMEhhbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_SMEhi7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax140Text? Identification { get; init; }

    /// <summary>
    /// Identification of the security domain.
    /// </summary>
    [IsoId("_SMEhkbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Security Domain Identification")]
    [IsoXmlTag("SctyDomnId")]
    public IsoMax35Text? SecurityDomainIdentification { get; init; }

    /// <summary>
    /// Additional identification of the key, for instance to derive the key.
    /// </summary>
    [IsoId("_SMEhl7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public IsoMax35Binary? AdditionalIdentification { get; init; }

    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_SMEhnbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Sequence counter of the cryptographic key.
    /// </summary>
    [IsoId("_SMEho7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public IsoNumber? SequenceCounter { get; init; }

    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_SMEhqbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CryptographicKeyType5Code Type { get; init; }

    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_SMEhr7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    [MinLength(1)]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = [];

    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_SMEhtbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    public IsoISODateTime? ActivationDate { get; init; }

    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_SMEhu7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    public IsoISODateTime? DeactivationDate { get; init; }

    /// <summary>
    /// Value for checking a cryptographic key.
    /// </summary>
    [IsoId("_SMEhwbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    public IsoMax35Binary? KeyCheckValue { get; init; }

    /// <summary>
    /// Current status of the key.
    /// </summary>
    [IsoId("_SMEhx7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required ATMStatus3Code CurrentStatus { get; init; }

    /// <summary>
    /// Reason for which the key has been stopped.
    /// </summary>
    [IsoId("_SMEhzbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public FailureReason6Code? FailureReason { get; init; }
}
