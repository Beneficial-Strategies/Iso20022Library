// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the clearing of the contract.
/// </summary>
[IsoId("_IeSj4ZQQEeiok48Eh9lW9Q")]
[DisplayName("Trade Clearing")]
public partial record TradeClearing3
{
    #nullable enable
    
    /// <summary>
    /// Indicates, whether the reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation and both counterparties to the contract are subject to the clearing obligation, as of the time of execution of the contract.
    /// </summary>
    [IsoId("_Iodzk5QQEeiok48Eh9lW9Q")]
    [DisplayName("Clearing Obligation")]
    [IsoXmlTag("ClrOblgtn")]
    public ClearingObligationType1Code? ClearingObligation { get; init; } 
    
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_IodzlZQQEeiok48Eh9lW9Q")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public Cleared9Choice_? ClearingStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the contract was entered into as an intragroup transaction.
    /// Usage: When absent, default value is false.
    /// </summary>
    [IsoId("_Iodzl5QQEeiok48Eh9lW9Q")]
    [DisplayName("Intra Group")]
    [IsoXmlTag("IntraGrp")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? IntraGroup { get; init; } 
    
    
    #nullable disable
    
}
