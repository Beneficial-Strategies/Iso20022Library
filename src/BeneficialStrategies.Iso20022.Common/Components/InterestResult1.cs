// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Consideration, such as amount of money, paid or received in exchange for an amount of money that has been invested, loaned or borrowed for a certain period.
/// </summary>
[IsoId("_SQuqh9p-Ed-ak6NoX_4Aeg_1199217791")]
[DisplayName("Interest Result")]
public partial record InterestResult1
{
    #nullable enable
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SQuqiNp-Ed-ak6NoX_4Aeg_522608502")]
    [DisplayName("Interest Due To A")]
    [IsoXmlTag("IntrstDueToA")]
    public ActiveCurrencyAndAmount? InterestDueToA { get; init; } 
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SQuqidp-Ed-ak6NoX_4Aeg_-1725036483")]
    [DisplayName("Interest Due To B")]
    [IsoXmlTag("IntrstDueToB")]
    public ActiveCurrencyAndAmount? InterestDueToB { get; init; } 
    
    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    [IsoId("_SQ30cNp-Ed-ak6NoX_4Aeg_-608633204")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    [IsoId("_SQ30cdp-Ed-ak6NoX_4Aeg_-1148128675")]
    [DisplayName("Interest Method")]
    [IsoXmlTag("IntrstMtd")]
    public required InterestMethod1Code InterestMethod { get; init; } 
    
    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    [IsoId("_SQ30ctp-Ed-ak6NoX_4Aeg_1341206546")]
    [DisplayName("Opening Collateral Balance")]
    [IsoXmlTag("OpngCollBal")]
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    
    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    [IsoId("_SQ30c9p-Ed-ak6NoX_4Aeg_-74786941")]
    [DisplayName("Closing Collateral Balance")]
    [IsoXmlTag("ClsgCollBal")]
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    
    
    #nullable disable
    
}
