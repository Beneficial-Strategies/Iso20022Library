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
[IsoId("_-MhZAW7iEeKo25nLKvGr8w_650995331")]
[Description(@"Specifies the external commercial reference type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalUnderlyingTradeTransactionType1Code))]
public enum ExternalUnderlyingTradeTransactionTypeCode
{
    /// <summary>
    /// Underlying transaction is a contract.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_uQn48PRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a contract.")]
    Contract,
    
    /// <summary>
    /// Underlying transaction is a delivery order.
    /// Encoded/decoded by serializers as &quot;DELV&quot;.
    /// </summary>
    [EnumMember(Value = "DELV")]
    [IsoId("_uQn48_RYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a delivery order.")]
    DeliveryOrder,
    
    /// <summary>
    /// Underlying transaction is a proforma invoice.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_uQn49vRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a proforma invoice.")]
    ProformaInvoice,
    
    /// <summary>
    /// Underlying transaction is a project.
    /// Encoded/decoded by serializers as &quot;PROJ&quot;.
    /// </summary>
    [EnumMember(Value = "PROJ")]
    [IsoId("_uQn4-fRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a project.")]
    Project,
    
    /// <summary>
    /// Underlying transaction is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_uQxp8PRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a purchase order.")]
    PurchaseOrder,
    
    /// <summary>
    /// Underlying transaction is a quotation.
    /// Encoded/decoded by serializers as &quot;QUOT&quot;.
    /// </summary>
    [EnumMember(Value = "QUOT")]
    [IsoId("_uQxp8_RYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a quotation.")]
    Quotation,
    
    /// <summary>
    /// Underlying transaction is a tender.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_uQxp9vRYEeuLhpyIdtJzwg")]
    [Description(@"Underlying transaction is a tender.")]
    Tender,
    
}
