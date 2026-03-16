// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Action to perform in case of error during the action in progress.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUh0ln1DEeCF8NjrBemJWQ_467213474")]
[Description(@"Action to perform in case of error during the action in progress.")]
[DerivedFrom(typeof(TerminalManagementErrorActionCode))]
public enum TerminalManagementErrorAction1Code
{
    /// <summary>
    /// Ignore the error.
    /// Encoded/decoded by serializers as &quot;IGNR&quot;.
    /// </summary>
    [EnumMember(Value = "IGNR")]
    [IsoId("_KUh0l31DEeCF8NjrBemJWQ_-1839509664")]
    [Description(@"Ignore the error.")]
    IgnoreError = TerminalManagementErrorActionCode.IgnoreError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Send a status report immediately.
    /// Encoded/decoded by serializers as &quot;SDSR&quot;.
    /// </summary>
    [EnumMember(Value = "SDSR")]
    [IsoId("_KUh0mH1DEeCF8NjrBemJWQ_-1174724220")]
    [Description(@"Send a status report immediately.")]
    SendStatusReport = TerminalManagementErrorActionCode.SendStatusReport, // same ordinal as derivation source for type conversions
}
