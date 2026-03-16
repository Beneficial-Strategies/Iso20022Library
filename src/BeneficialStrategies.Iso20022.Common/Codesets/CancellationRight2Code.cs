// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VkKxMNp-Ed-ak6NoX_4Aeg_1274144417")]
[Description(
    @"Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel."
)]
[DerivedFrom(typeof(CancellationRightCode))]
public enum CancellationRight2Code
{
    /// <summary>
    /// Investor is entitled to a &quot;cooling off&quot; period with cancellation rights under compliance rules.
    /// Encoded/decoded by serializers as &quot;VALI&quot;.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_VkKxMdp-Ed-ak6NoX_4Aeg_1687884304")]
    [Description(
        @"Investor is entitled to a ""cooling off"" period with cancellation rights under compliance rules."
    )]
    Entitled = CancellationRightCode.Entitled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules, as the investor is an execution&apos;s only client.
    /// Encoded/decoded by serializers as &quot;NOXO&quot;.
    /// </summary>
    [EnumMember(Value = "NOXO")]
    [IsoId("_VkKxMtp-Ed-ak6NoX_4Aeg_1687884598")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules, as the investor is an execution's only client."
    )]
    ExecutionOnly = CancellationRightCode.ExecutionOnly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules as the investor has agreed to waive those rights.
    /// Encoded/decoded by serializers as &quot;NOWA&quot;.
    /// </summary>
    [EnumMember(Value = "NOWA")]
    [IsoId("_VkKxM9p-Ed-ak6NoX_4Aeg_1687884616")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules as the investor has agreed to waive those rights."
    )]
    WaiverAgreement = CancellationRightCode.WaiverAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules as the investor is a financial institution.
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_VkKxNNp-Ed-ak6NoX_4Aeg_1687884658")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules as the investor is a financial institution."
    )]
    Institutional = CancellationRightCode.Institutional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of cancellation right.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VkKxNdp-Ed-ak6NoX_4Aeg_593992752")]
    [Description(@"Another type of cancellation right.")]
    Other = CancellationRightCode.Other, // same ordinal as derivation source for type conversions
}
