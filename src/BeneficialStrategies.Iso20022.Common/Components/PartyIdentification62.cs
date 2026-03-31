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
[IsoId("_tclvZToyEeOr__K5A0LSog")]
[DisplayName("Party Identification")]
public record PartyIdentification62
{
    /// <summary>
    /// Identification of the financial institution expressed as a BIC.
    /// </summary>
    [IsoId("_tclvaToyEeOr__K5A0LSog")]
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public IsoBICFIIdentifier? BICFI { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_tclvZzoyEeOr__K5A0LSog")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification1? ProprietaryIdentification { get; init; }

    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_tclvaDoyEeOr__K5A0LSog")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress5? NameAndAddress { get; init; }
}
