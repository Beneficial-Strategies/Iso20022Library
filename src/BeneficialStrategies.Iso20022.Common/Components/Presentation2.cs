// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the presentation of documents.
/// </summary>
[IsoId("_97bkJnltEeG7BsjMvd1mEw_1224258578")]
[DisplayName("Presentation")]
public record Presentation2
{
    /// <summary>
    /// Party, other than beneficiary, forwarding the documents.
    /// </summary>
    [IsoId("_97kuEHltEeG7BsjMvd1mEw_2057434773")]
    [DisplayName("Presenter")]
    [IsoXmlTag("Presntr")]
    public PartyIdentification43? Presenter { get; init; }

    /// <summary>
    /// Date on which the beneficiary presented the demand.
    /// </summary>
    [IsoId("_97kuEXltEeG7BsjMvd1mEw_-177176006")]
    [DisplayName("Beneficiary Presentation Date")]
    [IsoXmlTag("BnfcryPresntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BeneficiaryPresentationDate { get; init; }
}
