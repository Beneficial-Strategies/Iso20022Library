// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured information supplied to enable the matching, i.e. reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an accounts receivable system.
/// </summary>
[IsoId("_T3_jRNp-Ed-ak6NoX_4Aeg_1085128342")]
[DisplayName("Creditor Reference Information")]
public partial record CreditorReferenceInformation1
{
    #nullable enable
    
    /// <summary>
    /// Provides the type of the creditor reference.
    /// </summary>
    [IsoId("_T3_jRdp-Ed-ak6NoX_4Aeg_1086051228")]
    [DisplayName("Creditor Reference Type")]
    [IsoXmlTag("CdtrRefTp")]
    public CreditorReferenceType1? CreditorReferenceType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous reference assigned by the creditor to refer to the payment transaction.||Usage: if available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the cash.||If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor&apos;s reference or payment remittance identification should be quoted in the end-to-end transaction identification.
    /// </summary>
    [IsoId("_T3_jRtp-Ed-ak6NoX_4Aeg_1086049788")]
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CreditorReference { get; init; } 
    
    
    #nullable disable
    
}
