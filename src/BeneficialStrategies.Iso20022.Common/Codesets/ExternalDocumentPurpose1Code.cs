// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the document purpose as published in an external document purpose code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TRd1lAEcEeCQm6a_G2yO_w_37780651")]
[Description(
    @"Specifies the document purpose as published in an external document purpose code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalDocumentPurposeCode))]
public enum ExternalDocumentPurpose1Code
{
    /// <summary>
    /// The document represents a document that has been confirmed, for example an invoice that has been confirmed by the buyer for payment.|
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uHFiePRYEeuLhpyIdtJzwg")]
    [Description(
        @"The document represents a document that has been confirmed, for example an invoice that has been confirmed by the buyer for payment.|"
    )]
    Confirmed = ExternalDocumentPurposeCode.Confirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The document represents an invoice submitted under a factoring arrangment.
    /// Encoded/decoded by serializers as &quot;FINV&quot;.
    /// </summary>
    [EnumMember(Value = "FINV")]
    [IsoId("_uHPTcvRYEeuLhpyIdtJzwg")]
    [Description(@"The document represents an invoice submitted under a factoring arrangment. ")]
    Factoredinvoice = ExternalDocumentPurposeCode.Factoredinvoice, // same ordinal as derivation source for type conversions
}
