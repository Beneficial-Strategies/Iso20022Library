// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification assignment.
/// </summary>
[IsoId("_tpGiYVkyEeGeoaLUQk__nA_757109061")]
[DisplayName("Identification Assignment")]
public record IdentificationAssignment2
{
    /// <summary>
    /// Point to point reference, as assigned by the assigner, and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The assigner has to make sure that MessageIdentification is unique per assignee for a pre-agreed period.
    /// </summary>
    [IsoId("_tpGiYlkyEeGeoaLUQk__nA_-239963292")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the identification assignment was created.
    /// </summary>
    [IsoId("_tpGiY1kyEeGeoaLUQk__nA_-1350874711")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Party that created the identification assignment.
    /// </summary>
    [IsoId("_tpGiZFkyEeGeoaLUQk__nA_1013268714")]
    [DisplayName("Creator")]
    [IsoXmlTag("Cretr")]
    public Party12Choice_? Creator { get; init; }

    /// <summary>
    /// Identifies the first agent in the identification chain, following the payment initiating party.
    /// </summary>
    [IsoId("_tpQTYFkyEeGeoaLUQk__nA_-597652062")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public BranchAndFinancialInstitutionIdentification5? FirstAgent { get; init; }

    /// <summary>
    /// Party that assigns the identification assignment to another party. This is also the sender of the message.
    /// </summary>
    [IsoId("_tpQTYVkyEeGeoaLUQk__nA_-1094715058")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party12Choice_ Assigner { get; init; }

    /// <summary>
    /// Party that the identification assignment is assigned to. This is also the receiver of the message.
    /// </summary>
    [IsoId("_tpQTYlkyEeGeoaLUQk__nA_322874245")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party12Choice_ Assignee { get; init; }
}
