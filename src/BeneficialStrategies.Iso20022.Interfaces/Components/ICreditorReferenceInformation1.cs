// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured information supplied to enable the matching, i.e. reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an accounts receivable system.
/// </summary>
[IsoId("_T3_jRNp-Ed-ak6NoX_4Aeg_1085128342")]
public interface ICreditorReferenceInformation1 : IIsoComponent
{
    /// <summary>
    /// Provides the type of the creditor reference.
    /// </summary>
    [IsoId("_T3_jRdp-Ed-ak6NoX_4Aeg_1086051228")]
    [DisplayName("Creditor Reference Type")]
    [IsoXmlTag("CdtrRefTp")]
    ICreditorReferenceType1? CreditorReferenceType { get; }

    /// <summary>
    /// Unique and unambiguous reference assigned by the creditor to refer to the payment transaction.||Usage: if available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the cash.||If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor&apos;s reference or payment remittance identification should be quoted in the end-to-end transaction identification.
    /// </summary>
    [IsoId("_T3_jRtp-Ed-ak6NoX_4Aeg_1086049788")]
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    IsoMax35Text? CreditorReference { get; }
}
