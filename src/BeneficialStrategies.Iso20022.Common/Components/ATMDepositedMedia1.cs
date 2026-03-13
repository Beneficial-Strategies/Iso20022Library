// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposited media put in the safe.
/// </summary>
[IsoId("_jeG9UK4BEeWL1uap3dNhCQ")]
[DisplayName("ATM Deposited Media")]
public partial record ATMDepositedMedia1
{
    #nullable enable
    
    /// <summary>
    /// Link to the account for multi-account deposit.
    /// </summary>
    [IsoId("_tkpvgK4BEeWL1uap3dNhCQ")]
    [DisplayName("Account Sequence Number")]
    [IsoXmlTag("AcctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AccountSequenceNumber { get; init; } 
    
    /// <summary>
    /// Type of deposited media.
    /// </summary>
    [IsoId("_cTRR0K4CEeWL1uap3dNhCQ")]
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public required ATMMediaType2Code MediaType { get; init; } 
    
    /// <summary>
    /// Category of deposited media items.
    /// </summary>
    [IsoId("_1FGMsK4CEeWL1uap3dNhCQ")]
    [DisplayName("Media Category")]
    [IsoXmlTag("MdiaCtgy")]
    public ATMMediaType3Code? MediaCategory { get; init; } 
    
    /// <summary>
    /// Media item that are deposited.
    /// </summary>
    [IsoId("_l3I_UK4DEeWL1uap3dNhCQ")]
    [DisplayName("Media Items")]
    [IsoXmlTag("MdiaItms")]
    public ValueList<ATMDepositedMedia2> MediaItems { get; init; } = [];
    // ID for the above is _l3I_UK4DEeWL1uap3dNhCQ
    
    
    #nullable disable
    
}
