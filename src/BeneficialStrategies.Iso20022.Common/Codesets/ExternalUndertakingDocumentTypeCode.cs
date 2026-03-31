// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MrKA27iEeKo25nLKvGr8w_-2015115819")]
[Description(
    @"Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalUndertakingDocumentType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalUndertakingDocumentTypeCode>))]
#endif
public enum ExternalUndertakingDocumentTypeCode
{
    /// <summary>
    /// Document is a beneficiary statement.
    /// Encoded/decoded by serializers as &quot;BENS&quot;.
    /// </summary>
    [EnumMember(Value = "BENS")]
    [IsoId("_uRYG4PRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a beneficiary statement.")]
    BeneficiaryStatement,

    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_uRYG4_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice,

    /// <summary>
    /// Document is a claim form.
    /// Encoded/decoded by serializers as &quot;CLAF&quot;.
    /// </summary>
    [EnumMember(Value = "CLAF")]
    [IsoId("_uRYG5vRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a claim form.")]
    ClaimForm,

    /// <summary>
    /// Document is an undertaking demand.
    /// Encoded/decoded by serializers as &quot;DEMD&quot;.
    /// </summary>
    [EnumMember(Value = "DEMD")]
    [IsoId("_uRYG6fRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an undertaking demand.")]
    Demand,

    /// <summary>
    /// Document is a transfer form.
    /// Encoded/decoded by serializers as &quot;TRAF&quot;.
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_uRYG7PRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a transfer form.")]
    TransferForm,
}
