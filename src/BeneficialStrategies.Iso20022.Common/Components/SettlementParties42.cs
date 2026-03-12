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
[IsoId("_N16I30GLEeWqy4niLuXETA")]
[DisplayName("Settlement Parties")]
public partial record SettlementParties42
{
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    [IsoId("_OECrV0GLEeWqy4niLuXETA")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification92? Depository { get; init; } 
    
    /// <summary>
    /// Party that interacts with the depository.
    /// </summary>
    [IsoId("_OECrX0GLEeWqy4niLuXETA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount122? Party1 { get; init; } 
    
    /// <summary>
    /// Party that interacts with the party1.
    /// </summary>
    [IsoId("_OECrZ0GLEeWqy4niLuXETA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount122? Party2 { get; init; } 
    
    /// <summary>
    /// Party that interacts with the party2.
    /// </summary>
    [IsoId("_OECrgUGLEeWqy4niLuXETA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount122? Party3 { get; init; } 
    
    
    #nullable disable
    
}
