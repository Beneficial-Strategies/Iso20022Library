// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies settlement parties (delivering/receiving).
/// </summary>
[IsoId("_corOAfpNEeCLrd06h-p51g")]
[DisplayName("Settlement Parties")]
public partial record SettlementParties24
{
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    [IsoId("_co0_DfpNEeCLrd06h-p51g")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification47? Depository { get; init; } 
    
    /// <summary>
    /// Party that interacts with the depository.
    /// </summary>
    [IsoId("_co0_F_pNEeCLrd06h-p51g")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount51? Party1 { get; init; } 
    
    /// <summary>
    /// Party that interacts with the party1.
    /// </summary>
    [IsoId("_co0_IfpNEeCLrd06h-p51g")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount51? Party2 { get; init; } 
    
    /// <summary>
    /// Party that interacts with the party2.
    /// </summary>
    [IsoId("_co0_PfpNEeCLrd06h-p51g")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount51? Party3 { get; init; } 
    
    
    #nullable disable
    
}
