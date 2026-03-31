// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the main way customer information was collected to build up the customer menu and the withdrawal request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gHsJgIoZEeSirOZJBRz_nA")]
[Description(
    @"Describes the main way customer information was collected to build up the customer menu and the withdrawal request."
)]
[DerivedFrom(typeof(ATMCustomerProfileCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMCustomerProfile1Code>))]
#endif
public enum ATMCustomerProfile1Code
{
    /// <summary>
    /// Customer profile is deduced from the card data and the local configuration.
    /// Encoded/decoded by serializers as &quot;CRDF&quot;.
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_kD1O8YoZEeSirOZJBRz_nA")]
    [Description(@"Customer profile is deduced from the card data and the local configuration.")]
    CardInformation = ATMCustomerProfileCode.CardInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer profile is sent via an account enquiry selecting an account.
    /// Encoded/decoded by serializers as &quot;OREQ&quot;.
    /// </summary>
    [EnumMember(Value = "OREQ")]
    [IsoId("_kMZ8IYoZEeSirOZJBRz_nA")]
    [Description(@"Customer profile is sent via an account enquiry selecting an account.")]
    OtherRequest = ATMCustomerProfileCode.OtherRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer profile is built via a specific profile message exchange.
    /// Encoded/decoded by serializers as &quot;PREQ&quot;.
    /// </summary>
    [EnumMember(Value = "PREQ")]
    [IsoId("_kUNNQYoZEeSirOZJBRz_nA")]
    [Description(@"Customer profile is built via a specific profile message exchange.")]
    ProfileRequest = ATMCustomerProfileCode.ProfileRequest, // same ordinal as derivation source for type conversions
}
