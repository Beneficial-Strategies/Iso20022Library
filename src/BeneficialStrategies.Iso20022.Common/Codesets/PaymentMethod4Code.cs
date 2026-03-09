// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer method that will be used to transfer an amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z0kPYdp-Ed-ak6NoX_4Aeg_-2121115820")]
[Description(@"Specifies the transfer method that will be used to transfer an amount of money.")]
[DerivedFrom(typeof(PaymentMethodCode))]
public enum PaymentMethod4Code
{
    /// <summary>
    /// Written order to a bank to pay a certain amount of money from one person to another person.
    /// Encoded/decoded by serializers as &quot;CHK&quot;.
    /// </summary>
    [EnumMember(Value = "CHK")]
    [IsoId("_Z0kPYtp-Ed-ak6NoX_4Aeg_-2121115778")]
    [Description(@"Written order to a bank to pay a certain amount of money from one person to another person.")]
    Cheque = PaymentMethodCode.Cheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer of an amount of money in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;TRF&quot;.
    /// </summary>
    [EnumMember(Value = "TRF")]
    [IsoId("_Z0kPY9p-Ed-ak6NoX_4Aeg_-2121115388")]
    [Description(@"Transfer of an amount of money in the books of the account servicer.")]
    CreditTransfer = PaymentMethodCode.CreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collection of an amount of money from the debtor&apos;s bank account by the creditor. The amount of money and dates of collections may vary.
    /// Encoded/decoded by serializers as &quot;DD&quot;.
    /// </summary>
    [EnumMember(Value = "DD")]
    [IsoId("_Z0kPZNp-Ed-ak6NoX_4Aeg_-2121115346")]
    [Description(@"Collection of an amount of money from the debtor's bank account by the creditor. The amount of money and dates of collections may vary.")]
    DirectDebit = PaymentMethodCode.DirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer of an amount of money in the books of the account servicer. An advice should be sent back to the account owner.
    /// Encoded/decoded by serializers as &quot;TRA&quot;.
    /// </summary>
    [EnumMember(Value = "TRA")]
    [IsoId("_Z0kPZdp-Ed-ak6NoX_4Aeg_-2121115311")]
    [Description(@"Transfer of an amount of money in the books of the account servicer. An advice should be sent back to the account owner.")]
    TransferAdvice = PaymentMethodCode.TransferAdvice, // same ordinal as derivation source for type conversions
    
}
