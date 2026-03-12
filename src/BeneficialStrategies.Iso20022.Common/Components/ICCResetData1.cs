// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data of a Chip Card related to the reset of the chip.
/// </summary>
[IsoId("_SNfVUN7IEeiwsev40qZGEQ")]
[DisplayName("ICC Reset Data")]
public partial record ICCResetData1
{
    #nullable enable
    
    /// <summary>
    /// Value of the Answer To Reset of a chip card.
    /// </summary>
    [IsoId("_ZUB6MN7IEeiwsev40qZGEQ")]
    [DisplayName("ATR Value")]
    [IsoXmlTag("ATRVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ATRValue { get; init; } 
    
    /// <summary>
    /// Status of a smartcard response to a command (SW1-SW2).
    /// </summary>
    [IsoId("_dbA9sN7IEeiwsev40qZGEQ")]
    [DisplayName("Card Status")]
    [IsoXmlTag("CardSts")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? CardStatus { get; init; } 
    
    
    #nullable disable
    
}
