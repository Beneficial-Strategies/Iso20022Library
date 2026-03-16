// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MrKAW7iEeKo25nLKvGr8w_11518920")]
[Description(
    @"Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalUndertakingDocumentTypeCode))]
public enum ExternalUndertakingDocumentType1Code
{
    /// <summary>
    /// Document is a beneficiary statement.
    /// Encoded/decoded by serializers as &quot;BENS&quot;.
    /// </summary>
    [EnumMember(Value = "BENS")]
    [IsoId("_uRYG4vRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a beneficiary statement.")]
    BeneficiaryStatement = ExternalUndertakingDocumentTypeCode.BeneficiaryStatement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_uRYG5fRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = ExternalUndertakingDocumentTypeCode.CommercialInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a claim form.
    /// Encoded/decoded by serializers as &quot;CLAF&quot;.
    /// </summary>
    [EnumMember(Value = "CLAF")]
    [IsoId("_uRYG6PRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a claim form.")]
    ClaimForm = ExternalUndertakingDocumentTypeCode.ClaimForm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an undertaking demand.
    /// Encoded/decoded by serializers as &quot;DEMD&quot;.
    /// </summary>
    [EnumMember(Value = "DEMD")]
    [IsoId("_uRYG6_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is an undertaking demand.")]
    Demand = ExternalUndertakingDocumentTypeCode.Demand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a transfer form.
    /// Encoded/decoded by serializers as &quot;TRAF&quot;.
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_uRYG7vRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a transfer form.")]
    TransferForm = ExternalUndertakingDocumentTypeCode.TransferForm, // same ordinal as derivation source for type conversions
}
