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
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_oW4V8ajHEfCzuLlmLrhIvA")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Identifies under the same label a group of agenda resolutions for which a vote in favour can be assigned to only one resolution of that group.
    /// </summary>
    [IsoId("_oW4V86jHEfCzuLlmLrhIvA")]
    [DisplayName("Listing Group Resolution Label")]
    [IsoXmlTag("ListgGrpRsltnLabl")]
    public IsoMax35Text? ListingGroupResolutionLabel { get; init; }

    /// <summary>
    /// Number of securities for which vote in favour is instructed.
    /// </summary>
    [IsoId("_oW4V9ajHEfCzuLlmLrhIvA")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    public QuantityOrCode1Choice_? For { get; init; }

    /// <summary>
    /// Number of securities for which vote against is instructed.
    /// </summary>
    [IsoId("_oW4V96jHEfCzuLlmLrhIvA")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    public QuantityOrCode1Choice_? Against { get; init; }

    /// <summary>
    /// Number of securities for which vote to abstain is instructed.
    /// </summary>
    [IsoId("_oW4V-ajHEfCzuLlmLrhIvA")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    public QuantityOrCode1Choice_? Abstain { get; init; }

    /// <summary>
    /// Number of securities for which vote to withhold is instructed.
    /// </summary>
    [IsoId("_oW4V-6jHEfCzuLlmLrhIvA")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    public QuantityOrCode1Choice_? Withhold { get; init; }

    /// <summary>
    /// Number of securities for which vote in line with the votes of the management is instructed.
    /// </summary>
    [IsoId("_oW4V_ajHEfCzuLlmLrhIvA")]
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    public QuantityOrCode1Choice_? WithManagement { get; init; }

    /// <summary>
    /// Number of securities for which vote against the voting recommendation of the management is instructed.
    /// </summary>
    [IsoId("_oW4V_6jHEfCzuLlmLrhIvA")]
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    public QuantityOrCode1Choice_? AgainstManagement { get; init; }

    /// <summary>
    /// Number of securities for which decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_oW4WAajHEfCzuLlmLrhIvA")]
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    public QuantityOrCode1Choice_? Discretionary { get; init; }

    /// <summary>
    /// Number of securities for which vote in favour for one year for "say on pay" type of resolution is instructed.
    /// </summary>
    [IsoId("_oW4WA6jHEfCzuLlmLrhIvA")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    public QuantityOrCode1Choice_? OneYear { get; init; }

    /// <summary>
    /// Number of securities for which vote in favour of two years for "say on pay" type of resolution is instructed.
    /// </summary>
    [IsoId("_oW4WBajHEfCzuLlmLrhIvA")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    public QuantityOrCode1Choice_? TwoYears { get; init; }

    /// <summary>
    /// Number of securities for which vote in favour of three years for "say on pay" type of resolution is instructed.
    /// </summary>
    [IsoId("_oW4WB6jHEfCzuLlmLrhIvA")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    public QuantityOrCode1Choice_? ThreeYears { get; init; }

    /// <summary>
    /// Do not vote.
    /// </summary>
    [IsoId("_oW4WCajHEfCzuLlmLrhIvA")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    public QuantityOrCode1Choice_? NoAction { get; init; }

    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    [IsoId("_oW4WC6jHEfCzuLlmLrhIvA")]
    [DisplayName("Blank")]
    [IsoXmlTag("Blnk")]
    public QuantityOrCode1Choice_? Blank { get; init; }

    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_oW4WDajHEfCzuLlmLrhIvA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryVote1> Proprietary { get; init; } = [];
}
