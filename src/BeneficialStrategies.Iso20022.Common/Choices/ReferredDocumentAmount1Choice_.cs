// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature of the amount and currency on a document referred to in the remittance section, typically either the original amount due/payable or the amount actually remitted for the referenced document.
    /// </summary>
    [KnownType(typeof(ReferredDocumentAmount1Choice.DuePayableAmount))]
    [KnownType(typeof(ReferredDocumentAmount1Choice.DiscountAppliedAmount))]
    [KnownType(typeof(ReferredDocumentAmount1Choice.RemittedAmount))]
    [KnownType(typeof(ReferredDocumentAmount1Choice.CreditNoteAmount))]
    [KnownType(typeof(ReferredDocumentAmount1Choice.TaxAmount))]
    [JsonDerivedType(typeof(ReferredDocumentAmount1Choice.DuePayableAmount),nameof(ReferredDocumentAmount1Choice.DuePayableAmount))]
    [JsonDerivedType(typeof(ReferredDocumentAmount1Choice.DiscountAppliedAmount),nameof(ReferredDocumentAmount1Choice.DiscountAppliedAmount))]
    [JsonDerivedType(typeof(ReferredDocumentAmount1Choice.RemittedAmount),nameof(ReferredDocumentAmount1Choice.RemittedAmount))]
    [JsonDerivedType(typeof(ReferredDocumentAmount1Choice.CreditNoteAmount),nameof(ReferredDocumentAmount1Choice.CreditNoteAmount))]
    [JsonDerivedType(typeof(ReferredDocumentAmount1Choice.TaxAmount),nameof(ReferredDocumentAmount1Choice.TaxAmount))]
    [IsoId("_QGJCQtp-Ed-ak6NoX_4Aeg_-888106501")]
    [DisplayName("Referred Document Amount 1 Choice")]
    public abstract partial record ReferredDocumentAmount1Choice_
    {
    }
}
