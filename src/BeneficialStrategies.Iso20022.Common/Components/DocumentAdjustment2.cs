// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the amount and reason of the document adjustment.
/// </summary>
[IsoId("_TBrGFgEcEeCQm6a_G2yO_w_1465529279")]
[DisplayName("Document Adjustment")]
public partial record DocumentAdjustment2
{
    #nullable enable
    
    /// <summary>
    /// Amount of money of the document adjustment.
    /// </summary>
    [IsoId("_TBrGFwEcEeCQm6a_G2yO_w_1351690213")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Specifies whether the adjustment must be substracted or added to the total amount.
    /// </summary>
    [IsoId("_TBrGGAEcEeCQm6a_G2yO_w_468456926")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the adjustment.
    /// </summary>
    [IsoId("_TBrGGQEcEeCQm6a_G2yO_w_-528615427")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? Reason { get; init; } 
    
    /// <summary>
    /// Provides further details on the document adjustment.
    /// </summary>
    [IsoId("_TBrGGgEcEeCQm6a_G2yO_w_-1525687780")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
