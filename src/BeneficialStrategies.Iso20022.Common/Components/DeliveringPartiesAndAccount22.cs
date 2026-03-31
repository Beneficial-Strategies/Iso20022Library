// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Delivering Parties And Account22.
/// </summary>
[IsoId("_3o6bbZIOEe-HRNGM304Vlw")]
[DisplayName("Delivering Parties And Account22")]
public record DeliveringPartiesAndAccount22
{
    /// <summary>
    /// Depository.
    /// </summary>
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public required PartyIdentification255Choice_ Depository { get; init; }

    /// <summary>
    /// Party1.
    /// </summary>
    [DisplayName("Party1")]
    [IsoXmlTag("Pty1")]
    public required PartyIdentificationAndAccount229 Party1 { get; init; }

    /// <summary>
    /// Party2.
    /// </summary>
    [DisplayName("Party2")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount229? Party2 { get; init; }

    /// <summary>
    /// Securities Settlement System.
    /// </summary>
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; }
}
