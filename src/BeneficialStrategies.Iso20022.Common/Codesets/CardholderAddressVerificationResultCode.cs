// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the cardholder verification address checks on the street number and the postal code from the cardholder&apos;s address.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWF26gEcEeCQm6a_G2yO_w_1762343535")]
[Description(
    @"Result of the cardholder verification address checks on the street number and the postal code from the cardholder's address."
)]
[Derivations(typeof(CardholderAddressVerificationResult1Code))]
public enum CardholderAddressVerificationResultCode
{
    /// <summary>
    /// Address numeric match.
    /// Encoded/decoded by serializers as &quot;AMCH&quot;.
    /// </summary>
    [EnumMember(Value = "AMCH")]
    [IsoId("_TWF26wEcEeCQm6a_G2yO_w_-126591173")]
    [Description(@"Address numeric match.")]
    AddressMatch,

    /// <summary>
    /// Address numerics do not match.
    /// Encoded/decoded by serializers as &quot;ANMH&quot;.
    /// </summary>
    [EnumMember(Value = "ANMH")]
    [IsoId("_TWF27AEcEeCQm6a_G2yO_w_-472821746")]
    [Description(@"Address numerics do not match.")]
    AddressNotMatch,

    /// <summary>
    /// Address numeric not processed for technical reason.
    /// Encoded/decoded by serializers as &quot;ANMT&quot;.
    /// </summary>
    [EnumMember(Value = "ANMT")]
    [IsoId("_TWF27QEcEeCQm6a_G2yO_w_-483920523")]
    [Description(@"Address numeric not processed for technical reason.")]
    AddressTechnical,

    /// <summary>
    /// Address numeric not processed for non-technical reason.
    /// Encoded/decoded by serializers as &quot;ANMO&quot;.
    /// </summary>
    [EnumMember(Value = "ANMO")]
    [IsoId("_TWF27gEcEeCQm6a_G2yO_w_1261228387")]
    [Description(@"Address numeric not processed for non-technical reason.")]
    AddressNotTechnical,

    /// <summary>
    /// Address numeric missing in request.
    /// Encoded/decoded by serializers as &quot;AMSS&quot;.
    /// </summary>
    [EnumMember(Value = "AMSS")]
    [IsoId("_TWF27wEcEeCQm6a_G2yO_w_1300981109")]
    [Description(@"Address numeric missing in request.")]
    AddressMissing,

    /// <summary>
    /// Address numeric not used by issuer.
    /// Encoded/decoded by serializers as &quot;ANUS&quot;.
    /// </summary>
    [EnumMember(Value = "ANUS")]
    [IsoId("_TWF28AEcEeCQm6a_G2yO_w_1535767635")]
    [Description(@"Address numeric not used by issuer.")]
    AddressNotUsed,

    /// <summary>
    /// Postal code matches.
    /// Encoded/decoded by serializers as &quot;PMCH&quot;.
    /// </summary>
    [EnumMember(Value = "PMCH")]
    [IsoId("_TWF28QEcEeCQm6a_G2yO_w_403706914")]
    [Description(@"Postal code matches.")]
    PostalMatch,

    /// <summary>
    /// Postal code does not match.
    /// Encoded/decoded by serializers as &quot;PNMH&quot;.
    /// </summary>
    [EnumMember(Value = "PNMH")]
    [IsoId("_TWF28gEcEeCQm6a_G2yO_w_1351396796")]
    [Description(@"Postal code does not match.")]
    PostalNotMatch,

    /// <summary>
    /// Postal code not processed for technical reason.
    /// Encoded/decoded by serializers as &quot;PNMT&quot;.
    /// </summary>
    [EnumMember(Value = "PNMT")]
    [IsoId("_TWPA0AEcEeCQm6a_G2yO_w_1805484065")]
    [Description(@"Postal code not processed for technical reason.")]
    PostalTechnical,

    /// <summary>
    /// Postal code not processed for non-technical reason.
    /// Encoded/decoded by serializers as &quot;PNMO&quot;.
    /// </summary>
    [EnumMember(Value = "PNMO")]
    [IsoId("_TWPA0QEcEeCQm6a_G2yO_w_1717862763")]
    [Description(@"Postal code not processed for non-technical reason.")]
    PostalNotTechnical,

    /// <summary>
    /// Postal code missing in request.
    /// Encoded/decoded by serializers as &quot;PMSS&quot;.
    /// </summary>
    [EnumMember(Value = "PMSS")]
    [IsoId("_TWPA0gEcEeCQm6a_G2yO_w_-50079235")]
    [Description(@"Postal code missing in request.")]
    PostalMissing,

    /// <summary>
    /// Postal code not used by issuer.
    /// Encoded/decoded by serializers as &quot;PNUS&quot;.
    /// </summary>
    [EnumMember(Value = "PNUS")]
    [IsoId("_TWPA0wEcEeCQm6a_G2yO_w_-61178012")]
    [Description(@"Postal code not used by issuer.")]
    PostalNotUsed,
}
