// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the instructions from the bank.
/// </summary>
[IsoId("_-E96onltEeG7BsjMvd1mEw_-1962266357")]
[DisplayName("Bank Instructions")]
public partial record BankInstructions1
{
    #nullable enable
    
    /// <summary>
    /// Instructions from the bank.
    /// </summary>
    [IsoId("_-E96o3ltEeG7BsjMvd1mEw_-327246160")]
    [DisplayName("Text")]
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Text { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Last date for a response to the bank instructions.
    /// </summary>
    [IsoId("_-E96pHltEeG7BsjMvd1mEw_878374168")]
    [DisplayName("Last Date For Response")]
    [IsoXmlTag("LastDtForRspn")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LastDateForResponse { get; init; } 
    
    
    #nullable disable
    
}
