// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Action to perform in case of error during the maintenance action in progress.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rek3IB3YEeKKrOIoqWglDw")]
[Description(@"Action to perform in case of error during the maintenance action in progress.")]
[DerivedFrom(typeof(TerminalManagementErrorActionCode))]
public enum TerminalManagementErrorAction2Code
{
    /// <summary>
    /// Send a status report immediately.
    /// Encoded/decoded by serializers as &quot;SDSR&quot;.
    /// </summary>
    [EnumMember(Value = "SDSR")]
    [IsoId("_uWdDMx3YEeKKrOIoqWglDw")]
    [Description(@"Send a status report immediately.")]
    SendStatusReport = TerminalManagementErrorActionCode.SendStatusReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stop the current sequence of terminal management actions without any action, and do not notice the error with a status report.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_ugRtkx3YEeKKrOIoqWglDw")]
    [Description(@"Stop the current sequence of terminal management actions without any action, and do not notice the error with a status report.")]
    StopSequence = TerminalManagementErrorActionCode.StopSequence, // same ordinal as derivation source for type conversions
    
}
