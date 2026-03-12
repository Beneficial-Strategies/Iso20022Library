// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about result of a single instalment (financed or not) within an invoice.
/// </summary>
[IsoId("_PyxaU9p-Ed-ak6NoX_4Aeg_1394536846")]
[DisplayName("Instalment Financing Information")]
public partial record InstalmentFinancingInformation1
{
    #nullable enable
    
    /// <summary>
    /// Progressive number of the single instalment related to an invoice.
    /// </summary>
    [IsoId("_PyxaVNp-Ed-ak6NoX_4Aeg_254515146")]
    [DisplayName("Instalment Sequence Identification")]
    [IsoXmlTag("InstlmtSeqId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text InstalmentSequenceIdentification { get; init; } 
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_PyxaVdp-Ed-ak6NoX_4Aeg_310847975")]
    [DisplayName("Instalment Total Amount")]
    [IsoXmlTag("InstlmtTtlAmt")]
    public required ActiveCurrencyAndAmount InstalmentTotalAmount { get; init; } 
    
    /// <summary>
    /// Information about the financing result of one instalment.
    /// </summary>
    [IsoId("_PyxaVtp-Ed-ak6NoX_4Aeg_721361782")]
    [DisplayName("Instalment Financing Result")]
    [IsoXmlTag("InstlmtFincgRslt")]
    public required FinancingResult1 InstalmentFinancingResult { get; init; } 
    
    
    #nullable disable
    
}
