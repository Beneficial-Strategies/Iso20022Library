// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9nm-wY3hEeW32YMP0mBeyw")]
[Description(@"Types of terminal management action to be performed by a point of interaction.")]
[DerivedFrom(typeof(TerminalManagementActionCode))]
public enum TerminalManagementAction2Code
{
    /// <summary>
    /// Request to activate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_9yfZEY3hEeW32YMP0mBeyw")]
    [Description(@"Request to activate the element identified inside the message exchange.")]
    Activate = TerminalManagementActionCode.Activate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to deactivate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DCTV&quot;.
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_9yfZE43hEeW32YMP0mBeyw")]
    [Description(@"Request to deactivate the element identified inside the message exchange.")]
    Deactivate = TerminalManagementActionCode.Deactivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_9yfZFY3hEeW32YMP0mBeyw")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete = TerminalManagementActionCode.Delete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to download the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DWNL&quot;.
    /// </summary>
    [EnumMember(Value = "DWNL")]
    [IsoId("_9yfZF43hEeW32YMP0mBeyw")]
    [Description(@"Request to download the element identified inside the message exchange.")]
    Download = TerminalManagementActionCode.Download, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to install the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_9yfZGY3hEeW32YMP0mBeyw")]
    [Description(@"Request to install the element identified inside the message exchange.")]
    Install = TerminalManagementActionCode.Install, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to restart the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_9yfZG43hEeW32YMP0mBeyw")]
    [Description(@"Request to restart the element identified inside the message exchange.")]
    Restart = TerminalManagementActionCode.Restart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to upload the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;UPLD&quot;.
    /// </summary>
    [EnumMember(Value = "UPLD")]
    [IsoId("_9yfZHY3hEeW32YMP0mBeyw")]
    [Description(@"Request to upload the element identified inside the message exchange.")]
    Upload = TerminalManagementActionCode.Upload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to update the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_GKkeUY3iEeW32YMP0mBeyw")]
    [Description(@"Request to update the element identified inside the message exchange.")]
    Update = TerminalManagementActionCode.Update, // same ordinal as derivation source for type conversions
    
}
