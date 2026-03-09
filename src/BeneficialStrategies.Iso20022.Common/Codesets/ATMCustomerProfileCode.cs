// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the main way customer information was collected to build up the customer menu and the withdrawal request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QVZ8gIoZEeSirOZJBRz_nA")]
[Description(@"Describes the main way customer information was collected to build up the customer menu and the withdrawal request.")]
[Derivations(typeof(ATMCustomerProfile1Code))]
public enum ATMCustomerProfileCode
{
    /// <summary>
    /// Customer profile is deduced from the card data and the local configuration.
    /// Encoded/decoded by serializers as &quot;CRDF&quot;.
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_T3rwcIoZEeSirOZJBRz_nA")]
    [Description(@"Customer profile is deduced from the card data and the local configuration.")]
    CardInformation,
    
    /// <summary>
    /// Customer profile is built via a specific profile message exchange.
    /// Encoded/decoded by serializers as &quot;PREQ&quot;.
    /// </summary>
    [EnumMember(Value = "PREQ")]
    [IsoId("_XqFEAIoZEeSirOZJBRz_nA")]
    [Description(@"Customer profile is built via a specific profile message exchange.")]
    ProfileRequest,
    
    /// <summary>
    /// Customer profile is sent via an account enquiry selecting an account.
    /// Encoded/decoded by serializers as &quot;OREQ&quot;.
    /// </summary>
    [EnumMember(Value = "OREQ")]
    [IsoId("_bTWQwIoZEeSirOZJBRz_nA")]
    [Description(@"Customer profile is sent via an account enquiry selecting an account.")]
    OtherRequest,
    
}
