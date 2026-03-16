// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Deposited Media4.
/// </summary>
[IsoId("_hdxhIZ9PEe-nbM0aSPcoiQ")]
[DisplayName("ATM Deposited Media4")]
public partial record ATMDepositedMedia4
{
    #nullable enable

    /// <summary>
    /// Account Sequence Number.
    /// </summary>
    [DisplayName("Account Sequence Number")]
    [IsoXmlTag("AcctSeqNb")]
    public IsoNumber? AccountSequenceNumber { get; init; } 

    /// <summary>
    /// Media Category.
    /// </summary>
    [DisplayName("Media Category")]
    [IsoXmlTag("MdiaCtgy")]
    public ATMMediaType3Code? MediaCategory { get; init; } 

    /// <summary>
    /// Media Item.
    /// </summary>
    [DisplayName("Media Item")]
    [IsoXmlTag("MdiaItm")]
    public ValueList<ATMDepositedMediaItem1> MediaItem { get; init; } = [];

    /// <summary>
    /// Media Type.
    /// </summary>
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public required ATMMediaType4Code MediaType { get; init; } 

    
    #nullable disable
    
}
