// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Parties126.
/// </summary>
[IsoId("_s0KP4YotEe-efPejSUAtLw")]
[DisplayName("Settlement Parties126")]
public partial record SettlementParties126
{
    #nullable enable

    /// <summary>
    /// Depository.
    /// </summary>
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification315? Depository { get; init; } 

    /// <summary>
    /// Party1.
    /// </summary>
    [DisplayName("Party1")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount196? Party1 { get; init; } 

    /// <summary>
    /// Party2.
    /// </summary>
    [DisplayName("Party2")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount196? Party2 { get; init; } 

    /// <summary>
    /// Party3.
    /// </summary>
    [DisplayName("Party3")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount196? Party3 { get; init; } 

    /// <summary>
    /// Party4.
    /// </summary>
    [DisplayName("Party4")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount196? Party4 { get; init; } 

    /// <summary>
    /// Party5.
    /// </summary>
    [DisplayName("Party5")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount196? Party5 { get; init; } 

    
    #nullable disable
    
}
