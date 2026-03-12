// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance related details for a portfolio.
/// </summary>
[IsoId("_m91ywPNBEeCuA5Tr22BnwA_934037418")]
[DisplayName("Balance Details")]
public partial record BalanceDetails6
{
    #nullable enable
    
    /// <summary>
    /// Category of the financial asset balance type.
    /// </summary>
    [IsoId("_m91ywfNBEeCuA5Tr22BnwA_889825506")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    public FinancialAssetTypeCategory1Code? Category { get; init; } 
    
    /// <summary>
    /// Balance type.
    /// </summary>
    [IsoId("_m91ywvNBEeCuA5Tr22BnwA_1249881108")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public BalanceType7Choice_? Type { get; init; } 
    
    /// <summary>
    /// Unrealised gain or loss.
    /// </summary>
    [IsoId("_m91yw_NBEeCuA5Tr22BnwA_1569419041")]
    [DisplayName("Unrealised")]
    [IsoXmlTag("Urlsd")]
    public Unrealised1Code? Unrealised { get; init; } 
    
    /// <summary>
    /// Balance amount.
    /// </summary>
    [IsoId("_m91yxPNBEeCuA5Tr22BnwA_-1195789251")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection31 Amount { get; init; } 
    
    
    #nullable disable
    
}
