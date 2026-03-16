// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of date, as published in an external date type code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalDateTypeCode")]
[Description(@"Defines the type of date, as published in an external date type code list.")]
public enum ExternalDateTypeCode
{
    /// <summary>
    /// Relates to the invoice date.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_ExternalDateTypeCode_InvoiceDate")]
    [Description(@"Relates to the invoice date.")]
    InvoiceDate,

    /// <summary>
    /// Date type is not available.
    /// Encoded/decoded by serializers as &quot;NTAV&quot;.
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("_ExternalDateTypeCode_NotAvailable")]
    [Description(@"Date type is not available.")]
    NotAvailable,

    /// <summary>
    /// Relates to the next billing date.
    /// Encoded/decoded by serializers as &quot;NXBD&quot;.
    /// </summary>
    [EnumMember(Value = "NXBD")]
    [IsoId("_ExternalDateTypeCode_NextBillingDate")]
    [Description(@"Relates to the next billing date.")]
    NextBillingDate,

    /// <summary>
    /// Relates to the payment due date.
    /// Encoded/decoded by serializers as &quot;PADD&quot;.
    /// </summary>
    [EnumMember(Value = "PADD")]
    [IsoId("_ExternalDateTypeCode_PaymentDueDate")]
    [Description(@"Relates to the payment due date.")]
    PaymentDueDate,

}
