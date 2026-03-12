// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the classification of a financial institution.
/// </summary>
[IsoId("_0lQ2EbHXEemRPNDOvJwndA")]
[DisplayName("Financial Party Classification")]
public partial record FinancialPartyClassification2
{
    #nullable enable
    
    /// <summary>
    /// Classification of the business activities of the reporting counterparty.
    /// </summary>
    [IsoId("_0uXHsbHXEemRPNDOvJwndA")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
    public SimpleValueList<System.String> Classification { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _0uXHsbHXEemRPNDOvJwndA
    
    /// <summary>
    /// Nature business activities of the reporting counterparty as an investment fund.
    /// </summary>
    [IsoId("_0ugRobHXEemRPNDOvJwndA")]
    [DisplayName("Investment Fund Classification")]
    [IsoXmlTag("InvstmtFndClssfctn")]
    public FundType2Code? InvestmentFundClassification { get; init; } 
    
    
    #nullable disable
    
}
