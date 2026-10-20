// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic Key18.
/// </summary>
[IsoId("_cdiXEZB0Ee6FLLjWp95ntQ")]
[DisplayName("Cryptographic Key18")]
public partial record CryptographicKey18
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required Max350Text Identification { get; init; }

    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public Max35Binary? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public Max256Text? Name { get; init; }

    /// <summary>
    /// Security Profile.
    /// </summary>
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    public Max35Text? SecurityProfile { get; init; }

    /// <summary>
    /// Item Number.
    /// </summary>
    [DisplayName("Item Number")]
    [IsoXmlTag("ItmNb")]
    public Max35Text? ItemNumber { get; init; }

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required Max256Text Version { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CryptographicKeyType3Code? Type { get; init; }

    /// <summary>
    /// Function.
    /// </summary>
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public ValueList<KeyUsage1Code> Function { get; init; } = [];

    /// <summary>
    /// Activation Date.
    /// </summary>
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    public ISODateTime? ActivationDate { get; init; }

    /// <summary>
    /// Deactivation Date.
    /// </summary>
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    public ISODateTime? DeactivationDate { get; init; }

    /// <summary>
    /// Key Value.
    /// </summary>
    [DisplayName("Key Value")]
    [IsoXmlTag("KeyVal")]
    public ContentInformationType39? KeyValue { get; init; }

    /// <summary>
    /// Component With Authorised Access.
    /// </summary>
    [DisplayName("Component With Authorised Access")]
    [IsoXmlTag("CmpntWthAuthrsdAccs")]
    public ValueList<GenericIdentification186> ComponentWithAuthorisedAccess { get; init; } = [];

    /// <summary>
    /// Protected Component With Authorised Access.
    /// </summary>
    [DisplayName("Protected Component With Authorised Access")]
    [IsoXmlTag("PrtctdCmpntWthAuthrsdAccs")]
    public ValueList<ContentInformationType39> ProtectedComponentWithAuthorisedAccess { get; init; } =
        [];

    /// <summary>
    /// Key Check Value.
    /// </summary>
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    public Max35Binary? KeyCheckValue { get; init; }

    /// <summary>
    /// Additional Management Information.
    /// </summary>
    [DisplayName("Additional Management Information")]
    [IsoXmlTag("AddtlMgmtInf")]
    public ValueList<GenericInformation1> AdditionalManagementInformation { get; init; } = [];
}
