// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bqSa69p-Ed-ak6NoX_4Aeg_148511528")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
public enum AdditionalBusinessProcess2Code
{
    /// <summary>
    /// Relates to a claim on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_bqbk0Np-Ed-ak6NoX_4Aeg_-230763075")]
    [Description(@"Relates to a claim on the associated corporate action event.")]
    ClaimOrCompensation = AdditionalBusinessProcessCode.ClaimOrCompensation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates a preadvice of movement reversal.
    /// Encoded/decoded by serializers as &quot;REVR&quot;.
    /// </summary>
    [EnumMember(Value = "REVR")]
    [IsoId("_bqbk0dp-Ed-ak6NoX_4Aeg_-1899985982")]
    [Description(@"Indicates a preadvice of movement reversal.")]
    NotificationOfReversal = AdditionalBusinessProcessCode.NotificationOfReversal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;TAXR&quot;.
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_bqbk0tp-Ed-ak6NoX_4Aeg_-215987823")]
    [Description(
        @"Relates to a tax refund from the authorities on the associated corporate action event."
    )]
    TaxRefund = AdditionalBusinessProcessCode.TaxRefund, // same ordinal as derivation source for type conversions
}
