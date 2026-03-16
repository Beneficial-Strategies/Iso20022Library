// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Delivering Parties And Account21.
/// </summary>
[IsoId("_3SHE_ZIOEe-HRNGM304Vlw")]
[DisplayName("Delivering Parties And Account21")]
public partial record DeliveringPartiesAndAccount21
{
    #nullable enable

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
    public required PartyIdentificationAndAccount228 Party1 { get; init; } 

    /// <summary>
    /// Party2.
    /// </summary>
    [DisplayName("Party2")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount228? Party2 { get; init; } 

    /// <summary>
    /// Securities Settlement System.
    /// </summary>
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 

    
    #nullable disable
    
}
