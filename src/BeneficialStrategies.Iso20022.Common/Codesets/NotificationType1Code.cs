// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which type of action a user must take or is prevented to take.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aODGZtp-Ed-ak6NoX_4Aeg_507459033")]
[Description(@"Specifies which type of action a user must take or is prevented to take.")]
[DerivedFrom(typeof(NotificationTypeCode))]
public enum NotificationType1Code
{
    /// <summary>
    /// User must withdraw from transaction because of Force Majeure.
    /// Encoded/decoded by serializers as &quot;MWFT&quot;.
    /// </summary>
    [EnumMember(Value = "MWFT")]
    [IsoId("_aODGZ9p-Ed-ak6NoX_4Aeg_959058836")]
    [Description(@"User must withdraw from transaction because of Force Majeure.")]
    MustWithdrawFromTransaction = NotificationTypeCode.MustWithdrawFromTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// User is unable to submit data set(s).
    /// Encoded/decoded by serializers as &quot;CSDS&quot;.
    /// </summary>
    [EnumMember(Value = "CSDS")]
    [IsoId("_aODGaNp-Ed-ak6NoX_4Aeg_963678886")]
    [Description(@"User is unable to submit data set(s).")]
    CannotSubmitDataSet = NotificationTypeCode.CannotSubmitDataSet, // same ordinal as derivation source for type conversions
}
