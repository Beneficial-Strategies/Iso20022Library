// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer9.
/// </summary>
[IsoId("_xGQgIXQ8Ee6Y1uOeeiF_Eg")]
[DisplayName("Customer9")]
public partial record Customer9
{
    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public Max70Text? Name { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Credentials3? Identification { get; init; }

    /// <summary>
    /// Customer File Reference Number.
    /// </summary>
    [DisplayName("Customer File Reference Number")]
    [IsoXmlTag("CstmrFileRefNb")]
    public Max70Text? CustomerFileReferenceNumber { get; init; }

    /// <summary>
    /// Age.
    /// </summary>
    [DisplayName("Age")]
    [IsoXmlTag("Age")]
    public Max2NumericText? Age { get; init; }

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Contact.
    /// </summary>
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal1? Contact { get; init; }
}
