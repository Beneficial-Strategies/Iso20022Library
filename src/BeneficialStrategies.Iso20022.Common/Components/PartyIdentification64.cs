// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_Qu04IUiQEeOdL6nMHefDgg")]
[DisplayName("Party Identification")]
public record PartyIdentification64
{
    /// <summary>
    /// Identification of the party expressed as a BIC.
    /// </summary>
    [IsoId("_Q9tBo0iQEeOdL6nMHefDgg")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? AnyBIC { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier, as assigned to the party using a proprietary identification scheme.
    /// </summary>
    [IsoId("_Q9tBpUiQEeOdL6nMHefDgg")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification1? ProprietaryIdentification { get; init; }

    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_Q9tBp0iQEeOdL6nMHefDgg")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress5? NameAndAddress { get; init; }
}
