// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the summation of the call amounts per margin type and optionaly the default fund amount (only for CCP).
/// </summary>
[IsoId("_9b69MKMPEeCojJW5vEuTEQ_2035479962")]
[DisplayName("Margin Call Result")]
public partial record MarginCallResult3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the total amount required by the clearing member to participate to the default fund.
    /// </summary>
    [IsoId("_9b69MaMPEeCojJW5vEuTEQ_-1627281393")]
    [DisplayName("Default Fund Amount")]
    [IsoXmlTag("DfltFndAmt")]
    public ActiveCurrencyAndAmount? DefaultFundAmount { get; init; } 
    
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin and the segregated independent amount or the segregated independent amount only or the total margin call amount only.
    /// </summary>
    [IsoId("_9b69MqMPEeCojJW5vEuTEQ_-118727081")]
    [DisplayName("Margin Call Result")]
    [IsoXmlTag("MrgnCallRslt")]
    public required MarginCallResult2Choice_ MarginCallResult { get; init; } 
    
    
    #nullable disable
    
}
