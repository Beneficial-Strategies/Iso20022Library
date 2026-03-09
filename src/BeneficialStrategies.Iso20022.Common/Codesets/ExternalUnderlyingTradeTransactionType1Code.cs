// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external commercial reference type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MhZAG7iEeKo25nLKvGr8w_-1500208754")]
[Description(@"Specifies the external commercial reference type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUnderlyingTradeTransactionTypeCode))]
public enum ExternalUnderlyingTradeTransactionType1Code
{
    /// <summary>
    /// Underlying transaction is a contract.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_uQn48vRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a contract.")]
    Contract = ExternalUnderlyingTradeTransactionTypeCode.Contract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying transaction is a delivery order.
    /// Encoded/decoded by serializers as &quot;DELV&quot;.
    /// </summary>
    [EnumMember(Value = "DELV")]
    [IsoId("_uQn49fRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a delivery order.")]
    DeliveryOrder = ExternalUnderlyingTradeTransactionTypeCode.DeliveryOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying transaction is a proforma invoice.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_uQn4-PRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a proforma invoice.")]
    ProformaInvoice = ExternalUnderlyingTradeTransactionTypeCode.ProformaInvoice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying transaction is a project.
    /// Encoded/decoded by serializers as &quot;PROJ&quot;.
    /// </summary>
    [EnumMember(Value = "PROJ")]
    [IsoId("_uQn4-_RYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a project.")]
    Project = ExternalUnderlyingTradeTransactionTypeCode.Project, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying transaction is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_uQxp8vRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a purchase order.")]
    PurchaseOrder = ExternalUnderlyingTradeTransactionTypeCode.PurchaseOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying transaction is a quotation.
    /// Encoded/decoded by serializers as &quot;QUOT&quot;.
    /// </summary>
    [EnumMember(Value = "QUOT")]
    [IsoId("_uQxp9fRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a quotation.")]
    Quotation = ExternalUnderlyingTradeTransactionTypeCode.Quotation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying transaction is a tender.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_uQxp-PRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a tender.")]
    Tender = ExternalUnderlyingTradeTransactionTypeCode.Tender, // same ordinal as derivation source for type conversions
    
}
