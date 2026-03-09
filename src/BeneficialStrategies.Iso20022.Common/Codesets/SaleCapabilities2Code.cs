// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of the Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier 
/// or the Customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6gewcN6mEeiwsev40qZGEQ")]
[Description(@"Type of the Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier |or the Customer.")]
[DerivedFrom(typeof(SaleCapabilitiesCode))]
public enum SaleCapabilities2Code
{
    /// <summary>
    /// Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element). The output device attached to this input device is the CashierDisplay device.
    /// Encoded/decoded by serializers as &quot;CHIN&quot;.
    /// </summary>
    [EnumMember(Value = "CHIN")]
    [IsoId("_AwtYYd6nEeiwsev40qZGEQ")]
    [Description(@"Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element). The output device attached to this input device is the CashierDisplay device.")]
    CashierInput = SaleCapabilitiesCode.CashierInput, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element).
    /// Encoded/decoded by serializers as &quot;CUIN&quot;.
    /// </summary>
    [EnumMember(Value = "CUIN")]
    [IsoId("_BTpGUd6nEeiwsev40qZGEQ")]
    [Description(@"Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element).")]
    CustomerInput = SaleCapabilitiesCode.CustomerInput, // same ordinal as derivation source for type conversions
    
}
