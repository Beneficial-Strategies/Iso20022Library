// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bUOYsNxJEeioifFt1dhnJA")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
public enum DocumentType7Code
{
    /// <summary>
    /// When the POI or the Sale System wants to store a message on the journal printer or electronic journal of the Sale Terminal (it is sometimes a Sale Logging/Journal Printer).
    /// Encoded/decoded by serializers as &quot;JNRL&quot;.
    /// </summary>
    [EnumMember(Value = "JNRL")]
    [IsoId("_nHof4NxKEeioifFt1dhnJA")]
    [Description(
        @"When the POI or the Sale System wants to store a message on the journal printer or electronic journal of the Sale Terminal (it is sometimes a Sale Logging/Journal Printer)."
    )]
    Journal = DocumentTypeCode.Journal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// When the Sale System requires	the POI system to print the Customer receipt.
    /// Encoded/decoded by serializers as &quot;CRCP&quot;.
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_nQrHIdxKEeioifFt1dhnJA")]
    [Description(@"When the Sale System requires	the POI system to print the Customer receipt.")]
    CustomerReceipt = DocumentTypeCode.CustomerReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// When the Sale system print the Cashier copy of the Payment receipt.
    /// Encoded/decoded by serializers as &quot;HRCP&quot;.
    /// </summary>
    [EnumMember(Value = "HRCP")]
    [IsoId("_nXT6oNxKEeioifFt1dhnJA")]
    [Description(@"When the Sale system print the Cashier copy of the Payment receipt.")]
    CashierReceipt = DocumentTypeCode.CashierReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// When the Sale System requires the POI system to print the Sale receipt.
    /// Encoded/decoded by serializers as &quot;SRCP&quot;.
    /// </summary>
    [EnumMember(Value = "SRCP")]
    [IsoId("_ndpzMdxKEeioifFt1dhnJA")]
    [Description(@"When the Sale System requires the POI system to print the Sale receipt.")]
    SaleReceipt = DocumentTypeCode.SaleReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.
    /// Encoded/decoded by serializers as &quot;RPIN&quot;.
    /// </summary>
    [EnumMember(Value = "RPIN")]
    [IsoId("_pANyIdxKEeioifFt1dhnJA")]
    [Description(
        @"Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario."
    )]
    RelatedPaymentInstruction = DocumentTypeCode.RelatedPaymentInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an electronic payment document.
    /// Encoded/decoded by serializers as &quot;VCHR&quot;.
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_qXypEdxKEeioifFt1dhnJA")]
    [Description(@"Document is an electronic payment document.")]
    Voucher = DocumentTypeCode.Voucher, // same ordinal as derivation source for type conversions
}
