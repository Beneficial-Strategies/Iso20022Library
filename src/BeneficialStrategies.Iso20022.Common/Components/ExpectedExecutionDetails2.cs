// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Expected trade date and expected settlement date of the order execution.
/// </summary>
[IsoId("_R6914Np-Ed-ak6NoX_4Aeg_1060526305")]
[DisplayName("Expected Execution Details")]
public partial record ExpectedExecutionDetails2
{
    #nullable enable
    
    /// <summary>
    /// Expected date or expected date and time at which a price will be applied according to the terms of the prospectus.
    /// </summary>
    [IsoId("_R6914dp-Ed-ak6NoX_4Aeg_1060526331")]
    [DisplayName("Expected Trade Date Time")]
    [IsoXmlTag("XpctdTradDtTm")]
    public DateAndDateTimeChoice_? ExpectedTradeDateTime { get; init; } 
    
    /// <summary>
    /// Expected date at which the financial instruments will be exchanged against cash.
    /// </summary>
    [IsoId("_R6914tp-Ed-ak6NoX_4Aeg_1060526347")]
    [DisplayName("Expected Cash Settlement Date")]
    [IsoXmlTag("XpctdCshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedCashSettlementDate { get; init; } 
    
    
    #nullable disable
    
}
