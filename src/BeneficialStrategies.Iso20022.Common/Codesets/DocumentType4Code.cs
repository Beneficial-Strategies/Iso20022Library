// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the document for example commercial invoice, credit note, debit note.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_agObhtp-Ed-ak6NoX_4Aeg_1538718014")]
[Description(
    @"Specifies the type of the document for example commercial invoice, credit note, debit note."
)]
[DerivedFrom(typeof(DocumentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DocumentType4Code>))]
#endif
public enum DocumentType4Code
{
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_agObh9p-Ed-ak6NoX_4Aeg_1538718054")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = DocumentTypeCode.CommercialInvoice, // same ordinal as derivation source for type conversions
}
