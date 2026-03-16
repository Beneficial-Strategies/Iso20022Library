// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer9.
/// </summary>
[IsoId("_xGQgIXQ8Ee6Y1uOeeiF_Eg")]
[DisplayName("Customer9")]
public partial record Customer9
{
    #nullable enable

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 

    /// <summary>
    /// Age.
    /// </summary>
    [DisplayName("Age")]
    [IsoXmlTag("Age")]
    public IsoMax2NumericText? Age { get; init; } 

    /// <summary>
    /// Contact.
    /// </summary>
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal1? Contact { get; init; } 

    /// <summary>
    /// Customer File Reference Number.
    /// </summary>
    [DisplayName("Customer File Reference Number")]
    [IsoXmlTag("CstmrFileRefNb")]
    public IsoMax70Text? CustomerFileReferenceNumber { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Credentials3? Identification { get; init; } 

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; } 

    
    #nullable disable
    
}
