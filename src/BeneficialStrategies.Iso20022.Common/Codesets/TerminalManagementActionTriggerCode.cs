// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Event to start a terminal management action by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUYDkn1DEeCF8NjrBemJWQ_-837773377")]
[Description(@"Event to start a terminal management action by the point of interaction (POI).")]
[Derivations(typeof(TerminalManagementActionTrigger1Code))]
public enum TerminalManagementActionTriggerCode
{
    /// <summary>
    /// Date and time trigger the terminal management action.
    /// Encoded/decoded by serializers as &quot;DATE&quot;.
    /// </summary>
    [EnumMember(Value = "DATE")]
    [IsoId("_KUYDk31DEeCF8NjrBemJWQ_2024412951")]
    [Description(@"Date and time trigger the terminal management action.")]
    DateTime,
    
    /// <summary>
    /// Acquirer triggers the terminal management action.
    /// Encoded/decoded by serializers as &quot;HOST&quot;.
    /// </summary>
    [EnumMember(Value = "HOST")]
    [IsoId("_KUYDlH1DEeCF8NjrBemJWQ_-1095363320")]
    [Description(@"Acquirer triggers the terminal management action.")]
    HostEvent,
    
    /// <summary>
    /// Acceptor triggers the terminal management action.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_KUYDlX1DEeCF8NjrBemJWQ_-1209202386")]
    [Description(@"Acceptor triggers the terminal management action.")]
    Manual,
    
    /// <summary>
    /// Sale system triggers the terminal management action.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_KUYDln1DEeCF8NjrBemJWQ_-1387321058")]
    [Description(@"Sale system triggers the terminal management action.")]
    SaleEvent,
    
}
