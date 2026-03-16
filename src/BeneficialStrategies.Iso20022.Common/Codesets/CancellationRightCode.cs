// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYs7odp-Ed-ak6NoX_4Aeg_1275993288")]
[Description(
    @"Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel."
)]
[Derivations(typeof(CancellationRight2Code), typeof(CancellationRight1Code))]
public enum CancellationRightCode
{
    /// <summary>
    /// Investor is entitled to a &quot;cooling off&quot; period with cancellation rights under compliance rules.
    /// Encoded/decoded by serializers as &quot;VALI&quot;.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_bYs7otp-Ed-ak6NoX_4Aeg_-1019449689")]
    [Description(
        @"Investor is entitled to a ""cooling off"" period with cancellation rights under compliance rules."
    )]
    Entitled,

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules, as the investor is an execution&apos;s only client.
    /// Encoded/decoded by serializers as &quot;NOXO&quot;.
    /// </summary>
    [EnumMember(Value = "NOXO")]
    [IsoId("_bYs7o9p-Ed-ak6NoX_4Aeg_-1019449688")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules, as the investor is an execution's only client."
    )]
    ExecutionOnly,

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules as the investor has agreed to waive those rights.
    /// Encoded/decoded by serializers as &quot;NOWA&quot;.
    /// </summary>
    [EnumMember(Value = "NOWA")]
    [IsoId("_bYs7pNp-Ed-ak6NoX_4Aeg_-1019449680")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules as the investor has agreed to waive those rights."
    )]
    WaiverAgreement,

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules as the investor is a financial institution.
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_bYs7pdp-Ed-ak6NoX_4Aeg_-1019449679")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules as the investor is a financial institution."
    )]
    Institutional,

    /// <summary>
    /// Another type of cancellation right.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bYs7ptp-Ed-ak6NoX_4Aeg_567211443")]
    [Description(@"Another type of cancellation right.")]
    Other,
}
