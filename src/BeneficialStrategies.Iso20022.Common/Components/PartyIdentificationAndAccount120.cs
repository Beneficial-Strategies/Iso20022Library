// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification and account of the party.
/// </summary>
[IsoId("_0PDgOEHTEeW-Sp6UI3iOQA")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount120
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [IsoId("_0PDgOUHTEeW-Sp6UI3iOQA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification71Choice_ Identification { get; init; }

    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_0PDgQkHTEeW-Sp6UI3iOQA")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_0PDgS0HTEeW-Sp6UI3iOQA")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_0PDgR0HTEeW-Sp6UI3iOQA")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; }
}
