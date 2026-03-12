// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference information provided by the creditor to allow the identification of the underlying documents.
/// </summary>
[IsoId("_T3_jR9p-Ed-ak6NoX_4Aeg_252475969")]
[DisplayName("Creditor Reference Information")]
public partial record CreditorReferenceInformation2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of creditor reference.
    /// </summary>
    [IsoId("_T3_jSNp-Ed-ak6NoX_4Aeg_252476093")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CreditorReferenceType2? Type { get; init; } 
    
    /// <summary>
    /// Unique reference, as assigned by the creditor, to unambiguously refer to the payment transaction.||Usage: If available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the amount of money.||If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor&apos;s reference or payment remittance identification should be quoted in the end-to-end transaction identification.
    /// </summary>
    [IsoId("_T3_jSdp-Ed-ak6NoX_4Aeg_252476000")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; } 
    
    
    #nullable disable
    
}
