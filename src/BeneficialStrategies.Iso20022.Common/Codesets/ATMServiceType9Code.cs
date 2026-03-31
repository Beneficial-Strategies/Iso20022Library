// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of fund transfer selected by the customer or the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-atfIK4sEeWLdt0vLARX2Q")]
[Description(@"Describes the type of fund transfer selected by the customer or the ATM.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMServiceType9Code>))]
#endif
public enum ATMServiceType9Code
{
    /// <summary>
    /// Funds transfer between accounts belonging to the customer in the same bank.
    /// Encoded/decoded by serializers as &quot;TRFC&quot;.
    /// </summary>
    [EnumMember(Value = "TRFC")]
    [IsoId("_GTc9Aa4tEeWLdt0vLARX2Q")]
    [Description(@"Funds transfer between accounts belonging to the customer in the same bank.")]
    CustomerTransfer = ATMServiceTypeCode.CustomerTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer to another customer.
    /// Encoded/decoded by serializers as &quot;TRFI&quot;.
    /// </summary>
    [EnumMember(Value = "TRFI")]
    [IsoId("_GkSOUa4tEeWLdt0vLARX2Q")]
    [Description(@"Funds transfer to another customer.")]
    InterCustomerTransfer = ATMServiceTypeCode.InterCustomerTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer to pay a third party.
    /// Encoded/decoded by serializers as &quot;TRFP&quot;.
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_PF0xka4tEeWLdt0vLARX2Q")]
    [Description(@"Funds transfer to pay a third party.")]
    Payment = ATMServiceTypeCode.Payment, // same ordinal as derivation source for type conversions
}
