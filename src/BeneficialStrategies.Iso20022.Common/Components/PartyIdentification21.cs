// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party involved in the settlement chain.
/// </summary>
[IsoId("_PbrI8Np-Ed-ak6NoX_4Aeg_720823281")]
[DisplayName("Party Identification")]
public record PartyIdentification21
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_PbrI8dp-Ed-ak6NoX_4Aeg_720823298")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification2Choice_ PartyIdentification { get; init; }

    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    [IsoId("_PbrI8tp-Ed-ak6NoX_4Aeg_721744072")]
    [DisplayName("Processing Reference")]
    [IsoXmlTag("PrcgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingReference { get; init; }

    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    [IsoId("_PbrI89p-Ed-ak6NoX_4Aeg_721744107")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeChoice_? ProcessingDate { get; init; }

    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [IsoId("_PbrI9Np-Ed-ak6NoX_4Aeg_876895474")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; }
}
