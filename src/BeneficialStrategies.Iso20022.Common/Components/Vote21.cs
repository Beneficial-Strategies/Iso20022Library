// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote expressed for one resolution.
/// </summary>
[IsoId("_oNDrkajHEfCzuLlmLrhIvA")]
[DisplayName("Vote21")]
public record Vote21
{
    [IsoId("_oW4V8ajHEfCzuLlmLrhIvA")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    public required IsoMax35Text IssuerLabel { get; init; }

    [IsoId("_oW4V86jHEfCzuLlmLrhIvA")]
    [DisplayName("Listing Group Resolution Label")]
    [IsoXmlTag("ListgGrpRsltnLabl")]
    public IsoMax35Text? ListingGroupResolutionLabel { get; init; }

    [IsoId("_oW4V9ajHEfCzuLlmLrhIvA")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    public QuantityOrCode1Choice? For { get; init; }

    [IsoId("_oW4V96jHEfCzuLlmLrhIvA")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    public QuantityOrCode1Choice? Against { get; init; }

    [IsoId("_oW4V-ajHEfCzuLlmLrhIvA")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    public QuantityOrCode1Choice? Abstain { get; init; }

    [IsoId("_oW4V-6jHEfCzuLlmLrhIvA")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    public QuantityOrCode1Choice? Withhold { get; init; }

    [IsoId("_oW4V_ajHEfCzuLlmLrhIvA")]
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    public QuantityOrCode1Choice? WithManagement { get; init; }

    [IsoId("_oW4V_6jHEfCzuLlmLrhIvA")]
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    public QuantityOrCode1Choice? AgainstManagement { get; init; }

    [IsoId("_oW4WAajHEfCzuLlmLrhIvA")]
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    public QuantityOrCode1Choice? Discretionary { get; init; }

    [IsoId("_oW4WA6jHEfCzuLlmLrhIvA")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    public QuantityOrCode1Choice? OneYear { get; init; }

    [IsoId("_oW4WBajHEfCzuLlmLrhIvA")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    public QuantityOrCode1Choice? TwoYears { get; init; }

    [IsoId("_oW4WB6jHEfCzuLlmLrhIvA")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    public QuantityOrCode1Choice? ThreeYears { get; init; }

    [IsoId("_oW4WCajHEfCzuLlmLrhIvA")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    public QuantityOrCode1Choice? NoAction { get; init; }

    [IsoId("_oW4WC6jHEfCzuLlmLrhIvA")]
    [DisplayName("Blank")]
    [IsoXmlTag("Blnk")]
    public QuantityOrCode1Choice? Blank { get; init; }

    [IsoId("_oW4WDajHEfCzuLlmLrhIvA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryVote1> Proprietary { get; init; } = [];
}
