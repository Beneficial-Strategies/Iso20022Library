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
[IsoId("_1OBykan9EemdLtwzt4CWxg")]
[DisplayName("Financial Party Classification")]
public partial record FinancialPartyClassification1
{
    #nullable enable
    
    /// <summary>
    /// Classification of the business activities of the reporting counterparty.
    /// </summary>
    [IsoId("_1VoPYan9EemdLtwzt4CWxg")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public SimpleValueList<FinancialPartySectorType2Code> Classification { get; init; } = new SimpleValueList<FinancialPartySectorType2Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _1VoPYan9EemdLtwzt4CWxg
    
    /// <summary>
    /// Nature business activities of the reporting counterparty as an investment fund.
    /// </summary>
    [IsoId("_1VoPY6n9EemdLtwzt4CWxg")]
    [DisplayName("Investment Fund Classification")]
    [IsoXmlTag("InvstmtFndClssfctn")]
    public FundType2Code? InvestmentFundClassification { get; init; } 
    
    
    #nullable disable
    
}
