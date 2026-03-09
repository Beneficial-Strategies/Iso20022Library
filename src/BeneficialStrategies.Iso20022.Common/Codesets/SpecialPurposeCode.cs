// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies special purpose codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WjGtkBvUEeWeg9zOuV6DZQ")]
[Description(@"Specifies special purpose codes.")]
[Derivations(typeof(NotAvailable1Code),typeof(AnyMIC1Code),typeof(NoReasonCode),typeof(NotApplicable1Code),typeof(NotReported1Code),typeof(SpecialPurpose2Code))]
public enum SpecialPurposeCode
{
    /// <summary>
    /// Blank value.
    /// Encoded/decoded by serializers as &quot;BLNK&quot;.
    /// </summary>
    [EnumMember(Value = "BLNK")]
    [IsoId("_aerLQBvUEeWeg9zOuV6DZQ")]
    [Description(@"Blank value.")]
    Blank,
    
    /// <summary>
    /// Not available (N/A).
    /// Encoded/decoded by serializers as &quot;NTAV&quot;.
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("_brFsUBvaEeWeg9zOuV6DZQ")]
    [Description(@"Not available (N/A).")]
    NotAvailable,
    
    /// <summary>
    /// Any MIC code.
    /// Encoded/decoded by serializers as &quot;ANYM&quot;.
    /// </summary>
    [EnumMember(Value = "ANYM")]
    [IsoId("_KyeQMB3ZEeWNp95x0ENf8w")]
    [Description(@"Any MIC code.")]
    AnyMIC,
    
    /// <summary>
    /// Value not reported by the party.
    /// Encoded/decoded by serializers as &quot;NORP&quot;.
    /// </summary>
    [EnumMember(Value = "NORP")]
    [IsoId("_3wXcQNGeEeaQk737TH1Fzw")]
    [Description(@"Value not reported by the party.")]
    NotReported,
    
    /// <summary>
    /// No reason to report or no reason available to report.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_rM9R8OtfEeqXXbgP9HbjvA")]
    [Description(@"No reason to report or no reason available to report.")]
    NoReason,
    
    /// <summary>
    /// Not applicable (N/A).
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_M1W0YICCEeqdQubSe21TTw")]
    [Description(@"Not applicable (N/A).")]
    NotApplicable,
    
    /// <summary>
    /// Positive indication.
    /// Encoded/decoded by serializers as &quot;TRUE&quot;.
    /// </summary>
    [EnumMember(Value = "TRUE")]
    [IsoId("_KQB1wOG8EeyjU5A7t8P1KA")]
    [Description(@"Positive indication.")]
    True,
    
    /// <summary>
    /// Negative indication.
    /// Encoded/decoded by serializers as &quot;FALS&quot;.
    /// </summary>
    [EnumMember(Value = "FALS")]
    [IsoId("_NSF4kOG8EeyjU5A7t8P1KA")]
    [Description(@"Negative indication.")]
    False,
    
}
