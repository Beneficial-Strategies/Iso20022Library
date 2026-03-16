// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Event to start a terminal management action by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUOSlX1DEeCF8NjrBemJWQ_917878149")]
[Description(@"Event to start a terminal management action by the point of interaction (POI).")]
[DerivedFrom(typeof(TerminalManagementActionTriggerCode))]
public enum TerminalManagementActionTrigger1Code
{
    /// <summary>
    /// Date and time trigger the terminal management action.
    /// Encoded/decoded by serializers as &quot;DATE&quot;.
    /// </summary>
    [EnumMember(Value = "DATE")]
    [IsoId("_KUOSln1DEeCF8NjrBemJWQ_-370493014")]
    [Description(@"Date and time trigger the terminal management action.")]
    DateTime = TerminalManagementActionTriggerCode.DateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquirer triggers the terminal management action.
    /// Encoded/decoded by serializers as &quot;HOST&quot;.
    /// </summary>
    [EnumMember(Value = "HOST")]
    [IsoId("_KUOSl31DEeCF8NjrBemJWQ_1411431502")]
    [Description(@"Acquirer triggers the terminal management action.")]
    HostEvent = TerminalManagementActionTriggerCode.HostEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acceptor triggers the terminal management action.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_KUYDkH1DEeCF8NjrBemJWQ_-1262025415")]
    [Description(@"Acceptor triggers the terminal management action.")]
    Manual = TerminalManagementActionTriggerCode.Manual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sale system triggers the terminal management action.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_KUYDkX1DEeCF8NjrBemJWQ_-2047159303")]
    [Description(@"Sale system triggers the terminal management action.")]
    SaleEvent = TerminalManagementActionTriggerCode.SaleEvent, // same ordinal as derivation source for type conversions
}
