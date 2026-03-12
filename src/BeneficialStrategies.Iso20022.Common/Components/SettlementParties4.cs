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
[IsoId("_SiKYzNp-Ed-ak6NoX_4Aeg_-74170439")]
[DisplayName("Settlement Parties")]
public partial record SettlementParties4
{
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    [IsoId("_SiKYzdp-Ed-ak6NoX_4Aeg_272147056")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public required PartyIdentification35 Depository { get; init; } 
    
    /// <summary>
    /// Party that interacts with the Depository.
    /// </summary>
    [IsoId("_SiKYztp-Ed-ak6NoX_4Aeg_-1338015493")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public required PartyIdentificationAndAccount14 Party1 { get; init; } 
    
    /// <summary>
    /// Party that interacts with the Party1.
    /// </summary>
    [IsoId("_SiKYz9p-Ed-ak6NoX_4Aeg_-1252127887")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount14? Party2 { get; init; } 
    
    /// <summary>
    /// Party that interacts with the Party2.
    /// </summary>
    [IsoId("_SiKY0Np-Ed-ak6NoX_4Aeg_-1010167039")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount14? Party3 { get; init; } 
    
    
    #nullable disable
    
}
