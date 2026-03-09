// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Additional process to perform before starting or after a terminal management action by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUYDl31DEeCF8NjrBemJWQ_1229049347")]
[Description(@"Additional process to perform before starting or after a terminal management action by the point of interaction (POI).")]
[DerivedFrom(typeof(TerminalManagementAdditionalProcessCode))]
public enum TerminalManagementAdditionalProcess1Code
{
    /// <summary>
    /// Manual confirmation of the merchant before the terminal management action.
    /// Encoded/decoded by serializers as &quot;MANC&quot;.
    /// </summary>
    [EnumMember(Value = "MANC")]
    [IsoId("_KUYDmH1DEeCF8NjrBemJWQ_-1485151029")]
    [Description(@"Manual confirmation of the merchant before the terminal management action.")]
    ManualConfirmation = TerminalManagementAdditionalProcessCode.ManualConfirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acquirer reconciliation to be performed before the terminal management action.
    /// Encoded/decoded by serializers as &quot;RCNC&quot;.
    /// </summary>
    [EnumMember(Value = "RCNC")]
    [IsoId("_KUh0kH1DEeCF8NjrBemJWQ_361779399")]
    [Description(@"Acquirer reconciliation to be performed before the terminal management action.")]
    Reconciliation = TerminalManagementAdditionalProcessCode.Reconciliation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Restart the system after performing the terminal management action.
    /// Encoded/decoded by serializers as &quot;RSRT&quot;.
    /// </summary>
    [EnumMember(Value = "RSRT")]
    [IsoId("_KUh0kX1DEeCF8NjrBemJWQ_1903870501")]
    [Description(@"Restart the system after performing the terminal management action.")]
    RestartSystem = TerminalManagementAdditionalProcessCode.RestartSystem, // same ordinal as derivation source for type conversions
    
}
