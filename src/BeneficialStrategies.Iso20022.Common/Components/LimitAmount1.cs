// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money characterics used to specify a limit.
/// </summary>
[IsoId("_jORO5O5NEeCisYr99QEiWA_-1135919214")]
[DisplayName("Limit Amount")]
public partial record LimitAmount1
{
    #nullable enable
    
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_jOa_4O5NEeCisYr99QEiWA_-1878638285")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CreditDebitAmount1 Amount { get; init; } 
    
    /// <summary>
    /// Utilised amount of money of the limit expressed in an eligible currency.
    /// </summary>
    [IsoId("_jOa_4e5NEeCisYr99QEiWA_-1682012024")]
    [DisplayName("Utilisation Amount")]
    [IsoXmlTag("UtlstnAmt")]
    public required CreditDebitAmount1 UtilisationAmount { get; init; } 
    
    /// <summary>
    /// Remaining amount of money of the limit expressed in an eligible currency.
    /// </summary>
    [IsoId("_jOa_4u5NEeCisYr99QEiWA_1097770186")]
    [DisplayName("Available Amount")]
    [IsoXmlTag("AvlblAmt")]
    public required CreditDebitAmount1 AvailableAmount { get; init; } 
    
    
    #nullable disable
    
}
