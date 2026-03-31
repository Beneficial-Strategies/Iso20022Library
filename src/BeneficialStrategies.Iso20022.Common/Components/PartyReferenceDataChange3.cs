// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Reference Data Change3.
/// </summary>
[IsoId("_Y4YjZTE_Ee62xuUQ2zyZww")]
[DisplayName("Party Reference Data Change3")]
public record PartyReferenceDataChange3
{
    /// <summary>
    /// Operation Time Stamp.
    /// </summary>
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    public required IsoISODateTime OperationTimeStamp { get; init; }

    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification8 PartyIdentification { get; init; }

    /// <summary>
    /// Record.
    /// </summary>
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<UpdateLogPartyRecord2Choice_> Record { get; init; } = [];
}
