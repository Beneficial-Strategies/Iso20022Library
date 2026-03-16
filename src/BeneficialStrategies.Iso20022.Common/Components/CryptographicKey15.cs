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
[IsoId("_4i_F4S8hEeu125Ip9zFcsQ")]
[DisplayName("Cryptographic Key")]
public record CryptographicKey15
{
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_4y6YQS8hEeu125Ip9zFcsQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Identification { get; init; }

    /// <summary>
    /// Additional identification of the key.
    /// Usage
    /// For derived unique key per transaction (DUKPT) keys, the key serial number (KSN) with the 21 bits of the transaction counter set to zero.
    /// </summary>
    [IsoId("_4y6YQy8hEeu125Ip9zFcsQ")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name of the Cryptographic Element.
    /// </summary>
    [IsoId("_4y6YRS8hEeu125Ip9zFcsQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Name { get; init; }

    /// <summary>
    /// Identification of the set of security elements to which this element belongs.
    /// </summary>
    [IsoId("_4y6YRy8hEeu125Ip9zFcsQ")]
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecurityProfile { get; init; }

    /// <summary>
    /// Hierarchical identification of a key inside all the key system. It is composed of all item numbers of the upper level components, separated by the &apos;.&apos; character, ended by the item number of the current component.
    /// </summary>
    [IsoId("_4y6YSS8hEeu125Ip9zFcsQ")]
    [DisplayName("Item Number")]
    [IsoXmlTag("ItmNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ItemNumber { get; init; }

    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_4y6YSy8hEeu125Ip9zFcsQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_4y6YTS8hEeu125Ip9zFcsQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CryptographicKeyType3Code? Type { get; init; }

    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_4y6YTy8hEeu125Ip9zFcsQ")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public KeyUsage1Code? Function { get; init; }

    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_4y6YUS8hEeu125Ip9zFcsQ")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActivationDate { get; init; }

    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_4y6YUy8hEeu125Ip9zFcsQ")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeactivationDate { get; init; }

    /// <summary>
    /// Encrypted cryptographic key.
    /// </summary>
    [IsoId("_4y6YVS8hEeu125Ip9zFcsQ")]
    [DisplayName("Key Value")]
    [IsoXmlTag("KeyVal")]
    public ContentInformationType26? KeyValue { get; init; }

    /// <summary>
    /// Value for checking a cryptographic key security parameter.
    /// </summary>
    [IsoId("_4y6YVy8hEeu125Ip9zFcsQ")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? KeyCheckValue { get; init; }

    /// <summary>
    /// Additional Information needed by the receiver to securely process the management of the security element.
    /// </summary>
    [IsoId("_4y6YWS8hEeu125Ip9zFcsQ")]
    [DisplayName("Additional Management Information")]
    [IsoXmlTag("AddtlMgmtInf")]
    public GenericInformation1? AdditionalManagementInformation { get; init; }
}
