// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference information provided by the creditor to allow the identification of the underlying documents.
/// </summary>
[IsoId("_7u-CcTEsEe6GxLzpkVnWYg")]
[Description(@"Reference information provided by the creditor to allow the identification of the underlying documents.")]
[DisplayName("Creditor Reference Information3")]
public record CreditorReferenceInformation3
{
    /// <summary>
    /// Unique reference, as assigned by the creditor, to unambiguously refer to the payment transaction.
    /// Usage: If available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the amount of money.
    /// If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor's reference or payment remittance identification should be quoted in the end-to-end transaction identification.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Specifies the type of creditor reference.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CreditorReferenceType3? Type { get; init; }
}
