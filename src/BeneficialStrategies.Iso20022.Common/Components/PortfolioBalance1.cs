// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance breakdown information.
/// </summary>
[IsoId("_m9_jwPNBEeCuA5Tr22BnwA_-274650344")]
[DisplayName("Portfolio Balance")]
public partial record PortfolioBalance1
{
    #nullable enable
    
    /// <summary>
    /// Summary balance information.
    /// </summary>
    [IsoId("_m9_jwfNBEeCuA5Tr22BnwA_1134139495")]
    [DisplayName("Summary Balance")]
    [IsoXmlTag("SummryBal")]
    public ValueList<BalanceDetails5> SummaryBalance { get; init; } = [];
    // ID for the above is _m9_jwfNBEeCuA5Tr22BnwA_1134139495
    
    /// <summary>
    /// Detailed balance information.
    /// </summary>
    [IsoId("_m9_jwvNBEeCuA5Tr22BnwA_432347507")]
    [DisplayName("Detailed Balance")]
    [IsoXmlTag("DtldBal")]
    public ValueList<BalanceDetails6> DetailedBalance { get; init; } = [];
    // ID for the above is _m9_jwvNBEeCuA5Tr22BnwA_432347507
    
    
    #nullable disable
    
}
