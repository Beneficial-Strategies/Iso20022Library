// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates to the issuer the level of risk of the transaction.
/// </summary>
[IsoId("_lnDF4HsKEeSR68OJvMfxJQ")]
[DisplayName("Card Transaction Risk Indicator")]
public partial record CardTransactionRiskIndicator1
{
    #nullable enable
    
    /// <summary>
    /// Reason to indicate a certain level of risk for the transaction.
    /// </summary>
    [IsoId("_BJYHkHsNEeSR68OJvMfxJQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CardTransactionRiskReason1Code? Reason { get; init; } 
    
    /// <summary>
    /// Level of risk, from 1 to 99.
    /// </summary>
    [IsoId("_NUeygHsNEeSR68OJvMfxJQ")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Level { get; init; } 
    
    /// <summary>
    /// Recommended action for the issuer.
    /// </summary>
    [IsoId("_4l1jwHsNEeSR68OJvMfxJQ")]
    [DisplayName("Recommended Action")]
    [IsoXmlTag("RcmmnddActn")]
    public ActionType4Code? RecommendedAction { get; init; } 
    
    
    #nullable disable
    
}
