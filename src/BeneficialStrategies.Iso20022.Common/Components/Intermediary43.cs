// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_VT_kAW1NEeiqaPNRWUnGNA")]
[DisplayName("Intermediary")]
public record Intermediary43
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_Vl2JA21NEeiqaPNRWUnGNA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification139 Identification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Vl2JBW1NEeiqaPNRWUnGNA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account27? Account { get; init; }

    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_Vl2JB21NEeiqaPNRWUnGNA")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role4Choice_? Role { get; init; }

    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [IsoId("_Vl2JCW1NEeiqaPNRWUnGNA")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; }
}
