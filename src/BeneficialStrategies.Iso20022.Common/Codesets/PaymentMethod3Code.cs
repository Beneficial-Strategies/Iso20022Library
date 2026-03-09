// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer method that will be used to transfer an amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z0aeYtp-Ed-ak6NoX_4Aeg_1813568342")]
[Description(@"Specifies the transfer method that will be used to transfer an amount of money.")]
[DerivedFrom(typeof(PaymentMethodCode))]
public enum PaymentMethod3Code
{
    /// <summary>
    /// Written order to a bank to pay a certain amount of money from one person to another person.
    /// Encoded/decoded by serializers as &quot;CHK&quot;.
    /// </summary>
    [EnumMember(Value = "CHK")]
    [IsoId("_Z0aeY9p-Ed-ak6NoX_4Aeg_1931781357")]
    [Description(@"Written order to a bank to pay a certain amount of money from one person to another person.")]
    Cheque = PaymentMethodCode.Cheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer of an amount of money in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;TRF&quot;.
    /// </summary>
    [EnumMember(Value = "TRF")]
    [IsoId("_Z0aeZNp-Ed-ak6NoX_4Aeg_1931781374")]
    [Description(@"Transfer of an amount of money in the books of the account servicer.")]
    CreditTransfer = PaymentMethodCode.CreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer of an amount of money in the books of the account servicer. An advice should be sent back to the account owner.
    /// Encoded/decoded by serializers as &quot;TRA&quot;.
    /// </summary>
    [EnumMember(Value = "TRA")]
    [IsoId("_Z0kPYNp-Ed-ak6NoX_4Aeg_1931781417")]
    [Description(@"Transfer of an amount of money in the books of the account servicer. An advice should be sent back to the account owner.")]
    TransferAdvice = PaymentMethodCode.TransferAdvice, // same ordinal as derivation source for type conversions
    
}
