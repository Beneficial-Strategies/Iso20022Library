// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the modality through which the votes that have been recorded and counted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QzPaAK-vEemJ1NnLPsTFaw")]
[Description(
    @"Specifies the modality through which the votes that have been recorded and counted."
)]
[DerivedFrom(typeof(ModalityOfCountingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ModalityOfCounting1Code>))]
#endif
public enum ModalityOfCounting1Code
{
    /// <summary>
    /// Electronic vote recorded and counted at the meeting.
    /// Encoded/decoded by serializers as &quot;EVAM&quot;.
    /// </summary>
    [EnumMember(Value = "EVAM")]
    [IsoId("_OwH-kbLXEemDyeh7tbvg1w")]
    [Description(@"Electronic vote recorded and counted at the meeting.")]
    ElectronicAtMeeting = ModalityOfCountingCode.ElectronicAtMeeting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic vote recorded and counted ahead of the meeting.
    /// Encoded/decoded by serializers as &quot;EVBM&quot;.
    /// </summary>
    [EnumMember(Value = "EVBM")]
    [IsoId("_O3HXYbLXEemDyeh7tbvg1w")]
    [Description(@"Electronic vote recorded and counted ahead of the meeting.")]
    ElectronicBefore = ModalityOfCountingCode.ElectronicBefore, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Paper vote recorded and counted ahead of the meeting.
    /// Encoded/decoded by serializers as &quot;PVBM&quot;.
    /// </summary>
    [EnumMember(Value = "PVBM")]
    [IsoId("_O98_MbLXEemDyeh7tbvg1w")]
    [Description(@"Paper vote recorded and counted ahead of the meeting.")]
    PaperBefore = ModalityOfCountingCode.PaperBefore, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical attendance with vote at the meeting.
    /// Encoded/decoded by serializers as &quot;PVAM&quot;.
    /// </summary>
    [EnumMember(Value = "PVAM")]
    [IsoId("_PE8_EbLXEemDyeh7tbvg1w")]
    [Description(@"Physical attendance with vote at the meeting.")]
    PhysicalAtMeeting = ModalityOfCountingCode.PhysicalAtMeeting, // same ordinal as derivation source for type conversions
}
