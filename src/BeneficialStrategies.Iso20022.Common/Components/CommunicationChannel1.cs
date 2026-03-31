// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication channel information.
/// </summary>
[IsoId("_9yCXl3ltEeG7BsjMvd1mEw_167324952")]
[DisplayName("Communication Channel")]
public record CommunicationChannel1
{
    /// <summary>
    /// Method by which the original undertaking or proposed amendment is to be made available.
    /// </summary>
    [IsoId("_QEJog38KEeGvEbxvurqpIg")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required ExternalChannel1Code Method { get; init; }

    /// <summary>
    /// Type of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    [IsoId("_9yCXmXltEeG7BsjMvd1mEw_-988253345")]
    [DisplayName("Deliver To Party Type")]
    [IsoXmlTag("DlvrToPtyTp")]
    public required PartyType1Choice_ DeliverToPartyType { get; init; }

    /// <summary>
    /// Name of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    [IsoId("_9yMIkHltEeG7BsjMvd1mEw_493546087")]
    [DisplayName("Deliver To Name")]
    [IsoXmlTag("DlvrToNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? DeliverToName { get; init; }

    /// <summary>
    /// Address of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    [IsoId("_9yMIkXltEeG7BsjMvd1mEw_-657472540")]
    [DisplayName("Deliver To Address")]
    [IsoXmlTag("DlvrToAdr")]
    public PostalAddress6? DeliverToAddress { get; init; }
}
