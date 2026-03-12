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
[IsoId("_UP-lctp-Ed-ak6NoX_4Aeg_1188294125")]
[DisplayName("Document Adjustment")]
public partial record DocumentAdjustment1
{
    #nullable enable
    
    /// <summary>
    /// Amount of money of the document adjustment.
    /// </summary>
    [IsoId("_UP-lc9p-Ed-ak6NoX_4Aeg_1531842196")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_UP-ldNp-Ed-ak6NoX_4Aeg_1554008423")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the adjustment.
    /// </summary>
    [IsoId("_UP-lddp-Ed-ak6NoX_4Aeg_1641741581")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? Reason { get; init; } 
    
    /// <summary>
    /// Provides further details on the document adjustment.
    /// </summary>
    [IsoId("_UP-ldtp-Ed-ak6NoX_4Aeg_1656516606")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
